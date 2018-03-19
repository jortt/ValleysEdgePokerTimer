using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValleysEdgePokerTimer
{
    interface IRound
    {
        int time_left { get; }
        int small_blind { get; }
        int large_blind { get; }
        // boolean to determine if it is a break
        // maybe this should just be done by checking the class
        bool has_blinds { get; }
        void Tick();
    }

    class RoundOfPlay : IRound
    {
        public string bTime
        {
            get
            {
                return "Time: " + (time_left / 60).ToString() + " mins";
            }
        }
        public string bSmall_Blind
        {
            get
            {
                return "Small: " + small_blind.ToString();
            }
        }
        public string bLarge_Blind
        {
            get
            {
                return "Large:" + large_blind.ToString();
            }
        }
        public int time_left { get; private set; }
        public int small_blind { get; }
        public int large_blind { get; }
        public bool has_blinds { get { return true; } }

        public RoundOfPlay(int duration, int small, int large)
        {
            time_left = duration;
            small_blind = small;
            large_blind = large;
        }

        public void Tick()
        {
            if (time_left > 0)
            {
                time_left--;
            }
        }
    }

    class Break : IRound
    {
        public int time_left { get; private set; }
        public int small_blind { get { return 0; } }
        public int large_blind { get { return 0; } }
        public bool has_blinds { get { return false; } }

        public Break(int duration)
        {
            time_left = duration;
        }

        public void Tick()
        {
            if (time_left > 0)
            {
                time_left--;
            }
        }
    }
}
