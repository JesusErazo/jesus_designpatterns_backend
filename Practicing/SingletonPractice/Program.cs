// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using SingletonPractice;

ServiceCollection services = new ServiceCollection();
services.AddSingleton<ICustomLogger, Logger>(_ => Logger.Instance);

using ServiceProvider serviceProvider = services.BuildServiceProvider();

ICustomLogger logger = serviceProvider.GetRequiredService<ICustomLogger>();
ICustomLogger logger2 = serviceProvider.GetRequiredService<ICustomLogger>();


/*
Logger logger = Logger.Instance();
logger.Log("Message from instance 1");

Logger logger2 = Logger.Instance();
Console.WriteLine("Message from instance 2");
*/

/*
Parallel.For(0, 1000, _ =>
{
  Logger loggerP = Logger.Instance;
  Console.WriteLine(loggerP.GetHashCode());
});*/