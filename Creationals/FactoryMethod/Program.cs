using FactoryMethod.ReportExporters;

string reportType = "pdf";
string content = "This is the content of the report";

ReportExporter report = ReportExporterFactory.CreateExporter(reportType);
Console.WriteLine(report.Export(content));