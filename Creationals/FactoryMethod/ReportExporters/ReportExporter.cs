namespace FactoryMethod.ReportExporters
{
  internal abstract class ReportExporter
  {
    protected abstract IReport CreateReport();

    internal string Export(string content)
    {
      IReport report = CreateReport();
      //Here we can put some common code
      return report.Generate(content);
    }
  }
}
