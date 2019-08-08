using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Task3.Core.Entities;

namespace Task3.MT.Entities.Concrete
{
    public class Transaction : IEntity
    {
        public int Id { get; set ; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool TransactionType { get; set; }
        public decimal Amount { get; set; }
        public virtual Category Category { get; set; }


    }
}
