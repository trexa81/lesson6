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
            Console.WriteLine("Введите Id процесса или его имя для его завершения");

            int number;
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            
            bool result = int.TryParse(input, out number);
            if (result == true)
            //Console.WriteLine($"Преобразование прошло успешно" + number) ;
            {
                var killID = Process.GetProcessById(number);
                Console.WriteLine($"Для завершения процесса: " + number + " нажмите любую кнопку.");
                Console.ReadKey();
                killID.Kill();
            }
            else
            {

                foreach (var killName in Process.GetProcessesByName(input))
                {
                    Console.WriteLine($"Для завершения процесса: " + number + " нажмите любую кнопку.");
                    Console.ReadKey();
                    killName.Kill();
                }
                Console.WriteLine($"Преобразование завершилось неудачно" + input);
            }

            //var concoleReadLine = Console.ReadLine();
            //Console.WriteLine(killID);
            //Console.WriteLine("Введите имя процесса для его завершения");
            //var concoleReadLine2 = Console.ReadLine();
            //foreach (var killName in Process.GetProcessesByName(concoleReadLine2))
            //{
            //    Console.WriteLine(killName);
            //    Console.ReadKey();
            //    killName.Kill();
            //}
            //killName.Kill();
            //Console.ReadKey();
        }
    }
}
