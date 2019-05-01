using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nosh.Models
{
    public class VendingMachineSnack
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int snackId { get; set; }

        public Snack snack { get; set; }

        [Required]
        public int vendingMachineId { get; set; }

        public VendingMachine VendingMachine { get; set; }
    }
}
