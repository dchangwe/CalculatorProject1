using System;
using StatsOperations;

namespace ZScore
{
    public class FindZscore : IZScore
    {
        public static dynamic result;

        public double StatZScore(dynamic score, dynamic values)
        {
            result = StatsZScore.StatZScore(score, values);
            return result;

       

    }
    }
}
