using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class CPF : SingleBased<string>, IValidable<string>
    {
        public override void SetValue(string value)
        {
            Validate(value);
            base.SetValue(value);
        }

        public void Validate(string value)
        {
            if (!Regex.IsMatch(value, @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$"))
                throw new RegexException();

            if (!ValidatePattern(value))
                throw new PatternException();
        }

        private bool ValidatePattern(string value)
        {
            value = value.Replace(".", "").Replace("-", "");
            switch (value)
            {
                case "00000000000":
                    return false;
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }

            if (value.Length != 11)
                return false;

            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digit;
            int sum;
            int remainder;

            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "");

            if (!value.All(char.IsNumber))
            {
                return false;
            }

            if (value.Length != 11)
                return false;

            tempCpf = value.Substring(0, 9);
            sum = 0;

            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplier1[i];

            remainder = sum % 11;

            if (remainder < 2)
                remainder = 0;
            else
                remainder = 11 - remainder;

            digit = remainder.ToString();
            tempCpf += digit;
            sum = 0;

            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplier2[i];

            remainder = sum % 11;
            if (remainder < 2)
                remainder = 0;
            else
                remainder = 11 - remainder;

            digit += remainder.ToString();

            return value.EndsWith(digit);
        }
    }
}
