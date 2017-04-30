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
            string attacke;
            string target;
            //int nomer = int.Parse(Console.ReadLine());
            bool turne = true;
            Cris_Ey Cris_Ey = new Cris_Ey(70, 80, 20);
            Gesmand_shooter Gesmand_Shooter = new Gesmand_shooter(160, 140, 50);
            Shon Shon = new Shon(40, 60, 10);
            CAMBOPIG CAMBOPIG = new CAMBOPIG(300, 100, 10);
            Cris_Ey Cris_Ey_Sec = new Cris_Ey(80, 70, 30);
            Gesmand_shooter Gesmand_Shooter_Sec = new Gesmand_shooter(130, 150, 60);
            Shon Shon_Sec = new Shon(50, 50, 20);
            CAMBOPIG CAMBOPIG_Sec = new CAMBOPIG(200, 290, 20);
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

            while (0 == 0)
            {
                Console.WriteLine("Team 1 ");
                Console.WriteLine("Cris Ey " + "Урон" + Cris_Ey.dmg + " " + " Жизни"+ Cris_Ey.hp + " " + "Броня" + Cris_Ey.armor );
                Console.WriteLine("Gesmand Shooter " + "Урон" + Gesmand_Shooter.dmg + " " + " Жизни" + Gesmand_Shooter.hp + " " +"Броня" + Gesmand_Shooter.armor);
                Console.WriteLine("Shon " + "Урон" + Shon.dmg + " " +" Жизни" + + Shon.hp + " " + "Броня" + Shon.armor );
                Console.WriteLine("CAMBOPIG " + "Урон" + CAMBOPIG.dmg + " " + " Жизни" + CAMBOPIG.hp + " " + "Броня" + CAMBOPIG.armor );
                Console.WriteLine("Team 2");

               Console.WriteLine("Cris_Ey_Sec " + "Урон" + Cris_Ey_Sec.dmg + " " + " Жизни" + Cris_Ey_Sec.hp + " " + "Броня" + Cris_Ey_Sec.armor);
                Console.WriteLine("Gesmand_Shooter_Sec " + "Урон" + Gesmand_Shooter_Sec.dmg + " " + " Жизни" + Gesmand_Shooter_Sec.hp + " " + "Броня" + Gesmand_Shooter_Sec.armor);
                Console.WriteLine("Shon " + "Урон" + Shon_Sec.dmg + " " + " Жизни" + Shon_Sec.hp + " " + "Броня" + Shon_Sec.armor);
                Console.WriteLine("CAMBOPIG_Sec " + "Урон" + CAMBOPIG_Sec.dmg + " " + " Жизни" + CAMBOPIG_Sec.hp + " " + "Броня" +  CAMBOPIG_Sec.armor);
                if (turne == true)
                {
                    Console.WriteLine("Ход команды 1");


                    Console.WriteLine("Каким персонажем вы хотите атаковать? ");
                    attacke = Console.ReadLine();
                    Console.WriteLine("Кого вы хотите атаковать? ");
                    Console.WriteLine("Чтобы атаковать персонажа 1 введите 1, для 2 введите 2, для 3 введите 3, для 4 введите 4");
                    target = Console.ReadLine();
                    if (attacke == "1" && target == "1")
                    {
                        Cris_Ey.Attack(Cris_Ey_Sec);
                    }
                    if (attacke == "1" && target == "2")
                    {
                        Cris_Ey.Attack(Gesmand_Shooter_Sec);
                    }
                    if (attacke == "1" && target == "3")
                    {
                        Cris_Ey.Attack(Shon_Sec);
                    }
                    if (attacke == "1" && target == "4")
                    {
                        Cris_Ey.Attack(CAMBOPIG_Sec);
                    }
                    if (attacke == "2" && target == "1")
                    {
                        Gesmand_Shooter.Attack(Cris_Ey_Sec);
                    }
                    if (attacke == "2" && target == "2")
                    {
                        Gesmand_Shooter.Attack(Gesmand_Shooter_Sec);
                    }
                    if (attacke == "2" && target == "3")
                    {
                        Gesmand_Shooter.Attack(Shon_Sec);
                    }
                    if (attacke == "2" && target == "4")
                    {
                        Gesmand_Shooter.Attack(CAMBOPIG_Sec);
                    }
                    if (attacke == "3" && target == "1")
                    {
                        Shon.Attack(Cris_Ey_Sec);
                    }
                    if (attacke == "3" && target == "2")
                    {
                        Shon.Attack(Gesmand_Shooter_Sec);
                    }
                    if (attacke == "3" && target == "3")
                    {
                        Shon.Attack(Shon_Sec);
                    }
                    if (attacke == "3" && target == "4")
                    {
                        Shon.Attack(CAMBOPIG_Sec);
                    }
                    if (attacke == "4" && target == "1")
                    {
                        CAMBOPIG.Attack(Cris_Ey_Sec);
                    }
                    if (attacke == "4" && target == "2")
                    {
                        CAMBOPIG.Attack(Gesmand_Shooter_Sec);
                    }
                    if (attacke == "4" && target == "3")
                    {
                        CAMBOPIG.Attack(Shon_Sec);
                    }
                    if (attacke == "4" && target == "4")
                    {
                        CAMBOPIG.Attack(CAMBOPIG_Sec);
                    }
                    turne = false;
                }
                
                else
                {
                   
                    Console.WriteLine("Ход команды 2");
                    Console.WriteLine("Каким персонажем вы хотите атаковать?");
                    attacke = Console.ReadLine();
                    Console.WriteLine("Кого вы хотите атаковать? ");
                    Console.WriteLine("Чтобы атаковать персонажа 1 введите 1, для 2 введите 2, для 3 введите 3, для 4 введите 4");
                    target = Console.ReadLine();
                    if (attacke == "1" && target == "1")
                    {
                        Cris_Ey_Sec.Attack(Cris_Ey);
                    }
                    if (attacke == "1" && target == "2")
                    {
                        Cris_Ey_Sec.Attack(Gesmand_Shooter);
                    }
                    if (attacke == "1" && target == "3")
                    {
                        Cris_Ey_Sec.Attack(Shon);
                    }
                    if (attacke == "1" && target == "4")
                    {
                        Cris_Ey_Sec.Attack(CAMBOPIG);
                    }
                    if (attacke == "2" && target == "1")
                    {
                        Gesmand_Shooter_Sec.Attack(Cris_Ey);
                    }
                    if (attacke == "2" && target == "2")
                    {
                        Gesmand_Shooter_Sec.Attack(Gesmand_Shooter);
                    }
                    if (attacke == "2" && target == "3")
                    {
                        Gesmand_Shooter_Sec.Attack(Shon);
                    }
                    if (attacke == "2" && target == "4")
                    {
                        Gesmand_Shooter_Sec.Attack(CAMBOPIG);
                    }
                    if (attacke == "3" && target == "1")
                    {
                        Shon_Sec.Attack(Cris_Ey);
                    }
                    if (attacke == "3" && target == "2")
                    {
                        Shon_Sec.Attack(Gesmand_Shooter);
                    }
                    if (attacke == "3" && target == "3")
                    {
                        Shon_Sec.Attack(Shon);
                    }
                    if (attacke == "3" && target == "4")
                    {
                        Shon_Sec.Attack(CAMBOPIG);
                    }
                    if (attacke == "4" && target == "1")
                    {
                        CAMBOPIG_Sec.Attack(Cris_Ey);
                    }
                    if (attacke == "4" && target == "2")
                    {
                        CAMBOPIG_Sec.Attack(Gesmand_Shooter);
                    }
                    if (attacke == "4" && target == "3")
                    {
                        CAMBOPIG_Sec.Attack(Shon);
                    }
                    if (attacke == "4" && target == "4")
                    {
                        CAMBOPIG_Sec.Attack(CAMBOPIG);
                    }
                    turne = true;
                }
                Console.Clear();

            }

          
        }
    }
}
