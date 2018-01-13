using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValleysEdgePokerTimer
{
    class Tournament
    {
        private List<IRound> rounds_ = new List<IRound>();
        private int current_round_ = 0;

        public void AddRound(IRound rnd)
        {
            rounds_.Add(rnd);
        }

        public void Start()
        {
            current_round_ = 0;
        }

        public void Advance()
        {
            current_round_++;
        }

        public IRound GetCurrentRound()
        {
            return rounds_[current_round_];
        }
    }
}
