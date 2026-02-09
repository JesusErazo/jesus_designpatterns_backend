namespace FactoryMethod.Reports
{
  internal class ExcelReport : IReport
  {
    public string Generate(string content)
    {
      return $"[{typeof(ExcelReport).Name}]: {content}";
    }
  }
}
