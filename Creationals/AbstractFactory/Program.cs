using AbstractFactory;
using AbstractFactory.Abstractions;

string operativeSystem = "windows";

IElementsFactory elementsFactory = ElementsFactory.CreateFactory(operativeSystem);
IDialogBox dialogBox = elementsFactory.CreateDialogBox();
IButton button = elementsFactory.CreateButton();

dialogBox.Open();
button.Press();

