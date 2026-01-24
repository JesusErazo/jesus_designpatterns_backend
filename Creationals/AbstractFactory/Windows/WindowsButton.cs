using AbstractFactory.Abstractions;

namespace AbstractFactory.Windows
{
  internal class WindowsButton: IButton
  {
    public void Press()
    {
      Console.WriteLine("[WINDOWS]: You pressed the button...");
    }
  }
}
