using Accounting.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accounting.Controllers
{
    public class AccountingController : Controller
    {
        // GET: Accounting
        public ActionResult AccountIndex()
        {
			List<AccountViewModel> pageData = new List<AccountViewModel>();

			for(int i = 1; i < 5; i++)
			{
				if(i == 3)
				{
					pageData.Add(
					new AccountViewModel()
					{ Amount = i * 30, Date = DateTime.Now, Type = AccountViewModel.E_Accou_Type.Income, Comment = "" }
					);
				}
				else
				{
					pageData.Add(
					new AccountViewModel()
					{ Amount = i * 30, Date = DateTime.Now, Type = AccountViewModel.E_Accou_Type.OutCome, Comment = "" }
					);
				}				
			}

			return View(pageData);
        }
    }
}