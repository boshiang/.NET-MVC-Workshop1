using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Models
{
    public class BookInsert
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
    }
}