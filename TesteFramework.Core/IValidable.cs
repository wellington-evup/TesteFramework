namespace TesteFramework.Core
{
    public interface IValidable<T>
    {
        void Validate(T value);
    }
}