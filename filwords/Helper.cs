using System;

namespace filwords
{
    public class Helper
    {
        public static int GetRandomNumber()
        {
            var random = new Random();
            int num = random.Next(0, 7);

            return num;
        }
        public static ConsoleColor GetColor(int num)
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
    }
}