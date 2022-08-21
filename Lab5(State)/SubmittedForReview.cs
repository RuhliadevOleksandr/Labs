namespace State
{
    /// <summary>
    /// Клас стану завдання "Здано на перевірку"
    /// </summary>
    public class SubmittedForReview : ITaskState 
    {
        public void CompleteTask(Task task) { }

        public void FoundMistakes(Task task)
        {
            if (task.IsAvailable()) task.State = new ResubmitForInspection();
        }

        public void CorrectMistakes(Task task) { }

        public void Corrected(Task task)
        {
            if (task.IsAvailable()) task.State = new Checked();
        }

        public void Aprove(Task task) { }

        public override string ToString()
        {
            return "Здано на перевірку";
        }
    }
}
