using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.MyOptionsSettings
{
    public class EmailSettings
    {
        public string MailPort { get; set; }
        public string MailServer { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public string SenderName { get; set; }
    }
}
