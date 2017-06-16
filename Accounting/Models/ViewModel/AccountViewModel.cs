using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Accounting.Models.ViewModel
{
	public class AccountViewModel
	{
		public enum E_Accou_Type { Income, OutCome };
		public E_Accou_Type Type { get; set; }
		public int Amount {get; set;}
		public DateTime Date { get; set; }
		public string Comment { get; set; }
	}
}