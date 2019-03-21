using System.Collections;

namespace Singleton
{
    class GodelPeople : IEnumerable
    {
        private string[] names = {"Pavel1", "Pavel2", "Maxim", "Vova", "Anton", "Tanya"};
        public IEnumerator GetEnumerator()
        {
            return new GodelPeopleEnumerator(names);
        }
    }
}