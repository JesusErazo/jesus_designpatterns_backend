namespace Singleton
{
  internal class Logger : ICustomLogger
  {
    private Logger()
    {
      Console.WriteLine("Instantiating the logger...");
    }

    private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());

    public static Logger Instance => _lazyLogger.Value;

    public void Log(string message)
    {
      Console.WriteLine($"[Log]: {message}");
    }
  }
}
