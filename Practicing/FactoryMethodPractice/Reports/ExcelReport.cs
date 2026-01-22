namespace FactoryMethodPractice.Reports
{
  internal class ExcelReport : IReport
  {
    public string Generate(string content)
    {
      string format = $"[EXCEL REPORT]: {content}";
      return format;
    }
  }
}
