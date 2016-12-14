using System.Web.Mvc;
using AuditSales.Models.AuditForms;

namespace AuditSales.Controllers
{
	public class FormsController : Controller
	{
		public ActionResult AddForm()
		{
			return View(new Form1()
			{
				PersonsCount = 123,
				KindOfActivity = KindOfActivity.Service
			});
		}
	}
}