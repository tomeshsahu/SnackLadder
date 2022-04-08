using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackDieRoll
{
    public class Ladder
    { 
        const int position = 0;
        public int dieRoll()
        {
            Random random= new Random(); 
            int die=random.Next(1,7);
                
            return die;
        }
    
    }
}
