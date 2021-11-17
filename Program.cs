using System;
using System.Diagnostics;

namespace lesson6// new brench
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("notepad.exe");
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                Console.WriteLine($"{nameof(process.ProcessName)}: {process.ProcessName}, {nameof(Process.Id)}: {process.Id}");
            }
            Console.WriteLine("Введите Id процесса для его завершения");
            var concoleReadLine = Console.ReadLine();
            var killName = Process.GetProcessById(Convert.ToInt32(concoleReadLine));
            killName.Kill();
            //Console.ReadKey();
        }
    }
}
