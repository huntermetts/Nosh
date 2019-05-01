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
        public string vendingMachineName { get; set; }

        [Required]
        [StringLength(50)]
        public string vendingMachineLocation { get; set; }

        public virtual ICollection<VendingMachineSnack> VendingMachineSnack { get; set; }
    }
}
