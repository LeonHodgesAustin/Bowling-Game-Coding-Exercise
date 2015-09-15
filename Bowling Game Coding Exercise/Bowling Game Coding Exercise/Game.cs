using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Coding_Exercise
{
    //in retrosepct i might have been way simpler to do each game as a linked likst of frames and have each frame calcualte it's own score
    class Game
    {
        public string gameString;
        public int gameScore;
        public Frame[] frames;

        public Game(string gameString)
        {
            this.gameString = gameString;
            string[] frameStrings = gameString.Split('-');
            frames = new Frame[frameStrings.Length];

            for (int i = 0; i < frames.Length; i++)
                frames[i] = new Frame(frameStrings[i].ToCharArray(), i == (frames.Length-1));

            gameScore = scoreFrames(frames);
        }

        static int scoreFrames(Frame[] frames)
        {
            int score = 0;
            for (int i = 0; i < 10; i++)
            {
                Frame currentFrame = frames[i];
                int currentScore = 0;
                for (int j = 0; j < currentFrame.ballThrows.Count(); j++)
                {
                    BallThrow currentThrow = currentFrame.ballThrows[j];
                    switch (currentThrow.throwType)
                    {
                        case 0: currentScore += currentThrow.score;
                            break;
                        case 1: currentScore = 10;
                            if (!currentFrame.lastFrame)
                                currentScore += frames[i + 1].ballThrows[0].score;
                            break;
                        case 2: currentScore = 10;
                            if (!currentFrame.lastFrame)
                                switch (frames[i + 1].ballThrows[0].throwType)
                                {
                                    case 0: if(frames[i + 1].ballThrows[1].throwType != 1)
                                                currentScore += frames[i + 1].ballThrows[0].score + frames[i + 1].ballThrows[1].score;
                                            else
                                                currentScore += frames[i + 1].ballThrows[1].score;
                                        break;

                                    case 2: currentScore += frames[i + 1].ballThrows[0].score;

                                            if (!frames[i + 1].lastFrame)
                                                currentScore += frames[i + 2].ballThrows[0].score;
                                            else
                                                currentScore += frames[i + 1].ballThrows[1].score;
                                        break;
                                }
                            break;
                    }
                }
                score += currentScore;
            }
            return score;
        }
    }
}
