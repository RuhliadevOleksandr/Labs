using System;

namespace State
{
    /// <summary>
    /// Клас стану завдання "Здано на перевірку"
    /// </summary>
    public class SubmittedForReview : ITaskState 
    {
        public void CompleteTask(Task task)
        {
            throw new NotSupportedException("Завдання вже виконане!");
        }

        public void FoundMistakes(Task task)
        {
            if (task.IsAvailable()) task.State = new ResubmitForInspection();
        }

        public void CorrectMistakes(Task task)
        {
            throw new NotSupportedException("У завданні ще не знайшли помилок!");
        }

        public void Corrected(Task task)
        {
            if (task.IsAvailable()) task.State = new Checked();
        }

        public void Aprove(Task task)
        {
            throw new NotSupportedException("Завдання ще не перевірили!");
        }

        public override string ToString()
        {
            return "Здано на перевірку";
        }
    }
}
