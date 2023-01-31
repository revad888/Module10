namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = calc.Addition(a, b);
            Console.WriteLine(c);
            Console.ReadLine();

        }

         public interface IAddition
        {
             double Addition(string valu1, string value2);
        }

        public class Calculator : IAddition
        {
            public double Addition(string value1, string value2)
            {
                var d1 = Double.Parse(value1);
                var d2 = Double.Parse(value2);
                return d1 + d2;
            }
        }

    }
}