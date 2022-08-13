using CircleGame.Business.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace CircleGame.Business.Concrete
{
    public class GameManager : IGameManager
    {
        private List<int> _listOfPlayers;
        public int LastPlayerNumber(int count)
        {
            _listOfPlayers = Enumerable.Range(1, count).ToList();
            int index = 0;

            while (_listOfPlayers.Count > 1)
            {

                index++;
                index %= _listOfPlayers.Count;
                _listOfPlayers.RemoveAt(index);
            }

            return _listOfPlayers.First();
        }

    }
}
