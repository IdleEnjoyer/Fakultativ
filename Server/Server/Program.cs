using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot ConsoleBot = new Bot();
            System.Console.WriteLine("Сделайте запрос или задайте вопрос боту :)\nВведите \"Помоги\" для вывода всех команд");
            bool Exit = false;
            while (!Exit)
            {
                string n = System.Console.ReadLine();
                switch (n){
                    case "Выход":
                        {
                            System.Console.WriteLine("Выход из программы...");
                            ConsoleBot.WriteToLog(n, "Выход из программы...");
                            Exit = true;
                        }
                        break;
                    case "Как тебя зовут?":
                        {
                            System.Console.WriteLine(ConsoleBot.GetName());
                            ConsoleBot.WriteToLog(n, ConsoleBot.GetName());
                        }
                        break;
                    case "Сколько сейчас времени?":
                        {
                            System.Console.WriteLine(ConsoleBot.GetTime());
                            ConsoleBot.WriteToLog(n, ConsoleBot.GetTime());
                        }
                        break;
                    case "Сколько ты работаешь?":
                        {
                            System.Console.WriteLine(ConsoleBot.GetWorkTime());
                            ConsoleBot.WriteToLog(n, ConsoleBot.GetWorkTime());
                        }
                        break;
                    case "Покажи нашу переписку":
                        {
                            ConsoleBot.WriteToLog(n, "Вывод Истории Переписки...");
                            ConsoleBot.ReadFromLog();
                        }
                        break;
                    case "Очисти экран":
                        {
                            System.Console.Clear();
                            System.Console.WriteLine("Очищен Экран\n");
                            ConsoleBot.WriteToLog(n, "Очищен Экран");
                        }
                        break;
                    case "Как у тебя дела?":
                        {
                            string Output = "Мне " + ConsoleBot.BotMood();
                            System.Console.WriteLine(Output);
                            ConsoleBot.WriteToLog(n, Output);
                        }
                        break;
                    case "Помоги":
                        {
                            System.Console.WriteLine("Как тебя зовут?\nСколько сейчас времени?\nСколько ты работаешь?\nПокажи нашу переписку\nОчисти экран\nКак у тебя дела?\n");
                            ConsoleBot.WriteToLog(n, "Вывод всех команд");
                        }
                        break;
                    default:
                        {
                            System.Console.WriteLine("Неправильный ввод...");
                            ConsoleBot.WriteToLog(n, "Неправильный ввод...");
                        }
                        break;
                }
            }
        }
    }
}
