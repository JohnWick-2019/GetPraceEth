using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPraceEth
{
    /// <summary>
    /// The class combines the logic of getting a price and sending a message.
    /// </summary>
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
