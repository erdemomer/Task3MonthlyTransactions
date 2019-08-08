using System.Collections.Generic;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.MVCWebUI.Models
{
    public class TransactionsViewModel
    {
        public List<Transaction> transactions { get; set; }
        public Category category { get; set; }
        public List<Category> categories { get; set; }
    }
}
