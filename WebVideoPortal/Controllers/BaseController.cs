using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVideoPortal.BL;

namespace WebVideoPortal.Controllers
{
    public class BaseController : Controller
    {
        private readonly SecurityLogic _security = new SecurityLogic();

        protected void InitializeViewBag()
        {
            var email = User.Identity.Name;
            ViewBag.UserName = _security.GetUserFullNameByEmail(email);
        }
    }
}