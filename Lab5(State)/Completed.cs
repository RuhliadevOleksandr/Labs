using System;

namespace State
{
    /// <summary>
    /// Клас стану завдання "Виконано"
    /// </summary>
    public class Completed : ITaskState
    {
        public void CompleteTask(Task task)
        {
            throw new NotSupportedException("Завдання вже виконано!");
        }

        public void FoundMistakes(Task task)
        {
            throw new NotSupportedException("У завданні немає помилок!");
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
            throw new NotSupportedException("Завдання вже затверджено!");
        }

        public override string ToString()
        {
            return "Виконано";
        }
    }
}
