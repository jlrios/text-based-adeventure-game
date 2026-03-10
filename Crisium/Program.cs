using Crisium.Screens;

namespace Crisium;
public class Program {
    static void Main(string[] args) {
        Console.Write("\x1b[38;2;0;255;65m");

        //Prologue prologue = new Prologue();
        MainMenu mainMenu = new MainMenu();

        //prologue.DisplayPrologue();
        mainMenu.DisplayMenu();

        Console.ResetColor();

        Console.Write("\x1b[0m");  // reset
        
    }
}