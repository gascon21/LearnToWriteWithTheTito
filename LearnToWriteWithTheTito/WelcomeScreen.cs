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
        private int course;
        private int level;
        private int exercise;
        bool finish = false;
        List<string> exercises = new List<string>();

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int level)
        {
            this.level = level;
        }

        public int GetCourse()
        {
            return course;
        }

        public void SetCourse(int course)
        {
            this.course = course;
        }

        public int GetExercise()
        {
            return exercise;
        }

        public void SetExercise(int exercise)
        {
            this.exercise = exercise;
        }

        public bool GetFinish()
        {
            return finish;
        }

        public void SetFinish(bool finish)
        {
            this.finish = finish;
        }

        public void ListOfExercises()
        {
            if (exercises.Count == 0)
            {
                DirectoryInfo dir = new DirectoryInfo(".");
                FileInfo[] file = dir.GetFiles();
                for (int i = 0; i < file.Length; i++)
                {
                    if (file[i].FullName.Substring(file[i].FullName.Length - 5)
                        == ".meca")
                    {
                        exercises.Add(file[i].FullName.Substring(
                                file[i].FullName.Length - 11, 6));
                    }
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
                Console.SetCursorPosition(90, 27 + yExercises);
                Console.WriteLine("Course: " + exercises[i].Substring(0, 2)
                    + " Level: " + exercises[i].Substring(2, 2)
                    + " Exercise: " + exercises[i].Substring(4));
            }
        }

        public void CheckKey()
        {
            int lastCourse = 2;
            int lastLevel = 3;
            int lastExercice = 10;
            int startExercice = 0;
            int pos = 0;
            course = 1;
            level = 1;
            exercise = 1;
            int yArrow = 0;
            ConsoleKeyInfo key;
            bool enterKeyOrEsc = false;
            ShowExercises(startExercice);
            do
            {
                Console.SetCursorPosition(87, 27 + yArrow);
                Console.Write("->");
                Thread.Sleep(15);
                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        pos--;
                        if (pos >= 0)
                        {
                            Console.SetCursorPosition(87, 27 + yArrow);
                            Console.Write("  ");
                            
                            if(yArrow > 0)
                            {
                                yArrow--;
                                exercise--;
                                if (exercise < 1 )
                                {
                                    exercise = lastExercice;
                                    level--;
                                    if (level < 1)
                                    {
                                        level = lastLevel;
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
                                    exercise = lastExercice;
                                    level--;
                                    if (level < 1)
                                    {
                                        level = lastLevel;
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
                        pos++;
                        if (pos < exercises.Count)
                        {
                            Console.SetCursorPosition(87, 27 + yArrow);
                            Console.Write("  ");
                            
                            if (yArrow < 9)
                            {
                                yArrow++;
                                exercise++;

                                if (exercise > lastExercice) 
                                {
                                    exercise = 1;
                                    level++;

                                    if (level > lastLevel) 
                                    {
                                        level = 1;
                                        course++;
                                        if (course > lastCourse)
                                        {
                                            course = lastCourse;
                                        }
                                    }
                                }
                            }
                            else if (pos >= startExercice + 10)
                            {
                                startExercice++;
                                ShowExercises(startExercice);

                                exercise++;

                                if (exercise > lastExercice) 
                                {
                                    exercise = 1;
                                    level++;

                                    if (level > lastLevel) 
                                    {
                                        level = 1;
                                        course++;
                                        if (course > lastCourse)
                                        {
                                            course = lastCourse;
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
                        enterKeyOrEsc = true;
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        finish = true;
                        enterKeyOrEsc = true;
                    }
                }
            } while (!enterKeyOrEsc && !finish);
        }

        public void Draw()
        {
            int xOutMessage = 30;
            int yOutMessage = 31;

            Console.Clear();
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(xOutMessage, yOutMessage);
            Console.WriteLine("Pres ESC to exit");
            Console.SetCursorPosition(xOutMessage, yOutMessage + 1);
            Console.WriteLine("Use the arrow keys to move through the exercises");
            Console.SetCursorPosition(xOutMessage, yOutMessage + 2);
            Console.WriteLine("Press Enter to start with the selected exercise");
            Console.ForegroundColor = ConsoleColor.Gray;


            /*
            Console.SetCursorPosition(58, 30);
            Console.WriteLine("To begin you have to press \"ENTER\"");
            Console.SetCursorPosition(59, 31);
            Console.WriteLine("To exit you have to press \"ESC\"");
            */
            ListOfExercises();
            CheckKey();
        }
    }
}
