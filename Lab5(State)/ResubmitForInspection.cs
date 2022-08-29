using System;

namespace State
{
    /// <summary>
    /// Клас стану завдання "Перездати на перевірку"
    /// </summary>
    public class ResubmitForInspection : ITaskState
    {
        public void CompleteTask(Task task)
        {
            throw new NotSupportedException("Завдання вже виконане!");
        }

        public void FoundMistakes(Task task)
        {
            throw new NotSupportedException("Помилки у завданні вже знайдено!");
        }

        public void CorrectMistakes(Task task)
        {
            task.State = new SubmittedForReview();
        }

        public void Corrected(Task task)
        {
            throw new NotSupportedException("У завданні все ще є помилки!");
        }

        public void Aprove(Task task)
        {
            throw new NotSupportedException("У завданні все ще є помилки!");
        }

        public override string ToString()
        {
            return "Перездати на перевірку";
        }
    }
}
