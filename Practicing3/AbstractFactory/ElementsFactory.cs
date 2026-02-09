using AbstractFactory.Abstractions;
using AbstractFactory.MacOS;
using AbstractFactory.Windows;

namespace AbstractFactory
{
  internal static class ElementsFactory
  {
    internal static IElementsFactory CreateElementsFactory(string operativeSystemType)
    {
      return operativeSystemType switch
      {
        "macos" => new MacOSElementsFactory(),
        "windows" => new WindowsElementsFactory(),
        _ => throw new NotImplementedException("The operative system does not exist.")
      };
    }
  }
}
