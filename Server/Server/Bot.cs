using System;
using System.IO;
using System.Collections.Generic;

namespace Server
{
    class Bot
    {
        private Random rand;
        private DateTime Time;
        private string Name;
        private Dictionary<int,string> Mood = new Dictionary<int, string>(10);
        private FileInfo Log = new FileInfo("log.txt");
        

        public Bot()
        {
            Name = "Дима Давыденко";
            Time = DateTime.Now;
            rand = new Random();
            Mood.Add(0, "Грустно");
            Mood.Add(1, "Приемлемо");
            Mood.Add(2, "Здорово");
            Mood.Add(3, "Хорошо");
            Mood.Add(4, "Мерзко");
            Mood.Add(5, "Злостно");
            Mood.Add(6, "Безразлично");
            Mood.Add(7, "Непонятно");
            Mood.Add(8, "Интересно");
            Mood.Add(9, "Стыдно");
            if (!Log.Exists)
            {
                Log.Create();
            }
        }

        public string GetName()
        {
            return Name;
        }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }

        public TimeSpan GetWorkTime()
        {
            return DateTime.Now - Time;
        }
        public void WriteToLog(string input, string Text)
        {
            using (StreamWriter fstream = new StreamWriter(Log.Name,true))
            {
                fstream.Write("Пользователь: {0}\n", input);
                fstream.Write("Бот: {0}\n", Text);
            }
            return;
        }
        public void WriteToLog(string input, DateTime Text)
        {
            using (StreamWriter fstream = new StreamWriter(Log.Name, true))
            {
                fstream.Write("Пользователь: {0}\n", input);
                fstream.Write("Бот: {0}\n", Text);
            }
            return;
        }
        public void WriteToLog(string input, TimeSpan Text)
        {
            using (StreamWriter fstream = new StreamWriter(Log.Name, true))
            {
                fstream.Write("Пользователь: {0}\n", input);
                fstream.Write("Бот: {0}\n", Text);
            }
            return;
        }
        public void ReadFromLog()
        {
            using (StreamReader fstream = new StreamReader(Log.Name))
            {
                while (!fstream.EndOfStream)
                {
                    System.Console.WriteLine(fstream.ReadLine(),"\n");
                }
            }
            return;
        }

        public string BotMood()
        {
            string response;
            int n = rand.Next(0, 9);
            response = Mood[n];
            return response;
        }
    }
}
