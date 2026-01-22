// See https://aka.ms/new-console-template for more information
using FactoryMethodPractice.ReportExporters;

string reportType = "excel";
string content = "JESUS REPORT TEST";
ReportExporter reportExporter = ReportExporterFactory.CreateExporter(reportType);
Console.WriteLine(reportExporter.Export(content));

