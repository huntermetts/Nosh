using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nosh.Models
{
    public class SnackType
    {
        [Key]
        public int SnackTypeId { get; set; }

        public string snackTypeName { get; set; }

        public string imageURL { get; set; }

    }
}
