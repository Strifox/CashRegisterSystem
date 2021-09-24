using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterSystem.Models
{
    public class BluRayMovie
    {
        private static int price = 39;
        private static double discount = 0.85;
        public static int Price { get => price; set => price = value; }

        /// <summary>
        /// Removes 15 percent on price
        /// </summary>
        /// <param name="price">Blu-Ray price</param>
        /// <returns>Returns total price with 15 percent discount</returns>
        public static double BluRayDiscount(double price)
        {
            return price * discount;
        }
    }
}
