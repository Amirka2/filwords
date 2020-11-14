using System;
using System.Collections.Generic;

namespace filwords
{
    internal class Program
    {
        private static int index = 0;

        static void Choose(int index)
        {
            if (index == 0)
                NewGame();
            else if (index == 1)
                ContinueGame();
            else if (index == 2)
                HighScoreTable();
            else if (index == 3)
                Environment.Exit(0);
        }
        static void NewGame()
        {
            Console.Clear();
            Console.WriteLine("Однажды здесь будет новая игра");
            //Print.NewGame();
        }

        static void ContinueGame()
        {
            Console.Clear();
            Console.WriteLine("Однажды здесь будет продолжение текущей игры");
            //Print.ContinueGame();
        }

        static void HighScoreTable()
        {
            Console.Clear();
            Console.WriteLine("Однажды здесь будет таблица рекордов");
            //Print.HighScoreTable();
        }
        public static void Main(string[] args)
        {
            var menuItems = new List<Button> { };
            
            menuItems.Add(new Button("Новая игра"));
            menuItems.Add(new Button("Продолжить игру"));
            menuItems.Add(new Button("Таблица рекордов"));
            menuItems.Add(new Button("Выход"));
            
            Console.CursorVisible = false;
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            do
            {
                if (key.Key == ConsoleKey.UpArrow) 
                    index--;
                else if (key.Key == ConsoleKey.DownArrow) 
                    index++;
                
                if (index == menuItems.Count)
                    index = 0;
                else if (index < 0)
                    index = menuItems.Count - 1;

                menuItems[index].isChosen = true;
                Print.Menu(menuItems);
                key = Console.ReadKey();
                menuItems[index].isChosen = false;
            } while (key.Key != ConsoleKey.Enter);

            Choose(index);
        }
    }
}