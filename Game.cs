using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough_Text_Break
{
    //Set class to public
    public class Game
    {
        //Setting variables 
        //creating var to recieve RAPT-4s name
        string fourName;

        //Variable to keep the menu running
        bool running = true;

        //var to understand menu input
        int userMenuInput;

        //Player Variable as Object
        RAPT4 myChar;

        //instantiate Sentry
        Enemy nme1 = new Sentry();

        //instantiate Eye Fly
        Enemy nme2 = new eyeFly();

        //instantiate the Story object, this will create the contentArray
        Story myStory1 = new Story();

        //instantiate inventory
        Inventory myInventory1 = new Inventory();



        //Method to play the game
        public void PlayGame()
        {
            //Launching Acts (Scenes)
            Act1();
            Act2();

        }

        //Method that keeps the Player Information/HUD on screen
        public void UpdateHUD()
        {
            this.myChar.HUD();
        }

        //Method that'll keep the Enemy HUD up
        public void UpdateNMEHUD()
        {
            this.nme1.NMEHUD();
        }

        //Menu Creation
        public void MenuOne()
        {
            //presenting the menu options tro screen as printer text
            Console.WriteLine("The Sentry approaches! Quickly!");
            Console.WriteLine("\n1) Strike with an Electric Slash");
            Console.WriteLine("2) Launch forth an Electric Arc");

            //store user input in a var
            userMenuInput = Convert.ToInt16(Console.ReadLine());

            //conditioal branching for each result
            switch (userMenuInput)
            {
                case 1:
                    fourSlash();
                    break;

                case 2:
                    fourElec();
                    break;

                default:
                    Console.WriteLine("Wrong choice there");
                    break;
            }
        }

        //Inventory Method
        public void UpdateInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (string i in myInventory1.inventoryList)
            {
                Console.WriteLine(i);
            }
        }

        //Method that Allows Four to Physically Hit
        public int fourSlash()
        {
            return this.myChar.Slash();
        }

        //Method that allows for Four to deal Electric Damage
        public int fourElec()
        {
            return this.myChar.ElecStrike;
        }

           //Menu for Combat
        public void FourPhysical()
        {
            Console.Clear();
            Console.WriteLine("Let's attack the {0}, with the {1}.\n", this.nme1.GetNMEClassName, this.myChar);

            //inflict damage on the Sentry
            nme1.SetNMEHealthPoints = nme1.GetNMEHealthPoints - myChar.Slash();

            //Enemy health check
            NMEHealthCheck();

            //update the HUDs
            UpdateHUD();
            UpdateNMEHUD();
            UpdateInventory();
        }

        public void NMEHealthCheck()
        {
            if (this.nme1.GetNMEHealthPoints <= 0)
            {
                
                this.nme1.SetNMEHealthPoints = 0;

                Console.Clear();

                this.myChar.GainXP(this.nme1.GetNMEXP);
               
                UpdateHUD();
                this.nme1.NMEHUD();
                UpdateInventory();


                Console.WriteLine($"The{this.nme1.GetNMEClassName} explodes!");
                Console.WriteLine(myStory1.contentArray[1]);
                Console.ReadLine();

                //terminate the while loop
                running = false;
            }
        }


        //create a methode for spell casting melee
        public void FourElecSpecial()
        {
            Console.Clear();
            Console.WriteLine("Let's cast a spell on the {0}, with the {1}.\n", this.nme1.GetNMEClassName, this.myChar);

            //inflict spell damage on the orc
            nme1.SetNMEHealthPoints = nme1.GetNMEHealthPoints - fourElec();

            //npc health check
            NMEHealthCheck();

            //update the HUDs
            UpdateHUD();
            UpdateNMEHUD();
            UpdateInventory();
        }


        //Creating Act 1 (Method)
        public void Act1()
        {
            //Welcome the player to the game
            Console.WriteLine(myStory1.contentArray[0]);
            Console.ReadKey();

            Console.WriteLine("Now, proper introductions are to be made - let us instantiate our main character");
            Console.Clear();

            //instantiate RAPT-4
            myChar = new RAPT4(fourName);

            Console.Clear();

            //Bring up the HUD (Should be permantely viewable at all times)
            myChar.HUD();

            //Story introduction
            Console.WriteLine($"{myChar.fourName} STATUS: ONLINE");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(myStory1.contentArray[1]);

            Console.WriteLine(myStory1.contentArray[2]);

            Console.WriteLine(myStory1.contentArray[3]);
            Console.Clear();
            Console.WriteLine("KRCKA-DOOOOOOOOOOOOOOOOOOOOOOOOOOM!");
            Console.Clear();

            Console.WriteLine(myStory1.contentArray[4]);
            Console.WriteLine(myStory1.contentArray[5]);

            Console.ReadLine();

            myChar.HUD();
            UpdateNMEHUD();

            while (running)
            { MenuOne(); }

            Console.Clear();

            Console.WriteLine("It's over! For now...");
            Console.WriteLine("One of the Sentries seems to drop something upon its defeat, picking it up, you aquire some sort of gear! Four pockets it, heres hoping it'll be useful - typically how this sort of thing goes.");

            myInventory1.inventoryList.Add("Gear");

            UpdateHUD();
            nme1.NMEHUD();
            UpdateInventory();

            Console.ReadLine();

            //Act End
            Console.Clear();
        }

        public void Act2()
        {
            //Choose your Own Path
            Console.WriteLine("With a new objective set, it's time to go off to see what the rest of the world has, hopefully you'll find an actual sort of population as well.");
            Console.ReadLine();
            Console.Clear();


                Console.WriteLine(myStory1.contentArray[6]);
                userMenuInput = Convert.ToInt16(Console.ReadLine());

                switch (userMenuInput)
                {
                    case 1:
                        Console.WriteLine(myStory1.contentArray[10]);
                    break; 
                    case 2:
                        Console.WriteLine(myStory1.contentArray[9]);
                        break;

                    default:
                        Console.WriteLine(myStory1.contentArray[8]);
                        break;
                }

              

                Console.ReadLine();

                //END OF SCENE 2

            

        }
    }
}
