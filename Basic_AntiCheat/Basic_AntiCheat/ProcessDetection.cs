using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Basic_AntiCheat
{


    internal class ProcessDetection
    {
        public static bool detected;
        public static List<string> currentRunning = new List<string>();
        public static string[] suspectNames = ["cheat", "debugger"];
        public static string ignore = AppDomain.CurrentDomain.FriendlyName;

        public static void UpdateProcList()
        {
            Process[] running = Process.GetProcesses();
            foreach (Process process in running)
            {
                currentRunning.Add(process.ProcessName);

            }
        }

        public static void FindProcess()
        {
            foreach (string procName in currentRunning)
            {
                for (int i = 0; i < suspectNames.Length; i++)
                {
                    if (procName != ignore)
                    {
                        if (procName.Contains(suspectNames[i])){
                            detected = true;
                            Console.WriteLine("Detected" + suspectNames[i]);
                            return;
                        }
                    }
                }
            }

        }
    }
}
