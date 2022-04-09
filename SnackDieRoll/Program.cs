using System;
using SnackDieRoll;

public class Program
{

    public static void Main(String[] args)
    {
        Ladder Game = new Ladder();
        int value = Game.dieRoll();
        
        Console.WriteLine("Get Die Number" + " " + value);
        Game.check();
    }


}
