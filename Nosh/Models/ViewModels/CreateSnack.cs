using Microsoft.AspNetCore.Mvc.Rendering;
using Nosh.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nosh.Models.ViewModels
{
    public class CreateSnack
    {
        public List<SelectListItem> VendingMachine { get; set; }

        public List<SelectListItem>SnackType { get; set; }



        public CreateSnack(ApplicationDbContext context)
        {
            VendingMachine = context.VendingMachine.Select(vm =>
            new SelectListItem { Text = vm.vendingMachineName, Value = vm.id.ToString() }).ToList();

            //SnackType = context.Snack.Select(s => 
            //new SelectListItem { Text = s.snackType, Val})
        }

        public CreateSnack() { }
    }
}
