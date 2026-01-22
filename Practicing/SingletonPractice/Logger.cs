namespace SingletonPractice
{
  internal class Logger: ICustomLogger
  {
    private Logger()
    {
      Console.WriteLine("Creating Logger Instance...");
    }

    private static readonly Lazy<Logger> _lazzyLogger = new (() => new Logger());

    public static Logger Instance => _lazzyLogger.Value;

    public void Log(string message)
    {
      Console.WriteLine(message);
    }
  }
}
