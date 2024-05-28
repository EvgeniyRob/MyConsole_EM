﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_EM
{
    public class Level
    {
        public Level()
        {

        }

        //---------------------------------------------- Filders ------------------------------------------------
        #region = Filders =

        /// <summary>
        /// Цена уровня
        /// </summary>
        public decimal PriceLevel = 0;

        /// <summary>
        /// Лот на уровень
        /// </summary>
        public static decimal LotLevel = 0;

        /// <summary>
        /// Открытый объем на уровень
        /// </summary>
        public decimal Volume = 100;

        #endregion
        //---------------------------------------------- Methodes ------------------------------------------------
        #region = Methodes =

        public static List<Level> CalculateLevels(decimal priceUp, decimal step, int count)
        {
            List<Level> levels = new List<Level>();

            decimal priceLevel = priceUp;

            for (int i = 0; i < count; i++)
            {
                Level level = new Level() { PriceLevel = priceLevel };

                levels.Add(level);

                priceLevel -= step;

            }
            return levels;

        }

        #endregion 
    }
}
