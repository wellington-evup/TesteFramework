using System;
using System.Collections.Generic;
using System.Text;

namespace TesteFramework.Core
{
    public class FakeClientContactValidator : IClientContactValidator
    {
        public void Validate(Client client, EmailAddress email)
        {
        }
    }
}
