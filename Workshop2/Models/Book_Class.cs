using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workshop2.Models
{
    public class Book_Class
    {
        /// <summary>
        /// 類別代號
        /// </summary>
        ///[MaxLength(8)]
        [DisplayName("類別代號")]
        public int Book_Class_ID { get; set; }

        /// <summary>
        /// 類別名稱
        /// </summary>
        /// ///[MaxLength(120)]
        [DisplayName("類別名稱")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Book_Class_Name { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        /// [MaxLength(8)]
        [DisplayName("建立時間")]
        [Required(ErrorMessage = "此欄位必填")]
        public DateTime Create_Date { get; set; }

        /// <summary>
        /// 建立使用者
        /// </summary>
        /// [MaxLength(24)]
        [DisplayName("建立使用者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Create_User { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        /// [MaxLength(8)]
        [DisplayName("修改時間")]
        [Required(ErrorMessage = "此欄位必填")]
        public DateTime Modify_Date { get; set; }

        /// <summary>
        /// 修改使用者
        /// </summary>
        /// [MaxLength(24)]
        [DisplayName("修改使用者")]
        [Required(ErrorMessage = "此欄位必填")]
        public string Modify_User { get; set; }
    }
}