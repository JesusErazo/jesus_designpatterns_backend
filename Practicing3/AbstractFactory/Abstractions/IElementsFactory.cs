namespace AbstractFactory.Abstractions
{
  internal interface IElementsFactory
  {
    IButton CreateButton();
    IDialogBox CreateDialogBox();
  }
}
