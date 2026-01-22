namespace FactoryMethodPractice.Reports
{
  internal class CsvReport : IReport
  {
    public string Generate(string content)
    {
      string format = $"[CSV REPORT]: {content}";
      return format;
    }
  }
}
