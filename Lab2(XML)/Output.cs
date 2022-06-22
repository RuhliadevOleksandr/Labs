using System;

namespace LabXML
{
    /// <summary>
    /// Клас виводів
    /// </summary>
    static class Output
    {
        public static void ColorOutput(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void OutputTitle(string message)
        {
            ColorOutput(message, ConsoleColor.White);
        }

        public static void OutputException(string message)
        {
            ColorOutput(message, ConsoleColor.Red);
        }
    }
}
