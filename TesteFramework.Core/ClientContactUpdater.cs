using System;
using System.Collections.Generic;
using System.Text;

namespace TesteFramework.Core
{
    public class ClientContactUpdater : IClientContactUpdater
    {
        private readonly IClientContactValidator clientContactValidator;

        public ClientContactUpdater(IClientContactValidator clientContactValidator)
        {
            this.clientContactValidator = clientContactValidator;
        }

        public void Update(Client client, List<EmailAddress> emails)
        {
            emails.ForEach(email => clientContactValidator.Validate(client, email));

            //Update
        }
    }
}
