using System;
using TesteFramework.Core.ExtensionMethods;

namespace TesteFramework.Core.Formatters
{
    public class DateFormatter : IFormatter<DateTime?>
    {
        public string Format(DateTime? value)
        {
            if (!value.HasValue) return null;

            var diff = value.Value.GetDateDiff();
            return string.Format("{0} ano(s), {1} mes(es) e {2} dia(s)", diff.ElapsedYears, diff.ElapsedMonths, diff.ElapsedDays);
        }
    }
}
