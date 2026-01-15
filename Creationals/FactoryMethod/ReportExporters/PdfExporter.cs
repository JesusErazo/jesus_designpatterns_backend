using FactoryMethod.Reports;

namespace FactoryMethod.ReportExporters
{
  internal class PdfExporter : ReportExporter
  {
    protected override IReport CreateReport() => new PdfReport();
  }
}
