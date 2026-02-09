namespace Builder.Reports.Builders
{
  internal abstract class ReportBuilder
  {
    protected string _title = "";
    protected string _author = "";
    protected readonly List<(string, string)> _sections = new();
    protected bool _coverPage;
    protected bool _contentTable;

    //This is a Usual method when working with buider pattern
    internal ReportBuilder Start()
    {
      _title = "";
      _author = "Author";
      _sections.Clear();
      _coverPage = false;
      _contentTable = false;

      return this;
    }

    internal ReportBuilder WithTitle(string title)
    {
      _title = title;
      return this;
    }

    internal ReportBuilder WithAuthor(string author)
    {
      _author = author;
      return this;
    }

    internal ReportBuilder AddSection(string title, string content)
    {
      _sections.Add((title,content));
      return this;
    }

    internal ReportBuilder WithCoverPage(bool include = true)
    {
      _coverPage = include;
      return this;
    }

    internal ReportBuilder WithContentTable(bool include = true)
    {
      _contentTable = include;
      return this;
    }

    internal abstract Report Build();
  }
}
