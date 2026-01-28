using AbstractFactory.Abstractions;

namespace AbstractFactory.Windows
{
  internal class WindowsButton : IButton
  {
    public void Press()
    {
      Console.WriteLine($"[{typeof(WindowsButton).Name}] Button Pressed...");
    }
  }
}
