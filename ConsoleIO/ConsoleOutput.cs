using static System.Console;

namespace ConsoleIO
{
    public static class ConsoleOutput
    {
        public static string ErrorMessage { get; set; }
        public static void WriteInputMessage(string number)
        {
            Write($"Введите число {number}: ");
        }
        public static void WriteErrorMessage()
        {
            WriteLine(ErrorMessage);
            WriteLine("Нажмите любую клавишу для продолжения...");
            ReadKey();
            Clear();
        }
    }
}
