namespace FactoryMethod.Reports
{
  internal class CsvReport : IReport
  {
    public string Generate(string content)
    {
      return $"[CSV REPORT]: {content}";
    }
  }
}
