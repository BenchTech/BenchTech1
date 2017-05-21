using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG_2._0
{
   public class Cahrecter
    {
        private int dmg;
        private int hp;
        private int armor;

        public int Dmg
        {
            get
            {
                return dmg;
            }

            set
            {
                dmg = value;
            }
        }

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public int Armor
        {
            get
            {
                return armor;
            }

            set
            {
                armor = value;
            }
        }

        public void Attack(Cahrecter c)
        {
            int d;
            if(Armor<Dmg)
            {
                d = Dmg - Armor;
            }
            else
            {
                d = 0;
            }
            c.Hp -= d;
        }
        //public void Attack(CAMBOPIG c)
        //{
        //    c.hp -= this.dmg;
        //}
        //public void Attack(Gesmand_shooter g)
        //{
        //    g.hp -= this.dmg;
        //}
        //public void Attack(Cris_Ey y)
        //{
        //    y.hp -= this.dmg;
        //}

    }
}
