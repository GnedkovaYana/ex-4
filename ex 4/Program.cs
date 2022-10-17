using System;
using System.Collections.Immutable;
using System.Globalization;
namespace Number3
{
    public static class Program
    {
        public static void Main()
        {
            string array = Console.ReadLine();
            string[] arraySplit = array.Split();
            var result = ArrayChange(arraySplit);

            foreach (var e in result)
                Console.Write(e + " ");
        }

        static double[] ArrayChange(string[] arraySplit)
        {
            List<double> list = new List<double>();

            for (int i = 0; i < arraySplit.Length; i++)
            {
                list.Add(double.Parse(arraySplit[i], CultureInfo.InvariantCulture));
            }

            List<double> numbers = new List<double>();
            double[] resultArray = new double[list.Count];

            foreach (double item in list)
            {
                int IntegerPart = (int)item;
                if (item > 0 && item - IntegerPart == 0)
                {
                    int factNum = Factorial((int)item);
                    numbers.Add(factNum);
                }
                else if (item - IntegerPart != 0)
                {
                    numbers.Add(Math.Floor(Math.Abs((Math.Round(item, 2) - IntegerPart) * 100)));
                }
                else numbers.Add(item);
            }
            for (int j = 0; j < numbers.Count; j++)
            {
                resultArray[j] = numbers[j];
            }
            return resultArray;
        }

        public static int Factorial(int number)
        {
            int figure = 1;
            for (int i = 1; i <= number; i++)
                figure *= i;
            return figure;
        }
    }
}