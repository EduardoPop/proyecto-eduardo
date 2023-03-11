using System;

namespace Aplicacion_Eduardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor 1");
            string value1 = Console.ReadLine();
            int value1Number = Int32.Parse(value1);

            Console.WriteLine("Ingrese el valor 2");
            string value2 = Console.ReadLine();
            int value2Number = Int32.Parse(value2);

            Console.WriteLine(value1Number + value2Number);

            Console.WriteLine("Ingrese el valor 3");
            string value3 = Console.ReadLine();
            int value3Number = Int32.Parse(value3);

            Console.WriteLine("Ingrese el valor 4");
            string value4 = Console.ReadLine();
            int value4Number = Int32.Parse(value4);

            Console.WriteLine(value3Number - value4Number);

            Console.WriteLine("Ingrese el valor 5");
            string value5 = Console.ReadLine();
            int value5Number = Int32.Parse(value5);

            Console.WriteLine("Ingrese el valor 6");
            string value6 = Console.ReadLine();
            int value6Number = Int32.Parse(value6);

            Console.WriteLine(value5Number * value6Number);

            Console.WriteLine("Ingrese el valor 7");
            string value7 = Console.ReadLine();
            int value7Number = Int32.Parse(value7);

            Console.WriteLine("Ingrese el valor 8");
            string value8 = Console.ReadLine();
            int value8Number = Int32.Parse(value8);

            Console.WriteLine(value7Number / value8Number);
        }
    }
}
