using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Models
{
    public class Book_Data
    {
        /// <summary>
        /// Book_ID
        /// </summary>
        [DisplayName("PK流水號")]
        public int Book_ID { get; set; }

        /// <summary>
        /// Book_Name
        /// </summary>
        [DisplayName("書籍名稱")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Name { get; set; }

        /// <summary>
        /// Book_Class_ID
        /// </summary>
        [DisplayName("類別代號")]
        [Required(ErrorMessage = "此欄位必填")]
        public int Book_Class_ID { get; set; }

        /// <summary>
        /// Book_Author
        /// </summary>
        [DisplayName("書籍作者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Author { get; set; }

        /// <summary>
        /// Book_BoughtDate
        /// </summary>
        [DisplayName("書籍購書日期")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_BoughtDate { get; set; }

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

        /// <summary>
        /// Book_Status
        /// </summary>
        [DisplayName("書籍狀態")]
        [Required(ErrorMessage = "此欄位必填")]
        public char Book_Status { get; set; }

        /// <summary>
        /// Book_Keeper
        /// </summary>
        [DisplayName("書籍保管人")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Keeper { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        [DisplayName("建立時間")]
        [Required(ErrorMessage = "此欄位必填")]
        public DateTime Create_Date { get; set; }

        /// <summary>
        /// 建立使用者
        /// </summary>
        [DisplayName("建立使用者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Create_User { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        [DisplayName("修改時間")]
        [Required(ErrorMessage = "此欄位必填")]
        public DateTime Modify_Date { get; set; }

        /// <summary>
        /// 修改使用者
        /// </summary>
        [DisplayName("修改使用者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Modify_User { get; set; }
    }
}