namespace FactoryMethod.Reports
{
  internal class PdfReport : IReport
  {
    public string Generate(string content)
    {
      return $"[PDF] PDF Report with content: {content}";
    }
  }
}
