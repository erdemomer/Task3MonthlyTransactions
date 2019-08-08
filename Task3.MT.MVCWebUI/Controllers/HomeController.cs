using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task3.MT.Business.Abstract;
using Task3.MT.MVCWebUI.Models;

namespace Task3.MT.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        private ITransactionService _transactionService;
        private ICategoryService _categoryService;
        public HomeController(ITransactionService transactionService, ICategoryService categoryService)
        {
            _transactionService = transactionService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View(new HomeViewModel
            {
                Categories = _categoryService.GetAll(),
                Transactions = _transactionService.GetAll(),                
            }
            );
        }
        public IActionResult LastMonth()
        {
            DateTime _expiryDate = DateTime.Now - TimeSpan.FromDays(30);

            return View(new HomeViewModel
            {
            Categories = _categoryService.GetAll(),
                Transactions = _transactionService.GetAll().Where(x=>x.Date > _expiryDate).ToList(),
            }
            );
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
