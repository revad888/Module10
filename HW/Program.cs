namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            Calculator calc = new Calculator(logger);

            while (true)
            {
                //Подготовка консоли и ввод знаяений
                Console.Clear();

                Console.Write("Введите первое значение: ");
                var a = Console.ReadLine();

                Console.Write("Введите второе значение: ");
                var b = Console.ReadLine();

                //Вычисления
                calc.Addition(a, b);

                //Перезапуск вычисления
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Нажмите любую клавишу для нового расчета");
                Console.ReadKey();

            }


        }
    }
}