using System;
using System.Text;

namespace State
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Task task = new Task(new Issued(), 12, DateTime.Parse("8/11/2022"));

            task.CompleteTask();

            task.FoundMistakes();

            task.CorrectMistakes();

            task.Corrected();

            task.Aprove();

            Console.WriteLine(task);

            Console.ReadKey();
        }        
    }
}
