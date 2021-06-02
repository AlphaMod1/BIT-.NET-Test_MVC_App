using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApp2.Models
{
    public class RegistrationModel
    {
        [DisplayName("Your first name")]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [DisplayName("Your age")]
        [Range(18, 200, ErrorMessage = "You must be at least age of 18 or above")]
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
