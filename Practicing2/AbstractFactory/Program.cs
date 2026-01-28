// See https://aka.ms/new-console-template for more information

using AbstractFactory;
using AbstractFactory.Abstractions;

string operativeSystemType = "windows";

IElementsFactory elementsFactory = ElementsFactory.Create(operativeSystemType);
IButton button = elementsFactory.CreateButton();
IDialogBox dialogBox = elementsFactory.CreateDialogBox();

button.Press();
dialogBox.Open();