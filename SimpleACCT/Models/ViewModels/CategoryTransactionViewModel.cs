using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleACCT.Models.ViewModels
{
    public class CategoryTransactionViewModel
    {
        public Category Category { get; set; }
        public Transaction Transaction { get; set; }
    }
}