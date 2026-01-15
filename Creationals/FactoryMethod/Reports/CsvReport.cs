namespace FactoryMethod.Reports
{
  internal class CsvReport : IReport
  {
    public string Generate(string content)
    {
      return $"[CSV] CSV Report with content: {content}";
    }
  }
}
