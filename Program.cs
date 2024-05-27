using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_EM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            levels = new List<decimal>();

            WriteLine();

            string str;

            str = ReadLine("Введите верхнюю цену: ");
            priceUp = decimal.Parse(str);

            str = ReadLine("Задайте нижнию цену: ");
            priceDown = decimal.Parse(str);

            str = ReadLine("Введите шашг уровня: ");
            StepLevel = decimal.Parse(str);

            WriteLine();

            Console.ReadLine();
        }

        static List<decimal> levels;

        static decimal priceUp;

        static decimal priceDown;

        static int contLevels;
        public static decimal StepLevel
        {
            get
            {
                return stepLevel;
            }
            set
            {
                if(value <= 100)
                {
                    stepLevel = value;
                    levels = CalculateLevels(priceUp, priceDown, stepLevel);

                    decimal priceLevel = priceUp;

                    for (int i = 0; i < contLevels; i++)
                    {
                        levels.Add(priceLevel);

                        priceLevel -= stepLevel;

                    }
                }
            }
        }
        static decimal stepLevel;

        static List<decimal> CalculateLevels(decimal upperPrice, decimal lowerPrice, decimal step)
        {
            List<decimal> calculatedLevels = new List<decimal>();

            for (decimal priceLevel = upperPrice; priceLevel >= lowerPrice; priceLevel -= step)
            {
                calculatedLevels.Add(priceLevel);
            }
            return calculatedLevels;
        }


        static void WriteLine()
        {
            Console.WriteLine("Количество элементов в списке: " + levels.Count.ToString());

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine(levels[i]);
            }
        }
        static string ReadLine(string massage)
        {
            Console.WriteLine(massage); 

            return Console.ReadLine(); 
        }
        // последние правки вносил 24,05,24 
    }

}
