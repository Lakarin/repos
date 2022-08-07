using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineChartApp
{
    class F_numbers
    {
        static double StdDev(IEnumerable<double> sequence, double average)
        {
            double sum = sequence.Sum(d => Math.Pow(d - average, 2));
            return Math.Sqrt((sum) / sequence.Count());
        }

        static double Maxim(IEnumerable<double> sequence)
        {
            return (sequence.Max() > Math.Abs(sequence.Min())) ? sequence.Max() : Math.Abs(sequence.Min());
        }

        public static double FFValue(IEnumerable<double> seqQ)
        {
            double result = 0;

            if (seqQ.Any())
            {
                double average = seqQ.Average();
                result = 115.8454 / ((3 * StdDev(seqQ, average)) + Math.Abs(average));  //4.57 / ((3xSq) + (|q|))
            }
            return result;
        }

        public static double FLValue(IEnumerable<double> seqZ)
        {
            double result = 0;

            if (seqZ.Any())
            {
                double average = seqZ.Average();
                result = 314.67 / ((3 * StdDev(seqZ, average)) + Math.Abs(average));  //12.5 / ((3xSq) + (|z|))
            }
            return result;
        }

        public static double Fmin(IEnumerable<double> seqQ)
        {
            double result = 0;

            if (seqQ.Any())
                result = (6.55 * Math.Sqrt(1200 + 68.58) - 48.26) / Math.Abs(Maxim(seqQ));  //(6.55*(SQRT(1200+68.58))-48.26)/ABS(Maxim)
            return result;
        } 
    }
}
