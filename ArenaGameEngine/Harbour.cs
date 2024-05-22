using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Harbour : Hero
    {
        public Harbour(string name): this(name, 100){}

        public Harbour(string name, int strength) : base(name,strength){}

        public override int Attack()
        {
            int chance = Random.Shared.Next(0, 100);
            if (chance > 30)
            {
                return base.Attack();
            }
            return 0;
        }

        public override void TakeDamage(int incomingDamage)
        {
            incomingDamage = incomingDamage / 2;
            if(Health < 50)
            {
                Health += 100;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
