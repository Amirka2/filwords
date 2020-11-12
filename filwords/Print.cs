using System;
using System.Collections.Generic;

namespace filwords
{
    public class Print
    {
        private static int index = 0;

        static int GetRandomNumber ()
        {
            var random = new Random();
            int num = random.Next(0, 7);

            return num;
        }

        static ConsoleColor GetColor(int num)
        {
            ConsoleColor color;
            switch (num)
            {
                case 0: color = ConsoleColor.Red;
                    break;
                case 1: color = ConsoleColor.Blue;
                    break;
                case 2: color = ConsoleColor.Cyan;
                    break;
                case 3: color = ConsoleColor.Yellow;
                    break;
                case 4: color = ConsoleColor.Green;
                    break;
                case 5: color = ConsoleColor.Magenta;
                    break;
                case 6: color = ConsoleColor.Black;
                    break;
                default: color = ConsoleColor.Black;
                    break;
            }

            return color;
        }
        public static void GameName()
        {
            Console.Clear();
            string[] str = new string[7];
            str[0] = "######## #### ##       ##      ##  #######  ########  ########   ###### ";
            str[1] = "##        ##  ##       ##  ##  ## ##     ## ##     ## ##     ## ##    ##";
            str[2] = "##        ##  ##       ##  ##  ## ##     ## ##     ## ##     ## ##      ";
            str[3] = "######    ##  ##       ##  ##  ## ##     ## ########  ##     ##  ###### ";
            str[4] = "##        ##  ##       ##  ##  ## ##     ## ##   ##   ##     ##       ##";
            str[5] = "##        ##  ##       ##  ##  ## ##     ## ##    ##  ##     ## ##    ##";
            str[6] = "##       #### ########  ###  ###   #######  ##     ## ########   ###### ";
            
            for (int i = 1, j = 0; i < 8; i++, j++)
            {
                Console.ForegroundColor = GetColor(GetRandomNumber());
                Console.SetCursorPosition(60, i);
                Console.Write(str[j]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public static string Menu(List<string> items)
        {
            GameName();
            
            for (int i = 0; i < items.Count; i++)
            {
                Console.SetCursorPosition(90, i + 10);
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
            {
                if (index == items.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
            {
                if (index == 0)
                {
                    index = items.Count - 1;
                }
                else
                {
                    index--;
                }
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                return items[index];
            }

            Console.Clear();
            return string.Empty;
        }
    }
}