using SalesWebMvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Date")]
        public DateTime date { get; set; }

        [Display(Name = "Amount")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double amount { get; set; }

        [Display(Name = "Status")]
        public SaleStatus status { get; set; }

        [Display(Name = "Seller")]
        public Seller seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.status = status;
            this.seller = seller;
        }
    }
}
