using System;

namespace State
{
    /// <summary>
    /// Клас стану завдання "Видано"
    /// </summary>
    public class Issued : ITaskState
    {
        public void CompleteTask(Task task)
        {
            task.FinishTask();
            if (task.IsAvailable()) task.State = new SubmittedForReview();
        }

        public void FoundMistakes(Task task) 
        {
            throw new NotSupportedException("Завдання все ще невиконане!");
        }

        public void CorrectMistakes(Task task)
        {
            throw new NotSupportedException("Завдання все ще невиконане!");
        }

        public void Corrected(Task task)
        {
            throw new NotSupportedException("Завдання все ще невиконане!");
        }

        public void Aprove(Task task)
        {
            throw new NotSupportedException("Завдання все ще невиконане!");
        }

        public override string ToString()
        {
            return "Видано";
        }
    }
}
