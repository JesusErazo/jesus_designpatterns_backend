using AbstractFactory.Abstractions;

namespace AbstractFactory.MacOS
{
  internal class MacOSButton: IButton
  {
    public void Press()
    {
      Console.WriteLine("[MacOS]: You pressed the button...");
    }
  }
}
