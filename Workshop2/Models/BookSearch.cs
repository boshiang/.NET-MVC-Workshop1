using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Models
{
    public class BookSearch
    {
        /// <summary>
        /// Book_Name
        /// </summary>
        [DisplayName("書名")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Name { get; set; }


        /// <summary>
        /// Book_Class_Name
        /// </summary>
        [DisplayName("圖書類別")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Class_Name { get; set; }
        public string Book_Class_Name_Code { get; set; }

        /// <summary>
        /// Book_BoughtDate
        /// </summary>
        [DisplayName("購書日期")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_BoughtDate { get; set; }

        /// <summary>
        /// Book_Borrower
        /// </summary>
        [DisplayName("借閱人")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Borrower { get; set; }
        public string Book_Borrower_Code { get; set; }

        /// <summary>
        /// Book_Status
        /// </summary>
        [DisplayName("借閱狀態")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Status { get; set; }
        public string Book_Status_Code { get; set; }

        /// <summary>
        /// Book_Author
        /// </summary>
        [DisplayName("書籍作者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Author { get; set; }

        /// <summary>
        /// Book_Publisher
        /// </summary>
        [DisplayName("出版商")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Publisher { get; set; }

        /// <summary>
        /// Book_Note
        /// </summary>
        [DisplayName("內容簡介")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Note { get; set; }
    }
}