using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace English
{
    class Program
    {
        static bool _end = false;

        // Main
        static void Main(string[] args)
        {
            Thread game = new Thread(new ThreadStart(Intro));
            Thread music = new Thread(new ThreadStart(Music));

            game.Start();
            music.Start();

            bool off = false;

            while (!off)
            {
                if (_end)
                {
                    game.Abort();
                    music.Abort();
                    off = true;
                }
            }
        }

        // Intro
        static void Intro()
        {
            int choice;
            ArrayList levels = new ArrayList();
            levels.Add(1);
            levels.Add(2);
            levels.Add(3);
            levels.Add(4);
            levels.Add(5);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|   __ ___       __    __        ___  __                   ___     __ ___  |");
            Console.WriteLine("|  |    |  |  | |  \\  |   |\\   |  |  |        \\          /  |     |    |   |");
            Console.WriteLine("|  |__  |  |  | |   | |_  | \\  |  |  |__       \\        /   |  __ |_   |   |");
            Console.WriteLine("|     | |  |  | |   | |   |  \\ |  |     |       \\  /\\  /    |     |    |   |");
            Console.WriteLine("|   __| |  |__| |__/  |__ |   \\|  |   __|        \\/  \\/    _|_    |   _|_  |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                           __        __      __                           |");
            Console.WriteLine("|                          |    |  | |   | / |                             |");
            Console.WriteLine("|                          |__  |  | |   |/  |__                           |");
            Console.WriteLine("|                             | |  | |   |\\     |                          |");
            Console.WriteLine("|                           __| |__| |__ | \\  __|                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                 THE GAME                                 |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                PRESS START                               |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Welcome                                                                  |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                                                                      |");
            Console.WriteLine("|  |_|                                                                     |");
            Console.WriteLine("|  /|\\                                                                     |");
            Console.WriteLine("|  / \\                                                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  This is you. At the high school you attend, the Student Wi-Fi is down.  |");
            Console.WriteLine("|  You have a research paper due TODAY at 3:30! If you can't submit the    |");
            Console.WriteLine("|  paper in time, you'll get a zero and that's not the worst of it. If     |");
            Console.WriteLine("|  your parents hear of this, you'll be grounded for who knows how long.   |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Welcome                                                                  |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                                                                      |");
            Console.WriteLine("|  |_|                                                                     |");
            Console.WriteLine("|  /|\\                                                                     |");
            Console.WriteLine("|  / \\                                                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Your best bet at getting your paper done is to use the FAC-STAFF Wi-Fi  |");
            Console.WriteLine("|  . Unfortunately, as the name would imply, the FAC-STAFF Wi-Fi is        |");
            Console.WriteLine("|  supposed to be used by faculty and staff, not students. Hacking the     |");
            Console.WriteLine("|  Wi-Fi would take too long so getting someone to give it to you is the   |");
            Console.WriteLine("|  only option.                                                            |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| The Library                                                              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                   _      |");
            Console.WriteLine("|   _                                                              |_|     |");
            Console.WriteLine("|  |_|                                                             /|\\     |");
            Console.WriteLine("|  /|\\                                                              |      |");
            Console.WriteLine("|  / \\                                                             / \\     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  The person most likely to give you the password is Bryce. Bryce is the  |");
            Console.WriteLine("|  administrator's assistant and he is pretty chill. You can find Bryce    |");
            Console.WriteLine("|  in the library. Let's take a look...                                    |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| The Library                                                              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|      ______________________________     |For the right price... > _      |");
            Console.WriteLine("|   _ < Can I have the FAC-STAFF key?|    |______________________/ |_|     |");
            Console.WriteLine("|  |_| \\_____________________________|                             /|\\     |");
            Console.WriteLine("|  /|\\                                                              |      |");
            Console.WriteLine("|  / \\                                                             / \\     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Bryce has agreed that he will give you the FAC-STAFF key if you can     |");
            Console.WriteLine("|  complete a series of tasks for him. In order to prove that you are      |");
            Console.WriteLine("|  worthy, you have to complete a tech support task in each department of  |");
            Console.WriteLine("|  the school.                                                             |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| The Library                                                              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Which department would you like to start with?                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  1 Math                                                                  |");
            Console.WriteLine("|  2 Science                                                               |");
            Console.WriteLine("|  3 English                                                               |");
            Console.WriteLine("|  4 History                                                               |");
            Console.WriteLine("|  5 World Language                                                        |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                  SELECT ONE AND PRESS START TO CONTINUE                  |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the corresponding number and 'Enter' to continue:");
            choice = ScanInt();

            bool valid = false;
            for (int i = 0; i < levels.Count; i++)
            {
                if ((int)(levels[i]) == choice)
                {
                    Console.WriteLine("Loading...");
                    levels.Remove(levels[i]);
                    LevelSwitcher(choice, levels);
                    valid = true;
                    i = 10;
                }
            }
            if (valid == false)
            {
                Console.WriteLine("That level does not exist or has already been played. Level " + (int)(levels[0]) + " selected.");
                Console.WriteLine("Loading...");
                choice = (int)(levels[0]);
                levels.Remove(levels[0]);
                LevelSwitcher(choice, levels);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to exit:");
            Console.ReadKey();
            _end = true;
        }

        // Level Switcher
        private static void LevelSwitcher(int choice, ArrayList levels)
        {
            if (choice == 1)
            {
                Level1(levels);
            }
            else if (choice == 2)
            {
                Level2(levels);
            }
            else if (choice == 3)
            {
                Level3(levels);
            }
            else if (choice == 4)
            {
                Level4(levels);
            }
            else if (choice == 5)
            {
                Level5(levels);
            }
        }

        // Level 1
        private static void Level1(ArrayList levels)
        {
            int choice;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Math Department                                                          |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                                                                      |");
            Console.WriteLine("|  |_|                                                                     |");
            Console.WriteLine("|__/|\\_____________________________________________________________________|");
            Console.WriteLine("|  / \\                                                                     |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Bryce has asked you to go to Herman Hall and fix something for Mr.      |");
            Console.WriteLine("|  Omullan. Hopefully it's something quick. The day's already halfway      |");
            Console.WriteLine("|  over! If you can't get this problem fixed all this hassle will have     |");
            Console.WriteLine("|  been for nothing.                                                       |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Math Department                                                          |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _             | My laptop's at my desk. > _                            |");
            Console.WriteLine("|  |_|            |________________________/ |_|             ______        |");
            Console.WriteLine("|  /|\\                                       /|\\_          /______/|       |");
            Console.WriteLine("|  / \\                                       / \\           |/     |/       |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Mr. Omullan's laptop won't connect to the projector. To complete the    |");
            Console.WriteLine("|  connection, it seems that today's crossword puzzle has to be completed  |");
            Console.WriteLine("|  . Luckily, Mr. Omullan has filled in all but one word. Let's take a     |");
            Console.WriteLine("|  look at the puzzle...                                                   |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Puzzle1();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Math Department                                                          |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _           | Yes! It worked! Thank you > _                            |");
            Console.WriteLine("|  |_|          |__________________________/ |_|             ______        |");
            Console.WriteLine("|  /|\\                                       /|\\_          /______/|       |");
            Console.WriteLine("|  / \\                                       / \\           |/     |/       |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Okay, you've completed this task. It's getting close though. Hopefully  |");
            Console.WriteLine("|  there'll be enough time at the end to talk to Bryce and upload the      |");
            Console.WriteLine("|  file.                                                                   |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            if (levels.Count == 0)
            {
                Conclusion();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" __________________________________________________________________________ ");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("| Math Department                                                          |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  Which department would you like to go to next?                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  1 Math                                                                  |");
                Console.WriteLine("|  2 Science                                                               |");
                Console.WriteLine("|  3 English                                                               |");
                Console.WriteLine("|  4 History                                                               |");
                Console.WriteLine("|  5 World Language                                                        |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                  SELECT ONE AND PRESS START TO CONTINUE                  |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("                                                                            ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the corresponding number and 'Enter' to continue:");
                choice = ScanInt();

                bool valid = false;
                for (int i = 0; i < levels.Count; i++)
                {
                    if ((int)(levels[i]) == choice)
                    {
                        Console.WriteLine("Loading...");
                        levels.Remove(levels[i]);
                        LevelSwitcher(choice, levels);
                        valid = true;
                        i = 10;
                    }
                }
                if (valid == false)
                {
                    Console.WriteLine("That level does not exist or has already been played. Level " + (int)(levels[0]) + " selected.");
                    Console.WriteLine("Loading...");
                    choice = (int)(levels[0]);
                    levels.Remove(levels[0]);
                    LevelSwitcher(choice, levels);
                }
            }
        }

        // Puzzle 1
        private static void Puzzle1()
        {
            string answer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Math Department                                                          |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|       ___                                                                |");
            Console.WriteLine("|   ___|___|___ ___ ___ ___ ___ ___                                        |");
            Console.WriteLine("|  |_c_|_a_|_l_|_c_|_u_|_l_|_u_|_s_|                                       |");
            Console.WriteLine("|      |___|                                                               |");
            Console.WriteLine("|      |___|                                                               |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  The hint is: What is the name of the department you are in?             |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|               ENTER YOUR ANSWER AND PRESS START TO CONTINUE              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the correct answer and 'Enter' to continue:");
            answer = Scan();

            if (answer.ToLower() == "math")
            {
                Console.WriteLine("Loading...");
            }
            else
            {
                Console.WriteLine("Try again...");
                Puzzle1();
            }
        }

        // Level 2
        private static void Level2(ArrayList levels)
        {
            int choice;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Science Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                                                                      |");
            Console.WriteLine("|  |_|                                                                     |");
            Console.WriteLine("|  /|\\                                                                     |");
            Console.WriteLine("|  / \\                                                                     |");
            Console.WriteLine("|  |_                Bryce has asked you to help Dr. Moessner with her     |");
            Console.WriteLine("|    |_              printer. This should be a quick fix. Hopefully it'll  |");
            Console.WriteLine("|      |_            leave enough time for the paper. This is getting so   |");
            Console.WriteLine("|        |_          stressful.                                            |");
            Console.WriteLine("|          |_                                                              |");
            Console.WriteLine("|            |_                                                            |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Science Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                           _           _ < My printer's right here. | |");
            Console.WriteLine("|  |_|                        _|_|_        |_| \\_________________________| |");
            Console.WriteLine("|  /|\\                       /____/|      _/|\\                             |");
            Console.WriteLine("|  / \\                       |____|/       / \\                             |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  It looks like Dr. Moessner's printer isn't aligned so everything's      |");
            Console.WriteLine("|  printing kinda funny. To fix it, you just have to complete this         |");
            Console.WriteLine("|  pattern.                                                                |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Puzzle2();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Science Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                           _           _ < Wow! It worked! |          |");
            Console.WriteLine("|  |_|                        _|_|_        |_| \\________________|          |");
            Console.WriteLine("|  /|\\                       /____/|      _/|\\                             |");
            Console.WriteLine("|  / \\                       |____|/       / \\                             |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Well that's done. What a relief. It's looking like you might actually   |");
            Console.WriteLine("|  get the paper in on time. Thank goodness you don't have to explain      |");
            Console.WriteLine("|  this one to your parents.                                               |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            if (levels.Count == 0)
            {
                Conclusion();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" __________________________________________________________________________ ");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("| Science Department                                                       |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  Which department would you like to go to next?                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  1 Math                                                                  |");
                Console.WriteLine("|  2 Science                                                               |");
                Console.WriteLine("|  3 English                                                               |");
                Console.WriteLine("|  4 History                                                               |");
                Console.WriteLine("|  5 World Language                                                        |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                  SELECT ONE AND PRESS START TO CONTINUE                  |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("                                                                            ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the corresponding number and 'Enter' to continue:");
                choice = ScanInt();

                bool valid = false;
                for (int i = 0; i < levels.Count; i++)
                {
                    if ((int)(levels[i]) == choice)
                    {
                        Console.WriteLine("Loading...");
                        levels.Remove(levels[i]);
                        LevelSwitcher(choice, levels);
                        valid = true;
                        i = 10;
                    }
                }
                if (valid == false)
                {
                    Console.WriteLine("That level does not exist or has already been played. Level " + (int)(levels[0]) + " selected.");
                    Console.WriteLine("Loading...");
                    choice = (int)(levels[0]);
                    levels.Remove(levels[0]);
                    LevelSwitcher(choice, levels);
                }
            }
        }

        // Puzzle 2
        private static void Puzzle2()
        {
            int answer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| Science Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|   1, 1, 2, 3, 5, 8, 13, __                                               |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|   What is the next number in the pattern?                                |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|               ENTER YOUR ANSWER AND PRESS START TO CONTINUE              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the correct answer and 'Enter' to continue:");
            answer = ScanInt();

            if (answer == 21)
            {
                Console.WriteLine("Loading...");
            }
            else
            {
                Console.WriteLine("Try again...");
                Puzzle2();
            }
        }

        private static void Level3(ArrayList levels)
        {
            int choice;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| English Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|               _|   Bryce has asked you to help Mr. Hamor with            |");
            Console.WriteLine("|             _|     something on his phone. You're not sure you'll even   |");
            Console.WriteLine("|   _       _|       know what to do. You haven't used iOS in years.       |");
            Console.WriteLine("|  |_|    _|                                                               |");
            Console.WriteLine("|  /|\\  _|                                                                 |");
            Console.WriteLine("|  / \\_|                                                                   |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| English Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                               _ < My phone doesn't connect to LTE. | |");
            Console.WriteLine("|  |_|                             |_| \\_________________________________| |");
            Console.WriteLine("|  /|\\                            _/|\\                                     |");
            Console.WriteLine("|  / \\                             / \\                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  That's a relief. You've seen this problem before. You can reset his     |");
            Console.WriteLine("|  network settings by completing the following puzzle.                    |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Puzzle3();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| English Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                               _ < No way, it's fixed! |              |");
            Console.WriteLine("|  |_|                             |_| \\____________________|              |");
            Console.WriteLine("|  /|\\                            _/|\\                                     |");
            Console.WriteLine("|  / \\                             / \\                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  These tasks are taking so much time! You really hope you can get this   |");
            Console.WriteLine("|  done soon. You're really getting stressed about all this.               |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            if (levels.Count == 0)
            {
                Conclusion();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" __________________________________________________________________________ ");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("| English Department                                                       |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  Which department would you like to go to next?                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  1 Math                                                                  |");
                Console.WriteLine("|  2 Science                                                               |");
                Console.WriteLine("|  3 English                                                               |");
                Console.WriteLine("|  4 History                                                               |");
                Console.WriteLine("|  5 World Language                                                        |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                  SELECT ONE AND PRESS START TO CONTINUE                  |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("                                                                            ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the corresponding number and 'Enter' to continue:");
                choice = ScanInt();

                bool valid = false;
                for (int i = 0; i < levels.Count; i++)
                {
                    if ((int)(levels[i]) == choice)
                    {
                        Console.WriteLine("Loading...");
                        levels.Remove(levels[i]);
                        LevelSwitcher(choice, levels);
                        valid = true;
                        i = 10;
                    }
                }
                if (valid == false)
                {
                    Console.WriteLine("That level does not exist or has already been played. Level " + (int)(levels[0]) + " selected.");
                    Console.WriteLine("Loading...");
                    choice = (int)(levels[0]);
                    levels.Remove(levels[0]);
                    LevelSwitcher(choice, levels);
                }
            }
        }

        // Puzzle 3
        private static void Puzzle3()
        {
            int answer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| English Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   __ __ __                                                               |");
            Console.WriteLine("|  |2_|__|7_|                                                              |");  //6
            Console.WriteLine("|  |__|1_|5_|                                                              |");  //4
            Console.WriteLine("|  |9_|8_|__|                                                              |");  //3
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  In this box, numbers one through nine must be present. Also, in each    |");
            Console.WriteLine("|  column, the sum of the numbers has to equal 15. Enter the missing       |");
            Console.WriteLine("|  numbers.                                                                |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|               ENTER YOUR ANSWER AND PRESS START TO CONTINUE              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter each missing number one at a time.Enter the missing numbers as they appear from left to right and 'Enter' to continue:");
            answer = ScanInt();

            if (answer == 4)
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("Enter the next number and 'Enter' to continue:");
                answer = ScanInt();
                if (answer == 6)
                {
                    Console.WriteLine("Loading...");
                    Console.WriteLine("Enter the next number and 'Enter' to continue:");
                    answer = ScanInt();
                    if (answer == 3)
                    {
                        Console.WriteLine("Loading...");
                    }
                    else
                    {
                        Console.WriteLine("Try again...");
                        Puzzle3();
                    }
                }
                else
                {
                    Console.WriteLine("Try again...");
                    Puzzle3();
                }
            }
            else
            {
                Console.WriteLine("Try again...");
                Puzzle3();
            }
        }

        // Level 4
        private static void Level4(ArrayList levels)
        {
            int choice;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| History Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                  ___     ___             ___     ___                 |");
            Console.WriteLine("|  |_|                |   |   |   |           |   |   |  /|                |");
            Console.WriteLine("|  /|\\                |  o|   |o  |           |  o|   | | |                |");
            Console.WriteLine("|  / \\                |___|   |___|           |___|   |_|o|                |");
            Console.WriteLine("|                                                        |/                |");
            Console.WriteLine("|  For this task, Bryce wants you to help Mr. Thomison set up his first    |");
            Console.WriteLine("|  smartphone. This could be a while. Hopefully he's already had           |");
            Console.WriteLine("|  experience with Android. You need to submit this paper quick.           |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| History Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                               _ < So, you're gonna set this up? |    |");
            Console.WriteLine("|  |_|                             |_| \\______________________________|    |");
            Console.WriteLine("|  /|\\                            _/|\\                                     |");
            Console.WriteLine("|  / \\                             / \\                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  You just remembered there's a very detailed guide to settings up his    |");
            Console.WriteLine("|  phone online. To print it out for him, you have to answer this piece    |");
            Console.WriteLine("|  of trivia.                                                              |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Puzzle4();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| History Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                               _ < Oh sweet. Thanks a ton. |          |");
            Console.WriteLine("|  |_|                             |_| \\________________________|          |");
            Console.WriteLine("|  /|\\                            _/|\\                                     |");
            Console.WriteLine("|  / \\                             / \\                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  That's done. Okay, okay. You're getting there. You have to get that     |");
            Console.WriteLine("|  password. Please just let it be quick.                                  |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            if (levels.Count == 0)
            {
                Conclusion();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" __________________________________________________________________________ ");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("| History Department                                                       |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  Which department would you like to go to next?                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  1 Math                                                                  |");
                Console.WriteLine("|  2 Science                                                               |");
                Console.WriteLine("|  3 English                                                               |");
                Console.WriteLine("|  4 History                                                               |");
                Console.WriteLine("|  5 World Language                                                        |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                  SELECT ONE AND PRESS START TO CONTINUE                  |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("                                                                            ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the corresponding number and 'Enter' to continue:");
                choice = ScanInt();

                bool valid = false;
                for (int i = 0; i < levels.Count; i++)
                {
                    if ((int)(levels[i]) == choice)
                    {
                        Console.WriteLine("Loading...");
                        levels.Remove(levels[i]);
                        LevelSwitcher(choice, levels);
                        valid = true;
                        i = 10;
                    }
                }
                if (valid == false)
                {
                    Console.WriteLine("That level does not exist or has already been played. Level " + (int)(levels[0]) + " selected.");
                    Console.WriteLine("Loading...");
                    choice = (int)(levels[0]);
                    levels.Remove(levels[0]);
                    LevelSwitcher(choice, levels);
                }
            }
        }

        // Puzzle 4
        private static void Puzzle4()
        {
            string answer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| History Department                                                       |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  What is the last name of the first president of the United States?      |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|               ENTER YOUR ANSWER AND PRESS START TO CONTINUE              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the correct answer and 'Enter' to continue:");
            answer = Scan();

            if (answer.ToLower() == "washington")
            {
                Console.WriteLine("Loading...");
            }
            else
            {
                Console.WriteLine("Try again...");
                Puzzle4();
            }
        }

        // Level 5
        private static void Level5(ArrayList levels)
        {
            int choice;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| World Language Department                                                |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                  ___                                                 |");
            Console.WriteLine("|  |_|                |  /|     _\\                                         |");
            Console.WriteLine("|  /|\\                | | |   |__|                                         |");
            Console.WriteLine("|  / \\                |_|o|                                                |");
            Console.WriteLine("|                       |/                                                 |");
            Console.WriteLine("|  Now, Bryce has asked that you help Mrs. Dubel set up a game of          |");
            Console.WriteLine("|  jeopardy for her class. Depending on how far along she is, this could   |");
            Console.WriteLine("|  end up being a lot of work.                                             |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| World Language Department                                                |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                               _ < I can't get the buzzers to sync. | |");
            Console.WriteLine("|  |_|                             |_| \\_________________________________| |");
            Console.WriteLine("|  /|\\                            o/|\\                                     |");
            Console.WriteLine("|  / \\                             / \\                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Okay cool. Syncing these should be fairly easy. Let's see. Ah! I just   |");
            Console.WriteLine("|  have to complete this quiz and then they'll be synced up.               |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Puzzle5();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| World Language Department                                                |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|   _                               _ < Thanks. That was a huge help. |    |");
            Console.WriteLine("|  |_|                             |_| \\______________________________|    |");
            Console.WriteLine("|  /|\\                            o/|\\                                     |");
            Console.WriteLine("|  / \\                             / \\                                     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  Nice! These tasks are looking pretty easy. I might get the password in  |");
            Console.WriteLine("|  time. It would be so great if I could get this paper turned in.         |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            if (levels.Count == 0)
            {
                Conclusion();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" __________________________________________________________________________ ");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("| World Language Department                                                |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  Which department would you like to go to next?                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|  1 Math                                                                  |");
                Console.WriteLine("|  2 Science                                                               |");
                Console.WriteLine("|  3 English                                                               |");
                Console.WriteLine("|  4 History                                                               |");
                Console.WriteLine("|  5 World Language                                                        |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                                                                          |");
                Console.WriteLine("|                  SELECT ONE AND PRESS START TO CONTINUE                  |");
                Console.WriteLine("|__________________________________________________________________________|");
                Console.WriteLine("                                                                            ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter the corresponding number and 'Enter' to continue:");
                choice = ScanInt();

                bool valid = false;
                for (int i = 0; i < levels.Count; i++)
                {
                    if ((int)(levels[i]) == choice)
                    {
                        Console.WriteLine("Loading...");
                        levels.Remove(levels[i]);
                        LevelSwitcher(choice, levels);
                        valid = true;
                        i = 10;
                    }
                }
                if (valid == false)
                {
                    Console.WriteLine("That level does not exist or has already been played. Level " + (int)(levels[0]) + " selected.");
                    Console.WriteLine("Loading...");
                    choice = (int)(levels[0]);
                    levels.Remove(levels[0]);
                    LevelSwitcher(choice, levels);
                }
            }
        }

        // Puzzle 5
        private static void Puzzle5()
        {
            string answer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| World Language Department                                                |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|      ENGLISH                                                SPANISH      |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|      Yes                                                    Sí           |");
            Console.WriteLine("|                                                             ¯¯¯¯¯¯¯      |");
            Console.WriteLine("|      No                                                     No           |");
            Console.WriteLine("|                                                             ¯¯¯¯¯¯¯      |");
            Console.WriteLine("|      Hello                                                               |");
            Console.WriteLine("|                                                             ¯¯¯¯¯¯¯      |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|               ENTER YOUR ANSWER AND PRESS START TO CONTINUE              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the correct answer and 'Enter' to continue:");
            answer = Scan();

            if (answer.ToLower() == "hola")
            {
                Console.WriteLine("Loading...");
            }
            else
            {
                Console.WriteLine("Try again...");
                Puzzle5();
            }
        }

        // Conclusion
        private static void Conclusion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| The Library                                                              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|      ______________________________      |Okay, here's the key. > _      |");
            Console.WriteLine("|   _ < Bryce! I finished the tasks! |     |_____________________/ |_|     |");
            Console.WriteLine("|  |_| \\_____________________________|                             /|\\     |");
            Console.WriteLine("|  /|\\                                                              |      |");
            Console.WriteLine("|  / \\                                                             / \\     |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  You got the key! GO GO GO! Get to a laptop and turn that paper in.      |");
            Console.WriteLine("|  It's 3:24. Come on. Come on. You're so close.                           |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                          PRESS START TO CONTINUE                         |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| The Library                                                              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|        __________________________________________________________        |");
            Console.WriteLine("|       |      ______________________________________________      |       |");
            Console.WriteLine("|       |     |                                              |     |       |");
            Console.WriteLine("|       |     |                   FAC-STAFF                  |     |       |");
            Console.WriteLine("|       |     |                                              |     |       |");
            Console.WriteLine("|       |     |  Password: ***************                   |     |       |");
            Console.WriteLine("|       |     |______________________________________________|     |       |");
            Console.WriteLine("|       |                                                          |       |");
            Console.WriteLine("|       |__________________________________________________________|       |");
            Console.WriteLine("|      /                                                            \\      |");
            Console.WriteLine("|     /                                                              \\     |");
            Console.WriteLine("|    /                     PRESS START TO CONTINUE                    \\    |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| The Library                                                              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|        __________________________________________________________        |");
            Console.WriteLine("|       |      ______________________________________________      |       |");
            Console.WriteLine("|       |     |                                              |     |       |");
            Console.WriteLine("|       |     |        ____________________________   |\\     |     |       |");
            Console.WriteLine("|       |     |       |           SUBMIT           |   T     |     |       |");
            Console.WriteLine("|       |     |        ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯          |     |       |");
            Console.WriteLine("|       |     |______________________________________________|     |       |");
            Console.WriteLine("|       |                                                          |       |");
            Console.WriteLine("|       |__________________________________________________________|       |");
            Console.WriteLine("|      /                                                            \\      |");
            Console.WriteLine("|     /                                                              \\     |");
            Console.WriteLine("|    /                     PRESS START TO CONTINUE                    \\    |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press 'Enter' to continue:");
            Console.ReadKey();
            Console.WriteLine("Loading...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __________________________________________________________________________ ");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("| The Library                                                              |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|  YOU FINISHED THE GAME. CONGRATS!                                        |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                                                          |");
            Console.WriteLine("|                                  THE END                                 |");
            Console.WriteLine("|__________________________________________________________________________|");
            Console.WriteLine("                                                                            ");
        }

        // Music
        public static void Music()
        {
            SoundPlayer whatever = new SoundPlayer(Properties.Resource.bg);
            while(true)
            {
                whatever.Play();
                Thread.Sleep(4500);
            }
        }

        // Scanners
        static string Scan()
        {
            return Console.ReadLine();
        }

        static int ScanInt()
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                return 0;
            }
        }
    }
}
