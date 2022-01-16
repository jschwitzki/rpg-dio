namespace rpg.src.Entities
{
    public class Wizard : Hero
        {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return $"{this.Name} atacou com a sua magia.";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva om bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}