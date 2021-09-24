using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterSystem.Models
{
    public class BluRayMovie
    {
        public int Price { get; set; }
        public int Discount { get; set; }

        /// <summary>
        /// Removes 15 percent on price
        /// </summary>
        /// <param name="price">Blu-Ray price</param>
        /// <returns>Discounted price</returns>
        public double BluRayDiscount(double price)
        {
            return price * 0.85;
        }
    }
}
