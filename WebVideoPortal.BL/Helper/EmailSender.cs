using WebVideoPortal.Constants.Enums;
using WebVideoPortal.DAL;
using WebVideoPortal.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace WebVideoPortal.BL.Helper
{
    public class EmailSender
    {
        readonly DataModelContainer _entities = new DataModelContainer();

        public void Send(Templates templateId, string to, Dictionary<string, string> data)
        {
            var template = _entities.Templates.FirstOrDefault(t => t.Id == (int)templateId);
            if (template == null)
            {
                return;
            }

            var message = template.Body;
            foreach (var item in data)
            {
                message = message.Replace(string.Format("[{0}]", item.Key.ToUpper()), item.Value);
            }

            var mail = new MailMessage();
            mail.Subject = template.Subject;
            mail.Body = message;
            mail.IsBodyHtml = true;
            mail.To.Add(new MailAddress(to));
            SendAsync(mail);
        }

        private void SendAsync(MailMessage mail)
        {
            var smtp = new System.Net.Mail.SmtpClient();
            Task.Run(() => smtp.Send(mail));
        }
    }
}
