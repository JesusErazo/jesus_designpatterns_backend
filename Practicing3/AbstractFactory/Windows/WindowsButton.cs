using AbstractFactory.Abstractions;
using AbstractFactory.MacOS;

namespace AbstractFactory.Windows
{
  internal class WindowsButton : IButton
  {
    public void Press()
    {
      Console.WriteLine($"[{typeof(WindowsButton).Name}] Pressed.");
    }
  }
}
