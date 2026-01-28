namespace FactoryMethod.Reports
{
  internal class PdfReport : IReport
  {
    public string Generate(string content)
    {
      return $"[PDF REPORT]: {content}";
    }
  }
}
