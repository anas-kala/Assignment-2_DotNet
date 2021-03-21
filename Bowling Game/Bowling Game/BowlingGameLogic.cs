using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD___Bowling_Game;

/**
 * @author ${Anas Al Kala}
 *
 * 
 */
namespace TDD___Bowling_Game_Demo
{
    public class BowlingGameLogic : IGameLogic
    {
        private List<Frame> _frames = new List<Frame>();
        private Frame _currentFrame = new Frame();

        public void Roll(int pins)
        {
            _currentFrame.AddRoll(pins);
            // if we have reached that last frame
            if (_frames.Count == 10)
            {
                if (_frames[9].IsSpare)
                {
                    _frames.Add(_currentFrame);
                    return;
                }
            }
            if (_currentFrame.IsFrameFinished)
            {
                _frames.Add(_currentFrame);
                _currentFrame = new Frame();
            }
        }

        public int GetFinalScore()
        {
            int score = 0;
            for (var frameIndex = 0; frameIndex < 10; frameIndex++)
            {
                var frame = _frames[frameIndex];
                score += frame.Score;
                score += getSpareBous(frameIndex);
                score += getStrikeBonus(frameIndex);
            }
            return score;
        }

        private int getStrikeBonus(int index)
        {
            if (_frames[index].IsStrike == false || index + 1 >= _frames.Count)
            {
                return 0;
            }
            // here we have a strike and we still have not reached the last frame
            else
            {
                var nextFrame = _frames[index + 1];
                if (nextFrame.NumRolls == 2)   // if there were 2 rolls in this frame we are done.
                {
                    return nextFrame.Score;
                }
                else // if the next frame also has a strike, so we need its bonus
                {
                    if (index + 2 >= _frames.Count)
                    {
                        return nextFrame.Score;
                    }
                    else
                    {
                        var nextNextFrame = _frames[index + 2];
                        return nextFrame.FirstRoll + nextNextFrame.FirstRoll;
                    }
                }
            }
        }

        private int getSpareBous(int index)
        {
            if (_frames[index].IsSpare == false)
            {
                return 0;
            }

            // getting to here means that we have a spare.
            if (index + 1 < _frames.Count)
            {
                var frame = _frames[index + 1];
                return frame.FirstRoll;
            }

            // getting to here means that we have a spare but in the final frame
            // so getting the first ball from the next frame will not be valid.
            return 0;
        }
    }
}
