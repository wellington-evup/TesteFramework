using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class CNPJ : SingleBased<string>, IValidable<string>
    {
        public override void SetValue(string value)
        {
            Validate(value);
            base.SetValue(value);
        }

        public void Validate(string value)
        {
            if (Regex.IsMatch(value, @"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$"))
                throw new RegexException();

        }
    }
}
