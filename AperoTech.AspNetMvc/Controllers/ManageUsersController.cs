using System.Web.Mvc;
using AperoTech.AspNetMvc.Models;

namespace AperoTech.AspNetMvc.Controllers
{
	[RouteArea("admin"), RoutePrefix("user"), Route("{action=id}")]
	public class ManageUsersController : Controller
	{
		// GET
		public ActionResult Index()
		{
			ManageUsers manageUsers = new ManageUsers();
			return View(manageUsers);
		}

        [HttpPost]
        public ActionResult Add(ManageUsers manageUsers)
        {
            return View();
        }
    }
}