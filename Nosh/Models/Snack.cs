using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nosh.Models
{
    public class Snack
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string snackName { get; set; }

        [Required]
        //[DataType(DataType.Currency)]
        //[Column(TypeName = "money")]
        public double snackPrice { get; set; }

        [Required]
        [MaxLength(4)]
        public int snackCalories { get; set; }


        public int vendingMachineId { get; set; }

        [Required]
        [Display(Name = "Snack Category")]
        public int snackTypeId { get; set; }

        public virtual ICollection<UserSnack> UserSnack { get; set; }

        public virtual ICollection<VendingMachineSnack> VendingMachineSnack { get; set; }

        public SnackType snackType { get; set; }


    }
}
    