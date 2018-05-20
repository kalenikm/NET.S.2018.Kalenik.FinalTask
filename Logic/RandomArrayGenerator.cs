using System;

namespace Logic
{
    public static class RandomArrayGenerator
    {
        /// <summary>
        /// Returns an array with random double values. Sum of this elements is equals 1.
        /// </summary>
        /// <param name="count">Count of elements in array.</param>
        /// <returns>Array with random double values.</returns>
        public static double[] GetRandomArray1(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count can't be less or equals zero.");
            }

            Random rand = new Random((int)DateTime.Now.Ticks);

            double[] array = new double[count];
            double sum = 0;

            for (int i = 0; i < count - 1; i++)
            {
                array[i] = rand.NextDouble() % ((1 - sum) * 0.3);
                while (array[i] <= 0)
                {
                    array[i] = rand.NextDouble() % ((1 - sum) * 0.3);
                }
                sum += array[i];
            }
            array[count - 1] = 1 - sum;

            return array;
        }

        /// <summary>
        /// Returns an array with random double values. Sum of this elements is equals 1.
        /// </summary>
        /// <param name="count">Count of elements in array.</param>
        /// <returns>Array with random double values.</returns>
        public static double[] GetRandomArray2(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count can't be less or equals zero.");
            }

            Random rand = new Random((int)DateTime.Now.Ticks);

            double[] array = new double[count];
            long divider = 0;

            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(1, Int32.MaxValue);
                divider += (long)array[i];
            }

            double sum = 0;

            for (int i = 0; i < count - 1; i++)
            {
                array[i] = array[i] / divider;
                sum += array[i];
            }
            array[count - 1] = 1 - sum;

            return array;
        }
    }
}
