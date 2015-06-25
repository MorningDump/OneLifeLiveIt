using MailChimp;
using MailChimp.Helper;
using MailChimp.Lists;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVideoPortal.BL.Helper
{
    public static class MailChimpHelper
    {
        public static EmailParameter AddEmail(string email)
        {
            try
            {
                var apiKey = ConfigurationManager.AppSettings["MailChimpApiKey"];
                var listId = ConfigurationManager.AppSettings["MailChimpListId"];

                var mc = new MailChimpManager(apiKey);

                //  Create the email parameter
                var emailParam = new EmailParameter()
                {
                    Email = email
                };

                var result = mc.Subscribe(listId, emailParam, doubleOptIn: false);
                return result;
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
