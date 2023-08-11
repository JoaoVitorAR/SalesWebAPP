using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        [Key]
        public int _id { get; set; }
        public string _name { get; set; }
    }
}
