using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TesteFramework.Core
{
    public class ClientContactApiService
    {
        private readonly IAuthenticationValidator authenticationValidator;
        private readonly IClientContactUpdater clientContactUpdater;
        private readonly IClientContactResponseTranslator clientContactResponseTranslator;

        public ClientContactApiService(
            IAuthenticationValidator authenticationValidator,
            IClientContactUpdater clientContactUpdater,
            IClientContactResponseTranslator clientContactResponseTranslator)
        {
            this.authenticationValidator = authenticationValidator;
            this.clientContactUpdater = clientContactUpdater;
            this.clientContactResponseTranslator = clientContactResponseTranslator;
        }

        public HttpResponseMessage Update(WebToken webToken, Client client, List<EmailAddress> emails)
        {
            return clientContactResponseTranslator.GetResponseFromAction(() =>
            {
                authenticationValidator.Validate(webToken);
                clientContactUpdater.Update(client, emails);
            });
        }
    }
}
