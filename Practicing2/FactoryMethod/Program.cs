// See https://aka.ms/new-console-template for more information
using FactoryMethod.ReportExporters;

string reportType = "html";
string content = "Jesus Mateo";

ReportExporter reportExporter = ReportExporterFactory.CreateExporter(reportType);
Console.WriteLine(reportExporter.Export(content));
