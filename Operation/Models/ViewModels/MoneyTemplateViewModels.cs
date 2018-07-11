using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Operation.Models.ViewModels
{
    public class MoneyTemplateViewModels
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "類別 必須輸入!")]
        [Display(Name = "類別")]
        public string Category { get; set; }

        [Required(ErrorMessage = "金額 必須輸入!")]
        [Display(Name = "金額")]
        public int Money { get; set; }

        [Required(ErrorMessage = "日期 必須輸入!")]
        [DataType(DataType.Date)]
        [Display(Name = "日期")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "備註 必須輸入!")]
        [Display(Name = "備註")]
        public string Description { get; set; }
    }
}