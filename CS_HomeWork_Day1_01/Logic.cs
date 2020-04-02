using ConsoleIO;

namespace CS_HomeWork_Day1_01
{
    public static class Logic
    {
        private static byte SideSizeA { get; set; }
        private static byte SideSizeB { get; set; }
        private static byte SideSizeC { get; set; }

        public static void Initialization()
        {
            ConsoleInput.Input();
            while (!IsValidNumbers(ConsoleInput.A, ConsoleInput.B, ConsoleInput.C))
            {
                ConsoleOutput.WriteErrorMessage();
                ConsoleInput.Input();
            }
        }

        static bool IsValidNumbers(string A, string B, string C)
        {
            if (((byte.TryParse(A, out byte SideSizeA)) & (byte.TryParse(B, out byte SideSizeB)) & (byte.TryParse(C, out byte SideSizeC))) == false)
            {
                ConsoleOutput.ErrorMessage = "Ошибка! Введите число!";
                return false;
            }
            else if ((SideSizeA | SideSizeB | SideSizeC) <= 0)
            {
                ConsoleOutput.ErrorMessage = "Ошибка! Число дожно быть больше 0!";
                return false;
            }
            else if ((SideSizeA | SideSizeB | SideSizeC) >= 256)
            {
                ConsoleOutput.ErrorMessage = "Ошибка! Число должно быть меньше 256!";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
