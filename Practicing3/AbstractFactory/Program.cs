// See https://aka.ms/new-console-template for more information

using AbstractFactory;
using AbstractFactory.Abstractions;

string osType = "macos";
IElementsFactory elementsFactory = ElementsFactory.CreateElementsFactory(osType);
IButton button = elementsFactory.CreateButton();
IDialogBox dialogBox = elementsFactory.CreateDialogBox();

button.Press();
dialogBox.Open();
