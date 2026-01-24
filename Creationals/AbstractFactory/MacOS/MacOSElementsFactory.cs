using AbstractFactory.Abstractions;

namespace AbstractFactory.MacOS
{
  internal class MacOSElementsFactory : IElementsFactory
  {
    public IButton CreateButton() => new MacOSButton();

    public IDialogBox CreateDialogBox() => new MacOSDialogBox();
  }
}
