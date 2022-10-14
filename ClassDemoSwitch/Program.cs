// See https://aka.ms/new-console-template for more information
using ClassDemoSwitch;

Console.WriteLine("Hello, World!");

Menu menu = new Menu();
bool stop = false;

while (!stop)
{
    menu.PrintMenu();

    stop = menu.ReadChoice();

}




