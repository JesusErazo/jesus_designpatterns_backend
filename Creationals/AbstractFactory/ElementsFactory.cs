using AbstractFactory.Abstractions;
using AbstractFactory.MacOS;
using AbstractFactory.Windows;

namespace AbstractFactory
{
  internal static class ElementsFactory
  {
    public static IElementsFactory CreateFactory(string operativeSystem)
    {
      return (operativeSystem) switch
      {
        "windows" => new WindowsElementsFactory(),
        "macos" => new MacOSElementsFactory(),
        _ => throw new NotImplementedException("Operative system type not supported.")
      };

    }
  }
}
