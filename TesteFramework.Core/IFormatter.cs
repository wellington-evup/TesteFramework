namespace TesteFramework.Core
{
    public interface IFormatter<T>
    {
        string Format(T value);
    }
}