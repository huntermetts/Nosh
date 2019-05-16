using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nosh.Models
{
    public class VendingMachine
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Vending Machine Name")]
        public string vendingMachineName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Vending Machine Location")]
        public string vendingMachineLocation { get; set; }

        public virtual ICollection<Snack> Snack { get; set; }

        //public virtual ICollection<User> User { get; set; }
    }
}
