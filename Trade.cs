using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole_EM
{
    public class Trade
    {
        //---------------------------------------------- Filders ------------------------------------------------
        #region  = Filders =

        /// <summary>
        /// Цена интрумента
        /// </summary>
        public decimal Price = 0;

        public string SecCode = "";

        public string ClassCode = "";

        public DateTime DateTime = DateTime.MinValue;

        public string Portfolio = "";

        #endregion
        //----------------------------------------------          ------------------------------------------------
        #region
        /// <summary>
        /// Объем сделки
        /// </summary>
        public decimal Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }
        public decimal _volume = 0;

        #endregion 
    }
}
