using FactoryMethodPractice.Reports;

namespace FactoryMethodPractice.ReportExporters
{
  internal class CsvExporter : ReportExporter
  {
    protected override IReport CreateReport() => new CsvReport();
  }
}
