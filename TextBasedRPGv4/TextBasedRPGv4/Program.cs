using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGv4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Player Eric = new Player();
            Enemy Singularity = new Enemy();

            //Ints:
            int next = 0;
            int Arraycount = 0;
            int Attack_Type = 0;
            int Has_Key = 0;
            int Has_Sword = 0;
            int Hammer_Time = 0;

            //Strings:
            string Menu_Option;
            string[] Inventory = new string[20];
            string Input;
            string Enemy_Name;



            //Main Menu Screen/Prologue:-------------------------------------------------------------------------------------
            do
            {
                Console.Clear();
                Console.WriteLine("||||||||||||||Welcome To Ominous Rise : The Dark Begginnings||||||||||||||||||||");
                Console.WriteLine("Please Select An Option:");
                Console.WriteLine("1: Start Game");
                Console.WriteLine("2: Credits");
                Console.WriteLine("3: Exit");
                Menu_Option = Console.ReadLine().ToUpper();
                if (Menu_Option == "1")
                {
                    next = 1;
                }
                else { }
                if (Menu_Option == "2")
                {
                    Console.WriteLine("Eric Luong with the help of Kwame Bryan. ");
                    Console.WriteLine("< Back");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "BACK")
                    { next = 0; }
                    if (Input != "BACK")
                    { next = 0; }
                }
                if (Menu_Option == "3")
                {
                    next = 10;
                }
            } while (next == 0);


            do
            {
                Console.Clear();
                Console.WriteLine("You are the personification of Darkness, Living for the sole purpose of consuming 'light'. You feel as if you are guided by a mysterious force that aids your hunger. You find yourself on a rainy night at a gated home sensing the presence of 'light'. Your blood rushes as you stare at the home.");
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("'Look' around, to see if there is anything that might help you .");
                Console.WriteLine("'Door' to force your way in.");
                Console.WriteLine("'Mailbox' may contain something useful.");
                Console.WriteLine("'Menu' to check your inventory or health.");
                Input = Console.ReadLine().ToUpper();
                if (Input == "LOOK")
                {
                    if (Has_Key == 0)
                    {
                        do
                        {
                            Console.WriteLine("You dont notice anything special... ");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            { next = 1; }
                            if (Input != "BACK")
                            { next = 0; }
                        } while (next == 0);
                    }
                    if (Has_Key == 1)
                    {
                        do
                        {
                            Console.WriteLine("You notice something, you swear wasn't there before. A hammer. You pick it up, and put it in you inventory");
                            Console.WriteLine("+5 Score");
                            Inventory[0] = "Hammer";
                            Console.WriteLine("< Back");
                            Hammer_Time = 1;
                            Eric.Score += 5;
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            { next = 1; }
                            if (Input != "BACK")
                            { next = 0; }
                        } while (next == 0);
                    }
                }
                if (Input == "DOOR")
                {
                    if (Inventory[0] == null)
                    {
                        do
                        {
                            Console.WriteLine("The door wont give in, but gives you a wierd feeling upon touch");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            { next = 1; }
                            if (Input != "BACK")
                            { next = 0; }
                        } while (next == 0);
                    }
                    if (Inventory[0] != null && Hammer_Time == 1)
                        {
                            do
                            {
                                Console.WriteLine("You need the key...");
                                Console.WriteLine("< Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "BACK")
                                { next = 1; }
                                if (Input != "BACK")
                                { next = 0; }
                            } while (next == 0);
                        }
                    
                    if (Inventory[1] != null)
                    {
                        do
                        {
                            Console.WriteLine("The Key maybe the way into the home...");
                            Console.WriteLine("'Try'?");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            { next = 1; }
                            if (Input != "BACK")
                            { next = 0; }
                            if (Input == "TRY")
                            {
                                do
                                {
                                    Console.WriteLine("You feel something surrond you as you insert the key. It works.");
                                    Console.WriteLine("+10 Score");
                                    Console.WriteLine("< Continue");
                                    Input = Console.ReadLine().ToUpper();
                                    Eric.Score += 10;
                                    if (Input == "CONTINUE")
                                    { next = 3; }
                                    if (Input != "CONTINUE")
                                    { next = 0; }
                                } while (next == 0);
                            }
                        } while (next == 0);
                    }
                }
                if (Input == "MAILBOX")
                {
                    do
                    {
                        Console.WriteLine("There might be something inside...");
                        Console.WriteLine("'Open'?");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        { next = 1; }
                        if (Input != "BACK")
                        { next = 0; }
                        if (Input == "OPEN" && Inventory[0] == null)
                        {
                            do
                            {
                                Console.WriteLine("the Mailbox is shut tight and closed...");
                                Console.WriteLine("< Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "BACK")
                                { next = 1; }

                                if (Input != "BACK")
                                { next = 0; }
                            } while (next == 0);
                            Has_Key = 1;
                        }
                        if (Input == "OPEN" && Inventory[0] != null)
                        {
                            do
                            {
                                Console.WriteLine("You use the Hammer to force open the Mailbox and find the key....As you hold the key you feel invigorating...");
                                Console.WriteLine("< Back");
                                Hammer_Time = 0;
                                Inventory[1] = "Key";
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "BACK")
                                { next = 1; }
                                if (Input != "BACK")
                                { next = 0; }
                            } while (next == 0);
                        }
                    } while (next == 0);
                }
                if (Input == "MENU")
                {
                    next = 0;
                    Console.WriteLine("'Inventory', to see your Inventory content");
                    Console.WriteLine("'Status', to see HP and Score");
                    Console.WriteLine("< Back");
                    Input = Console.ReadLine().ToUpper();
                    {
                        if (Input == "STATUS")
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Your Health is at {0} and your Score is at {1}", Eric.HP, Eric.Score);
                                Console.WriteLine("< Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "BACK")
                                {
                                    next = 1;
                                }
                                if (Input != "BACK")
                                {
                                    next = 0;
                                }

                            } while (next == 0);
                        if (Input == "INVENTORY")

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Your Inventory:");
                                Console.WriteLine("Nothing");
                                Console.WriteLine("< Back");
                                Input = Console.ReadLine().ToUpper();
                                if (Input == "BACK")
                                {
                                    next = 1;
                                }
                                if (Input != "BACK")
                                {
                                    next = 0;
                                }
                            } while (next == 0);
                    }
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your thrist for light persists...");
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            {
                                next = 1;
                            }
                            if (Input != "BACK")
                            {
                                next = 0;
                            }
                        } while (next == 0);
                    }
                    if (Input == "INVENTORY" || Input == "INV")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your Inventory Contains:");
                            for (Arraycount = 0; Arraycount < 20; Arraycount++)
                            {
                                int inventory_possition = Arraycount + 1;
                                Console.SetCursorPosition(0, inventory_possition);
                                Console.WriteLine("{0}", Inventory[Arraycount]);
                            }
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            {
                                next = 1;
                            }
                            if (Input != "BACK")
                            {
                                next = 0;
                            }
                        } while (next == 0);

                    }
                    if (Input == "STATUS" || Input == "STAT")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your Health is at {0} and your Score is at {1}", Eric.HP, Eric.Score);
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            {
                                next = 1;
                            }
                            if (Input != "BACK")
                            {
                                next = 0;
                            }
                        } while (next == 0);
                    }
                    if (Input == "BACK")
                    {
                        next = 2;
                    }
                    else
                    { }
                }
            } while (next != 3);
            //Part 2 -----------------------------------------------------------------------------------------------------------------------------------------------
            do
            {
                Console.Clear();
                Console.WriteLine("You enter the home and feel the lights presence. Upstairs you hear shrieks of anger, the room apears to have just changed right before your eyes. A stair case just appeared out of nowhere.");
                Console.WriteLine("////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("Go up the 'Stairs'?");
                Console.WriteLine("'Look' around?");
                Console.WriteLine("'Menu' to check your inventory or health");
                Input = Console.ReadLine().ToUpper();
                if (Input == "MENU")
                {

                    Console.WriteLine("'Inventory, to see your Inventory");
                    Console.WriteLine("'Status, to see HP and Score");
                    Console.WriteLine("< Back");
                    Input = Console.ReadLine().ToUpper();

                    if (Input == "INVENTORY" || Input == "INV")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Inventory");
                            for (Arraycount = 0; Arraycount < 20; Arraycount++)
                            {
                                int inventory_possition = Arraycount + 1;
                                Console.SetCursorPosition(0, inventory_possition);
                                Console.WriteLine("{0}", Inventory[Arraycount]);
                            }
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            {
                                next = 1;
                            }
                            if (Input != "BACK")
                            {
                                next = 0;
                            }
                        } while (next == 0);

                    }
                    if (Input == "STATUS" || Input == "STAT")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your Health is at {0} and your Score is at {1}", Eric.HP, Eric.Score);
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            {
                                next = 1;
                            }
                            if (Input != "BACK")
                            {
                                next = 0;
                            }
                        } while (next == 0);
                    }
                }
                if (Input == "STAIRS" || Input == "LOOK")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("ENTITIES OF LIGHT APPEAR");
                        Console.WriteLine("PREPARE FOR BATTLE");
                        Console.WriteLine("!!!!");
                        Console.WriteLine("< Battle");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BATTLE")
                        {
                            next = 3;
                        }
                        if (Input != "BATTLE")
                        {
                            next = 0;
                        }
                    } while (next == 0);
                }
            } while (next != 3);


            //Enemy---------------------------------------------------------------------------------------------------------------------------------------------
            Enemy_Name = "Singularity";

            //Combat System:if you press enter before entering a number game stops.. No Fix --------------------------------------------------------------------------------------------------------------------------------------------------
            do
            {
                next = 0;
                Console.Clear();
                Console.WriteLine("Your Health is at {0} Points,", Eric.HP);
                Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name, Singularity.Enemy_HP);
                Console.WriteLine("Enter the number for the type of attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Attack_Type = Convert.ToInt32(Console.ReadLine());
                if (Attack_Type == 1)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Eric.Light_Attack);
                    Console.WriteLine("{0}", Random_Damage_Roll);

                    { }
                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Singularity.Enemy_HP = Singularity.Enemy_HP - Random_Damage_Roll;
                }
                if (Attack_Type == 2)
                {
                    Random Damage_Roll = new Random();
                    int Random_Damage_Roll = Damage_Roll.Next(0, Eric.Heavy_attack);
                    Console.WriteLine("{0}", Random_Damage_Roll);
                    { }

                    Console.WriteLine("You did {0} Damage to the {1}", Random_Damage_Roll, Enemy_Name);
                    Singularity.Enemy_HP = Singularity.Enemy_HP - Random_Damage_Roll;
                }
                else { }
                if (Singularity.Enemy_HP > 0)
                {
                    Random Enemy_Damage_Roll = new Random();
                    int Random_Enemy_Damage_Roll = Enemy_Damage_Roll.Next(0, Singularity.Enemy_MaxDmg);
                    Console.WriteLine("The {0} attacks back and dealt {1} Points of Damage", Enemy_Name, Random_Enemy_Damage_Roll);
                    Eric.HP = Eric.HP - Random_Enemy_Damage_Roll;
                    Console.ReadLine();
                }
                else { }
            } while (Eric.HP > 0 && Singularity.Enemy_HP > 0);
            Console.Clear();
            if (Singularity.Enemy_HP < 0)
            {
                Singularity.Enemy_HP = 0;
            }
            if (Eric.HP < 0)
            {
                Eric.HP = 0;
            }
            Console.WriteLine("Your Health is at {0} Points", Eric.HP);
            Console.WriteLine("The {0}s Health is at {1} Points", Enemy_Name, Singularity.Enemy_HP);
            Console.WriteLine("Enter The Type of Attack:");
            Console.WriteLine("1. One Handed Attack");
            Console.WriteLine("2. Two Handed Attack");
            if (Singularity.Enemy_HP > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle.");
                Console.ReadLine();
            }
            if (Eric.HP > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You won the battle.");
                Eric.Score += 5;
                Console.ReadLine();
            }

            //Menu Writeout ------------------------------------------------------------------------------------------------------------
            do
            {
                next = 0;
                Console.Clear();
                Console.WriteLine("You finish off the Starlight and comsume its Energy... You feel overwhelmed with content.");
                Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("'Continue' through home");
                Console.WriteLine("'Menu' to check Inventory OR Status ");
                Console.WriteLine("'Exit' to quit the menu");
                Eric.HP += 10;
                Input = Console.ReadLine().ToUpper();
                if (Input == "MENU")
                {
                    next = 0;
                    Console.WriteLine("'Inventory' to see your Inventory");
                    Console.WriteLine("'Status' to see HP and Score");
                    Console.WriteLine("< Back");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "INVENTORY" || Input == "INV")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your Inventory Contains:");
                            for (Arraycount = 0; Arraycount < 20; Arraycount++)
                            {
                                int inventory_possition = Arraycount + 1;
                                Console.SetCursorPosition(0, inventory_possition);
                                Console.WriteLine("{0}", Inventory[Arraycount]);
                            }
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            { next = 2; }
                            if (Input != "BACK")
                            { next = 0; }
                        } while (next == 0);

                    }
                    if (Input == "STATUS" || Input == "STAT")
                    {
                        next = 0;
                        Console.Clear();
                        Console.WriteLine("Your Health is at {0} and your Score is at {1}", Eric.HP, Eric.Score);
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        {
                            next = 2;
                        }
                        if (Input != "BACK")
                        {
                            next = 0;
                        }

                    } while (next == 0) ;
                }

                if (Input == "CONTINUE")
                {
                    next = 1;
                }
            } while (next != 1);

            //Part 3 -------------------------------------------------------------------------------------------------------------------------------------
            do
            {
                Console.Clear();
                Console.WriteLine("As You Continue Through The Home You Come Across A Distinct Door. You Are Confronted With the options.");
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine("'Look' to Look For More StarLight .");
                Console.WriteLine("'Door' to Investigate The Door.");
                Console.WriteLine("'Find' to Look For Items. ");
                Console.WriteLine("'Menu' to check your inventory or health.");
                Input = Console.ReadLine().ToUpper();
                if (Input == "LOOK")
                {
                    do
                    {
                        Console.WriteLine("You Dont notice any Starlight but you feel the energy of another....");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        { next = 1; }
                        if (Input != "BACK")
                        { next = 0; }
                    } while (next == 0);
                }

                if (Input == "DOOR" && Inventory[2] == null)
                {
                    do
                    {
                        Console.WriteLine("The Door Is Wonderfully Carved With a Depiction of a Supreme Being.....");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        { next = 1; }
                        if (Input != "BACK")
                        { next = 0; }
                    } while (next == 0);
                }

                    if (Input == "DOOR" && Inventory[2] != null )
                    {
                        do
                        {
                            Console.WriteLine("With the Sinister Blade you destroy the godly wall to reveal a behemoth Starlight. It screeches in anger as it flashes towards you.");
                            Console.WriteLine("< Continue");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "Continue")
                            { next = 5; }
                            if (Input != "Continue")
                            { next = 5; }
                        } while (next == 0);
                    }
                
                if (Input == "FIND")
                {
                    do
                    {
                        Console.WriteLine("You Wander Into A Illuminated Hall, Hearing Sounds of Hymms ");
                        Console.WriteLine("Suddenly a Dark Lightning Strikes The Floor Revealing a Fuming Blade.");
                        Console.WriteLine("'Take'?");
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        { next = 1; }
                        if (Input != "BACK")
                        { next = 0; }
                    
                        if (Input == "TAKE")
                        {
                            Console.Clear();
                            Console.WriteLine("You Take the blade. It is heavy and sinister.");
                            Console.WriteLine("< Back");
                            Has_Sword = 1;
                            Input = Console.ReadLine().ToUpper();
                            Inventory[2] = "Fuming Blade";
                            if (Input == "BACK")
                            { next = 1; }
                            if (Input != "Back")
                            { next = 0; }
                        } 
                    } while (next == 0);
                }
                if (Input == "MENU")
                {
                    next = 0;
                    Console.WriteLine("'Inventory' to see your Inventory");
                    Console.WriteLine("'Status' to see HP and Score");
                    Console.WriteLine("< Back");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "INVENTORY" || Input == "INV")
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Your Inventory Contains:");
                            for (Arraycount = 0; Arraycount < 20; Arraycount++)
                            {
                                int inventory_possition = Arraycount + 1;
                                Console.SetCursorPosition(0, inventory_possition);
                                Console.WriteLine("{0}", Inventory[Arraycount]);
                            }
                            Console.WriteLine("< Back");
                            Input = Console.ReadLine().ToUpper();
                            if (Input == "BACK")
                            { next = 2; }
                            if (Input != "BACK")
                            { next = 0; }
                        } while (next == 0);

                    }
                    if (Input == "STATUS" || Input == "STAT")
                    {
                        next = 0;
                        Console.Clear();
                        Console.WriteLine("Your Health is at {0} and your Score is at {1}", Eric.HP, Eric.Score);
                        Console.WriteLine("< Back");
                        Input = Console.ReadLine().ToUpper();
                        if (Input == "BACK")
                        {
                            next = 2;
                        }
                        if (Input != "BACK")
                        {
                            next = 0;
                        }

                    } while (next == 0) ;  
                }
                else { }
            } while (next != 5);

            do
            {
                Console.Clear();
                Console.WriteLine("To Be Continued....");
                Console.WriteLine("Thank You for playing");
                Console.WriteLine("< Exit");
                Console.WriteLine("");
                Input = Console.ReadLine().ToUpper();
                if (Input =="EXIT")
                { next = 10; }
                if (Input !="EXIT")
                { next = 10; }
            } while (next == 0);
        }
    }
} 

                
   

