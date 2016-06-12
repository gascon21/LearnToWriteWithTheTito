using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace LearnToWriteWithTheTito
{
    class TextWriting
    {
        private bool finishCheck;
        private DateTime origin;
        private Mark marks;
        private Element element;
        private Exercise exercises;
        private bool drawWelcome;
        private int course;
        private int level;
        private int exercise;
        private const int WIDTHSCREAN = 135;

        public TextWriting()
        {
            element = new Element();
            marks = new Mark();
            exercises = new Exercise();
        }
        

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

        public bool GetDrawWelcome()
        {
            return drawWelcome;
        }

        public void SetDrawWelcome(bool drawWelcome)
        {
            this.drawWelcome = drawWelcome;
        }

        /// <summary>
        /// Read  the only phrase that is in the file at the appropriate level,
        /// which has passed through a parameter
        /// </summary>
        /// <param name="level">Parameter indicating the level to be read</param>
        public void Read()
        {
            string fileName = course.ToString("00") + level.ToString("00")
                    + exercise.ToString("00") + ".meca";
            if (File.Exists(fileName))
            {
                try
                {
                    StreamReader input = File.OpenText(fileName);
                    List<string> text = new List<string>();
                    string line;

                    line = input.ReadLine();
                    exercises.SetCourse(Convert.ToInt32(line));

                    line = input.ReadLine();
                    exercises.SetLevel(Convert.ToInt32(line));

                    line = input.ReadLine();
                    exercises.SetExercise(Convert.ToInt32(line));

                    line = input.ReadLine();
                    exercises.SetComment(line);

                    line = input.ReadLine();
                    exercises.SetTime(line);

                    line = input.ReadLine();
                    exercises.SetSpeed(line);

                    /*do
                    {
                        line = input.ReadLine();
                        if (line != null)
                        {
                            text.Add(line);
                        }
                    } while (line != null);*/

                    line = input.ReadLine();
                    text.Add(line);
                    exercises.SetText(text);
                    input.Close();
                }
                catch (PathTooLongException)
                {
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("Path too long");
                }
                catch (IOException)
                {
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("Could not read the file");
                }
                catch (Exception ex)
                {
                    Console.SetCursorPosition(15, 5);
                    Console.WriteLine("An error has occurred: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File not exist");
            }
        }

        /// <summary>
        /// This function places the cursor coordinates x and y and write the 
        /// corresponding phrase at the level
        /// </summary>
        /// <param name="level">Parameter indicating the level to be write</param>
        public void Write()
        {
            int xText = 5;
            int yText = 1;
            Read();
            Console.SetCursorPosition(xText, yText);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Course: " + exercises.GetCourse() +
                    " Level: " + exercises.GetLevel() + " Exercise: " +
                    exercises.GetExercise() + " " + exercises.GetComment());
            Console.ForegroundColor = ConsoleColor.Gray;
            yText ++;
            Console.SetCursorPosition(xText, yText);

            for (int i = 0; i < exercises.GetText()[0].Length; i ++)
            {
                if((i % WIDTHSCREAN == 0) && (i > 0))
                {
                    yText ++;
                    Console.SetCursorPosition(xText, yText);
                }
                Console.Write(exercises.GetText()[0][i]);
            }
        }

        /// <summary>
        /// This function places the cursor coordinates x and y and is 
        /// writing it typed by the user while checking failures
        /// </summary>
        /// <param name="level">Parameter indicating the level to be check</param>
        public void Check()
        {
            marks.SetCourse(course);
            marks.SetLevel(level);
            bool lastCourseLevelExercice = false;
            const int LASTCOURSE = 2;
            const int LASTLEVEL = 3;
            const int LASTEXERCISE = 10;
            origin = DateTime.Now;
            element.SetOrigin(origin);
            int xWrite = 5;
            int yWrite = 9;
            finishCheck = false;
            bool enterKey = false;
            int yArrow = 0;
            int xOutMessage = 65;
            int yOutMessage = 35;
            int mistakes = 0;
            int currentPos = 0;
            int totalPulsations = 0;
            //int currentWord = 0;
            //int currentPosInWord = 0;
            //string[] words = exercises[0].GetText()[0].Split(' ');
            int posX = 0;
            //bool finish;

            Console.SetCursorPosition(xWrite, yWrite);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Writed text(Green correct, red mistake)");
            Console.SetCursorPosition(xOutMessage, yOutMessage);
            Console.WriteLine("Pres esc to return to the welcome screen");
            Console.ForegroundColor = ConsoleColor.Gray;

            yWrite += 1;
            while (!finishCheck)
            {
                //finish = false;
                DateTime current = DateTime.Now;

                element.SetMistakes(mistakes);
                element.SetTotalPulsations(totalPulsations);
                element.SetCurrent(current);

                element.Menu();

                marks.Hand(exercises.GetText()[0][currentPos], false);
                marks.KeyBoard(exercises.GetText()[0][currentPos], false);

                Thread.Sleep(20);
                if (Console.KeyAvailable)
                {
                    Console.SetCursorPosition(xWrite + posX, yWrite);
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key != ConsoleKey.Escape)
                    {
                        totalPulsations++;
                        if (key.KeyChar != exercises.GetText()[0][currentPos])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(key.KeyChar);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            mistakes++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(key.KeyChar);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                        marks.Hand(exercises.GetText()[0][currentPos], true);
                        marks.KeyBoard(exercises.GetText()[0][currentPos], true);

                        posX++;
                        currentPos++;

                        // Reflects the value of the key, check it and if it is
                        // right printed with green, if the letter is incorrect
                        // printed in red
                        if ((currentPos % WIDTHSCREAN == 0) && (currentPos > 0))
                        {
                            yWrite += 1;
                            posX = 0;
                            Console.SetCursorPosition(xWrite, yWrite);
                        }

                        // Check if you typed is correct or not, if it is passed 
                        // to the next level, if not asking you to try again
                        // lack of level rise
                        if (currentPos == exercises.GetText()[0].Length)
                        {
                            finishCheck = true;
                            
                            if (mistakes != 0)
                            {
                                Console.SetCursorPosition(xWrite, yWrite + 3);
                                Console.WriteLine("Wrong answer");
                                Console.SetCursorPosition(xWrite, yWrite + 4);
                                Console.WriteLine("Back to welcome screen");
                                Console.SetCursorPosition(xWrite, yWrite + 5);
                                Console.WriteLine("Repeat the exercise");

                                do
                                {
                                    Console.SetCursorPosition(xWrite - 3, yWrite
                                            + 4 + yArrow);
                                    Console.Write("->");
                                    Thread.Sleep(15);

                                    if (Console.KeyAvailable)
                                    {
                                        key = Console.ReadKey(true);
                                        if (key.Key == ConsoleKey.UpArrow)
                                        {
                                            Console.SetCursorPosition(xWrite - 3,
                                                        yWrite + 4 + yArrow);
                                            Console.Write("  ");
                                            if (yArrow > 0)
                                            {
                                                yArrow--;
                                            }
                                        }
                                        if (key.Key == ConsoleKey.DownArrow)
                                        {
                                            Console.SetCursorPosition(xWrite - 3,
                                                        yWrite + 4 + yArrow);
                                            Console.Write("  ");
                                            if (yArrow < 1)
                                            {
                                                yArrow++;
                                            }
                                        }
                                    }
                                    else if (key.Key == ConsoleKey.Enter)
                                    {
                                        enterKey = true;
                                        if(yArrow == 0)
                                            drawWelcome = true;
                                    }
                                } while (!enterKey);

                                Console.WriteLine();
                            }
                            else
                            {
                                Console.SetCursorPosition(xWrite, yWrite + 3);
                                Console.WriteLine("Correct!");
                                Console.SetCursorPosition(xWrite, yWrite + 4);
                                Console.WriteLine("Back to welcome screen");

                                if (LASTCOURSE == course && LASTLEVEL == level &&
                                        LASTEXERCISE == exercise)
                                    lastCourseLevelExercice = true;

                                if (!lastCourseLevelExercice)
                                {
                                    Console.SetCursorPosition(xWrite, yWrite + 5);
                                    Console.WriteLine("Go to the next exercise");
                                    Console.WriteLine();

                                    do
                                    {
                                        Console.SetCursorPosition(xWrite - 3, yWrite
                                                + 4 + yArrow);
                                        Console.Write("->");
                                        Thread.Sleep(15);

                                        if (Console.KeyAvailable)
                                        {
                                            key = Console.ReadKey(true);
                                            if (key.Key == ConsoleKey.UpArrow)
                                            {
                                                Console.SetCursorPosition(xWrite - 3,
                                                            yWrite + 4 + yArrow);
                                                Console.Write("  ");
                                                if (yArrow > 0)
                                                {
                                                    yArrow--;//todo
                                                }
                                            }
                                            else if (key.Key == ConsoleKey.DownArrow)
                                            {
                                                Console.SetCursorPosition(xWrite - 3,
                                                            yWrite + 4 + yArrow);
                                                Console.Write("  ");
                                                if (yArrow < 1)
                                                {
                                                    yArrow++;//todo
                                                }
                                            }
                                            else if (key.Key == ConsoleKey.Enter)
                                            {
                                                enterKey = true;
                                                if (yArrow == 0)
                                                    drawWelcome = true;
                                                else
                                                {
                                                    exercise++;

                                                    if (exercise > LASTEXERCISE)
                                                    {
                                                        exercise = 1;
                                                        level++;

                                                        if (level > LASTLEVEL)
                                                        {
                                                            level = 1;
                                                            course++;
                                                            if (course > LASTCOURSE)
                                                            {
                                                                course = LASTCOURSE;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } while (!enterKey);
                                }
                                else
                                {
                                    Console.SetCursorPosition(xWrite - 3, yWrite
                                                + 4 + yArrow);
                                    Console.Write("->");
                                    do
                                    {
                                        if (Console.KeyAvailable)
                                        {
                                        
                                            key = Console.ReadKey(true);
                                            if (key.Key == ConsoleKey.Enter)
                                            {
                                                enterKey = true;
                                                drawWelcome = true;
                                            }
                                        
                                        }
                                    } while (!enterKey);
                                }
                            }
                        }
                    }
                    else
                    {
                        finishCheck = true;
                        drawWelcome = true;
                    }
                }
            }
        }
    }
}
