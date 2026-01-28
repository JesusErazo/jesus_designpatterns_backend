using FactoryMethod.Reports;

namespace FactoryMethod.ReportExporters
{
  internal class CsvExporter : ReportExporter
  {
    protected internal override IReport CreateReport() => new CsvReport();
  }
}
