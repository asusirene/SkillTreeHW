using HomeWork1.Models;
using HomeWork1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static HomeWork1.Models.AccountCategoryEnum;

namespace HomeWork1.Service
{
    public class AccountService
    {
        private Model1 _context = new Model1();
        public List<AccountCategoryViewModel> GetAccountCategory()
        {
            List<AccountCategoryViewModel> cateList = new List<AccountCategoryViewModel>();
            foreach (AccountCategoryEnum item in Enum.GetValues(typeof(Catrgory)))
            {
                AccountCategoryViewModel cate = new AccountCategoryViewModel();
                cate.Key = Convert.ToInt16(item);
                cate.Value = cate.Key.ToString(); //不知道為何無法取得EnumHelper的擴充方法
                cateList.Add(cate);
            }
            return cateList;
        }
        public IEnumerable<AccountViewModel> GetAccountList()
        {
            var query = _context.AccountBook.AsEnumerable().Select(x => new AccountViewModel
            {
                Category = ((Catrgory)x.Categoryyy).ToString(),  //不知道為何無法取得EnumHelper的擴充方法
                LogDate = x.Dateee,
                Money = x.Amounttt
            });
            return query;
        }
    }
}