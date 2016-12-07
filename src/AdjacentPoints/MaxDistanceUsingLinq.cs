using System;
using System.Linq;

namespace AdjacentPointsMaxDistance
{
    public class MaxDistanceUsingLinq : IAdjacentPoints
    {        
        public int Calculate(int[] a)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a), "Parameter a must be a non-nullable value");
            if (a.Length == 0 || a.Length > 40000)
                throw new ArgumentOutOfRangeException(nameof(a), "Lenght of parameter a must be between 1 and 40000");

            var sorted = a.ToList().OrderBy(x => x).ToArray();
            var adjacanetElments = sorted.Skip(1).Zip(sorted, (se, fi) => new[] { fi, se }).ToArray();
            var ret = adjacanetElments.Select(x => new { Sum = System.Math.Abs(x[0] - x[1]) }).Max(x => x.Sum);

            return ret == 0 ? -2 : ret;
        }     
    }
}