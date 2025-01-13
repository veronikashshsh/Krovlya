using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krovlya
{
    internal static class DataCalculations
    {
        public static int AmountOfCompon { get; set; }
        public static double UsefulWidthValue { get; set; }
        public static double FullWidthValue { get; set; }
        public static double MaxLengthValue { get; set; }
        public static double WidthRoofValue { get; set; }
        public static double ResultMetalList { get; set; }
        public static double AreaOfRoof { get; set; }
        public static double ListLength { get; set; }
    }

    internal static class DataCalculationsForTriangle
    {
        public static double AreaValue { get; set; }
        public static double HeightValue { get; set; }
        public static double SideAValue { get; set; }
        public static double SideBValue { get; set; }
        public static double SideCValue { get; set; }
    }

    internal static class DataCalculationsForRectangle
    {
        public static double AreaValue { get; set; }
        public static double LengthValue { get; set; }
        public static double WidthValue { get; set; }
    }
}
