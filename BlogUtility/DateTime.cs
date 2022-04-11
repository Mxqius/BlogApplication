using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUtility
{
    public class DateTime
    {
        public string GetTime()
        {
            PersianCalendar PC = new PersianCalendar();
            int day = PC.GetDayOfMonth(System.DateTime.Now);
            int month = PC.GetMonth(System.DateTime.Now);
            int year = PC.GetYear(System.DateTime.Now);
            string time = PC.GetHour(System.DateTime.Now).ToString().PadLeft(2, '0') + ":" + PC.GetMinute(System.DateTime.Now).ToString().PadLeft(2, '0') + ":" + PC.GetSecond(System.DateTime.Now).ToString().PadLeft(2, '0');
            return time;
        }
        public string GetDate()
        {
            PersianCalendar PC = new PersianCalendar();
            int day = PC.GetDayOfMonth(System.DateTime.Now);
            int month = PC.GetMonth(System.DateTime.Now);
            int year = PC.GetYear(System.DateTime.Now);
            string date = year.ToString() + "/" + month.ToString().PadLeft(2, '0') + "/" + day.ToString().PadLeft(2, '0');
            return date;
        }
    }
}
