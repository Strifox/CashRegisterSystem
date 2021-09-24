using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterSystem.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public bool Membership { get; set; }
        public List<DvdMovie> DvdMoviesRented { get; set; }
        public List<BluRayMovie> BluRayMoviesRented { get; set; }
        public int TotalPrice { get; set; }

    }
}
