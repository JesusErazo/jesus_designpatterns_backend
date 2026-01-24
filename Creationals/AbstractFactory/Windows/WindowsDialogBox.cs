using AbstractFactory.Abstractions;

namespace AbstractFactory.Windows
{
  internal class WindowsDialogBox: IDialogBox
  {
    public void Open()
    {
      Console.WriteLine("[WINDOWS]: Opening Dialog Box...");
    }
  }
}
