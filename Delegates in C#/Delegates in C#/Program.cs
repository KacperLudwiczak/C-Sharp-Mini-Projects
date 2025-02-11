namespace Delegates_in_C_
{
    internal class Program
    {
        // 1. Declaration:
        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            // Delegates define a method signature, and any method assigned to a delegate must match this signature.

            // 2. Instantiation:
            Notify notifyDelegate = ShowMessage;
            // Other version:
            // Notify notifyDelegate = new Notify(notifyDelegate);

            // 3. Invocation:
            notifyDelegate("Hello, Delegates!");

            Console.ReadKey();
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
