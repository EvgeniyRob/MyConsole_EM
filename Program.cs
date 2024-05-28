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
            levels = new List<Level>();

            WriteLine();

            string str;

            str = ReadLine("Введите кол-во уровней: ");
            contLevels = Convert.ToInt32(str);

            str = ReadLine("Введите верхнюю цену: ");
            priceUp = decimal.Parse(str);

            //str = ReadLine("Задайте нижнию цену: ");
            //priceDown = decimal.Parse(str);

            str = ReadLine("Введите шашг уровня: ");
            StepLevel = decimal.Parse(str);

            str = ReadLine("Введите лот на уровень: ");
            LotLevel = decimal.Parse(str);

            WriteLine();

            Console.ReadLine();
        }
        //---------------------------------------------- Filders ------------------------------------------------
        #region = Filders =


        static List<Level> levels;

        static decimal priceUp;

        //static decimal priceDown;

        static int contLevels;

        static decimal LotLevel;

        //----------------------------------------------

        static Trade trade = new Trade();
        //static Level 




        #endregion
        //---------------------------------------------- Propertis ----------------------------------------------
        #region = Propertis =

        public static decimal StepLevel
        {
            get
            {
                return stepLevel;
            }
            set
            {
                if (value <= 100)
                {
                    stepLevel = value;
                    //levels = CalculateLevels(priceUp, priceDown, stepLevel);

                    levels = Level.CalculateLevels(priceUp, stepLevel, contLevels);

                }
            }
        }
        static decimal stepLevel;
        #endregion


        //---------------------------------------------- Methodes -----------------------------------------------
        #region = Methodes =

        /*static List<decimal> CalculateLevels(decimal upperPrice, decimal lowerPrice, decimal step)
        {
            List<decimal> calculatedLevels = new List<decimal>();

            for (decimal priceLevel = upperPrice; priceLevel >= lowerPrice; priceLevel -= step)
            {
                calculatedLevels.Add(priceLevel);
            }
            return calculatedLevels;
        }*/

        static void WriteLine()
        {
            Console.WriteLine("Количество элементов в списке: " + levels.Count.ToString());

            for (int i = 0; i < levels.Count; i++)
            {
                Console.WriteLine(levels[i].PriceLevel);
            }
        }
        static string ReadLine(string massage)
        {
            Console.WriteLine(massage);

            return Console.ReadLine();
        }

        static void fghf()// последние правки вносил 27,05,24 
        {

        }

        #endregion
    }

}
