using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web.Security;
using WebVideoPortal.Models;
using WebVideoPortal.BL;
using WebVideoPortal.Constants;

namespace WebVideoPortal.Controllers
{
    [Authorize]
    public class QuestionaireController : BaseController
    {
        private readonly QuestionaireLogic _questionaire = new QuestionaireLogic();

        public ActionResult Index()
        {
            InitializeViewBag();

            var username = User.Identity.Name;
            var answer = _questionaire.GetAnswerByUserId(username);

            return View(answer);
        }

        [HttpPost]
        public async Task<ActionResult> Index(QuestionaireModel model)
        {
            if (!ModelState.IsValid)
            {
                model.IsValid = false;
                model.ErrorMessage = Strings.FixValidationErrors;
                return View(model);
            }

            var username = User.Identity.Name;
            if (string.IsNullOrWhiteSpace(username))
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Login");
            }

            try
            {
                await _questionaire.PostAnswer(model, username);
                model.InformationMessage =  Strings.QuestionaireSuccessfullyUpdated;
            }
            catch (ArgumentException ex)
            {
                model.IsValid = false;
                model.ErrorMessage = ex.Message;
                return View(model);
            }
            catch (Exception)
            {
                model.IsValid = false;
                model.ErrorMessage = Strings.ErrorOccured;
                return View(model);
            }

            return View(model);
        }
    }
}