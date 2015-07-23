using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebVideoPortal.BL;

namespace WebVideoPortal.Controllers
{
    [Authorize]
    public class VideoController : BaseController
    {
        private readonly QuestionaireLogic _questionaire = new QuestionaireLogic();

        // GET: Video
        public ActionResult Index()
        {
            InitializeViewBag();

            var username = User.Identity.Name;
            var check = _questionaire.CheckAnswerByUserId(username);
            if(!check)
            {
                return RedirectToAction("Index", "Questionaire");
            }

            return View();
        }
    }
}