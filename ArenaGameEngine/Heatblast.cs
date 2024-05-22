using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Heatblast : Hero
    {
        public Heatblast(string name) : this(name, 100){}

        public Heatblast(string name, int strength) : base(name, strength){}

        public override int Attack()
        {
            int chance = Random.Shared.Next(0, 100);
            if(chance % 2 == 0)
            {
                return base.Attack();
            }
            return 0;
        }

        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
            if (!IsAlive) {
                int chanceToReborn = Random.Shared.Next(0, 100);
                if(chanceToReborn < 30)
                {
                    Health = 250;
                }
            } 
        }
    }
}
