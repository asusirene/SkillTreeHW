using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork1.Models.ViewModels
{
    public class AccountViewModel
    {
        public int Idx { get; set; }
        public string Category { get; set; }
        public DateTime LogDate { get; set; }
        public int Money { get; set; }
    }
}