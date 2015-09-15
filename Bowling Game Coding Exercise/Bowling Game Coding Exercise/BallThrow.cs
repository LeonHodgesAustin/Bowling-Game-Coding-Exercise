using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Coding_Exercise
{
    class BallThrow
    {
        public int score;
        public int throwType;
        //0 = normal
        //1 = spare
        //2 = strike
        public BallThrow(int score, int throwType)
        {
            this.score = score;
            this.throwType = throwType;
        }
    }
}
