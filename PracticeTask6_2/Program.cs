using System;

namespace PracticeTask6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int intOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int intTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Арифметические операции над {0} и {1}", intOne, intTwo);
            Console.WriteLine("{0} + {1} = {2}", intOne, intTwo, intOne + intTwo);
            Console.WriteLine("{0} - {1} = {2}", intOne, intTwo, intOne - intTwo);
            Console.WriteLine("{0} * {1} = {2}", intOne, intTwo, intOne * intTwo);
            Console.WriteLine("{0} / {1} = {2}", intOne, intTwo, intOne / intTwo);
            Console.WriteLine("{0} % {1} = {2}", intOne, intTwo, intOne % intTwo);
            Console.Write("\nНажмите Enter");
            Console.ReadLine();
            Console.Write("Введите первое вещественное число: ");
            double doubleOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе вещественное число: ");
            double doubleTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Арифметические операции над {0:F} и {1:F}", doubleOne, doubleTwo);
            Console.WriteLine("{0:F} - {1:F} = {2:F}", doubleOne, doubleTwo, doubleOne - doubleTwo);
            Console.WriteLine("{0:F} * {1:F} = {2:F}", doubleOne, doubleTwo, doubleOne * doubleTwo);
            Console.WriteLine("{0:F} + {1:F} = {2:F}", doubleOne, doubleTwo, doubleOne + doubleTwo);
            Console.WriteLine("{0:F} % {1:F} = {2:F}", doubleOne, doubleTwo, doubleOne % doubleTwo);
            Console.WriteLine("{0:F} / {1:F} = {2:F}", doubleOne, doubleTwo, doubleOne / doubleTwo);
            Console.Write("\nНажмите Enter");
            Console.ReadLine();
            char charOne;
            char charTwo;
            Console.Write("Введите первый символ: ");
            charOne = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите второй символ: ");
            charTwo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("charOne = {0}, код = {1}, предшествующий ей символ - {2}, последующий ей символ - {3}", charOne, (uint)charOne, (char)(((uint)charOne)-1), (char)(((uint)charOne) + 1));
            Console.WriteLine("charTwo = {0}, код = {1}, предшествующий ей символ - {2}, последующий ей символ - {3}", charTwo, (uint)charTwo, (char)(((uint)charTwo) - 1), (char)(((uint)charTwo) + 1));
            Console.Write("\nНажмите Enter");
            Console.ReadLine();
            bool boolOne = (15 > 30) || (54 < 478);
            bool boolTwo = (894 >= 54) && (7 == 7);
            Console.WriteLine("boolOne = (15 > 30) || (54 < 478) - {0}", boolOne);
            Console.WriteLine("boolTwo = (894 >= 54) && (7 == 7) - {0}", boolTwo);
            Console.Write("\nНажмите Enter");
            Console.ReadLine();

        }
    }
}
