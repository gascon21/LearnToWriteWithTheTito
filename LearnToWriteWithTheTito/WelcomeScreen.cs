using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class WellcomeScreen implements the
    /// start's program screen 
    /// </summary>
    class WelcomeScreen
    {
        List<string> exercises = new List<string>();
        public void ListOfExercises()
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            FileInfo[] file = dir.GetFiles();
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].FullName.Substring(file[i].FullName.Length - 5) ==
                        ".meca")
                {
                    exercises.Add(file[i].FullName.Substring(
                            file[i].FullName.Length - 11));
                }
            }
        }

        public void ShowExercises(int startExercice)
        {
            int lastExercise = startExercice + 10;
            int yExercises;

            for (int i = startExercice; i < lastExercise; i++)
            {
                yExercises = i - startExercice;
                Console.SetCursorPosition(110, 27 + yExercises);
                Console.WriteLine(exercises[i]);
            }
        }

        public void CheckKey(LearnToWriteWithTheTito LearnToWrite)
        {
            int startExercice = 0;
            int pos = 0;
            int course = 1;
            int level = 1;
            int exercise = 1;
            int yArrow = 0;
            ConsoleKeyInfo key;
            bool enterKey = false;
            ShowExercises(startExercice);
            do
            {
                Console.SetCursorPosition(107, 27 + yArrow);
                Console.Write("->");
                Thread.Sleep(15);
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        /*if (yArrow > 0)
                        {
                            Console.SetCursorPosition(107, 27 + yArrow);
                            Console.Write("  ");
                            yArrow--;

                            exercise--;
                            if(exercise < 1)
                            {
                                exercise = 1;
                                level--;
                                if(level < 1)
                                {
                                    level = 1;
                                    course--;
                                }
                            }
                        }*/
                        pos--;
                        if (pos >= 0)
                        {
                            Console.SetCursorPosition(107, 27 + yArrow);
                            Console.Write("  ");
                            
                            if(yArrow > 0)
                            {
                                yArrow--;
                                exercise--;
                                if (exercise < 1 )
                                {
                                    exercise = 3;
                                    level--;
                                    if (level < 1)
                                    {
                                        level = 2;
                                        course--;
                                        if (course < 1)
                                        {
                                            course = 1;
                                        }
                                    }
                                }
                            }
                            else if (pos <= startExercice)
                            {
                                yArrow = 0;
                                startExercice--;
                                ShowExercises(startExercice);

                                exercise--;
                                if (exercise < 1)
                                {
                                    exercise = 1;
                                    level--;
                                    if (level < 1)
                                    {
                                        level = 1;
                                        course--;
                                        if (course < 1)
                                        {
                                            course = 1;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            pos++;
                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        /*if (yArrow < 9)
                        {
                            Console.SetCursorPosition(107, 27 + yArrow);
                            Console.Write("  ");
                            yArrow++;

                            exercise++;
                            if (exercise > 3) // Greater than 3 because there are only 3 exercises per level
                            {
                                exercise = 1;
                                level++;
                                if (level > 2) // Greater than 2 because there are only 2 levels per course
                                {
                                    level = 1;
                                    course++;
                                }
                            }
                        }*/

                        pos++;
                        if (pos < exercises.Count)
                        {
                            Console.SetCursorPosition(107, 27 + yArrow);
                            Console.Write("  ");
                            
                            if (yArrow < 9)
                            {
                                yArrow++;
                                exercise++;
                                if (exercise > 3) // Greater than 3 because there are only 3 exercises per level
                                {
                                    exercise = 1;
                                    level++;
                                    if (level > 2) // Greater than 2 because there are only 2 levels per course
                                    {
                                        level = 1;
                                        course++;
                                        if (course > 2)
                                        {
                                            course = 2;
                                        }
                                    }
                                }
                            }
                            else if (pos >= startExercice + 10)
                            {
                                startExercice++;
                                ShowExercises(startExercice);

                                exercise++;
                                if (exercise > 3) // Greater than 3 because there are only 3 exercises per level
                                {
                                    exercise = 1;
                                    level++;
                                    if (level > 2) // Greater than 2 because there are only 2 levels per course
                                    {
                                        level = 1;
                                        course++;
                                        if (course > 2)
                                        {
                                            course = 2;
                                        }
                                    }
                                }
                            }
                            
                        }
                        else
                        {
                            pos--;
                        } 
                        
                    }
                    else if(key.Key == ConsoleKey.Enter)
                    {
                        enterKey = true;
                        LearnToWrite.SetCourse(course);
                        LearnToWrite.SetLevel(level);
                        LearnToWrite.SetExercise(exercise);
                    }
                }
            } while (!enterKey);
        }

        public void Draw(LearnToWriteWithTheTito LearnToWrite)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("                                   _        ______        __       ____    __    _          _________     _____     ");
            Console.WriteLine("                                  | |      |  ____|      /  \\     |  _ \\  |  \\  | |        |___   ___|   /  _  \\    ");
            Console.WriteLine("                                  | |      | |__        / /\\ \\    | |_\\ \\ | . \\ | |            | |      /  / \\  \\   ");
            Console.WriteLine("                                  | |      |  __|      / /__\\ \\   |  ___/ | |\\ \\| |            | |     |  |   |  |  ");
            Console.WriteLine("                                  | |____  | |_____   / /____\\ \\  | |\\ \\  | | \\ ' |            | |      \\  \\_/  /   ");
            Console.WriteLine("                                  |______| |_______| /_/      \\_\\ |_| \\_\\ |_|  \\__|            |_|       \\_____/    ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   __                 __  ____    _   _________   ______          __                 __  _   _________   _     _   ");
            Console.WriteLine("                   \\ \\      ___      / / |  _ \\  | | |___   ___| |  ____|         \\ \\      ___      / / | | |___   ___| | |   | |  ");
            Console.WriteLine("                    \\ \\    / _ \\    / /  | |_\\ \\ | |     | |     | |__             \\ \\    / _ \\    / /  | |     | |     | |___| |  ");
            Console.WriteLine("                     \\ \\  / / \\ \\  / /   |  ___/ | |     | |     |  __|             \\ \\  / / \\ \\  / /   | |     | |     |  ___  |  ");
            Console.WriteLine("                      \\ \\/ /   \\ \\/ /    | |\\ \\  | |     | |     | |_____            \\ \\/ /   \\ \\/ /    | |     | |     | |   | |  ");
            Console.WriteLine("                       \\__/     \\__/     |_| \\_\\ |_|     |_|     |_______|            \\__/     \\__/     |_|     |_|     |_|   |_|  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                               _________   _     _   ______           _________   _   _________     _____     _   _   _   ");
            Console.WriteLine("                              |___   ___| | |   | | |  ____|         |___   ___| | | |___   ___|   /  _  \\   | | | | | |  ");
            Console.WriteLine("                                  | |     | |___| | | |__                | |     | |     | |      /  / \\  \\  | | | | | |  ");
            Console.WriteLine("                                  | |     |  ___  | |  __|               | |     | |     | |     |  |   |  | | | | | | |  ");
            Console.WriteLine("                                  | |     | |   | | | |_____             | |     | |     | |      \\  \\_/  /  |_| |_| |_|  ");
            Console.WriteLine("                                  |_|     |_|   |_| |_______|            |_|     |_|     |_|       \\_____/    _   _   _   ");
            Console.WriteLine("                                                                                                             |_| |_| |_|  ");

            /*
            Console.SetCursorPosition(58, 30);
            Console.WriteLine("To begin you have to press \"ENTER\"");
            Console.SetCursorPosition(59, 31);
            Console.WriteLine("To exit you have to press \"ESC\"");
            */
            ListOfExercises();
            CheckKey(LearnToWrite);
        }
        


    }
}
