using FactoryMethodPractice.Reports;

namespace FactoryMethodPractice.ReportExporters
{
  internal class ExcelExporter : ReportExporter
  {
    protected override IReport CreateReport() => new ExcelReport();
  }
}
