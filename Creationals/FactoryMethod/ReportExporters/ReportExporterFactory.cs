namespace FactoryMethod.ReportExporters
{
  internal static class ReportExporterFactory
  {
    internal static ReportExporter CreateExporter(string reportType)
    {
      return reportType switch
      {
        "pdf" => new PdfExporter(),
        "excel" => new ExcelExporter(),
        "csv" => new CsvExporter(),
        _ => throw new NotImplementedException("The report type does not exist."),
      };
    }
  }
}
