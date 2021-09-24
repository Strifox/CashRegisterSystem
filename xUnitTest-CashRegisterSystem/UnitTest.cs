using CashRegisterSystem.Models;
using System.Collections.Generic;
using Xunit;

namespace xUnitTest_CashRegisterSystem
{
    public class UnitTest
    {
        Customer customer = new Customer() {
            Name = "Abahram Lincoln",
            DvdMoviesRented = new List<DvdMovie>()
            {
                new DvdMovie(),
                new DvdMovie()
            },
            BluRayMoviesRented = new List<BluRayMovie>()
            {
                new BluRayMovie(),
                new BluRayMovie()
            },
        };

        [Fact]
        public void MembershipBluRayDiscount()
        {
            double price = customer.BluRayMoviesRented.Count * BluRayMovie.Price;
            double actualDiscount = BluRayMovie.BluRayDiscount(price);
            double expected = 66.3;

            Assert.Equal(expected, actualDiscount);
        }

        [Fact]
        public void MembershipDvdDiscount()
        {
            double price = customer.BluRayMoviesRented.Count * DvdMovie.Price;
            double actualDiscount = DvdMovie.DvdDiscount(price);
            double expected = 52.2;

            Assert.Equal(expected, actualDiscount);
        }
    }
}
