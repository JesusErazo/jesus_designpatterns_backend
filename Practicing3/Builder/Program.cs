// See https://aka.ms/new-console-template for more information
using Builder.Reports;
using Builder.Reports.Builders;
using Builder.Reports.Common;

ReportContent reportContent = new ReportContent(
  Title: "Security Inspection",
  Author: "Jesus Erazo",
  CoverPage: true,
  ContentTable: true,
  Sections: new List<(string, string)>
  {
    ("Summary", "Key results..."),
    ("Controlls", "Control details..."),
    ("Attachments", "Evidences..."),
  }
);

ReportsDirector director = new ReportsDirector();

ReportBuilder markdownReportBuilder = new MarkdownReportBuilder();
ReportBuilder htmlReportBuilder = new HtmlReportBuilder();

Report mdReport = director.Build(markdownReportBuilder, reportContent);
Report htmlReport = director.Build(htmlReportBuilder, reportContent);

Console.WriteLine("--HTML REPORT--");
Console.WriteLine(htmlReport.FinalRepresentation);

Console.WriteLine("--MARKDOWN REPORT--");
Console.WriteLine(mdReport.FinalRepresentation);