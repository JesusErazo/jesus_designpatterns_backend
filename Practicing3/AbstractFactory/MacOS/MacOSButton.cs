using AbstractFactory.Abstractions;

namespace AbstractFactory.MacOS
{
  internal class MacOSButton : IButton
  {
    public void Press()
    {
      Console.WriteLine($"[{typeof(MacOSButton).Name}] Pressed.");
    }
  }
}
