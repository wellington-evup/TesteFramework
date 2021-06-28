using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class CEP : SingleBased<string>, IValidable<string>
    {
        public override void SetValue(string value)
        {
            Validate(value);
            base.SetValue(value);
        }

        public void Validate(string value)
        {
            if (Regex.IsMatch(value, @"^[0-9]{5})-?([0-9]{3}$"))
                throw new RegexException();


        }
    }
}
