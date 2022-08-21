namespace State
{
    /// <summary>
    /// Інтерфейс стан завдання
    /// </summary>
    public interface ITaskState
    {
        /// <summary>
        /// Завершити завдання
        /// </summary>
        /// <param name="task">Власне завдання</param>
        void CompleteTask(Task task);

        /// <summary>
        /// Знайдено помилки
        /// </summary>
        /// <param name="task">Власне завдання</param>
        void FoundMistakes(Task task);

        /// <summary>
        /// Виправити помилки
        /// </summary>
        /// <param name="task">Власне завдання</param>
        void CorrectMistakes(Task task);

        /// <summary>
        /// Виконано правильно
        /// </summary>
        /// <param name="task">Власне завдання</param>
        void Corrected(Task task);

        /// <summary>
        /// Затвердити завдання
        /// </summary>
        /// <param name="task">Власне завдання</param>
        void Aprove(Task task);
    }
}
