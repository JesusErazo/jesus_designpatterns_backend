using Builder.Reports.Common;

namespace Builder.Reports.Builders
{
  internal class ReportsDirector
  {
    internal Report Build(ReportBuilder builder, ReportContent reportContent)
    {
      builder.Start()
             .WithTitle(reportContent.Title)
             .WithContentTable(reportContent.ContentTable);

      if (!string.IsNullOrWhiteSpace(reportContent.Author))
        builder.WithAuthor(reportContent.Author);

      if (reportContent.CoverPage)
        builder.WithCoverPage();

      foreach (var (title, content) in reportContent.Sections)
      {
        builder.AddSection(title, content);
      }

      return builder.Build();
    }
  }
}
