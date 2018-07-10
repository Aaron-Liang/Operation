using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Operation.Models.ViewModels
{
    public class MoneyTemplateListViewModels
    {
        public int id { get; set; }

        public int no { get; set; }

        public string category { get; set; }

        public int money { get; set; }

        public DateTime date { get; set; }
    }
}