using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG_2._0
{
    class Cris_Ey
    {
        public Cris_Ey(int hp, int dmg, int armor)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.armor = armor;
        }
        public int hp;
        public int dmg;
        public int armor;
        public void Attack(Shon s)
        {
            s.hp -= this.dmg;
        }
        public void Attack(CAMBOPIG c)
        {
            c.hp -= this.dmg;
        }
        public void Attack(Gesmand_shooter g)
        {
            g.hp -= this.dmg;
        }
        public void Attack(Cris_Ey y)
        {
            y.hp -= this.dmg;
        }

        }
    }
    
    

