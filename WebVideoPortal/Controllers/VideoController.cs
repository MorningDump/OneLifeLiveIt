using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebVideoPortal.Controllers
{
    [Authorize]
    public class VideoController : BaseController
    {
        // GET: Video
        public ActionResult Index()
        {
            InitializeViewBag();

            return View();
        }
    }
}