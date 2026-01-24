using AbstractFactory.Abstractions;

namespace AbstractFactory.Windows
{
  internal class WindowsElementsFactory : IElementsFactory
  {
    public IButton CreateButton() => new WindowsButton();

    public IDialogBox CreateDialogBox() => new WindowsDialogBox();
  }
}
