using System;
using SnackDieRoll;

public class Program
{

    public static void Main(String[] args)
    {
        Ladder Game = new Ladder();
        int value = Game.dieRoll();
        Console.WriteLine("Die Number is" + " " + value);
    }

}