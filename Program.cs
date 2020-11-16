using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventureKB
{

    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();


        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to my text adventure!");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You and a couple of your friends take a boat ride to a nearby deserted island just to explore for fun. ");
            Console.WriteLine(" You get off the boat, explore the island only to come back and see that the boat has capsized and floated away.");
            Console.WriteLine("You have no cellphone reception.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Seek help");
            Console.WriteLine("2. Build a shelter");
            Console.WriteLine("3. Gather wood to make a fire");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "seek help":
                case "seek":
                    {
                        Console.WriteLine("You and your friends scream for help to the top of your lungs, only to hear the echoes in the trees.");
                        Console.WriteLine("You spot a helicopter flying nearby and decide to write SOS, Help in the sand.");
                        Console.WriteLine("Fortunately, this works!");
                        Console.WriteLine("The helicopter was flying close enough to see your cry for help!");
                        Console.WriteLine("You and your friends are saved! The end.");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;
                    }

                case "2":
                case "Build a shelter":
                    {
                        Console.WriteLine("You and your friends search the island for wood, leaves and anything that can help you make a shelter.");
                        Console.WriteLine("It is getting dark and you realize you need to get some rest for the day ahead.");
                        Console.WriteLine("Then you hear a rustling in the woods just behind your heads. What do you do?");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "gather wood to make a fire":
                    {
                        Console.WriteLine("You and your friends search high and low for wood to make a fire.");
                        Console.WriteLine("You have gathered the wood and make a fire using a method you learned in Boy Scouts.");
                        Console.WriteLine("You and your friends feel safe, and manage to get a few hours of sleep before day break.");
                        Console.WriteLine("You are awakened by the sound of a rescue helicopter who saw the fire, and dropped in to get you!!");
                        Console.WriteLine("You are now safe and heading home!");
                        Console.ReadLine();
                        Console.Clear();
                        first();
                        break;

                    }

            }
        }

        public static void second()
        {
            string secChoice;
            Console.WriteLine("1. run, run as fast as you can");
            Console.WriteLine("2. Go into the woods to see who's there");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();
            Console.Clear();

            if (secChoice == "1")
            {
                Console.WriteLine("You run and run looking back only to realize a bear is chasing you and your friends.");
                Console.WriteLine("The bear catches you and claws you down your back.");
                Console.WriteLine("You begin to bleed profusely and you collapse and lose consiousness.");
                Console.ReadLine();
                Console.Clear();
                gameOver();
                

            }
            else if (secChoice == "2")
            {
                Console.WriteLine("You and your friends follow the sound into the woods and discover a bear.");
                Console.WriteLine("The bear catches you and claws you down your back.");
                Console.WriteLine("You begin to bleed profusely and you collapse and lose consiousness.");
                Console.ReadLine();
                gameOver();

            }
            else
            {
                Console.WriteLine("You must reply.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }
        }

            public static void gameOver()
            {
                Console.Clear();
                Console.WriteLine("You have died.");
                Console.WriteLine("The End");
                Console.ReadLine();
                Console.Clear();
                gameTitle();
            }


        }



    }

        
    





