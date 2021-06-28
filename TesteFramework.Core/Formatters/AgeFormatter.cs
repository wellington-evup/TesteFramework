using System;
using TesteFramework.Core.ExtensionMethods;

namespace TesteFramework.Core.Formatters
{
    public class AgeFormatter : IFormatter<DateTime?>
    {
        public string Format(DateTime? value)
        {
            if (!value.HasValue) return null;

            var diff = value.Value.GetDateDiff();
            return string.Format("{0} ano(s)", diff.ElapsedYears);
        }
    }
}
