using System;
using LabModels;
using System.Text.RegularExpressions;

namespace LabXML
{
    /// <summary>
    /// Клас методів для добування даних із консолі
    /// </summary>
    public static class DataFromConsole
    {
        public static uint GetUNumber(string className, string property)
        {
            uint number = 0;
            bool success = false;
            while (!success)
            {
                Console.Write($"{property}: ");
                try
                {
                    number = uint.Parse(Console.ReadLine());
                    success = true;
                }
                catch (ArgumentNullException)
                {
                    Output.OutputException($"{className} must have {property}!");
                }
                catch
                {
                    Output.OutputException($"{property} must be an unsigned number!");
                }
            }
            return number;
        }

        public static decimal GetDecimal(string className, string property)
        {
            decimal number = 0;
            bool success = false;
            while (!success)
            {
                Console.Write($"{property}: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    success = true;
                }
                catch (ArgumentNullException)
                {
                    Output.OutputException($"{className} must have {property}!");
                }
                catch
                {
                    Output.OutputException($"{property} must be a decimal!");
                }
            }
            return number;
        }

        public static string GetWord(string className, string property, Regex regex)
        {
            string word = null;
            bool success = false;
            while (!success)
            {
                Console.Write($"{property}: ");
                try
                {
                    word = Console.ReadLine().Validate();
                    if (!(regex == null) && !regex.IsMatch(word))
                    {
                        Output.OutputException($"{property} must consist only of {regex}!");
                    }
                    else
                    {
                        success = true;
                    }
                } 
                catch
                {
                    Output.OutputException($"{className} must have {property}!");
                }
            }
            return word;
        }

        public static FormOfKnoledgeControl GetForm(string className, string property)
        {
            FormOfKnoledgeControl form = 0;
            bool success = false;
            while (!success)
            {
                Console.Write($"{property}: ");
                try
                {
                    form = (FormOfKnoledgeControl)int.Parse(Console.ReadLine());
                    success = true;
                }
                catch (ArgumentNullException)
                {
                    Output.OutputException($"{className} must have {property}!");
                }
                catch (Exception)
                {
                    Output.OutputException($"{property} must be a digit(0-Test, 1-Examination)!");
                }
            }
            return form;
        }

        public static ConsoleKey AskToAdd(string className, ConsoleKey key)
        {
            Output.ColorOutput(string.Format(
                                             $"\nDo you want to add another {className}?"
                                             + "\nPress 'y' or 'n'."
                                            ), ConsoleColor.Yellow);
            while (key != ConsoleKey.Y && key != ConsoleKey.N)
            {
                key = Console.ReadKey(true).Key;
            }
            return key;
        }
    }
}
