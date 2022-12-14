using System;

namespace Wxl.Helpers.DateTimeHelpers
{
    public static partial class DateHelpers
    {
        /// <summary>
        /// Determine if two intervals intersectm inclusive
        /// </summary>
        /// <param name="intervalStartA">Start of interval a</param>
        /// <param name="intervalEndA">End of interval a</param>
        /// <param name="intervalStartB">Start of interval b</param>
        /// <param name="intervalEndB">End of interval b</param>
        /// <returns>Whether the intervals intersect</returns>
        public static bool IntervalsIntersect(
            DateTime intervalStartA,
            DateTime intervalEndA,
            DateTime intervalStartB,
            DateTime intervalEndB)
        {
            return intervalStartA <= intervalEndB && intervalEndA >= intervalStartB;
        }

        /// <summary>
        /// Determine if two intervals intersect, inclusive
        /// </summary>
        /// <param name="a">Interval a</param>
        /// <param name="b">Interval b</param>
        /// <returns>Whether the intervals intersect</returns>
        public static bool IntervalsIntersect(DateInterval a, DateInterval b)
        {
            return a.Start <= b.End && a.End >= b.Start;
        }
    }

    public struct DateInterval
    {
        public DateTime Start { get; }
        public DateTime End { get; }

        public DateInterval(DateTime start, DateTime end)
        {
            if (start > end)
            {
                throw new ArgumentException($"Argument {nameof(start)} must be later or equal to {nameof(end)}");
            }

            Start = start;
            End = end;
        }
    }
}
