namespace Basic_AntiCheat
{
    class Program
    {
        private static Thread thread;
        static void Main(string[] args)
        {
            thread = new Thread(ConsoleThread);
            thread.Start();
            Console.ReadLine();
        }

        public static void ConsoleThread()
        {
            while (true)
            {
                ProcessDetection.UpdateProcList();
                ProcessDetection.FindProcess();
                Thread.Sleep(2000);
            }
        }
    }
}
