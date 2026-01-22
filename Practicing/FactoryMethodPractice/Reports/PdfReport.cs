namespace FactoryMethodPractice.Reports
{
  internal class PdfReport : IReport
  {
    public string Generate(string content)
    {
      string format = $"[PDF REPORT]: {content}";
      return format;
    }
  }
}
