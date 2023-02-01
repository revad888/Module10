using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW
{
    public class Logger : ILogger
    {
        // Возращение результата операции в кончоль
        public void Anser(double anser)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Результат: {anser}");
        }
        //Возращение информации об ошибки в консоль
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
        }


    }
}

