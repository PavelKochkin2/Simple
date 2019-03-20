using System.Collections;

namespace Singleton
{
    class Week : IEnumerable
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
}