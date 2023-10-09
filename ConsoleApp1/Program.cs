using System;

public class Piano
{
    private int currentOctave;
    private int[][] octaves;

    public Piano()
    {
        currentOctave = 0; 
        octaves = new int[][]
        {
            new int[] { 261, 293, 329, 349, 392, 440, 493 },  
            new int[] { 523, 587, 659, 698, 784, 880, 988 },  
            new int[] { 600, 700, 800, 900, 1000, 1100, 1200 },
            
        };
    }

    public int[] ChangeOctave(int newOctave)
    {
        if (newOctave >= 0 && newOctave < octaves.Length)
        {
            currentOctave = newOctave;
            return octaves[currentOctave];
        }
        else
        {
            Console.WriteLine("У меня только 3 октавы!!!");
            return octaves[currentOctave];
        }
    }

    public void PlaySound(int frequency)
    {
        Console.Beep(frequency, 500); 
    }

    public void Start()
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.F1:
                    ChangeOctave(0);
                    break;
                case ConsoleKey.F2:
                    ChangeOctave(1);
                    break;
                case ConsoleKey.F3:
                    ChangeOctave(2);
                    break;

                case ConsoleKey.Q:
                    PlaySound(octaves[currentOctave][0]);
                    break;
                case ConsoleKey.W:
                    PlaySound(octaves[currentOctave][1]);
                    break;
                case ConsoleKey.E:
                    PlaySound(octaves[currentOctave][2]);
                    break;
                case ConsoleKey.R:
                    PlaySound(octaves[currentOctave][3]);
                    break;
                case ConsoleKey.T:
                    PlaySound(octaves[currentOctave][4]);
                    break;
                case ConsoleKey.Y:
                    PlaySound(octaves[currentOctave][5]);
                    break;
                case ConsoleKey.U:
                    PlaySound(octaves[currentOctave][6]);
                    break;
                case ConsoleKey.I:
                    PlaySound(octaves[currentOctave][7]);
                    break;
                case ConsoleKey.O:
                    PlaySound(octaves[currentOctave][8]);
                    break;
                case ConsoleKey.A:
                    PlaySound(octaves[currentOctave][9]);
                    break;
                case ConsoleKey.S:
                    PlaySound(octaves[currentOctave][10]);
                    break;
                case ConsoleKey.D:
                    PlaySound(octaves[currentOctave][11]);
                    break;
                case ConsoleKey.F:
                    PlaySound(octaves[currentOctave][12]);
                    break;


            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Piano piano = new Piano();
        piano.Start();
    }
};
