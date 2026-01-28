namespace FactoryMethod.ReportExporters
{
  internal abstract class ReportExporter
  {
    protected internal abstract IReport CreateReport();

    internal string Export(string content)
    {
      IReport report = CreateReport();
      return report.Generate(content);
    }
  }
}
