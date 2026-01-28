using AbstractFactory.Abstractions;

namespace AbstractFactory.Windows
{
  internal class WindowsDialogBox : IDialogBox
  {
    public void Open()
    {
      Console.WriteLine($"[{typeof(WindowsDialogBox).Name}] Opening Dialog Box...");
    }
  }
}
