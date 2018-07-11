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
            RandomValue randomValue = new RandomValue();
            var arrayMoney = randomValue.getNumbers(50, 5000);
            ViewBag.vbMoney = arrayMoney;

            return View(arrayMoney);
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