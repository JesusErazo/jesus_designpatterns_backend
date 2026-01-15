using FactoryMethod.Reports;

namespace FactoryMethod.ReportExporters
{
  internal class CsvExporter : ReportExporter
  {
    protected override IReport CreateReport() => new CsvReport();
  }
}
