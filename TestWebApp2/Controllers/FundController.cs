using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp2.Models;
using TestWebApp2.Repository;

namespace TestWebApp2.Controllers
{
    public class FundController : Controller
    {
        private readonly IFundRepository _repo;
        public FundController(IFundRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetFunds());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FundModel fundModel)
        {
            if (!ModelState.IsValid)
            {
                return View(fundModel);
            }

            _repo.CreateFund(fundModel);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(FundModel fundModel)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(FundModel fundModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(fundModel);
            }

            _repo.GetFunds().Where(i => i.Id == fundModel.Id).ToList();

            return RedirectToAction("Index");
        }
    }
}
