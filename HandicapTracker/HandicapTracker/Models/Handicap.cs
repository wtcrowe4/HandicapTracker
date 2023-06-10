using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandicapTracker.Models
{
    public class Handicap
    {
        public double Value { get; set; } = 2.3;

        public List<Round> Rounds { get; set; }

        public List<Score> Scores { get; set; }

        public List<Score> Differentials { get; set; }

        /// <summary>
        /// calculates the handicap value from the list of scores and differentials
        /// </summary>
        /// <returns>the resulting handicap</returns>
        public double CalculateHandicapValue()
        {
            if (Differentials.Count < 5)
            {
                //return a handicap value of 0 if less than 5 Differentials exist
                return 0;
            }

            var sortedDifferentials = Differentials.OrderBy(d => d.Value).ToList();

            int count = 0;
            double total = 0;

            for (int x = 0; x < Differentials.Count; x++)
            {
                if (x > 19)
                {
                    break; // only use the lowest 20% of a user's differentials.
                }

                count++;
                total += sortedDifferentials[x].Value;
            }

            double averageDifferential = (total / count);

            return Math.Round((averageDifferential * 0.96), 1);
        }

    }

    public class Round
    {
        public DateTime Date { get; set; }

        public int Score { get; set; }

        public int CourseRating { get; set; }

        public int SlopeRating { get; set; }

        public double Differential { get; set; }
    }

    public class Score
    {
        public int Value { get; set; }
        public int AdjustedValue { get; set; }

        public int CourseRating { get; set; }
        public int SlopeRating { get; set;}

    }
}
