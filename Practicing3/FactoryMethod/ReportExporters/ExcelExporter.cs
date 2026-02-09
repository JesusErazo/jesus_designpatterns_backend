using FactoryMethod.Reports;

namespace FactoryMethod.ReportExporters
{
  internal class ExcelExporter : ReportExporter
  {
    protected override IReport CreateReport() => new ExcelReport();
  }
}
