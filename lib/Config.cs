using System;

namespace OpenPSO.Lib
{
    public class Config
    {
        // Inertia weight
        public double W { get; }

        // Acceleration coefficients, used to tune the relative influence of
        // each term of the formula
        public double C1 { get; }
        public double C2 { get; }

        public double XMax { get; }
        public double VMax { get; }

        // public int PopSize { get; }

        public Random Rng { get; }

        public readonly IFunction function;

        public readonly int maxEvals;

        public readonly double criteria;

        public readonly bool critKeepGoing;

        public Config()
        {
            Rng = new Random();
        }
    }
}