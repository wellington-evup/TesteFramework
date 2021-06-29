using System.Collections.Generic;

namespace TesteFramework.Core
{
    public interface IClientContactUpdater
    {
        void Update(Client client, List<EmailAddress> emails);
    }
}