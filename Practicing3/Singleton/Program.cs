
using Microsoft.Extensions.DependencyInjection;
using Singleton;

ServiceCollection services = new ServiceCollection();
services.AddSingleton<ICustomLogger, CustomLogger>(_ => CustomLogger.Instance);
using ServiceProvider serviceProvider = services.BuildServiceProvider();
/*
ICustomLogger logger = serviceProvider.GetRequiredService<ICustomLogger>();
logger.LogMessage("This is a test message");
*/

Parallel.For(0, 1000, _ =>
{
  ICustomLogger loggerTest = serviceProvider.GetRequiredService<ICustomLogger>();
});
