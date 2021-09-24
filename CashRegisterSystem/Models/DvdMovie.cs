using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterSystem.Models
{
    public class DvdMovie
    {
        public int Price { get; set; }
        public int Discount { get; set; }

        /// <summary>
        /// Removes 15 percent on price
        /// </summary>
        /// <param name="price">Dvd price</param>
        /// <returns>Discounted Price</returns>
        public double DvdDiscount(double price)
        {
            return price * 0.90;
        }

    }
}
