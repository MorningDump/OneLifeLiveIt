using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Threading.Tasks;
using WebVideoPortal.BL;
using WebVideoPortal.Models;
using WebVideoPortal.Constants;

namespace WebVideoPortal.Controllers
{

    public class SecurityController : Controller
    {
        private readonly SecurityLogic _security = new SecurityLogic();

        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Video");
            }

            var model = new UserAuthenticateModel();
            return View(model);
        }

        public ActionResult Register()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Video");
            }

            var model = new UserRegisterModel2();
            return View(model);
        }

        public async Task<ActionResult> Activate(Guid? uid)
        {
            if (!uid.HasValue)
            {
                return RedirectToAction("Login", "Security");
            }

            try
            {
                await _security.ActivateAccount(uid.Value);
            }
            catch (Exception)
            {
            }

            return RedirectToAction("Login", "Security");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Security");
        }

        public ActionResult ForgotPassword()
        {
            var model = new ForgotPasswordModel();
            return View(model);
        }

        public ActionResult ResetPassword(Guid? uid)
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("Index", "Video");
            }

            if (!uid.HasValue)
            {
                return RedirectToAction("Login");
            }

            var model = new ResetPasswordModel();
            model.UID = uid.Value;
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(UserAuthenticateModel model)
        {
            if (!ModelState.IsValid)
            {
                model.IsValid = false;
                model.ErrorMessage = Strings.FixValidationErrors;
                return View(model);
            }

            try
            {
                if (_security.Authenticate(model))
                {
                    FormsAuthentication.RedirectFromLoginPage(model.Email, false);
                }
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

        [HttpPost]
        public async Task<ActionResult> Register(UserRegisterModel2 model)
        {
            if (!ModelState.IsValid)
            {
                model.IsValid = false;
                model.ErrorMessage = Strings.FixValidationErrors;
                return View(model);
            }

            try
            {
                var link = HttpUtility.UrlDecode(Url.Action("Activate", "Security", new { uid = "{0}" }, Request.Url.Scheme));
                await _security.Register(link, model);

                FormsAuthentication.RedirectFromLoginPage(model.Email, false);
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

        [HttpPost]
        public ActionResult ForgotPassword(ForgotPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                model.IsValid = false;
                model.ErrorMessage = Strings.FixValidationErrors;
                return View(model);
            }

            try
            {
                var link = HttpUtility.UrlDecode(Url.Action("ResetPassword", "Security", new { uid = "{0}" }, Request.Url.Scheme));
                _security.ForgotPassword(link, model);
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

            return RedirectToAction("Login");
        }

        [HttpPost]
        public async Task<ActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!model.UID.HasValue)
            {
                return RedirectToAction("Login");
            }

            if (!ModelState.IsValid)
            {
                model.IsValid = false;
                model.ErrorMessage = Strings.FixValidationErrors;
                return View(model);
            }

            try
            {
                await _security.ResetPassword(model);
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

            return RedirectToAction("Login");
        }
    }
}