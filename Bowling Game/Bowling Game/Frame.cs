using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author ${Anas Al Kala}
 *
 * 
 */
namespace TDD___Bowling_Game_Demo
{
    public class Frame
    {
        private readonly List<int> _pins = new List<int>();

        public bool IsFrameFinished
        {
            get
            {
                if (_pins.Count == 2)
                    return true;
                else if (_pins.Count == 1)
                {
                    if (_pins[0] == 10)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }

        public void AddRoll(int pins)
        {
            if (pins < 0 || pins > 10)
            {
                return;
            }
            _pins.Add(pins);
        }

        public bool IsStrike
        {
            get
            {
                if (_pins[0] == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsSpare
        {
            get
            {
                if (_pins.Count == 2 && (_pins[0] + _pins[1]) == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int NumRolls
        {
            get
            {
                return _pins.Count;
            }
        }
        public int FirstRoll
        {
            get { return _pins[0]; }
        }
        public int SecondRoll
        {
            get
            {
                if (_pins.Count == 2)
                    return _pins[1];
                else
                    return 0;
            }
        }

        public int Score
        {
            get
            {
                if (_pins.Count == 1)
                    return _pins[0];
                else if (_pins.Count == 2)
                    return _pins[0] + _pins[1];
                else
                    return _pins[0] + _pins[1] + _pins[2];      // for the potential last roll of the last frame.
            }
        }
    }
}