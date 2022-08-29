using System;

namespace State
{
    /// <summary>
    /// Клас стану завдання "Перевірено"
    /// </summary>
    public class Checked : ITaskState
    {
        public void CompleteTask(Task task)
        {
            throw new NotSupportedException("Завдання вже виконане!");
        }

        public void FoundMistakes(Task task)
        {
            task.State = new ResubmitForInspection();
        }

        public void CorrectMistakes(Task task)
        {
            throw new NotSupportedException("Всі помилки вже виправлені!");
        }

        public void Corrected(Task task)
        {
            throw new NotSupportedException("Завдання вже помічено правильним!");
        }

        public void Aprove(Task task)
        {
            task.Evaluate(task.GetMaxMark());
            task.State = new Completed();
        }

        public override string ToString()
        {
            return "Перевірено";
        }
    }
}
