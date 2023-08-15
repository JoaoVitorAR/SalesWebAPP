using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void AddSeller(Seller seller)
        {
          sellers.Add(seller);
        }

        public double TotalSales(DateTime intial, DateTime final)
        {
            return sellers.Sum(sellers => sellers.TotalSales(intial, final));
        }
    }
}
