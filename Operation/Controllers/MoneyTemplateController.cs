using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Operation.Models.ViewModels;
using Operation.Service;

namespace Operation.Controllers
{
    public class MoneyTemplateController : Controller
    {
        public ActionResult Index()
        {
            var source = new MoneyTemplateGroupViewModels
            {
                MoneyTemplateListViewModels=GetFakeData()
            };
            
            return View(source);
        }

        private IEnumerable<MoneyTemplateListViewModels> GetFakeData()
        {
            for (int i = 0; i < 50; i++)
            {
                yield return new MoneyTemplateListViewModels
                {
                    Id       = i,
                    Category = i % 2 == 0 ? "支出" : "收入",
                    Date     = DateTime.Now.AddHours(i),
                    Money    = i * 1000,
                };
            }
        }

        // GET: MoneyTemplate
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(MoneyTemplateViewModels moneyTemplateViewModels)
        {
            //判斷模型繫結是否錯誤，或者有商業邏輯上是否錯誤
            if (ModelState.IsValid)
            {
                //未撰寫寫入資料庫的程式段
                return RedirectToAction("Index");
            }

            return View(moneyTemplateViewModels);
        }
    }
}