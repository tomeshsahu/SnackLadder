using System;
using SnackDieRoll;

public class Program
{

    public static void Main(String[] args)
    {
        Ladder Start = new Ladder();
        int value = Start.dieRoll();

        Console.WriteLine("Welcome in the Game, You got : " + value + "  " + "Position");
        Start.check();



    }
}
