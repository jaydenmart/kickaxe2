using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
//using System.Speech.Synthesis;
//using System.Drawing;
using System.Data;

//4swag
namespace Adventure
{
    class MainClass
    {
        const int SWP_NOSIZE = 0x0001;


j;asldkfjs;ldfjas;dlfjasl;dfj
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr MyConsole = GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        public static void Main(string[] args)
        {

            int xpos = 0;
            int ypos = 0;
            SetWindowPos(MyConsole, 0, xpos, ypos, 0, 0, SWP_NOSIZE);
            Console.SetWindowSize(155, 81);

            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Johnny changed this trollingly.");
                System.Threading.Thread.Sleep(2);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(String.Format("{0," + (Console.WindowWidth + 29) / 2 + "}", "Kick Axe II: Quest of Masters"));
            System.Threading.Thread.Sleep(200);
            Console.WriteLine(String.Format("{0," + (Console.WindowWidth + 23) / 2 + "}", "Mother FALCON axe yeah!"));
            System.Threading.Thread.Sleep(200);
            Console.WriteLine(String.Format("{0," + (Console.WindowWidth + 60) / 2 + "}", "A game by Jayden Martinez, Drew Williams, and Jonathan Bush."));
            System.Threading.Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.White;

            Random rndColos = new Random();
            int colosRnd = rndColos.Next(1, 4);
            
            // variables
            int levelNumeric;
            string jbBlockedPath = "\nYour path is blocked.\n";
            bool swag = false;
            bool swagalicious = false;
            bool gnome = false;
            bool jesterKilled = false;
            bool catKilled = false;
            bool slothKilled = false;
            //inventory items: lantern 0, Sword 1, jester 2, cat 3, sloth 4, bartender 5, snail 6
            bool[] inventoryInsideRoom = { false, false, false, false, false, false, false };
            bool[] inventeryOwned =      { false, false, false, false, false, false, false };
            //bool[] roomContains = {false, false, false, false };
            Random deads = new Random();
            int newdeads = deads.Next(1, 5);


         
        //game room areas      
       

            //the prison cell you started in.
        levelNumeric1:
            levelNumeric = 1;
            if (inventeryOwned[0] == false)
            {
                inventoryInsideRoom[0] = true;
            }
            Console.WriteLine("\nYou're in a small prison cell, there is an entrance to the north.");
            if (inventoryInsideRoom[0] == true)
            {
                Console.WriteLine("The room contains a lantern.\n");
            }
            else
            {
                Console.WriteLine("");
            }
            goto commands;

            // the general prison area
        levelNumeric2:
            levelNumeric = 2;
            inventoryInsideRoom[0] = false;
            inventoryInsideRoom[1] = false;
            Console.WriteLine("\nYou're in the general prison area, there are prison cells to the north and south, with a passage to the east.\n");
            goto commands;

            // open cell
        levelNumeric3:
            levelNumeric = 3;
            inventoryInsideRoom[1] = true;
            if (inventeryOwned[1] == false)
            {
                inventoryInsideRoom[1] = true;
            }
            else
            {
                inventoryInsideRoom[1] = false;
            }
            Console.WriteLine("\nYou're in another prison cell with an open door to the south.");
            if (inventoryInsideRoom[1] == true)
            {
                Console.WriteLine("The room contains a sword.\n");
            }
            else
            {
                Console.WriteLine("");
            }
            goto commands;

            // Colos ent
        levelNumeric4:
            levelNumeric = 4;
            inventoryInsideRoom[2] = false;
            inventoryInsideRoom[3] = false;
            Console.WriteLine("\nYou're in a large passageway with passages to the north and west.");
            goto commands;

            //Colos battle1
        levelNumeric501:
            levelNumeric = 501;
            //cat vampire
            if (catKilled == false) {
            inventoryInsideRoom[3] = true;
            Console.WriteLine("\nYou're in a large room with marble pillars all around, the ceiling is open revealing the sky. In the center of the arena is an vampire cat, waiting to fight you.");
            } else {
            Console.WriteLine("\nYou're in a large room with marble pilars all around, the ceiling is open revealing the sky. There are passages in all directions.\n");
            inventoryInsideRoom[3] = false;
            }
            goto commands;

            //Colos battle2
        levelNumeric502:
            levelNumeric = 502;
            //evil jester
            if (jesterKilled == false) {
            inventoryInsideRoom[2] = true;
            Console.WriteLine("\nYou're in a large room with marble pillars all around, the ceiling is open revealing the sky. In the center of the arena is an evil jester, waiting to fight you.");
            } else {
            Console.WriteLine("\nYou're in a large room with marble pilars all around, the ceiling is open revealing the sky. There are passages in all directions.\n");
            inventoryInsideRoom[2] = false;
            }
            goto commands;

            //Colos battle3
        levelNumeric503:
            levelNumeric = 503;
            //sloth
            Console.WriteLine("\nYou're in a large room with marble pillars all around, the ceiling is open revealing the sky. Waiting for you in the center off the colosseum, amidst the sound of the screaming fans, the most terrifying creature of all...");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("So horrible you can barely stand to look at its terrifying figure.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("You must fight this horrible creature.");
            System.Threading.Thread.Sleep(750);
            Console.WriteLine("You must fight the MIGHTY SLOTH!\n");
            goto commands;

            //colos exit, 6
        levelNumeric6:
            levelNumeric = 6;


            //Path To Forest
        levelNumeric101:
            levelNumeric = 101;
            Console.WriteLine("\n You are on a path that leads into the Forest. The path continues east.");






            //Johnny's rooms
            
            
            //town entrance
        levelNumeric7:
            levelNumeric = 7;
            Console.WriteLine("\nAfter walking for some time, you come across a gate to the west leading into a town.\n");
            goto commands;

            //town center
        levelNumeric9:
            levelNumeric = 9;
            Console.WriteLine("\nYou're in the center of a small town, there are alleyways leading in every direction, with a gate to the east.");
            goto commands;

            //southern alley
        levelNumeric19:
            levelNumeric = 19;
            Console.WriteLine("\nYou're in an alleyway with a paint shop to the east, a bar to the west, a shop to the south, and the town center to the north.\n");
            goto commands;

            //paint shop
        levelNumeric18:
            levelNumeric = 18;
            Console.WriteLine("\nThis is a strangely empty paint shop, the only object in the room is a single can of paint.\n");
            goto commands;

            //bar
        levelNumeric20:
            levelNumeric = 20;
            Console.WriteLine("\nYou are standing in a bar with many people passed out on the floor, the bartender is standing behind a counter.\n");
            goto commands;

            //north alley
        levelNumeric11:
            levelNumeric = 11;
            Console.WriteLine("\nYou are in an alleyway with a French bakery to the north, and apothecary shop to the east, and the town center is to the south.\n");
            goto commands;

            //French bakery
        levelNumeric13:
            levelNumeric = 13;
            Console.WriteLine("You are in a French bakery with pastries lining the wall, there's a garbage bucket leaning next to the southern door.\n");
            goto commands;
        //death
        death:
            Console.WriteLine("\n You have died. You are now as dead as any dead animal that has ever died. Would you like to try again?");

            //death2
        death2:
            Console.WriteLine("\n You be deads for deads son! Try Again?");

            //death3
        death3:
            Console.WriteLine("\n You are no longer with us, my condolences. Would you like to retry?");

            //death4 
        death4:
            Console.WriteLine("\n Ya done goofed. Try again, newb?");

             if (newdeads == 1)
            { 
               goto death;
            }
            if  (newdeads == 2)
            {
                goto death2;
            }
            if  (newdeads == 3)
            {
                goto death3;
            }
            if  (newdeads == 4)
            {
                goto death4;
            }
            if (newdeads == 5)
            {
                goto death5
            }
        




            //go to this after each switch statement*
        commands:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(">");
            string commands = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            string[] commandArray = commands.Split(' ');
            switch (commandArray[0])
            {
                case "Help":
                case "help":
                    Console.WriteLine("\nAll commands currently in the game:\n North: Moves character north. Variants: north, n, N \n South: Moves character south. Variants: south, s, S \n East: Moves character east. Variants: east, e, E \n West: Moves character west. Variants: west, w, W \n Look: Restates room description. Variants: look, l, L \n Inspect: Inspects specified object. Usage: Inspect <objectname>. Variants: inspect, Search, search, Examine, examine\n Take: Retrieves specified object and puts it into the inventory. Usage: Take <objectname>. Variants: take, Grab, grab\n Inventory: Checks inventory. Variants: inventory, Invent, invent, i, I\n Give  ");

                    goto commands;
                    break;
                /* case "Maples":
                if (gnome == true) {
                goto gnomeBathRoom;
                }
                break; */
                case "north":
                case "North":
                case "N":
                case "n":
                    switch (levelNumeric)
                    {
                        case 1:
                            goto levelNumeric2;
                            break;
                        case 2:
                            goto levelNumeric3;
                            break;
                        case 4:
                            switch (colosRnd)
                            {
                                case 1:
                                    goto levelNumeric501;
                                    break;
                                case 2:
                                    goto levelNumeric502;
                                    break;
                                case 3:
                                    goto levelNumeric503;
                                    break;
                            }
                            break;
                        case 5:
                            goto levelNumeric501;
                            break;
                        case 6:
                            goto levelNumeric9;
                            break;
                        default:
                            Console.WriteLine(jbBlockedPath);
                            break;


                    }
                    break;
                case "south":
                case "South":
                case "S":
                case "s":
                    switch (levelNumeric)
                    {
                        case 2:
                            goto levelNumeric1;
                            break;
                        case 3:
                            goto levelNumeric2;
                            break;
                        case 501:
                        case 502:
                        case 503:
                            goto levelNumeric4;
                            break;
                        default:
                            Console.WriteLine(jbBlockedPath);
                            break;
                    }
                    break;
                case "east":
                case "East":
                case "E":
                case "e":
                    switch (levelNumeric)
                    {
                        case 2:
                            goto levelNumeric4;
                            break;
                        case 8:
                            goto levelNumeric101;
                            break;
                        default:
                            Console.WriteLine(jbBlockedPath);
                            break;
                    }
                    break;
                case "west":
                case "West":
                case "W":
                case "w":
                    switch (levelNumeric)
                    {
                        case 2:
                            gnome = true;
                            break;
                        case 4:
                            goto levelNumeric2;
                            break;
                        default:
                            Console.WriteLine(jbBlockedPath);
                            break;
                    }
                    break;
                case "dance":
                case "Dance":
                    Console.WriteLine("\nYou did a Little Jig");
                    break;
                case "look":
                case "Look":
                case "l":
                case "L":
                    switch (levelNumeric)
                    {
                        case 1:
                            goto levelNumeric1;
                            break;
                        case 2:
                            goto levelNumeric2;
                            break;
                        case 3:
                            goto levelNumeric3;
                            break;
                        case 4:
                            goto levelNumeric4;
                            break;
                        case 501:
                            goto levelNumeric501;
                            break;
                        case 502:
                            goto levelNumeric502;
                            break;
                        case 503:
                            goto levelNumeric503;
                            break;
                        case 6:
                            goto levelNumeric6;
                            break;
                        case 7:
                            goto levelNumeric7;
                            break;
                        //case 8:
                        //    goto levelNumeric8;
                        //    break;
                        case 9:
                            goto levelNumeric9;
                            break;
                        /* case 10:
                                goto levelNumeric10;
                                break;
                            case 10:
                                goto levelNumeric10;
                                break;
                            
                            case 11:
                                goto levelNumeric11;
                                break;
                            case 12:
                                goto levelNumeric12;
                                break;
                            case 13:
                                goto levelNumeric13;
                                break;
                            case 14:
                                goto levelNumeric14;
                                break;
                            case 10:
                                goto levelNumeric10;
                                break;
                            case 10:
                                goto levelNumeric10;
                                break;
                                 */

                    }
                    break;
                case "Speak":
                case "speak":
                case "say":
                case "Say":
                    break;
                case "search":
                case "Search":
                case "inspect":
                case "Inspect":
                case "examine":
                case "Examine":
                    if (commandArray.Length >= 2)
                    {
                        switch (commandArray[1])
                        {
                            case "Lantern":
                            case "lantern":
                            case "lamp":
                            case "Lamp":
                                switch (inventeryOwned[0])
                                {
                                    case true:
                                        Console.WriteLine("\nIt's a small worn down lantern\n");
                                        break;
                                }
                                break;
                                switch (inventoryInsideRoom[6]) {
                                    case true:
                                        Console.WriteLine("\nIt's a sturdy bucket with a single snail shell.\n");
                                }
                            default:
                                Console.WriteLine("\nYou don't have a " + commandArray[0] + "!\n");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nWhat do you want to inspect?");
                    }
                    break;
                case "grab":
                case "Grab":
                case "take":
                case "Take":
                    if (commandArray.Length >= 2)
                    {
                        switch (commandArray[1])
                        {
                            case "Lantern":
                            case "lantern":
                            case "lamp":
                            case "Lamp":
                                switch (inventoryInsideRoom[0])
                                {
                                    case true:
                                        Console.WriteLine("\nTaken\n");
                                        inventoryInsideRoom[0] = false;
                                        inventeryOwned[0] = true;
                                        break;
                                    default:
                                        goto invDef;
                                        break;
                                }
                                break;
                            case "Sword":
                            case "sword":
                                switch (inventoryInsideRoom[1])
                                {
                                    case true:
                                        Console.WriteLine("\nTaken\n");
                                        inventoryInsideRoom[1] = false;
                                        inventeryOwned[1] = true;
                                        break;
                                    default:
                                        goto invDef;
                                        break;
                                }
                                break;
                            case "Grue":
                            case "grue":
                                Console.WriteLine("\nI don't think he would be happy with that... \n");
                                break;
                            default:
                            invDef:
                                Console.WriteLine("\nThere is no " + commandArray[1] + " here.\n");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nWhat do you want to take?");
                        break;
                    }
                    break;
                case "inventory":
                case "Inventory":
                case "invent":
                case "Invent":
                case "i":
                case "I":
                    break;
                case "use":
                case "Use":
                    break;
                case "exit":
                case "Exit":
                    break;
                case "Kill":
                case "kill":

                    if (commandArray.Length >= 1)
                    {
                        switch (commandArray[1])
                        {
                            case "self":
                            case "Self":
                            case "Myself":
                            case "myself":
                                goto death;
                                break;
                        }
                    }
                    break;
                case "DEBUG":
                    //debug = true;
                    goto commands;
                    break;
                case "SECRET":
                    goto pocketses;
                    break;
                default:
                    Console.WriteLine("\nThat command is not in the game.");
                    goto commands;
                    break;
            }
            goto commands;

        pocketses:
            Console.WriteLine("\n You have found the secret area of Julan Du'gal, enter your code for glory! \n");
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            string secret = Console.ReadLine();
            switch (secret)
            {
                case "4 8 15 16 23 42":
                    Console.Write("\n You are truly a gifted person, you shall be rewarded with all text being");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" BLUE!!!! \n");
                    goto pocketses;
                    break;
                case "RETURN ME!":
                    Console.WriteLine("\n Very well young apprentice, I shall take you back to the main game. farewell, young grasshopper. \n");
                    goto commands;
                    break;
                case "swag":
                    Console.WriteLine("\n Well done my swagmeister! You are granted the ability to have swag points!");
                    switch (levelNumeric)
                    {
                        case 1:
                            swagalicious = true;
                            goto pocketses;
                            break;
                    }
                    break;
                case "Give me all!":
                    Console.WriteLine(" \n very well, Grand Master, all shall be given to you! \n");
                    inventeryOwned[0] = true;
                    inventeryOwned[1] = true;
                    inventeryOwned[2] = true;
                    goto pocketses;
                    break;
                default:
                    Console.WriteLine("\n You have dissapointed me, you shall be returned to the main area. pitiful. \n");
                    goto commands;
                    break;




                gnomeBathRoom:
                    levelNumeric = 1000;
                    Console.WriteLine("\nYou suddenly teleport into a strange bathroom with no doors or windows anywhere. There is a gnome taking a bath in the center of the room, and seems annoyed at your disturbance.");
                    inventoryInsideRoom[3] = true;
                    goto commands;
            }
        }
    }
}
