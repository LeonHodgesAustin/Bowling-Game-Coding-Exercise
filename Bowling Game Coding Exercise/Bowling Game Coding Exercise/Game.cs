using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Coding_Exercise
{
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
            {
                frames[i] = new Frame(frameStrings[i].ToCharArray(), i == (frames.Length-1));
            }

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
                            {
                                Frame nextFrame = frames[i + 1];
                                currentScore += nextFrame.ballThrows[0].score;
                            }
                            break;
                        case 2: currentScore = 10;
                            if (!currentFrame.lastFrame)
                            {
                                Frame nextFrame = frames[i + 1];
                                currentScore += nextFrame.ballThrows[0].score;
                                if (!nextFrame.lastFrame)
                                {
                                    nextFrame = frames[i + 2];
                                    currentScore += nextFrame.ballThrows[0].score;
                                }
                                else
                                {
                                    currentScore += nextFrame.ballThrows[1].score;
                                }

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
