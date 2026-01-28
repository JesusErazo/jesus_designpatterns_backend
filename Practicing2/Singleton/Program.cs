// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using Singleton;

ServiceCollection services = new ServiceCollection();
services.AddSingleton<ILogger, Logger>(_ => Logger.Instance);

ServiceProvider serviceProvider = services.BuildServiceProvider();
ILogger logger = serviceProvider.GetRequiredService<ILogger>();
ILogger logger2 = serviceProvider.GetRequiredService<ILogger>();

logger.Log("Message from logger 1");
logger2.Log("Message from logger 2");

/*
Parallel.For(0, 1000, _ =>
{
  Logger logger = Logger.Instance;
});*/