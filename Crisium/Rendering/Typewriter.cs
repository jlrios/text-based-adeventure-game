public class Typewriter {
    public void TypeText(string message) {
        foreach (char c in message) {
            Thread.Sleep(20);
            Console.Write(c);
        }
    }
}