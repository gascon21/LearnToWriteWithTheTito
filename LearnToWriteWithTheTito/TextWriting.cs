using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LearnToWriteWithTheTito
{
    class TextWriting
    {
        private bool finishCheck;
        private int xText;
        private int yText;
        private int xWrite;
        private int yWrite;
        private DateTime origin = DateTime.Now;
        private int[] originTime;
        private int[] currentTime;
        private List<string> phrases;
        private Element elementChrono;
        private List<Exercise> exercises;
        private Exercise exercise;

        public TextWriting()
        {
            xText = 5;
            yText = 1;
            xWrite = 5;
            yWrite = 9;
            finishCheck = false;
            originTime = new int[3];
            currentTime = new int[3];
            elementChrono = new Element();
            phrases = new List<string>();
            exercises = new List<Exercise>();
        }

        /// <summary>
        /// Read  the only phrase that is in the file at the appropriate level,
        /// which has passed through a parameter
        /// </summary>
        /// <param name="level">Parameter indicating the level to be read</param>
        public void Read(int level)
        {
            string fileName = "levels.txt";
            string[] phrase;
            bool firstLine = true;
            if (File.Exists(fileName))
            {
                try
                {
                    StreamReader input = File.OpenText(fileName);
                    string line;
                    do
                    {
                        line = input.ReadLine();
                        // The first line is the header and have to skip it
                        if (!firstLine)
                        {
                            if (line != null)
                            {
                                phrases.Add(line);
                            }
                        }
                        firstLine = false;
                    } while (line != null);
                    input.Close();
                    
                    List<string> text;
                    for (int i = 0 ; i < phrases.Count ; i ++)
                    {
                        exercise = new Exercise();
                        text = new List<string>();
                        phrase = phrases[i].Split(';');
                        exercise.SetCourse(Convert.ToInt32(phrase[0]));
                        exercise.SetLesson(Convert.ToInt32(phrase[1]));
                        exercise.SetExercise(Convert.ToInt32(phrase[2]));
                        exercise.SetComment(phrase[3]);
                        exercise.SetTime(phrase[4]);
                        exercise.SetSpeed(phrase[5]);
                        text.Add(phrase[6].Substring(1, phrase[6].Length - 2));
                        exercise.SetText(text);
                        exercises.Add(exercise);
                        
                    }
                    
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
        public void Write(int level)
        {
            Read(level);
            Console.SetCursorPosition(xText, yText);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Text to be writing");
            Console.ForegroundColor = ConsoleColor.Gray;
            yText += 1;
            Console.SetCursorPosition(xText, yText);

            for (int i = 0; i < exercises[0].GetText()[0].Length; i ++)
            {
                if((i % 135 == 0) && (i > 0))
                {
                    yText += 1;
                    Console.SetCursorPosition(xText, yText);
                }
                Console.Write(exercises[0].GetText()[0][i]);
            }
        }

        /// <summary>
        /// This function places the cursor coordinates x and y and is 
        /// writing it typed by the user while checking failures
        /// </summary>
        /// <param name="level">Parameter indicating the level to be check</param>
        public void Check(int level)
        {
            originTime[0] = origin.Hour;
            originTime[1] = origin.Minute;
            originTime[2] = origin.Second;
            int mistakes = 0;
            int currentPos = 0;
            //int currentWord = 0;
            //int currentPosInWord = 0;
            //string[] words = exercises[0].GetText()[0].Split(' ');
            int posX = 0;
            bool finish;

            Console.SetCursorPosition(xWrite, yWrite);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Writed text(Green correct, red mistake)");
            Console.ForegroundColor = ConsoleColor.Gray;
            yWrite += 1;
            while (!finishCheck)
            {
                finish = false;
                DateTime current = DateTime.Now;
                currentTime[0] = current.Hour;
                currentTime[1] = current.Minute;
                currentTime[2] = current.Second;
                elementChrono.Menu(originTime, currentTime);
                
                Thread.Sleep(15);
                if (Console.KeyAvailable)
                {
                    Console.SetCursorPosition(xWrite + posX, yWrite);
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.KeyChar != ' ')
                    {
                        if (key.KeyChar != exercises[0].GetText()[0][currentPos])
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
                    }
                    posX++;
                    currentPos++;

                    // Reflects the value of the key, check it and if it is
                    // right printed with green, if the letter is incorrect
                    // printed in red
                    if ((currentPos % 135 == 0) && (currentPos > 0))
                    {
                        yWrite += 1;
                        posX = 0;
                        Console.SetCursorPosition(xWrite, yWrite);
                    }
                }

                // Check if you typed is correct or not, if it is passed 
                // to the next level, if not asking you to try again
                // lack of level rise
                if (currentPos == exercises[0].GetText()[0].Length)
                {
                    if(mistakes != 0)
                    {
                        Console.SetCursorPosition(xWrite, yWrite + 4);
                        Console.WriteLine("Wrong answer");
                        Console.WriteLine();
                        finishCheck = true;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.SetCursorPosition(xWrite, yWrite + 4);
                        Console.WriteLine("Correct!");
                        Console.WriteLine();
                        level++;
                        finishCheck = true;
                        Thread.Sleep(2000);
                    }
                }
            }
        }
    }
}
