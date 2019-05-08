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

        [Required(ErrorMessage = "Please enter a valid snack name")]
        [StringLength(50)]
        [Display(Name = "Snack Name ")]
        public string snackName { get; set; }

        [Required(ErrorMessage = "Please enter a valid snack price")]
        [DataType(DataType.Currency)]
        [Display(Name = "Snack Price")]
        public double snackPrice { get; set; }

        [Required(ErrorMessage = "Please enter a valid calorie amount")]

        [Display(Name = "Snack Calories")]
        public int snackCalories { get; set; }


        public virtual ICollection<SnackType> SnackType { get; set; }

        [Required]
        [Display(Name = "Snack Category")]
        public int SnackTypeId { get; set; }

        public virtual ICollection<UserSnack> UserSnack { get; set; }

        //public virtual ICollection<VendingMachineSnack> VendingMachineSnack { get; set; }

        [Required]
        [Display(Name = "Vending Machine")]
        public int vendingMachineId { get; set; }

        public SnackType snackType { get; set; }

        public VendingMachine vendingMachine { get; set; }
    }
}
    