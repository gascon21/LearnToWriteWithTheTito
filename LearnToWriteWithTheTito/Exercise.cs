using System.Collections.Generic;

namespace LearnToWriteWithTheTito
{
    class Exercise
    {
        private byte course;
        private byte level;
        private byte exercise;
        private string comment;
        private string time;
        private string speed;
        private string text;

        public int GetCourse()
        {
            return course;
        }
        public void SetCourse(int course)
        {
            this.course = (byte)course;
        }
        public int GetLevel()
        {
            return level;
        }
        public void SetLevel(int level)
        {
            this.level = (byte)level;
        }
        public int GetExercise()
        {
            return exercise;
        }
        public void SetExercise(int exercise)
        {
            this.exercise = (byte)exercise;
        }
        public string GetComment()
        {
            return comment;
        }
        public void SetComment(string comment)
        {
            this.comment = comment;
        }
        public string GetTime()
        {
            return time;
        }
        public void SetTime(string time)
        {
            this.time = time;
        }
        public string GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(string speed)
        {
            this.speed = speed;
        }
        public List<string> GetText()
        {
            List<string> newText = new List<string>();
            newText.Add(text);
            return newText;
        }
        public void SetText(List<string> newText)
        {
            text = newText[0];
        }
    }
}
