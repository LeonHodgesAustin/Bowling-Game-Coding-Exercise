using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Coding_Exercise
{
    class Frame
    {
        public BallThrow[] ballThrows;
        public bool lastFrame;
        public Frame(char[] frameChars, bool lastFrame)
        {
            ballThrows = new BallThrow[frameChars.Length];
            for (int i = 0; i < frameChars.Length; i++)
                switch (frameChars[i])
                {
                    case 'X': ballThrows[i] = new BallThrow(10, 2);
                        break;
                    case '/': ballThrows[i] = new BallThrow(10, 1);
                        break;
                    default: ballThrows[i] = new BallThrow(int.Parse(frameChars[i].ToString()), 0);
                        break;
                }

            this.lastFrame = lastFrame;
        }
    }
}
