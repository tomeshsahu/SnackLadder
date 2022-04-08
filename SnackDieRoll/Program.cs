using System;
using SnackDieRoll;

public class Program
{

    public static void Main(String[] args)
    {
        Ladder Game = new Ladder();
        int value = Game.dieRoll();
        int value2 = Game.Check();
        Console.WriteLine("Get Die Number" + " " + value);
        Console.WriteLine("Take Position" + " " + value2);
    }


}
