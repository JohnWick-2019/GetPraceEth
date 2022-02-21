using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPraceEth
{
    class WorkClass
    {
        public static void Show()
        {
            Parser parser = new Parser();
            {
                var ethParse = parser.Parse();
                SendMail.MailSend(ethParse);
            }
        }
    }
}
