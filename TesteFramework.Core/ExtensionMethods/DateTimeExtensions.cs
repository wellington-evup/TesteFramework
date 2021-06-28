using Itenso.TimePeriod;
using System;

namespace TesteFramework.Core.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static DateDiff GetDateDiff(this DateTime d1)
        {
            return GetDateDiff(d1, DateTime.Now);
        }

        public static DateDiff GetDateDiff(this DateTime d1, DateTime d2)
        {
            return new DateDiff(d1, d2);
        }
    }
}
