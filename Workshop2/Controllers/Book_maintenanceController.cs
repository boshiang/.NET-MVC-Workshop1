using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Workshop2.Controllers
{
    public class Book_maintenanceController : Controller
    {
        // GET: Book_maintenance
        [HttpGet()]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult Index(FormCollection form)
        {
            Models.Book_Service Book_Service = new Models.Book_Service();
            var xxx = Book_Service.GetBook_DatasByCondition(new Models.BookSearchArg()
            {
                Book_Name = "123",
                Book_Class_Name = "",
                User_CName = "",
                Book_Status = ""
            });
            ViewBag.EmpAdd = xxx[0].Book_Name;
            return View("Index");
        }
        [HttpGet()]
        public ActionResult InsertBook()
        {
            Models.BookSearch result = new Models.BookSearch();
            List<SelectListItem> Book_Class_Name = new List<SelectListItem>();
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "eg",
                Text = "English"
            });
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "ch",
                Text = "Chinese"
            });
            ViewBag.Book_Class_Name = Book_Class_Name;
            return View(result);
        }
        [HttpPost()]
        public ActionResult InsertBook(Models.Book_Data Data)
        {
            List<SelectListItem> Book_Class_Name = new List<SelectListItem>();
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "eg",
                Text = "English"
            });
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "ch",
                Text = "Chinese"
            });
            ViewBag.Book_Class_Name = Book_Class_Name;
            ViewBag.label = 123;
            return View();
        }

        [HttpGet()]
        public ActionResult Search()
        {
            List<SelectListItem> Book_Class_Name = new List<SelectListItem>();
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "eg",
                Text = "English"
            });
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "ch",
                Text = "Chinese"
            });
            ViewBag.Book_Class_Name = Book_Class_Name;

            List<SelectListItem> Book_Borrower = new List<SelectListItem>();
            Book_Borrower.Add(new SelectListItem()
            {
                Value = "1",
                Text = "我"
            });
            Book_Borrower.Add(new SelectListItem()
            {
                Value = "2",
                Text = "施先生"
            });
            ViewBag.Book_Borrower = Book_Borrower;

            List<SelectListItem> Book_Status = new List<SelectListItem>();
            Book_Status.Add(new SelectListItem()
            {
                Value = "A",
                Text = "可以借出"
            });
            Book_Status.Add(new SelectListItem()
            {
                Value = "B",
                Text = "已借出"
            });
            Book_Status.Add(new SelectListItem()
            {
                Value = "C",
                Text = "已借出(未領)"
            });
            Book_Status.Add(new SelectListItem()
            {
                Value = "U",
                Text = "不可借出"
            });
            ViewBag.Book_Status = Book_Status;

            return View();
        }
        [HttpPost()]
        public ActionResult Search(Models.BookSearch data) {
            List<SelectListItem> Book_Class_Name = new List<SelectListItem>();
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "eg",
                Text = "English"
            });
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "ch",
                Text = "Chinese"
            });
            ViewBag.Book_Class_Name = Book_Class_Name;

            List<SelectListItem> Book_Borrower = new List<SelectListItem>();
            Book_Borrower.Add(new SelectListItem()
            {
                Value = "1",
                Text = "我"
            });
            Book_Borrower.Add(new SelectListItem()
            {
                Value = "2",
                Text = "施先生"
            });
            ViewBag.Book_Borrower = Book_Borrower;

            List<SelectListItem> Book_Status = new List<SelectListItem>();
            Book_Status.Add(new SelectListItem()
            {
                Value = "A",
                Text = "可以借出"
            });
            Book_Status.Add(new SelectListItem()
            {
                Value = "B",
                Text = "已借出"
            });
            Book_Status.Add(new SelectListItem()
            {
                Value = "C",
                Text = "已借出(未領)"
            });
            Book_Status.Add(new SelectListItem()
            {
                Value = "U",
                Text = "不可借出"
            });
            ViewBag.Book_Status = Book_Status;
            return View("Search");
        }
    }
}