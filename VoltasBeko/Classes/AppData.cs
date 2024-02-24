using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltasBeko
{
    internal class AppData
    {
        private static string globalProjectDirectory = Environment.CurrentDirectory;
        public static string ProjectDirectory = Directory.GetParent(globalProjectDirectory).Parent.Parent.FullName;
        public static Mode appMode = Mode.Idol;
        public static bool InspectionStarted = false;
        public static string ModelName = "";
        public static string SelectedModel = "";
        public static TIS_Cam camera = new TIS_Cam();
    }
    public enum Mode
    {
        Idol,
        Inspection,
        Settings,
        CreateModel
    }
}
