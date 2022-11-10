namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] octavia = Octave(1);
            Console.WriteLine("белые клавиши : Q, W, E, R, T, Y, U, I, O, P");
            Console.WriteLine("черные клафиши : A, S, D, F, G, H, J, K, L");
            Console.WriteLine("выберите октава : 1 - F1, 2 - F2,");


            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    octavia = Octave(1);
                    Console.WriteLine("Выбрана октава 1");
                }
                if (key.Key == ConsoleKey.F2)
                {
                    octavia = Octave(2);
                    Console.WriteLine("Выбрана октава 2");
                }
                if (key.Key == ConsoleKey.Q)
                {
                    Sound(octavia[1]);

                }
                if (key.Key == ConsoleKey.W)
                {
                    Sound(octavia[2]);

                }
                if (key.Key == ConsoleKey.E)
                {
                    Sound(octavia[3]);

                }
                if (key.Key == ConsoleKey.R)
                {
                    Sound(octavia[4]);

                }
                if (key.Key == ConsoleKey.T)
                {
                    Sound(octavia[5]);
                }
                if (key.Key == ConsoleKey.Y)
                {
                    Sound(octavia[6]);
                }
                if (key.Key == ConsoleKey.U)
                {
                    Sound(octavia[7]);
                }
                if (key.Key == ConsoleKey.I)
                {
                    Sound(octavia[8]);
                }
                if (key.Key == ConsoleKey.O)
                {
                    Sound(octavia[9]);
                }
                if (key.Key == ConsoleKey.P)
                {
                    Sound(octavia[11]);
                }
                if (key.Key == ConsoleKey.A)
                {
                    Sound(octavia[1]);
                }
                if (key.Key == ConsoleKey.S)
                {
                    Sound(octavia[2]);
                }
                if (key.Key == ConsoleKey.D)
                {
                    Sound(octavia[3]);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Sound(octavia[4]);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Sound(octavia[5]);
                }
                if (key.Key == ConsoleKey.H)
                {
                    Sound(octavia[6]);
                }
                if (key.Key == ConsoleKey.J)
                {
                    Sound(octavia[7]);
                }
                if (key.Key == ConsoleKey.K)
                {
                    Sound(octavia[9]);
                }
                if (key.Key == ConsoleKey.L)
                {
                    Sound(octavia[11]);
                }
            }

        }

        static void Sound(int chastota)
        {
            Console.Beep(chastota, 500);
        }

        static int[] Octave(int octavia)
        {
            int[] octavia5 = { 219, 240, 259, 320, 340, 363, 390, 417, 437, 456, 474, 509 };
            int[] octavia6 = { 531, 563, 597, 619, 640, 667, 702, 734, 760, 791, 822, 850 };
            if (octavia == 2)
            {
                return octavia5;
            }
            return octavia6;
        }
    }
}