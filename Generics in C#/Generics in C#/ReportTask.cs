namespace Generics_in_C_
{
    internal class ReportTask : ITask<string>
    {
        public string ReportName { get; set; }

        public string Perform()
        {
            return $"Report {ReportName} generated successfully.";
        }
    }
}
