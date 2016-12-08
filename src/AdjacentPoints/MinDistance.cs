using System;
using System.Linq;

namespace AdjacentPointsMaxDistance
{
    public class MinDistance : IAdjacentPoints
    {
        public int Calculate(int[] a)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a), "Parameter a must be a non-nullable value");
            if (a.Length == 0 || a.Length > 40000)
                throw new ArgumentOutOfRangeException(nameof(a), "Lenght of parameter a must be between 1 and 40000");

            Array.Sort(a);
            var minDistance = int.MaxValue;

            for (var i = 0; i < a.Length - 1; i++)
            {
                var currentDistance = Math.Abs(a[i + 1] - a[i]);

                if (currentDistance < minDistance)
                    minDistance = currentDistance;
            }

            return minDistance > 0 ? minDistance : -2;
        }
    }
}