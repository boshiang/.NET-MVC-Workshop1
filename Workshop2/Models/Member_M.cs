using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Workshop2.Models
{
    public class Member_M
    {
        /// <summary>
        /// User_ID
        /// </summary>
        [DisplayName("人員編號")]
        public int User_ID { get; set; }

        /// <summary>
        /// User_CName
        /// </summary>
        [DisplayName("中文名稱")]
        [Required(ErrorMessage = "此欄位必填")]
        public string User_CName { get; set; }

        /// <summary>
        /// User_EName
        /// </summary>
        [DisplayName("英文名稱")]
        [Required(ErrorMessage = "此欄位必填")]
        public string User_EName { get; set; }

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


}
