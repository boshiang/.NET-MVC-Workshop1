using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Models
{
    /// <summary>
    /// 新修刪查
    /// <param name="Book_Data"></param>
    /// </summary>
    public class Book_Service
    {
        /// <summary>
        /// 查詢
        /// </summary>
        public int SearchBook(Models.Book_Class BookCode)
        {
            return 0;
        }

        public List<Models.Book_Data> GetBook_DatasByCondition(Models.BookSearchArg arg)
        {
            List<Models.Book_Data> Book = new List<Book_Data>();
            Book.Add(new Book_Data() { Book_ID = 1, Book_Name = "第一本", Book_Class_ID = 1, Book_Author = "123", Book_BoughtDate = "1999/01/01", Book_Publisher = "123", Book_Note  = "123"});
            Book.Add(new Book_Data() { Book_ID = 2, Book_Name = "第2本", Book_Class_ID = 2, Book_Author = "123", Book_BoughtDate = "1999/01/01", Book_Publisher = "123", Book_Note = "123" });
            return Book;
        }

    }
}