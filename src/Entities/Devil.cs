namespace RPG.src.Entities
{
    public class Devil : Monster
    {
        public Devil(string Name, int Level, string HeroType, int Life, int MagicPoint) : base(Name, Level, HeroType, Life, MagicPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Life = Life;
            this.MagicPoint = MagicPoint;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia de Fogo";
        }

        public string Attack(int Bonus)
        {
            if ( Bonus > 4)
            {
                return this.Name + " Lançou Magia de Fogo super efetiva com bonus de ataque de " + Bonus + " " + "+";
            }else
            {
                return this.Name + " Lançou Magia de Fogo com força fraca bonus de ataque de " + Bonus + " " + "+";
            }
        }
    }
}