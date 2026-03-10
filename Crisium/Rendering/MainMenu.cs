
public class MainMenu() {
    Screen screen = new Screen();
    Typewriter typewriter = new Typewriter();
    Terminal terminal = new Terminal();
    private ConsoleKeyInfo option;
    private bool endMenu = false;
    public void showHeader() {
        Console.WriteLine(" \n ░█████╗░██████╗░██╗░██████╗██╗██╗░░░██╗███╗░░░███╗");
        Console.WriteLine(" ██╔══██╗██╔══██╗██║██╔════╝██║██║░░░██║████╗░████║");
        Console.WriteLine(" ██║░░╚═╝██████╔╝██║╚█████╗░██║██║░░░██║██╔████╔██║");
        Console.WriteLine(" ██║░░██╗██╔══██╗██║░╚═══██╗██║██║░░░██║██║╚██╔╝██║");
        Console.WriteLine(" ╚█████╔╝██║░░██║██║██████╔╝██║╚██████╔╝██║░╚═╝░██║");
        Console.WriteLine(" ░╚════╝░╚═╝░░╚═╝╚═╝╚═════╝░╚═╝░╚═════╝░╚═╝░░░░░╚═╝");
        Console.WriteLine(" Versión 0.1.0\n");
        Console.WriteLine(" Edición aventura de texto interactiva");
        Console.WriteLine(" Intérprete de comandos versión 0.1.0");
        Console.WriteLine(" Programado por José L. Ríos");
        Console.WriteLine(" (C) 2026 Derechos resevados Patolli Interactivo\n");
    }
    public void DisplayMenu() {
       Console.Clear();
               Console.Write("\x1b[38;2;0;255;65m");

        showHeader();
        Console.WriteLine(" ──────── MENÚ PRINCIPAL ────────");
        Console.WriteLine("   1. Nueva aventura");
        Console.WriteLine("   2. Cargar aventura");
        Console.WriteLine("   3. Configuración");
        Console.WriteLine("   4. Ayuda");
        Console.WriteLine("   5. Salir\n");
        Console.Write("\x1b[1m");
        Console.Write(" Seleccione opción (1-5): ");

        do {
            option = Console.ReadKey(true);

            if (option.KeyChar != '1' && option.KeyChar != '2' && option.KeyChar != '3' && option.KeyChar != '4' && option.KeyChar != '5') {
                Console.SetCursorPosition(1, 23);
                Console.Write("Opción invalida, intente de nuevo...");
                screen.PauseRandom(1000, 1000);
                Console.SetCursorPosition(1, 23);
                Console.Write("                                      ");
                Console.SetCursorPosition(26, 21);
            }
        } while (option.KeyChar is < '1' or > '5');

        PerformSelectedOption(option);
    }

    public void PerformSelectedOption(ConsoleKeyInfo _option) {
        switch(_option.KeyChar) {
            case '1':
                Console.WriteLine(" \n Nueva aventura...");
                var exits = new HashSet<string>
{
    "norte",
    "este"
};
screen.ClrScr();
                terminal.DrawTopBar("Bosque");

                terminal.DrawCompass(exits);

    terminal.WriteLine("Estás en un bosque oscuro.");

    string cmd = terminal.ReadCommand();

    terminal.WriteLine(" > " + cmd);
                
                break;
            case '2':
                Console.WriteLine("\n Cargar aventura...");
                break;
            case '3':
                Console.WriteLine("\n Configuración...");
                break;
            case '4':
                Console.WriteLine("\n Ayuda...");
                break;
            case '5':
                Console.Clear();
                typewriter.TypeText("\n CRISIUM\n");
                typewriter.TypeText("\n > JUEGO TERMINADO");
                typewriter.TypeText("\n > FIN DE LÍNEA.\n\n");
                break;
        }    
    }
}