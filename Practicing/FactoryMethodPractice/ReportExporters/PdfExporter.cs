using FactoryMethodPractice.Reports;

namespace FactoryMethodPractice.ReportExporters
{
  internal class PdfExporter : ReportExporter
  {
    protected override IReport CreateReport() => new PdfReport();
  }
}
