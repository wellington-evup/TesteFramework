using System;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class BirthDate : SingleBased<DateTime?>, IValidable<DateTime?>
    {
        public override void SetValue(DateTime? value)
        {
            Validate(value);
            base.SetValue(value);
        }

        public void Validate(DateTime? value)
        {
            if (value < new DateTime(1900, 1, 1))
                throw new PatternException();
        }
    }
}
