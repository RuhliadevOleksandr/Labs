using System;

namespace State
{
    /// <summary>
    /// Клас завдання
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Максимальна оцінка за завдання
        /// </summary>
        public readonly uint _maxMark;

        /// <summary>
        /// Стан завдання
        /// </summary>
        public ITaskState State { get; set; }

        /// <summary>
        /// Дедлайн
        /// </summary>
        public DateTime Deadline { get; private set; }

        /// <summary>
        /// Час закінчення виконання завдання
        /// </summary>
        public DateTime? StopTime { get; private set; }

        /// <summary>
        /// Поточна оцінка за завдання
        /// </summary>
        public decimal CurrentMark { get; private set; }

        /// <summary>
        /// Конструктор з параметрами
        /// </summary>
        /// <param name="state">Стан завдання</param>
        /// <param name="maxMark">Максимальна оцінка за завдання</param>
        /// <param name="deadline">Дедлайн</param>
        public Task(ITaskState state, uint maxMark, DateTime deadline)
        {
            State = state;
            _maxMark = maxMark;
            Deadline = deadline;
            CurrentMark = 0;
        }

        /// <summary>
        /// Оцінити завдання
        /// </summary>
        /// <param name="mark">Оцінка за завдання</param>
        public void Evaluate(decimal mark)
        {
            CurrentMark = mark;
        }

        /// <summary>
        /// Завершити завдання
        /// </summary>
        public void FinishTask()
        {
            StopTime = DateTime.Now;
        }

        /// <summary>
        /// Виконати завдання
        /// </summary>
        public void CompleteTask()
        {
            State.CompleteTask(this);
        }

        /// <summary>
        /// Знайдено помилки в завданні
        /// </summary>
        public void FoundMistakes()
        {
            State.FoundMistakes(this);
        }

        /// <summary>
        /// Виправити помилки в завданні
        /// </summary>
        public void CorrectMistakes()
        {
            State.CorrectMistakes(this);
        }

        /// <summary>
        /// Завдання виконано правильно
        /// </summary>
        public void Corrected()
        {
            State.Corrected(this);
        }

        /// <summary>
        /// Затвердити завдання
        /// </summary>
        public void Aprove()
        {
            State.Aprove(this);
        }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        /// <returns>Рядок з описом завдання</returns>
        public override string ToString()
        {
            if(StopTime == null)
            {
                return string.Format(
                                 $"Стан: {State}" +
                                 $"\nДата виконання: _/_/_ _:_:_" +
                                 $"\nДедлайн: {Deadline}" +
                                 $"\nОцінка: {CurrentMark}/{_maxMark}"
                                );
            }
            else
            {
                return string.Format(
                                 $"Стан: {State}" +
                                 $"\nДата виконання: {StopTime}" +
                                 $"\nДедлайн: {Deadline}" +
                                 $"\nОцінка: {CurrentMark}/{_maxMark}"
                                );
            }
        }
    }
}
