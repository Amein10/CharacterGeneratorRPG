using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGeneratorRPG
{
    public class Dice
    {
        public int ReRoll()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 21);
            return randomNumber;
        }
    }

}