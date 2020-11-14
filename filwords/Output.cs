using System;
using System.Collections.Generic;

namespace filwords
{
    public class Output
    {
        public static void PrintGameName()
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
                Console.ForegroundColor = Helper.GetColor(Helper.GetRandomNumber());
                Console.SetCursorPosition(60, i);
                Console.Write(str[j]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        private static void PrintButton(Button button, int i)
        {
            Row('╔', '═', '╗', button, 10 + 3 * i);
            Row('║', button.text, '║', button, 11 + 3 * i);
            Row('╚', '═', '╝', button, 12 + 3 * i);
        }
        private static void Row(char ch1, char ch2, char ch3, Button button, int j)
        {
            Console.SetCursorPosition( 85, j);
            Console.Write(ch1);
            for (int i = button.width; i > 0; i--)
                Console.Write(ch2);
            Console.WriteLine(ch3);
        }
        private static void Row(char ch1, string value, char ch2, Button button, int j)
        {
            Console.SetCursorPosition(85, j);
            Console.Write(ch1);
            
            int check = 0;
            if (value.Length % 2 != 0)
                check = 1;

            int space = (button.width - value.Length) / 2;
            for (int i = space; i > 0; i--)
                Console.Write(" ");
            Console.Write(value);
            for (int i = space + check; i > 0; i--)
                Console.Write(" ");
            Console.WriteLine(ch2);
        }
        public static void PrintMenu(List<Button> items)
        {
            Console.Clear();
            PrintGameName();

            for (int i = 0; i < items.Count; i++)
            {
                
                if (items[i].isChosen)
                    Console.ForegroundColor = ConsoleColor.Red;
                
                PrintButton(items[i], i);
                Console.ResetColor();
            }
        }
        public static void PrintNewGame()
        {
            Console.Clear();
            
            Console.SetCursorPosition(90, 5);
            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();

            Console.SetCursorPosition(90, 5);
            Console.WriteLine("Тут однажды будет начало новой игры");
            Console.ReadKey();
        }
        public static void PrintContinueGame()
        {
            Console.Clear();

            Console.SetCursorPosition(90, 5);
            Console.WriteLine("Тут однажды будет продолжение игры");
            Console.ReadKey();
        }
        public static void PrintHighScoreTable()
        {
            Console.Clear();

            Console.SetCursorPosition(90, 5);
            Console.WriteLine("Тут однажды будет таблица рекордов");
            Console.ReadKey();
        }
    }
}