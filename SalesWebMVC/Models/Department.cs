
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

<<<<<<< HEAD


        public Department(int id, string name)
=======
        public Department(int id, string name, ICollection<Seller> sellers)
>>>>>>> ffd6d5d548c8228e0962169fd4a2fccdeb872c75
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final) {
            var total = Sellers.Select(s => s.TotalSales(initial, final)).Sum();
            return total;
        }
    }
}
