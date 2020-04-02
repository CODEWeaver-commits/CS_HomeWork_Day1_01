using static System.Console;

namespace ConsoleIO
{
    public static class ConsoleInput
    {
        public static string A { get; set; }
        public static string B { get; set; }
        public static string C { get; set; }
        public static void Input()
        {
            ConsoleOutput.WriteInputMessage("A");
            A = ReadLine();
            ConsoleOutput.WriteInputMessage("B");
            B = ReadLine();
            ConsoleOutput.WriteInputMessage("C");
            C = ReadLine();
        }
    }
}
