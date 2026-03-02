using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LR5_s8.UsersClasses
{
    internal class InfoEmailSending
    {
        public InfoEmailSending(string smtpClientAdress,
            StringPair emailAdressFrom,
            string emailPassword,
            StringPair emailAdressTo,
            string subject,
            string body)
        {
            SmtpClientAdress = String.IsNullOrWhiteSpace(smtpClientAdress) ?
                 throw new Exception("Нельзя вставлять пробелы или пустые значения!") : smtpClientAdress;
            EmailAdressFrom = emailAdressFrom ?? throw new ArgumentNullException(nameof(emailAdressFrom));
            EmailPassword = String.IsNullOrWhiteSpace(emailPassword) ?
                 throw new Exception("Нельзя вставлять пробелы или пустые значения!") : emailPassword;
            EmailAdressTo = emailAdressFrom ?? throw new ArgumentNullException(nameof(emailAdressTo));
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
            Body = body ?? throw new ArgumentNullException(body);
        }
        public string SmtpClientAdress { get; set; }
        public StringPair EmailAdressFrom { get; set; }
        public string EmailPassword { get; set; }
        public StringPair EmailAdressTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public class StringPair
        {
            public StringPair(string emailAdress, string name)
            {
                EmailAdress = string.IsNullOrWhiteSpace(emailAdress) ?
                    throw new Exception("Нельзя вставлять пробелы или пустые значения!") : emailAdress;
                Name = String.IsNullOrWhiteSpace(name) ?
                    throw new Exception("Нельзя вставлять пробелы или пустые значения!") : name;
            }
            public string EmailAdress { get; set; } public string Name { get; set; }
        }
    }
}
