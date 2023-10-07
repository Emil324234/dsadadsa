internal class Program
{
    private static void Main(string[] args)
    {
        int[] Firstoktava = new int[] { 1635, 1732, 1835, 1945, 2060, 2183, 2312, 2450, 2596, 2750, 2914, 3087 }; 
        int[] Secondoktava = new int[] { 3270, 3465, 3671, 3889, 4120, 4365, 4625, 4900, 5191, 5500, 5827, 6174 };
        int[] Thirdoktava = new int[] { 6541, 6930, 7342, 7778, 8241, 8731, 9250, 9800, 1038, 1100, 1165, 1235 }; 
        Console.WriteLine("Z и X - менять октавы");
        Console.WriteLine("C, D, E, F, G, A, B - белые клавиши. Z, X, V, N, M, L - черные клавиши"); Console.WriteLine("Выбрана первая октава");
        Thirdoktava = Firstoktava; do
        {
            ConsoleKeyInfo mykey = Console.ReadKey(true);
            Melody(mykey, Thirdoktava);
        }
        while (true);
}
private static void Melody(ConsoleKeyInfo mykey, int[] Thirdoktava)
        {
            switch (mykey.Key)
            {
                case ConsoleKey.C:
                    Console.Beep(Thirdoktava[0], 450);
                    break;
                case ConsoleKey.D:
                    Console.Beep(Thirdoktava[1], 450); 
                break;
                case ConsoleKey.E:
                    Console.Beep(Thirdoktava[2], 450);
                    break;
                case ConsoleKey.F:
                    Console.Beep(Thirdoktava[3], 450); 
                break;
                case ConsoleKey.G:
                    Console.Beep(Thirdoktava[4], 450);
                    break;
                case ConsoleKey.A:
                    Console.Beep(Thirdoktava[5], 450); 
                break;
                case ConsoleKey.B:
                    Console.Beep(Thirdoktava[6], 450);
                    break;
                case ConsoleKey.Z:
                    Console.Beep(Thirdoktava[7], 450); 
                break;
                case ConsoleKey.X:
                    Console.Beep(Thirdoktava[8], 450);
                    break;
                case ConsoleKey.V:
                    Console.Beep(Thirdoktava[9], 450); 
                break;
                case ConsoleKey.N:
                    Console.Beep(Thirdoktava[10], 450);
                    break;
                case ConsoleKey.M:
                    Console.Beep(Thirdoktava[11], 450); 
                break;
                case ConsoleKey.L:
                    Console.Beep(Thirdoktava[12], 450);
                    break;
            }}
}