using BlackJack.GameElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.Actions
{
    interface IGameActions
    {
        void Hit(KeyValuePair<List<Card>, int> keyValuePair);
        void Split(List<Card> listCard);
        void Hold();
    }
}
