namespace Builder.Reports.Common
{
  internal record ReportContent(
    string Title,
    string? Author,
    bool CoverPage,
    bool ContentTable,
    IReadOnlyList<(string Title, string Content)> Sections
  );
}
