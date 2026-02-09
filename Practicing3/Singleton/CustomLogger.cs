namespace Singleton
{
  internal class CustomLogger : ICustomLogger
  {
    private CustomLogger()
    {
      Console.WriteLine($"Instantiating {typeof(CustomLogger).Name}...");
    }

    private static readonly Lazy<CustomLogger> _lazzyLogger = new(() => new CustomLogger());

    internal static CustomLogger Instance => _lazzyLogger.Value; 

    public void LogMessage(string message)
    {
      Console.WriteLine($"[{typeof(CustomLogger).Name}]: {message}");
    }

  }
}
