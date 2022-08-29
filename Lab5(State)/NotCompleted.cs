using System;

namespace State
{
    /// <summary>
    /// Клас стану завдання "Не виконано"
    /// </summary>
    public class NotCompleted : ITaskState
    {
        public void CompleteTask(Task task)
        {
            throw new NotSupportedException("Завдання вже недоступне!");
        }

        public void FoundMistakes(Task task)
        {
            throw new NotSupportedException("Завдання вже недоступне!");
        }

        public void CorrectMistakes(Task task)
        {
            throw new NotSupportedException("Завдання вже недоступне!");
        }

        public void Corrected(Task task)
        {
            throw new NotSupportedException("Завдання вже недоступне!");
        }

        public void Aprove(Task task)
        {
            throw new NotSupportedException("Завдання вже недоступне!");
        }

        public override string ToString()
        {
            return "Не виконано";
        }
    }
}
