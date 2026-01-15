using Singleton;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.AddSingleton<ICustomLogger, Logger>(_ => Logger.Instance);

using ServiceProvider serviceProvider = services.BuildServiceProvider();

ICustomLogger logger = serviceProvider.GetRequiredService<ICustomLogger>();
ICustomLogger logger2 = serviceProvider.GetRequiredService<ICustomLogger>();

logger.Log("Message from logger 1");
logger2.Log("Message from logger 2");

/*
//Testing that we get a single instance
Logger logger = Logger.Instance;
Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

//Testing on a multi-threat environment
Parallel.For(0, 1000, _ =>
{
  Logger logger = Logger.Instance;
});*/