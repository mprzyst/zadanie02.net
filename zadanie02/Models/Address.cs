using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace zadanie02.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]

        public string Street { get; set; }
        
        [StringLength(5, MinimumLength = 5), Required(ErrorMessage = "Enter valid postcode!")]
        public string ZipCode { get; set; }
        
        [Required(ErrorMessage ="This field is required!")]
        public string City { get; set; }
        public int Number { get; set; }
    }
}
