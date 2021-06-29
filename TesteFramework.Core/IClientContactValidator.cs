namespace TesteFramework.Core
{
    public interface IClientContactValidator
    {
        void Validate(Client client, EmailAddress email);
    }
}