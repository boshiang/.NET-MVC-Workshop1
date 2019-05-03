using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Workshop2.Models
{
    public class BookSearchArg
    {
        [DisplayName("書名")]
        public string Book_Name { get; set; }
        [DisplayName("圖書類別")]
        public string Book_Class_Name { get; set; }
        [DisplayName("借閱人")]
        public string User_CName { get; set; }
        [DisplayName("借閱狀態")]
        public string Book_Status { get; set; }
    }
}