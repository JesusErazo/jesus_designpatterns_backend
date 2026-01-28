using System.Text;

namespace Builder.Reports.Builders
{
  internal class HtmlReportBuilder : ReportBuilder
  {
    internal override Report Build()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("<!DOCTYPE html><html><head><meta charset=\"utf-8\"><title>Report</title></head><body>");

      if (_coverPage)
      {
        sb.AppendLine($"<h1>{_title}</h1>");
        if (!string.IsNullOrWhiteSpace(_author))
          sb.AppendLine($"<p><em>Author: {System.Net.WebUtility.HtmlEncode(_author)}</em></p>");
        sb.AppendLine("<hr />");
      }

      if(_contentTable && _sections.Count > 0)
      {
        sb.AppendLine("<h2>Content Table</h2><ul>");
        for (int i = 0; i < _sections.Count; i++)
          sb.AppendLine($"<li><a href=\"#sec{i + 1}\">{System.Net.WebUtility.HtmlEncode(_sections[i].Item1)}</a></li>");
        sb.Append("</ul>");
      }

      for (int i = 0; i < _sections.Count; i++)
      {
        sb.AppendLine($"<h2 id=\"sec{i + 1}\">{System.Net.WebUtility.HtmlEncode(_sections[i].Item1)}</h2>");
        sb.AppendLine($"<p>{System.Net.WebUtility.HtmlEncode(_sections[i].Item2)}</p>");
      }

      sb.AppendLine("</body></html>");

      return new Report(
        _title,
        _author,
        new List<(string, string)>(_sections),
        _coverPage,
        _contentTable,
        sb.ToString()
      );
    }
  }
}
