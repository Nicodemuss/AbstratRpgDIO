namespace abs_RPG.src.entities
{
    public abstract class Hero
    {
        protected string name;
        protected int level;
        protected string heroType;


        public Hero()
        {
        }

        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

       

        public override string ToString()
        {
            return ($"Nome = {name} \n Level = {level} \n Class = {heroType}");
        }
        public virtual string Attack(){
            return(this.name + " Atacou com a espada");
        }
        public virtual string Attack(int bonus){
            return(this.name + " Atacou com a espada com bonus de "+ bonus);
        }


    }
}