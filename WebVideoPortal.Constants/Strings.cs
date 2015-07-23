using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.Constants
{
    public static class Strings
    {
        public const string PasswordPolicy = "Password should be 6-15 symbols.";
        public const string PasswordNotMatch = "Password doesn't match.";
        public const string FixValidationErrors = "Please, fix validation errors.";
        public const string DuplicateEmail = "Duplicate email address.";
        public const string InvalidUserNameOrPassword = "Invalid username or password.";
        public const string InvalidUserId = "Invalid user.";
        public const string InvalidOldPassword = "Invalid old password.";
        public const string ErrorOccured = "Sorry, error has occurred.";
        public const string AgreeTerms = "Please, accept terms first.";
        public const string EmailNotExist = "Email doesn't exist.";
        public const string InvalidUrl = "Invalid Url.";
        public const string IsRequierd = "is required.";
        public const string InvalidNumber = "Please, enter valid integer number";
        public const string IncorrectCombination = "SORRY!<br /> We didn't recognize this combination of login/password";
        public const string Notification_DuplicateEmail = "We found {0} duplicate email addresses.";
        public const string QuestionaireSuccessfullyUpdated = "Thanks! Your answer has been successfully submitted";
        public const string PasswordPolicyRegex = @"^(?=.*).{6,15}$";
        public const string UrlRegex = @"^([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";
    }
}
