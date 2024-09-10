using ServiceReference1;
using SmsIrRestful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServiceReference1.SendReceiveSoapClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AustriaTime
{
    public class sms
    {
        public static void Send(string[] to)
        {

             SmsIr smsIr = new SmsIr("*******************");

  var bulkSendResult = await smsIr.BulkSendAsync(12300000000, message, to);

           
        }


    }
}
