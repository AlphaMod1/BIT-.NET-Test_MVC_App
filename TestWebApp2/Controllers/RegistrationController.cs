using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApp2.Models;
using TestWebApp2.Services;

namespace TestWebApp2.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AgeCalcService _ageCalcService;

        public RegistrationController()
        {
            _ageCalcService = new AgeCalcService();
        }

        public IActionResult Index()
        {
            var model = new RegistrationModel();
            return View(model);
        }


        public IActionResult Post(RegistrationModel model) {

            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            model.BirthDate = _ageCalcService.CalcBirthDateFromAge(model.Age);
            return View(model);
        
        }
    }
}
