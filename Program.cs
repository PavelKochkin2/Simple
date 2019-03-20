using System;
using System.Collections;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var GamesOfYear = new GamesOfYear();
            foreach (var game in GamesOfYear)
            {
                Console.WriteLine(game);
            }


            Console.Read();
        }
    }

    class GamesOfYear : IEnumerable
    {
        private string[] games =
        {
            "God Of War",
            "The Legend of Zelda: Breath of the Wild",
            "Overwatch",
            "The Witcher 3: Wild Hunt",
            "Dragon Age: Inquisition"
        };


        public IEnumerator GetEnumerator()
        {
            return new GamesOfYearEnumerator(games);
        }
    }

    class GamesOfYearEnumerator : IEnumerator
    {
        private int position = -1;

        public string[] games;

        public GamesOfYearEnumerator(string[] games)
        {
            this.games = games;
        }

        public bool MoveNext()
        {
            if (position < games.Length -1)
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

        public object Current
        {
            get
            {
                if (position == -1 || position >= games.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return games[position];
            }
        }
    }
}