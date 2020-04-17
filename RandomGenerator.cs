using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV2
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random random;
        private RandomGenerator()
        {
            this.random = new Random();
        }
        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        }
        public int NextInt(int lowerbound, int upperbound)
        {
            return random.Next(lowerbound, upperbound);
        }
    }
}
