using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workshop2.Models;

namespace Workshop2.Controllers
{
    public class Book_maintenanceController : Controller
    {
        BookDatabaseEntities1 db = new BookDatabaseEntities1();
        // GET: Book_maintenance
        [HttpGet()]
        public ActionResult Index(string SearchBookName, string SearchClassName, string SearchBrrower, string SearchStatus)
        {
            //書名搜尋
            var Book_Search = from b in db.BookDataBase
                            select b;
            if (!String.IsNullOrEmpty(SearchBookName))
            {
                Book_Search = Book_Search.Where(s => s.Book_Name.Contains(SearchBookName));
            }
            //類別搜尋
            var BookClassLst = new List<string>();
            var BookClassQry = from c in db.BookDataBase
                           orderby c.Book_Class_Name
                           select c.Book_Class_Name;
            BookClassLst.AddRange(BookClassQry.Distinct());
            ViewBag.SearchClassName = new SelectList(BookClassLst);
            if (!string.IsNullOrEmpty(SearchClassName))
            {
                Book_Search = Book_Search.Where(x => x.Book_Class_Name == SearchClassName);
            }
            //借閱人搜尋
            var BookBrrowerLst = new List<string>();
            var BookBrrowerQry = from b in db.BookDataBase
                               orderby b.Book_Brrower descending
                               select b.Book_Brrower;
            BookBrrowerLst.AddRange(BookBrrowerQry.Distinct());
            ViewBag.SearchBrrower = new SelectList(BookBrrowerLst);
            if (!string.IsNullOrEmpty(SearchBrrower))
            {
                Book_Search = Book_Search.Where(x => x.Book_Brrower == SearchBrrower);
            }
            //借閱狀態搜尋
            var BookStatusLst = new List<string>();
            var BookStatusQry = from bs in db.BookDataBase
                                orderby bs.Book_Status
                                select bs.Book_Status;
            BookStatusLst.AddRange(BookStatusQry.Distinct());
            ViewBag.SearchStatus = new SelectList(BookStatusLst);
            if (!string.IsNullOrEmpty(SearchStatus))
            {
                Book_Search = Book_Search.Where(x => x.Book_Status == SearchStatus);
            }

            //var BookData = db.BookDataBase.ToList();
            return View(Book_Search);
        }
        [HttpGet()]
        public ActionResult Insert()
        {
            Models.BookDataBase result = new Models.BookDataBase();
            var BookData = db.BookDataBase.ToList();
            List<SelectListItem> Book_Class_Name = new List<SelectListItem>();
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "文學",
                Text = "文學"
            });
            Book_Class_Name.Add(new SelectListItem()
            {
                Value = "財經",
                Text = "財經"
            });
            ViewBag.Book_Class_Name = Book_Class_Name;
            return View(result);
        }
        [HttpPost()]
        public ActionResult Insert(BookDataBase bookDataBase)
        {
            db.BookDataBase.Add(bookDataBase);
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
        [HttpGet()]
        public ActionResult Delete(int Book_ID)
        {
            var BookData = db.BookDataBase.Where(m => m.Book_ID == Book_ID).FirstOrDefault();
            if (BookData.Book_Status != "已借出")
            {
                db.BookDataBase.Remove(BookData);
                db.SaveChanges();
                TempData["deleteMessage"] = "已刪除";
                ViewBag.confirm = "刪除成功";
                return RedirectToAction("Index");
            }
            else {
                TempData["deleteMessage"] = "資料有誤，無法刪除，請重新操作";
                ViewBag.confirm = "書籍為「已借出」，無法刪除!";
                return RedirectToAction("Index");
            }
           
        }
        [HttpGet()]
        public ActionResult Edit(int Book_ID)
        {
            var BookData = db.BookDataBase.Where(m => m.Book_ID == Book_ID).FirstOrDefault();
            return View(BookData);
        }
        [HttpPost()]
        public ActionResult Edit(BookDataBase bookDataBase)
        {
            int Book_ID = bookDataBase.Book_ID;
            var BookData = db.BookDataBase.Where(m => m.Book_ID == Book_ID).FirstOrDefault();
            BookData.Book_Name = bookDataBase.Book_Name;
            BookData.Book_Author = bookDataBase.Book_Author;
            BookData.Book_Publisher = bookDataBase.Book_Publisher;
            BookData.Book_Note = bookDataBase.Book_Note;
            BookData.Book_BoughtDate = bookDataBase.Book_BoughtDate;
            BookData.Book_Class_Name = bookDataBase.Book_Class_Name;
            BookData.Book_Status = bookDataBase.Book_Status;
            BookData.Book_Brrower = bookDataBase.Book_Brrower;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}