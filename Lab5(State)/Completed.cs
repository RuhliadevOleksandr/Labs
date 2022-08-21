namespace State
{
    /// <summary>
    /// Клас стану завдання "Виконано"
    /// </summary>
    public class Completed : ITaskState
    {
        public void CompleteTask(Task task) { }

        public void FoundMistakes(Task task) { }

        public void CorrectMistakes(Task task) { }

        public void Corrected(Task task) { }

        public void Aprove(Task task) { }

        public override string ToString()
        {
            return "Виконано";
        }
    }
}
