namespace FactoryMethodPractice.ReportExporters
{
  internal abstract class ReportExporter
  {
    protected abstract IReport CreateReport();
    internal string Export(string content)
    {
      IReport report = CreateReport();
      //We can put common code here
      return report.Generate(content);
    }
  }
}
