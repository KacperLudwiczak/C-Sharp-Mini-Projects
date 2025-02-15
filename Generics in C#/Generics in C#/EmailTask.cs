namespace Generics_in_C_
{
    internal class EmailTask : ITask<string>
    {
        public string Recipient { get; set; }
        public string Message { get; set; }

        public string Perform()
        {
            return $"Email sent to {Recipient} with message {Message}.";
        }
    }
}
