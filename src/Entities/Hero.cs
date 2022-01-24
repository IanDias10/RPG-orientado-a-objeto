namespace RPG.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Life, int MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;


        }

        public string Name;
        public int Level;
        public string HeroType;
        public int Life;
        public int MagicPoint;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " + this.Life + " " + this.MagicPoint;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada enorme";
        }
    }   
}