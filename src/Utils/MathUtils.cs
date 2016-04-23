using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTorrent
{
    public static class MathUtils
    {
        public static int PercentageOf(double small, double big)
        {
            return (int)(small / big) * 100;
        }

        public static int PercentageFrom(double percentage, double value)
        {
            return (int)((percentage / 100) * value);
        }

        public static double ETA(double downloadedBytes, double downloadSpeed, double size)
        {
            return (int)(((size - downloadedBytes) / 1000) / (downloadSpeed / 1000));
        }
    }
}
