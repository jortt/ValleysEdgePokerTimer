using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValleysEdgePokerTimer
{
    class Tournament
    {
        public static int NumberOfRounds = 8;

        private List<bool> rndEnables_;
        private List<int> rndSmallBlinds_;
        private List<int> rndLargeBlinds_;
        private List<int> rndDurations_;

        private int currentRound_ = 0;

        public Tournament()
        {
            rndEnables_ = new List<bool>(new bool[NumberOfRounds]);
            for(int i = 0; i < NumberOfRounds; i++) { rndEnables_[i] = false; }
            rndSmallBlinds_ = new List<int>(NumberOfRounds);
            rndLargeBlinds_ = new List<int>(NumberOfRounds);
            rndDurations_ = new List<int>(NumberOfRounds);
        }

        public Tournament(List<bool> enables, List<int> smallBlinds, List<int> largeBlinds, List<int> durations)
        {
            rndEnables_ = enables;
            rndSmallBlinds_ = smallBlinds;
            rndLargeBlinds_ = largeBlinds;
            rndDurations_ = durations;
        }

        public void Start()
        {
            currentRound_ = 0;
        }

        public void Advance()
        {
            currentRound_++;
        }

        public Round GetCurrentRound()
        {
            if (currentRound_ < NumberOfRounds)
            {
                return new Round(rndEnables_.ElementAt(currentRound_),
                                    rndSmallBlinds_.ElementAt(currentRound_),
                                    rndLargeBlinds_.ElementAt(currentRound_),
                                    rndDurations_.ElementAt(currentRound_));
            }
            else
            {
                return new Round(false, -1, -1, -1);
            }
        }

        public Round GetNextRound()
        {
            if (currentRound_ < NumberOfRounds - 1)
            {
                return new Round(rndEnables_.ElementAt(currentRound_ + 1),
                                    rndSmallBlinds_.ElementAt(currentRound_ + 1),
                                    rndLargeBlinds_.ElementAt(currentRound_ + 1),
                                    rndDurations_.ElementAt(currentRound_ + 1));
            }
            else
            {
                return new Round(false, -1, -1, -1);
            }
        }
    }

    class Round
    {
        public bool IsEnabled;
        public int SmallBlind;
        public int LargeBlind;
        public int Duration;

        public Round(bool isEnabled, int smallBlind, int largeBlind, int duration)
        {
            IsEnabled = isEnabled;
            SmallBlind = smallBlind;
            LargeBlind = largeBlind;
            Duration = duration;
        }
    }
}
