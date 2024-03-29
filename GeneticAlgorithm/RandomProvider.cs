﻿using System;

namespace GeneticAlgorithm
{
    public static class RandomProvider
    {
        private static readonly Random Rnd = new Random();
        private static readonly object Sync = new object();

        public static double NextDouble()
        {
            lock (Sync)
            {
                return Rnd.NextDouble();
            }
        }

        public static int Next()
        {
            lock (Sync)
            {
                return Rnd.Next();
            }
        }

        public static int Next(int max)
        {
            lock (Sync)
            {
                return Rnd.Next(max);
            }
        }

        public static int Next(int min, int max)
        {
            lock (Sync)
            {
                return Rnd.Next(min, max);
            }
        }

    }
}