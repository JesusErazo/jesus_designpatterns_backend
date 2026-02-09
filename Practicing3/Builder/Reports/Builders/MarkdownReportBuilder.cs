using System.Text;

namespace Builder.Reports.Builders
{
  internal class MarkdownReportBuilder : ReportBuilder
  {
    internal override Report Build()
    {
      StringBuilder sb = new StringBuilder();

      if (_coverPage)
      {
        sb.AppendLine($"# {_title}");
        if (!string.IsNullOrWhiteSpace(_author))
          sb.AppendLine($"> Author: **{_author}**");
        sb.AppendLine();
        sb.AppendLine("---");
      }

      if (_contentTable && _sections.Count > 0)
      {
        sb.AppendLine("## Content Table");
        for (int i = 0; i < _sections.Count; i++)
          sb.AppendLine($"- [{_sections[i].Item1}](#sec{i + 1})");
        sb.AppendLine();
      }

      for (int i = 0; i < _sections.Count; i++)
      {
        sb.AppendLine($"## <a name=\"sec{i + 1}\"></a>{_sections[i].Item1}");
        sb.AppendLine(_sections[i].Item2);
        sb.AppendLine();
      }

      return new Report(
        _title,
        _author,
        new List<(string, string)>(_sections),
        _coverPage,
        _contentTable,
        sb.ToString());
    }
  }
}
