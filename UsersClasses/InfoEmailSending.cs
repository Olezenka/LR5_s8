using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5_s8.UsersClasses
{
    internal class InfoEmailSending
    {
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
