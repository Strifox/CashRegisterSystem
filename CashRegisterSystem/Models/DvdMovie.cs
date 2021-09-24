using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterSystem.Models
{
    public class DvdMovie
    {
        private static int price = 29;
        private static double discount = 0.90;
        public static int Price { get => price; set => price = value; }

        /// <summary>
        /// Removes 10 percent on price
        /// </summary>
        /// <param name="price">Dvd price</param>
        /// <returns>Discounted Price</returns>
        public static double DvdDiscount(double price)
        {
            return price * discount;
        }

    }
}
