public class Terminal {
    private readonly int width;
    private readonly int height;

    private readonly int topBar = 0;
    private readonly int compassTop = 1;
    private readonly int compassHeight = 5;
    private readonly int bottomBar;
    private readonly int inputLine;
    private readonly int gameTop;
    private readonly int gameBottom;

    private readonly List<string> buffer = new();

    public Terminal()
    {
        Console.CursorVisible = true;

        width = Console.WindowWidth;
        height = Console.WindowHeight;

        bottomBar = height - 35;
        inputLine = height - 2;

        gameTop = compassTop + compassHeight + 1;
        gameBottom = inputLine - 1;

        DrawStaticLayout();
    }

    private void DrawStaticLayout()
    {
        Console.Clear();

        DrawBottomBar();
    }

    public void DrawTopBar(string location)
    {
        Console.SetCursorPosition(0, topBar);

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        string text =
            $" {DateTime.Now:yyyy-MM-dd HH:mm:ss} | Ubicación: {location}";

        Console.Write(text.PadRight(width));

        //Console.ResetColor();
    }

    public void DrawBottomBar()
    {
        Console.SetCursorPosition(0, bottomBar);

        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;

        string text =
            " F1 Ayuda   F2 Mapa   F3 Inventario   ESC Salir ";

        Console.Write(text.PadRight(width));

        Console.ResetColor();
    }

    public void DrawCompass(HashSet<string> exits)
    {
        DrawCompassLine(0, "", "", Mark(exits, "norte"), "", "");
        DrawCompassLine(1, "", Mark(exits, "noroeste"), "", Mark(exits, "noreste"), "");
        DrawCompassLine(2, Mark(exits, "oeste"), "", "", "", Mark(exits, "este"));
        DrawCompassLine(3, "", Mark(exits, "suroeste"), "", Mark(exits, "sureste"), "");
        DrawCompassLine(4, "", "", Mark(exits, "sur"), "", "");
    }

    private void DrawCompassLine(int line, string left, string midLeft, string center, string midRight, string right)
    {
        int y = compassTop + line;

        Console.SetCursorPosition(0, y);

        Console.BackgroundColor = ConsoleColor.DarkBlue;

        int cx = width / 2;

        WriteAt(cx - 12, left);
        WriteAt(cx - 6, midLeft);
        WriteAt(cx, center);
        WriteAt(cx + 6, midRight);
        WriteAt(cx + 12, right);

        Console.ResetColor();
    }

    private string Mark(HashSet<string> exits, string dir)
    {
        bool ok = exits.Contains(dir);

        Console.ForegroundColor =
            ok ? ConsoleColor.Green : ConsoleColor.DarkGray;

        return ok ? "●" : "·";
    }

    private void WriteAt(int x, string text)
    {
        Console.SetCursorPosition(x, Console.CursorTop);
        Console.Write(text);
    }

    public void WriteLine(string text)
    {
        buffer.Add(text);

        if (buffer.Count > gameBottom - gameTop + 1)
            buffer.RemoveAt(0);

        RenderBuffer();
    }

    private void RenderBuffer()
    {
        for (int i = 0; i <= gameBottom - gameTop; i++)
        {
            Console.SetCursorPosition(0, gameTop + i);

            if (i < buffer.Count)
                Console.Write(buffer[i].PadRight(width));
            else
                Console.Write(new string(' ', width));
        }
    }

    public string ReadCommand()
    {
        Console.SetCursorPosition(0, inputLine);

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.Write("> ".PadRight(width));

        Console.SetCursorPosition(2, inputLine);

        Console.ResetColor();

        return Console.ReadLine() ?? "";
    }
}