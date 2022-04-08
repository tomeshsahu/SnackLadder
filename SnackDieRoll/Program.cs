using System;
using SnackDieRoll;

public class Program
{

    public static void Main(String[] args)
    {
        Ladder Game = new Ladder();
        int Start = Game.dieRoll();
        Console.WriteLine("Welcome in the Snack Game, Your Position is" + " " + Start);
    }

}