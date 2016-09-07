using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroServiceApplication.Common
{
    class Util
    {
        public static DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000");
            //long lTime = long.Parse(timeStamp);
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
    }
}
