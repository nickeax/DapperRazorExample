using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperRazorExample.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Product ID")]
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Product Name")]
        [StringLength(25, ErrorMessage = "Name should be 1 to 25 char in lenght")]
        public string  Name { get; set; }

        [Required]
        [Display(Name = "Model")]
        [StringLength(50, ErrorMessage = "Name should be 1 to 50 char in lenght")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
