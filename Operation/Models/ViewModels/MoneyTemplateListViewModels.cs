using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Operation.Models.ViewModels
{
    public class MoneyTemplateListViewModels
    {
        public int Id { get; set; }

        public int No { get; set; }

        public string Category { get; set; }

        public int Money { get; set; }

        public DateTime Date { get; set; }
    }
}