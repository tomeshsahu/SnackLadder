using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackDieRoll
{
    public class Ladder
    {
        const int No_Play = 0;
        const int Snack = 1;
        const int Lader = 2;
        int Position = 0;
        public int dieRoll()
        {
            Random random = new Random();
            int diePosition = random.Next(1, 7);

            return diePosition;
        }
        public void check()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            switch (option)
            {
                case No_Play:
                    this.Position += 0;
                    Console.WriteLine("Position is"+this.Position);
                    break;
                case Snack:
                    this.Position -= this.dieRoll();
                    Console.WriteLine("Position is"+this.Position);
                    break;
                case Lader:
                    this.Position += this.dieRoll();
                    Console.WriteLine("Position is"+this.Position);
                    break;
                    
            }

        }
    }
}
