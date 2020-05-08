using System;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;

namespace sqrtCalc.Controllers {
    public class SqrtController : Controller {
        public ActionResult Sqrt () {

            return View ();
        }

        [HttpPost]
        public ActionResult Sqrt (string num1, string num2) {
            int fsqrt = int.Parse (num1);
            double firstSqrt = Math.Sqrt (fsqrt);
            int ssqrt = int.Parse (num2);
            double secondSqrt = Math.Sqrt (ssqrt);

            ViewBag.Errornegative = "You inputed a negative number";
            ViewBag.Errorsame = "Your input has same squareroot";
            ViewBag.ErrorNumber = "You did not input a number";
            ViewBag.Error = "You have not filled all fields";
            ViewBag.FirstNumber = fsqrt;
            ViewBag.SecondNumber = ssqrt;
            ViewBag.Sqrt1 = firstSqrt;
            ViewBag.Sqrt2 = secondSqrt;

            return View ();
        }
    }
}