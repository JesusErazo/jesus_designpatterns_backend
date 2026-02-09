// See https://aka.ms/new-console-template for more information
using FactoryMethod.ReportExporters;

string reportType = "csv";
string content = "Annual sales...";
ReportExporter reportExporter = ReportExporterFactory.CreateExporter(reportType);
string report = reportExporter.Export(content);

Console.WriteLine(report);