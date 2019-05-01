using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nosh.Models
{
    public class UserSnack
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int userId { get; set; }

        public User user { get; set; }

        [Required]
        public int snackId { get; set; }

        public Snack snack { get; set; }
    }
}
