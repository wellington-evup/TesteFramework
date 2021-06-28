using System;

namespace TesteFramework.Core
{
    public class SingleBased<T>
    {
        public T Value { get; private set; }

        public SingleBased()
        {

        }

        public SingleBased(T value)
        {
            SetValue(value);
        }

        public virtual void SetValue(T value)
        {
            Value = value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public string ToString(IFormatter<T> formatter)
        {
            return formatter.Format(Value);
        }
    }
}
