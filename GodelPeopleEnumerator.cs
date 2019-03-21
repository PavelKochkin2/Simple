using System;
using System.Collections;

namespace Singleton
{
    class GodelPeopleEnumerator : IEnumerator 
    {
        private readonly string[] _names;

        private int _position = -1;

        public GodelPeopleEnumerator(string[] names)
        {
            this._names = names;
        }

        public bool MoveNext()
        {
            if (_position == -1 || _position < _names.Length - 1)
            {
                _position++;
                return true;
            }

            return false;
        }

        public void Reset() => _position = 1;


        public object Current
        {
            get
            {
                if (_position == -1 || _position > _names.Length)
                {
                    throw new ArgumentException();
                }

                return _names[_position];
            }
        }
    }
}