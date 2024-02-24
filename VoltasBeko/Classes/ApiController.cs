using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using VoltasBeko;

namespace VoltasBeko
{
    internal static class ApiController
    {
        static ApiController()
        {
            Console.WriteLine("ip from contructor " + Ip);
            ServerCheckThread = new Thread(CheckServerRunning);
            ServerCheckThread.Start();
        }

        private static bool checkServerFlag = true;
        private static Thread ServerCheckThread = null;
        public static event EventHandler ApiConnectionEvent;

        public static string Ip = "127.0.0.1";
        public static string Port = "5001";

        public static string ProcessImage(Bitmap inputImage, string endPoint = "predict", string port = "5001")
        {
            string imageString = BitmapToBase64(inputImage);

            string ResponseString = "";
            HttpWebResponse response = null;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create($"http://{Ip}:{port}/{endPoint}");
                request.Accept = "application/json";
                request.Method = "POST";
                request.Timeout = 3000;
                JavaScriptSerializer jss = new JavaScriptSerializer();
                jss.MaxJsonLength = int.MaxValue;
                var imageDict = new Dictionary<string, string>
                {
                    { "image", imageString }
                };

                var myContent = jss.Serialize(imageDict);

                //Console.WriteLine(JsonConvert.SerializeObject(myContent));

                var data = Encoding.ASCII.GetBytes(myContent);

                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                Console.WriteLine("request write ");
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                response = (HttpWebResponse)request.GetResponse();
                ResponseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                //ConsoleExtension.WriteWithColor(ResponseString);

            }
            catch (WebException ex)
            {
                return ex.ToString();

            }


            return ResponseString;
        }

        private static string BitmapToBase64(Bitmap image)
        {
            string base64String = "";
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, ImageFormat.Jpeg);
                byte[] imageBytes = m.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
            }
            return base64String;
        }

        public static async Task ShutdownServer(int port)
        {
            await Task.Delay(100);
            checkServerFlag = false;
            if (ServerCheckThread.IsAlive)
            {
                ServerCheckThread.Abort();
            }

            string baseUrl = $"http://{Ip}:{port}";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Send a GET request to the /shutdown endpoint
                    HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl}/shutdown");

                    if (response.IsSuccessStatusCode)
                    {
                        // Server shutdown request was successful
                        Console.WriteLine($"Server {port} shutdown request sent successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Server {port} shutdown request failed with status code: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        public static async void CheckServerRunning()
        {
            int port = 5001;
            while (checkServerFlag)
            {
                Thread.Sleep(1000);
                string baseUrl = $"http://{Ip}:{port}";

                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        // Send a GET request to the /shutdown endpoint
                        HttpResponseMessage response = await httpClient.GetAsync($"{baseUrl}/ServerCheck");

                        if (response.IsSuccessStatusCode)
                        {
                            // Server shutdown request was successful
                            //ConsoleExtension.WriteWithColor($"Server {port} running successfully.", ConsoleColor.Green);
                            ApiConnectionEvent?.Invoke(true, EventArgs.Empty);

                        }
                        else
                        {
                            ConsoleExtension.WriteWithColor($"Server {port} running failed with status code: " + response.StatusCode, ConsoleColor.Red);
                            ApiConnectionEvent?.Invoke(false, EventArgs.Empty);

                        }
                    }
                    catch (Exception ex)
                    {
                        ConsoleExtension.WriteWithColor("An error occurred in CheckServerRunning: " + ex.Message, ConsoleColor.Red);
                        ApiConnectionEvent?.Invoke(false, EventArgs.Empty);

                    }
                }
            }

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static Process processAnaconda;
        public static (string text, bool status) RunAnacondaCmd(string fileName = "fastapiQR")
        {
            try
            {

                // Set working directory and create process
                var workingDirectory = $@"{AppData.ProjectDirectory}\TensorFlow\QR";
                processAnaconda = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        WorkingDirectory = workingDirectory
                    }
                };
                processAnaconda.Start();
                // Pass multiple commands to cmd.exe
                using (var sw = processAnaconda.StandardInput)
                {
                    if (sw.BaseStream.CanWrite)
                    {
                        // Vital to activate Anaconda
                        //sw.WriteLine("C:\\Users\\Admin\\anaconda3\\envs\\pytorch\\Scripts\\activate.bat");
                        // Activate your environment
                        //sw.WriteLine("conda activate pytorch");
                        // run your script. You can also pass in arguments
                        //ConsoleExtension.WriteWithColor($"File name for server is {fileName}", ConsoleColor.Green);
                        sw.WriteLine($"python {fileName}.py");
                    }
                }


                ConsoleExtension.WriteWithColor("Api Started successfully", ConsoleColor.Yellow);
                return ("Api Running", true);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while starting Detection API {ex.Message}");
                return ("Api not running", false);
            }
        }
    }
}
