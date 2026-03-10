public class Screen {
    private static readonly Random _random = new();
    public void PauseRandom(int min, int max) {
        Thread.Sleep(_random.Next(min, max));
    }
    public void WaitForKey(string message = "Presione cualquier tecla para continuar...") {
        Console.Write(message);
        Console.ReadKey(true);
    }    

    // Clear screen
    public void ClrScr() {
        Console.Clear();
    }

    public void Pause(int ms) {
        Thread.Sleep(ms);
    }

    public void GotoXY(int x, int y) {
        Console.SetCursorPosition(x, y);
    }    


}