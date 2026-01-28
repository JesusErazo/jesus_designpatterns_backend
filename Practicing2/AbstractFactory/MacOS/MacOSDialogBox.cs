using AbstractFactory.Abstractions;

namespace AbstractFactory.MacOS
{
  internal class MacOSDialogBox : IDialogBox
  {
    public void Open()
    {
      Console.WriteLine($"[{typeof(MacOSDialogBox).Name}] Opening Dialog Box...");
    }
  }
}
