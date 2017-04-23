using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG_2._0
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool turne = true;
            Cris_Ey Cris_Ey = new Cris_Ey(70,80,20);
            Gesmand_shooter Gesmand_Shooter = new Gesmand_shooter(160,140,50);
            Shon Shon = new Shon(40,60,10);
            CAMBOPIG CAMBOPIG = new CAMBOPIG(300,100,10);
            Cris_Ey Cris_Ey_Sec = new Cris_Ey(80,70,30);
            Gesmand_shooter Gesmand_Shooter_Sec = new Gesmand_shooter(130,150,60);
            Shon Shon_Sec = new Shon(50,50,20);
            CAMBOPIG CAMBOPIG_Sec = new CAMBOPIG(200,290,20);
            //Cris_Ey.dmg = 80;
            //Cris_Ey.hp = 70;
            //Cris_Ey.armor = 20;
            //Gesmand_Shooter.dmg = 140;
            //Gesmand_Shooter.hp = 160;
            //Gesmand_Shooter.armor = 50;
            //Shon.armor = 10;
            //Shon.dmg = 60;
            //Shon.hp = 40;
            //CAMBOPIG.armor = 10;
            //CAMBOPIG.damage = 200;
            //CAMBOPIG.hp = 300;
            //Cris_Ey_Sec.hp = 70;
            //Cris_Ey_Sec.dmg = 80;
            //Cris_Ey_Sec.armor = 30;
            //Gesmand_Shooter_Sec.dmg = 130;
            //Gesmand_Shooter_Sec.hp = 150;
            //Gesmand_Shooter_Sec.armor = 60;
            //Shon_Sec.armor = 20;
            //Shon_Sec.dmg = 50;
            //Shon_Sec.hp = 50;
            //CAMBOPIG_Sec.armor = 20;
            //CAMBOPIG_Sec.damage = 200;
            //CAMBOPIG_Sec.hp = 290;         
            Console.WriteLine("Team 1                                                               Team 2");
            Console.WriteLine("Cris Ey " + Cris_Ey.dmg + " " + Cris_Ey.hp + " " + Cris_Ey.armor + "                  Cris_Ey_Sec " + Cris_Ey_Sec.dmg + " " + Cris_Ey_Sec.hp + " " + Cris_Ey_Sec.armor);
            Console.WriteLine("Gesmand Shooter " + Gesmand_Shooter.dmg + " " + Gesmand_Shooter.hp + " " + Gesmand_Shooter.armor + "                  Gesmand_Shooter_Sec " + Gesmand_Shooter_Sec.dmg + " " + Gesmand_Shooter_Sec.hp + " " + Gesmand_Shooter_Sec.armor);
            Console.WriteLine("Shon " + Shon.dmg + " " + Shon.hp + " " + Shon.armor + "                  Shon " + Shon_Sec.dmg + " " + Shon_Sec.hp + " " + Shon_Sec.armor);
            Console.WriteLine("CAMBOPIG " + CAMBOPIG.dmg + " " + CAMBOPIG.hp + " " + CAMBOPIG.armor + "                  CAMBOPIG_Sec " + CAMBOPIG_Sec.dmg + " " + CAMBOPIG_Sec.hp + " " + CAMBOPIG_Sec.armor);
            Console.ReadLine();
            if (turne == true)
            {
                Console.WriteLine(" Ход команды 1");
            }
            else
            {
                Console.WriteLine("Ход команды 2");
            }
          
        }
    }
}
