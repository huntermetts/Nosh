using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nosh.Models
{
    public class User : IdentityUser 
    { 
        public User() { }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        public bool isVendor { get; set; }

        //public virtual ICollection<Snack> Snacks { get; set; }

        public virtual ICollection<UserSnack> UserSnack { get; set; }
    }
}
