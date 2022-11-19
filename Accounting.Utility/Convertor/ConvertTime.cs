using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Utility.Convertor
{
    public class ConvertTime
    {
        public static String Shamsi(DateTime inPutTime)
        {
            
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1}/{2} {3}:{4}", pc.GetYear(inPutTime), pc.GetMonth(inPutTime),
                pc.GetDayOfMonth(inPutTime),pc.GetHour(inPutTime),pc.GetMinute(inPutTime)); 
        }
    }
}
