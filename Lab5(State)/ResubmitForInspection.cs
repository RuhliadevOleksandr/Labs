namespace State
{
    /// <summary>
    /// Клас стану завдання "Перездати на перевірку"
    /// </summary>
    public class ResubmitForInspection : ITaskState
    {
        public void CompleteTask(Task task) { }

        public void FoundMistakes(Task task) { }

        public void CorrectMistakes(Task task)
        {
            task.State = new SubmittedForReview();
        }

        public void Corrected(Task task) { }

        public void Aprove(Task task) { }

        public override string ToString()
        {
            return "Перездати на перевірку";
        }
    }
}
