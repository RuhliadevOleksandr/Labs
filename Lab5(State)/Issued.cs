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

        public void FoundMistakes(Task task) { }

        public void CorrectMistakes(Task task) { }

        public void Corrected(Task task) { }

        public void Aprove(Task task) { }

        public override string ToString()
        {
            return "Видано";
        }
    }
}
