using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class EmailAddress : SingleBased<string>, IValidable<string>
    {
        public override void SetValue(string value)
        {
            Validate(value);
            base.SetValue(value);
        }

        public void Validate(string value)
        {
            if (!Regex.IsMatch(value, @"^[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?"))
                throw new RegexException();


        }
    }
}
