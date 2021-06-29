using System;
using System.Collections.Generic;
using System.Text;
using TesteFramework.Core.Exceptions;

namespace TesteFramework.Core
{
    public class ClientContactValidator : IClientContactValidator
    {
        public void Validate(Client client, EmailAddress email)
        {
            if(!email.Value.EndsWith(".br"))
                throw new ForeignException();
        }
    }
}
