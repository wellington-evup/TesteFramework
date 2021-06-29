using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TesteFramework.Core
{
    public class ClientContactApiService
    {
        private readonly IClientContactUpdater clientContactUpdater;
        private readonly IClientContactResponseTranslator clientContactResponseTranslator;

        public ClientContactApiService(
            IClientContactUpdater clientContactUpdater,
            IClientContactResponseTranslator clientContactResponseTranslator)
        {
            this.clientContactUpdater = clientContactUpdater;
            this.clientContactResponseTranslator = clientContactResponseTranslator;
        }

        public HttpResponseMessage Update(Client client, List<EmailAddress> emails)
        {
            return clientContactResponseTranslator.GetResponseFromAction(() => clientContactUpdater.Update(client, emails));
        }
    }
}
