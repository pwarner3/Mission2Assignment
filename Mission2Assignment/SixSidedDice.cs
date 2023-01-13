using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2Assignment
{
    class SixSidedDice
    {
        public int[] sides = new int[6];
        Random rnd = new Random();
        public SixSidedDice()
        {
            sides[0] = 1;
            sides[1] = 2;
            sides[2] = 3;
            sides[3] = 4;
            sides[4] = 5;
            sides[5] = 6;
        }
        public int RollDice()
        {
            int randomNum;
            randomNum = rnd.Next(1,7);

            return randomNum;
        }
        
    }
}
