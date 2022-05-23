using System;
namespace abs_RPG.src.entities

{
    public class Mage : Hero
    {
        public Mage(string name, int level, string heroType) : base(name, level, heroType)
        {

        }

        public override string Attack()
        {
            Random rd = new Random();
            int bonus = rd.Next(0,100);
            if(bonus<60 && bonus>30){
            return (this.name + " Atacou com a magia com bonus de "+bonus);

            }else if(bonus>=60)
                        return (this.name + " Atacou com a magia com incrivel bonus de "+bonus);
                        return (this.name + " Atacou com magia");

        }
         public override string Attack(int bonus)
        {
           if(bonus<60 && bonus>30){
            return (this.name + " Atacou com a magia com bonus de "+bonus);

            }else if(bonus>=60)
                        return (this.name + " Atacou com a magia com incrivel bonus de "+bonus);
                        return (this.name + " Atacou com magia");

        }
    }
}