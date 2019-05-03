using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Models
{
    public class Book_Code
    {
        /// <summary>
        /// Code_Type
        /// </summary>
        [DisplayName("Code_Type")]
        public int Code_Type { get; set; }

        /// <summary>
        /// Code_ID
        /// </summary>
        [DisplayName("Code_ID")]
        [Required(ErrorMessage = "此欄位必填")]
        public int Code_ID { get; set; }

        /// <summary>
        /// Code_Type_Desc
        /// </summary>
        [DisplayName("Code_Type描述")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Code_Type_Desc { get; set; }

        /// <summary>
        /// Code_Name
        /// </summary>
        [DisplayName("Code_Name描述")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Code_Name { get; set; }

        /// <summary>
        /// Create_Date
        /// </summary>
        [DisplayName("建立時間")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Create_Date { get; set; }

        /// <summary>
        /// Create_User
        /// </summary>
        [DisplayName("建立使用者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Create_User { get; set; }

        /// <summary>
        /// Modify_Date
        /// </summary>
        [DisplayName("修改時間")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Modify_Date { get; set; }

        /// <summary>
        /// Modify_User
        /// </summary>
        [DisplayName("修改使用者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Modify_User { get; set; }
    }

    //public static void Main()
    //{
    //    IList<Book_Code> list = new List<Book_Code>()
    //    {
    //        new Book_Code()
    //        {
    //            Code_Type = 1,
    //            Code_ID = 1,
    //            Code_Type_Desc = "one",
    //            Code_Name = "one",
    //            Create_Date = "1990/06/18",
    //            Create_User = 


    //        }
    //    };
    //}
}