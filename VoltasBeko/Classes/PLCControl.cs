using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//Required nuget package S7netplus
namespace VoltasBeko
{
    class PLCControl
    {
        public static bool plcConnected = false;
        static Plc mplc;

        public static CpuType PLCmodel = CpuType.S71200;
        public static string PLCip = "192.168.1.2";
        public static int rack_no = 0;
        public static int slot_no = 1;


        public static string DB_no = "DB42";// include BD ie. DB12 
        //registers
        public static string reg_fabric_curr_Length = "18";
        public static string regMachineMode = "302";
        public static string reg_defect_loc = "2"; //write defect 
        public static string regsoftwareReady = "298"; //write defect 
        public static string reg_ready_for_ins = "0.0"; //s/w ready bit written by main PC
        public static string reg_light_status = "310"; 
        public static string reg_software_test = "306"; 
        public static string reg_punch_count = "314"; 


        public static bool connectToPLC()
        {
            if (!(mplc == null))
            {
                if (mplc.IsConnected)
                {
                    plcConnected = true;
                    Console.WriteLine("PLC already connected. returning");
                    return true;
                }
            }
            mplc = new Plc(CpuType.S71200, "192.168.1.2", 0, 1);
            try
            {
                mplc.Open();
                if (mplc.IsConnected)
                {
                    plcConnected = true;

                    Console.WriteLine("Plc connected successfuly.");
                }
                else
                {
                    plcConnected = false;

                    Console.WriteLine("Unable to connect to PLC.");

                }
                return plcConnected;
            }
            catch (Exception e)
            {
                plcConnected = false;

                Console.WriteLine("Unable to connect to PLC" + e.Message.ToString());
                return plcConnected;
            }

        }
        public static bool disconnectPLC()
        {
            if (mplc == null)
            {
                plcConnected = false;

                return true;

            }
            try
            {
                if (mplc.IsConnected)
                {
                    mplc.Close();
                    plcConnected = false;

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to disconnect PLC" + ex.Message.ToString());
                plcConnected = false;

                return false;
            }
            return false;
        }
        public static float readCurrentLength()
        {
            if (plcConnected)
            {
                return Conversion.ConvertToFloat((uint)mplc.Read(DB_no + ".DBD" + reg_fabric_curr_Length));
            }
            else
            {
                connectToPLC();
                if (plcConnected)
                    return Conversion.ConvertToFloat((uint)mplc.Read(DB_no + ".DBD" + reg_fabric_curr_Length));
                else

                    return 0;
            }

        }


        public static float ReadPunchCount()
        {
            if (plcConnected)
            {
                return Conversion.ConvertToFloat((uint)mplc.Read(DB_no + ".DBD" + reg_punch_count));

            }
            else
            {
                connectToPLC();
                if (plcConnected)
                    return Conversion.ConvertToFloat((uint)mplc.Read(DB_no + ".DBD" + reg_punch_count));
                else
                    return -1;
            }

        }


        public static bool WriteSoftwareTest(float status)
        {
            if (plcConnected)
            {
                mplc.Write(DB_no + ".DBD" + reg_software_test, status);
                return true;
            }
            else
            {
                connectToPLC();
                if (plcConnected)
                {
                    mplc.Write(DB_no + ".DBD" + reg_software_test, status);
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        public static float ReadLightStatus()
        {
            try
            {
                if (plcConnected)
                {
                    return Conversion.ConvertToFloat((uint)mplc.Read(DB_no + ".DBD" + reg_light_status));
                }
                else
                {
                    connectToPLC();
                    if (plcConnected)
                        return Conversion.ConvertToFloat((uint)mplc.Read(DB_no + ".DBD" + reg_light_status));
                    else

                        return 0;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Exception while reading light status from plc. {ex.Message}");
                Console.ResetColor();
                return 0;

            }


        }


        public static float ReadMachineMode()
        {
            if (plcConnected)
            {
                return Conversion.ConvertToInt((uint)mplc.Read(DB_no + ".DBD" + regMachineMode));
            }
            else
            {
                connectToPLC();
                if (plcConnected)
                    return Conversion.ConvertToInt((uint)mplc.Read(DB_no + ".DBD" + regMachineMode));
                else

                    return 0;
            }

        }


        public static bool writeSoftwareReady(float status)
        {
            if (plcConnected)
            {
                mplc.Write(DB_no + ".DBD" + regsoftwareReady, status);
                return true;
            }
            else
            {
                connectToPLC();
                if (plcConnected)
                {
                    mplc.Write(DB_no + ".DBD" + regsoftwareReady, status);
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }


        public static bool writeDefectLocation(float location)
        {
            if (plcConnected)
            {
                mplc.Write(DB_no + ".DBD" + reg_defect_loc, location);
                return true;
            }
            else
            {
                connectToPLC();
                if (plcConnected)
                {
                    mplc.Write(DB_no + ".DBD" + reg_defect_loc, location);
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        public static bool readInspection_Status()
        { //reg_ready_for_ins
            if (plcConnected)
            {
                return (bool)mplc.Read(DB_no + ".DBX" + reg_ready_for_ins);

            }
            else
            {
                connectToPLC();
                if (plcConnected)
                {
                    return (bool)mplc.Read(DB_no + ".DBX" + reg_ready_for_ins);

                }
                else
                {
                    return false;
                }

            }
        }

        public static bool writeInspection_Status(bool runStatus)
        {
            if (plcConnected)
            {
                mplc.Write(DB_no + ".DBX" + reg_ready_for_ins, runStatus);
                return true;
            }
            else
            {
                connectToPLC();
                if (plcConnected)
                {
                    mplc.Write(DB_no + ".DBX" + reg_ready_for_ins, runStatus);
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
    }
}
