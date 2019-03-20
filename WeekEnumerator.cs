using System;
using System.Collections;

namespace Singleton
{
    class WeekEnumerator : IEnumerator
    {
        string[] days;
        public String Jopa { get; set; }
        int position = -1;
        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();
                return days[position];
            }
        }

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }

            return false;

        }

        public void Reset()
        {
            position = -1;
        }
    }
}