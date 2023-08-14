using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }
        public Department department { get; set; }
        public ICollection<SalesRecord> salesRec { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void AddSales(SalesRecord sales)
        {
            salesRec.Add(sales);
        }

        public void RemoveSales(SalesRecord sales)
        {
            salesRec.Remove(sales);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return salesRec.Where(sales => sales.date >= initial && sales.date <= final)
                .Sum(sales => sales.amount);
        }
    }
}
