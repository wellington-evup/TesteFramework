using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class RG : SingleBased<string>, IValidable<string>
    {
        public override void SetValue(string value)
        {
            Validate(value);
            base.SetValue(value);
        }

        public void Validate(string value)
        {
            if (Regex.IsMatch(value, @"^\d{1,2}).?(\d{3}).?(\d{3})-?(\d{1}|X|x$"))
                throw new RegexException();

        }
    }
}
