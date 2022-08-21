namespace State
{
    /// <summary>
    /// Клас стану завдання "Перевірено"
    /// </summary>
    public class Checked : ITaskState
    {
        public void CompleteTask(Task task) { }

        public void FoundMistakes(Task task) { }

        public void CorrectMistakes(Task task) { }

        public void Corrected(Task task) { }

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
