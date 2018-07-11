using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Operation.Models.ViewModels
{
    public class MoneyTemplateGroupViewModels
    {
        public MoneyTemplateViewModels MoneyTemplateViewModels { get; set; }
        public IEnumerable<MoneyTemplateListViewModels> MoneyTemplateListViewModels { get; set; }
    }
}