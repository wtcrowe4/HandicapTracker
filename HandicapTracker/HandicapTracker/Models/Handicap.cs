using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandicapTracker.Models
{
    internal class Handicap
    {
        public double Value { get; set; }

        public List<Round> Rounds { get; set; }
    }

    internal class Round
    {
        public DateTime Date { get; set; }

        public int Score { get; set; }

        public int CourseRating { get; set; }

        public int SlopeRating { get; set; }

        public double Differential { get; set; }
    }
}
