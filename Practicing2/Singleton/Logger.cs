namespace Singleton
{
  internal class Logger: ILogger
  {
    private Logger() {
      Console.WriteLine("Creating Logger Instance...");
    }

    private static readonly Lazy<Logger> _lazzyLogger = new Lazy<Logger>(() => new Logger());

    internal static Logger Instance => _lazzyLogger.Value;

    public void Log(string message)
    {
      Console.WriteLine($"[LOG]: {message}");
    }
  }
}
