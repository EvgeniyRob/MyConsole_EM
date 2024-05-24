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

            string str = ReadLine("Введите количество уровней: ");

            contLevels = Convert.ToInt32(str);

            str = ReadLine("Введите верхнюю цену: ");

            priceUp = decimal.Parse(str);

            str = ReadLine("Введите шашг уровня: ");

            StepLevel = decimal.Parse(str);

            WriteLine();

            Console.ReadLine();
        }
        static List<decimal> levels;

        static decimal priceUp;

        static int contLevels;
        static decimal StepLevel
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

            return Console.ReadLine(); ;
        }

    }

}
