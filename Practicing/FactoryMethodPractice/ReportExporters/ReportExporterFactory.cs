namespace FactoryMethodPractice.ReportExporters
{
  internal static class ReportExporterFactory
  {
    internal static ReportExporter CreateExporter(string reportType)
    {
      return (reportType) switch
      {
        "pdf" => new PdfExporter(),
        "csv" => new CsvExporter(),
        "excel" => new ExcelExporter(),
        _ => throw new NotImplementedException("The report type does not exist."),
      };
    }
  }
}
