namespace TesteFramework.Core
{
    public interface ITranslator<X, Y>
    {
        Y Translate(X value);
        X Translate(Y value);
    }

    public abstract class Translator<X, Y> : ITranslator<X, Y>
    {
        public abstract Y Translate(X value);
        public abstract X Translate(Y value);
    }
}