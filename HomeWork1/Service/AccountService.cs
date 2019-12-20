using HomeWork1.Models;
using HomeWork1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork1.Service
{
    public class AccountService
    {
        private Model1 _context = new Model1();
        public IEnumerable<AccountViewModel> GetAccountList()
        {
            string[] categoryArray = new string[] { "收入", "支出" };
            var query = _context.AccountBook.AsEnumerable().Select(x => new AccountViewModel
            {
                Category = categoryArray[x.Categoryyy],
                LogDate = x.Dateee,
                Money = x.Amounttt
            });
            return query;
        }
    }
}