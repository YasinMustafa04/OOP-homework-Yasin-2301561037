using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class GameEventListener
    {
        public virtual void GameRound(
            Hero attacker, Hero defender, int attack)
        {

        }
    }
}
