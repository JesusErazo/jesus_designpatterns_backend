namespace FactoryMethod.Reports
{
  internal class ExcelReport : IReport
  {
    public string Generate(string content)
    {
      return $"[EXCEL REPORT]: {content}";
    }
  }
}
