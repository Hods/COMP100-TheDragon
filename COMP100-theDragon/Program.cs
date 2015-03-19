using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace COMP100_theDragon
{
    class Program
    {
        static void Main(string[] args)
        {
            SpookyCave();
        }


        // UTILITY METHODS
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Start Over.....................>");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            Console.Clear();
        }

        // Main menu Utility Method
        private static void SpookyCave()
        {
            int selection = 0; // default selection
            string introText ="You are on a planet full of dragons. In front of you,\n";
            introText += "you see two caves. In one cave, the dragon is friendly\n";
            introText += "and will share his treasure with you. The other dragon\n";
            introText += "is greedy and hungry, and will eat you on sight.\n\n";
            string bodyText = ""; 


            while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                              +");
                Console.WriteLine("+  WHICH CAVE DO YOU GO INTO?  +");
                Console.WriteLine("+                              +");
                Console.WriteLine("+  1. Cave 1                   +");
                Console.WriteLine("+  2. Cave 2                   +");
                Console.WriteLine("+  3. Give Up :(               +");
                Console.WriteLine("+                              +");
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Cave 1 - Player Dies
                        bodyText = Cave1(bodyText);
                        break;
                    case 2: // Cave 2 - Player Lives
                        bodyText = Cave2(bodyText);
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorrect entry - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }
        }

        // Positive Outcome 1 - Player Lives - WIN
        private static string Cave2(string bodyText)
        {
            bodyText = "You approach the cave, it is bright and cheerful.\n";
            bodyText += "A large white dragon approaches you...\n\n";
            bodyText += "And... \n\n... gives you his treasure!\n";
            Console.ResetColor();
            Console.WriteLine(bodyText);
            Thread.Sleep(5000);

            bodyText = ".......... .M?78IIIIIIIII77M?. .........\n";
            bodyText += ".......... MMMMII.+?I,7=??MMMMMM........\n";
            bodyText += ".......... ..MMM=??OMMMMMM.MOMMM7.......\n";
            bodyText += "......... .... MMOZ.=,Z,Z.ZMMMMMM.......\n";
            bodyText += "...............MM+?M?MM??MMMZIMM........\n";
            bodyText += "............M?MMM.MMI+ID~?,Z8MI.........\n";
            bodyText += "..........MIM??ZZ?7?~M,MMM?IINI.........\n";
            bodyText += "..........??IIIIMMIIIZ$MII7IM7Z.........\n";
            bodyText += "..........?=IIIIIMNMZMM7MMIM7MN ........\n";
            bodyText += "..........?+IMMIIIIII=I?MMIMMIM ........\n";
            bodyText += "..... .NM I+IIIIIIIII?I+MMMZ8MM.........\n";
            bodyText += "8 .D?M.?M.I7MMIIIII7M+IIMDMMM??..M?+....\n";
            bodyText += ".......  ..+?M?MM7III7DZMMMM.~NMM....   \n";
            bodyText += "...........:M. MMM.I??+MM.M+?MMM,.......\n";
            bodyText += "......MMM....DM...??M...M?.MD..:M.......\n";
            bodyText += "....................... ....... .......\n";
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine(bodyText);
            WaitForKey();
            return bodyText;
        }

        // Negative Outcome 1 - Player Dies - LOSS
        private static string Cave1(string bodyText)
        {
            Console.Clear();
            bodyText = "You approach the cave, it is dark and spooky.\n";
            bodyText += "A large red dragon jumps out in front of you!\n";
            bodyText += "He opens his jaws and...\n\n\n";
            bodyText += "Gobbles you down with one bite!\n\n";
            Console.ResetColor();
            Console.WriteLine(bodyText);
            Thread.Sleep(5000);


            bodyText = ".......................................,\n";
            bodyText += ".........I88O8O$...O..~.Z878=$..........\n";
            bodyText += "......Z+$IO=878..8O,8....Z8~===+Z.......\n";
            bodyText += "....I7Z++II+=Z...8Z88....O+++=$Z77Z.....\n";
            bodyText += "..$$ZI777$$???,..=..IO...+7ZI8I7O$$$....\n";
            bodyText += ".8DDO$Z8D8$Z$$78..:+$8..D7$IZD7ZZZOD7...\n";
            bodyText += "D?DNZD88..DZZ8ZZ8O7OZ88$OOOZ:.OZOZ$DN8,.\n";
            bodyText += ". ?DDN8O...+:...88?$$7I,..:...ZZOO8D....\n";
            bodyText += "  .DDNDZ......:...I$Z.........O8DDO8....\n";
            bodyText += "   8,ZNO..........?DN=........8DNNDI....\n";
            bodyText += "   .   8.........8ID8:........D....O....\n";
            bodyText += "       .8........$?ZI........Z.. .......\n";
            bodyText += "   .   ..........8$Z........7...........\n";
            bodyText += "      ...........$.............. .......\n";
            bodyText += "      ..........7Z....,.Z........ ......\n";
            bodyText += "     . .........+I.......8..............\n";
            bodyText += "       ..........Z......D........ . ....\n";
            bodyText += "      . ..........$ZZO$:.........   ....\n";
            bodyText += " .    . ......................... ......\n";
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
            return bodyText;
        }
        
    }
}
