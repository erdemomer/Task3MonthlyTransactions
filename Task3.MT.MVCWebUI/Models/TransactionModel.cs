using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.MVCWebUI.Models
{
    public class TransactionModel : Transaction
    {
        
        public List<Category> Categories { get; set; }
        public List<SelectListItem> Types { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "false", Text = "Spending" },
            new SelectListItem { Value = "true", Text = "Earning" }
        };
    }
}
