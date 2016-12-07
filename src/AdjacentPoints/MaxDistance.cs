using System;
using System.Linq;

namespace AdjacentPointsMaxDistance
{
    public class MaxDistance : IAdjacentPoints
    {
        public int Calculate(int[] a)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a), "Parameter a must be a non-nullable value");
            if (a.Length == 0 || a.Length > 40000)
                throw new ArgumentOutOfRangeException(nameof(a), "Lenght of parameter a must be between 1 and 40000");

            var sorted = a.ToList().OrderBy(x => x).ToArray();
            var maxDistance = 0;

            for (var i = 0; i < sorted.Length - 1; i++)
            {
                var currentDistance = sorted[i + 1] - sorted[i];

                if (currentDistance > maxDistance)
                    maxDistance = currentDistance;
            }

            return maxDistance > 1 ? maxDistance : -2;
        }      
    }
}
