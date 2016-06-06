using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToWriteWithTheTito
{
    /// <summary>
    /// Class LearnToWriteWithTheTito implements the main 
    /// program.
    /// </summary>
    class LearnToWriteWithTheTito
    {
        private int level;
        private int course;
        private int exercise;
        private TextWriting textWriting;
        private Element elements;
        private WelcomeScreen welcomeScreen;

        public LearnToWriteWithTheTito()
        {
            textWriting = new TextWriting();
            elements = new Element();
            welcomeScreen = new WelcomeScreen();
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

        private void Run(LearnToWriteWithTheTito LearnToWrite)
        {
            welcomeScreen.Draw(LearnToWrite);
            elements.Draw();
            textWriting.Write(course, level, exercise);
            textWriting.Check(course, level, exercise);
            

        }

        static void Main(string[] args)
        {
            Console.WindowHeight = 39;
            Console.WindowWidth = 150;
            LearnToWriteWithTheTito LearnToWrite = new LearnToWriteWithTheTito();
            LearnToWrite.Run(LearnToWrite);
        }
    }
}
