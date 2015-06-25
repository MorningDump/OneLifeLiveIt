using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebVideoPortal.Models;
using WebVideoPortal.Constants;
using WebVideoPortal.Constants.Enums;
using WebVideoPortal.BL.Helper;
using WebVideoPortal.DAL;

namespace WebVideoPortal.BL
{
    public class SecurityLogic : BaseLogic
    {
        public async Task Register(string activateAccountLinkFormatted, UserRegisterModel model)
        {
            var duplicateEmail = Entities.Users.FirstOrDefault(u => u.Email == model.Email);
            if (duplicateEmail != null)
            {
                throw new ArgumentException(Strings.DuplicateEmail);
            }

            var hash = Security.HashSHA1(model.Password);

            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                CompanyName = model.CompanyName,
                PasswordHash = hash,
                EmailConfirmed = false,
                UID = Guid.NewGuid(),
                FirstLogin = false
            };

            Entities.Users.Add(user);
            await Entities.SaveChangesAsync();


            MailChimpHelper.AddEmail(model.Email);

            var data = new Dictionary<string, string>();
            data.Add("link", string.Format(activateAccountLinkFormatted, user.UID));

            var sender = new EmailSender();
            sender.Send(Templates.AccountActivation, model.Email, data);
        }

        public bool Authenticate(UserAuthenticateModel model)
        {
            var user = Entities.Users.FirstOrDefault(u => u.Email == model.Email);
            if (user == null)
            {
                throw new ArgumentException(Strings.IncorrectCombination);
            }

            var hash = Security.HashSHA1(model.Password);
            if (hash != user.PasswordHash)
            {
                throw new ArgumentException(Strings.IncorrectCombination);
            }

            return true;
        }

        public async Task ResetPassword(ResetPasswordModel model)
        {
            var user = Entities.Users.FirstOrDefault(u => u.UID == model.UID);
            if (user == null)
            {
                throw new ArgumentException(Strings.InvalidUserId);
            }

            var hash = Security.HashSHA1(model.Password);
            user.PasswordHash = hash;
            await Entities.SaveChangesAsync();
        }

        public void ForgotPassword(string resetLinkFormatted, ForgotPasswordModel model)
        {
            var user = Entities.Users.FirstOrDefault(u => u.Email == model.Email);
            if (user == null)
            {
                throw new ArgumentException(Strings.EmailNotExist);
            }

            var data = new Dictionary<string, string>();
            data.Add("link", string.Format(resetLinkFormatted, user.UID));

            var sender = new EmailSender();
            sender.Send(Templates.ResetPassword, user.Email, data);
        }

        public async Task ActivateAccount(Guid uid)
        {
            var user = Entities.Users.FirstOrDefault(u => u.UID == uid);
            if (user == null)
            {
                throw new ArgumentException(Strings.InvalidUserId);
            }

            user.EmailConfirmed = true;
            await Entities.SaveChangesAsync();
        }

        public int GetUserIdByEmail(string email)
        {
            var user = Entities.Users.FirstOrDefault(u => u.Email == email);
            return user != null ? user.Id : 0;
        }

        public string GetUserFullNameByEmail(string email)
        {
            var user = Entities.Users.FirstOrDefault(u => u.Email == email);
            return user != null ? user.Name : null;
        }
    }
}

