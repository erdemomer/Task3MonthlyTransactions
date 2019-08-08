using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task3.MT.Business.Abstract;
using Task3.MT.Entities.Concrete;
using Task3.MT.MVCWebUI.Models;

namespace Task3.MT.MVCWebUI.Controllers
{
    public class TransactionController : Controller
    {
        private ITransactionService _transactionService;
        private ICategoryService _categoryService;
        public TransactionController(ITransactionService transactionService, ICategoryService categoryService)
        {
            _transactionService = transactionService;
            _categoryService = categoryService;
        }
        // GET: Transaction
        public ActionResult Index(int? Id, int? all)
        {
            var categoryId = Convert.ToInt32(RouteData?.Values["Id"]);
            var _category = (_categoryService.GetAll().Where(x => x.Id == categoryId).Any()&& all==null)? _categoryService.GetByCategoryId(categoryId):null;
            var _transactions = (categoryId > 0 && all ==null) ? _transactionService.GetListByCategoryId(categoryId) : _transactionService.GetAll();
            return View(new TransactionsViewModel { transactions = _transactions,
            categories= _categoryService.GetAll(),
            category= _category
          }         
                );
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {
            return View(new TransactionModel
            {
                Categories = _categoryService.GetAll(),
                Date = DateTime.Now
            }
            );
        }

        // POST: Transaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionModel model)
        {
            try
            {
                Transaction transaction = model;
                _transactionService.Add(transaction);
                return RedirectToAction(nameof(Index), new TransactionsViewModel
                {
                    transactions = _transactionService.GetListByCategoryId(transaction.CategoryId),
                    categories = _categoryService.GetAll(),
                    category = _categoryService.GetByCategoryId(transaction.CategoryId)

                });
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Edit/5
        public ActionResult Edit(int Id)
        {

            try
            {
                var TransactionId = Convert.ToInt32(RouteData?.Values["Id"]);
                var transaction = _transactionService.GetByTransactionId(TransactionId);
                return View(new TransactionModel
                {
                    Categories = _categoryService.GetAll(),
                    Date = transaction.Date,
                    Amount= transaction.Amount,
                    Description= transaction.Description,
                    Id=transaction.Id,
                    TransactionType= transaction.TransactionType,
                    CategoryId= transaction.CategoryId
                }
                );
            }
            catch
            {
                return View();
            }
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TransactionModel model)
        {
            try
            {


                Transaction transaction = model;
                _transactionService.Update(transaction);
                return RedirectToAction(nameof(Index), new TransactionsViewModel
                {
                    transactions = _transactionService.GetListByCategoryId(transaction.CategoryId),
                    categories = _categoryService.GetAll(),
                    category = _categoryService.GetByCategoryId(transaction.CategoryId)

                });
            }
            catch
            {
                return View();
            }
        }

        // GET: Transaction/Delete/5
        public ActionResult Delete(int Id)
        {
            return View(_transactionService.GetByTransactionId(Id));
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Transaction transaction)
        {
            try
            {
                var _transaction = _transactionService.GetByTransactionId(transaction.Id);
                var catId = _transaction.CategoryId;
                _transactionService.Delete(_transaction);

                return RedirectToAction(nameof(Index), new TransactionsViewModel
                {
                    transactions = _transactionService.GetListByCategoryId(catId),
                    categories = _categoryService.GetAll(),
                    category = _categoryService.GetByCategoryId(catId)
                });
            }
            catch
            {
                return View();
            }
        }
    }
}