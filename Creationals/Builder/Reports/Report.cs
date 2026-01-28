namespace Builder.Reports
{
  internal class Report(
    string title,
    string author,
    List<(string Title, string Content)> sections,
    bool includeCoverPage,
    bool includeContentTable,
    string finalRepresentation
  )
  {
    public string Title { get; } = title;
    public string Author { get; } = author;
    public IReadOnlyList<(string Title, string Content)> Sections { get;} = sections.AsReadOnly();
    public bool IncludeCoverPage { get; } = includeCoverPage;
    public bool IncludeContentTable { get; } = includeContentTable;
    public string FinalRepresentation { get; } = finalRepresentation;
    public override string ToString() => FinalRepresentation;
  }
}
