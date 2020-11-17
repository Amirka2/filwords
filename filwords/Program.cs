using System;
using System.Collections.Generic;

namespace filwords
{
    internal class Program
    {
        private static int index = 0;

        static void ChooseMenuItem(int index)
        {
            if (index == 0)
                CreateNewGame();
            else if (index == 1)
                ContinueGame();
            else if (index == 2)
                OpenHighScoreTable();
            else if (index == 3)
            {
                Console.Clear();
                Environment.Exit(0);
            }        
        }
        static void CreateNewGame()
        {
            Console.Clear();
            Console.WriteLine("Однажды здесь будет новая игра");
            //Output.PrintNewGame();
        }

        static void ContinueGame()
        {
            Console.Clear();
            Console.WriteLine("Однажды здесь будет продолжение текущей игры");
            //Output.PrintContinueGame();
        }

        static void OpenHighScoreTable()
        {
            Console.Clear();
            Console.WriteLine("Однажды здесь будет таблица рекордов");
            //Output.PrintHighScoreTable();
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
                Output.PrintMenu(menuItems);
                key = Console.ReadKey();
                menuItems[index].isChosen = false;
            } while (key.Key != ConsoleKey.Enter);

            ChooseMenuItem(index);
        }
    }
}