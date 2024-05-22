namespace ArenaGameEngine
{
    public class Hero
    {
        public string Name { get; private set; }
        
        public int Health { get; set; }

        public int Strength { get; private set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            Strength = 80;
        }

        public Hero(string name, int strength)
        {
            Name = name;
            Health = 500;
            Strength = strength;
        }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public bool IsDead
        {
            get { return !IsAlive; }
        }

        public virtual int Attack()
        {
            int coef = Random.Shared.Next(80, 121);
            return (coef * Strength) / 100;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            Health = Health - incomingDamage;
        }

        public override string ToString()
        {
            return "Health:" + this.Health + ". Name:" + this.Name + ". Strenght:" + this.Strength;
        }
    }
}
