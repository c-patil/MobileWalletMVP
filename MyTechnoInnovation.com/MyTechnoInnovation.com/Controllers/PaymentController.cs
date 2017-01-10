using MyTechnoInnovation.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTechnoInnovation.com.Controllers
{
    public class PaymentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(PaymentViewModels paymentViewModel)
        {
            if (ModelState.IsValid)
            {
                TempData["paymentViewModel"] = paymentViewModel;
                return RedirectToAction("ReviewPayment");
            }
            else
            {
                return View(paymentViewModel);
            }
            // return View();
        }

        public ActionResult ReviewPayment()
        {
            var paymentViewModel = TempData["paymentViewModel"] as PaymentViewModels;
            return View(paymentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReviewPayment(PaymentViewModels paymentViewModel)
        {
            TempData["paymentViewModel"] = paymentViewModel;
            return RedirectToAction("ConfirmPayment", paymentViewModel);
        }


        public ActionResult ConfirmPayment()
        {
            var paymentViewModel = TempData["paymentViewModel"] as PaymentViewModels;
            return View(paymentViewModel);
        }


    }
}
