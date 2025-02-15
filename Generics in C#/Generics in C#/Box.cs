namespace Generics_in_C_
{
    internal class Box<T> // Generic
    {
        public T Content { get; set; }

        public string Log()
        {
            return $"Box contains {Content}.";
        }
    }
}
