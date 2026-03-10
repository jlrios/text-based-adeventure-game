using System.Runtime.CompilerServices;

public class ProgressBar {
    Screen consoleSreen = new Screen();
    public void DrawProgressBar() {
        Console.Write(" Progreso: [ ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ] 0%" );
        int x = 13;
        for (var p = 1; p <= 20; p++) {
            Thread.Sleep(40);
            consoleSreen.GotoXY(x, Console.CursorTop);
            Console.Write("█");
            //Console.Write($"{p + 19}%");
            x++;
        }
    }
}