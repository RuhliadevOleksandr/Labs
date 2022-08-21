using System;

namespace State
{
    /// <summary>
    /// Клас розширюючих методів
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Повертає кількість днів до дедлайну
        /// </summary>
        /// <param name="task">Власне завдання</param>
        /// <returns>Кількість днів</returns>
        public static int GetLeftDays(this Task task)
        {
            if (task.StopTime != null)
            {
                return (task.Deadline - (DateTime)task.StopTime).Days;
            }
            else
            {
                return (task.Deadline - DateTime.Now).Days;
            }
        }

        /// <summary>
        /// Повертає максимальну оцінку відносно дедлайну
        /// </summary>
        /// <param name="task">Власне завдання</param>
        /// <returns>Оцінку</returns>
        public static decimal GetMaxMark(this Task task)
        {
            int leftDays = task.GetLeftDays();
            if (leftDays < 0)
            {
                decimal numberOfWeeks = Math.Ceiling(-leftDays / 7m);
                decimal coefficient = (task._maxMark / 20m);
                return task._maxMark - numberOfWeeks * coefficient;
            }
            else
            {
                return task._maxMark;
            }
        }

        /// <summary>
        /// Чи доступне завдання
        /// </summary>
        /// <param name="task">Власне завдання</param>
        /// <returns>Доступність</returns>
        public static bool IsAvailable(this Task task)
        {
            decimal mark = task.GetMaxMark();
            decimal minMark = task._maxMark * 3 / 5;
            if (mark < minMark)
            {
                task.State = new NotCompleted();
                return false;
            }
            return true;
        }
    }
}
