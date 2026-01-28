using FactoryMethod.Reports;

namespace FactoryMethod.ReportExporters
{
  internal class PdfExporter : ReportExporter
  {
    protected internal override IReport CreateReport() => new PdfReport();
  }
}
