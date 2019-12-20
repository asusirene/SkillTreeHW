using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    public class AccountCategoryEnum
    {
        /// <summary>
        /// 帳單類型
        /// </summary>
        public enum Catrgory
        {
            [Description("支出")]
            InCome = 0,
            [Description("收入")]
            Expenses = 1
        }
    }
}