using System;
using System.Collections.Generic;

namespace filwords
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var menuItems = new List<string>
            {
                "Новая игра",
                "Продолжить",
                "Рейтинг",
                "Выход"
            };

            Console.CursorVisible = false;
            while (true)
            {
                var selectedMenuItem = Print.Menu(menuItems);

                if (selectedMenuItem == "Новая игра")
                {
                    
                }
                else if (selectedMenuItem == "Продолжить")
                {
                    
                }
                else if (selectedMenuItem == "Рейтинг")
                {
                    
                }
                else if (selectedMenuItem == "Выход")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}