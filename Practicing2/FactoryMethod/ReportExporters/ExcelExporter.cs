using FactoryMethod.Reports;

namespace FactoryMethod.ReportExporters
{
  internal class ExcelExporter : ReportExporter
  {
    protected internal override IReport CreateReport() => new ExcelReport();
  }
}
