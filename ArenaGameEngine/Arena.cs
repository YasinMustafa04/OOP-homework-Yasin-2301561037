using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Arena
    {
        public Hero HeroA { get; private set; }

        public Hero HeroB { get; private set; }

        public Hero HeroC { get; private set; }
        public Hero HeroD { get; private set; }

        public GameEventListener EventListener { get; set; }

        public Arena(Hero a, Hero b, Hero heroC, Hero heroD)
        {
            HeroA = a;
            HeroB = b;
            HeroC = heroC;
            HeroD = heroD;
        }

        public Hero Battle()
        {
            Hero attacker, defender;
            List<Hero> heroesForArena = new List<Hero> { HeroA, HeroB, HeroC, HeroD };
            while (true)
            {
                List<Hero> heroes = isHeroesDead(heroesForArena);
                List<Hero> chosenHeroes = chooseHero(heroes);
                attacker = chosenHeroes[0];
                defender = chosenHeroes[1];
                int damage = attacker.Attack();
                if (attacker.GetType().Name.Equals("Fireboy") && defender.GetType().Name.Equals("Harbour"))
                {
                    damage = 0;
                }
                defender.TakeDamage(damage);

                if (EventListener != null)
                {
                    EventListener.GameRound(attacker, defender, damage);
                }

                if (isHeroesDead(heroesForArena).Count == 1) return isHeroesDead(heroesForArena)[0];
            }
        }

        private List<Hero> chooseHero(List<Hero> heroes) {
            int choose = Random.Shared.Next(0, heroes.Count);
            Hero attacker = heroes[choose];
            heroes.Remove(attacker);
            int secondChoose = Random.Shared.Next(0, heroes.Count);
            Hero defender = heroes[secondChoose];
            return new List<Hero> { attacker, defender };
        }

        private List<Hero> isHeroesDead(List<Hero> heroes) 
        {
            return heroes.FindAll(hero => hero.IsAlive == true).ToList();  
        }
    }
}
