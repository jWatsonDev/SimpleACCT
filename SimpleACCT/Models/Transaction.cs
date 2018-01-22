using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleACCT.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [DataType(DataType.Currency)]
        public float Amount { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Date { get; set; }
        public string DateAdded { get; set; }
        public bool? Paid { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
    }
}