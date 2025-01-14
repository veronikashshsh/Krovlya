using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public class DataCalculationsForTriangle
    {
        //public double HeightValue { get; set; }
        public double SideAValue { get; set; }
        public double SideBValue { get; set; }
        public double SideCValue { get; set; }
        public double AreaValue()
        {
            return Math.Sqrt((SideAValue + SideBValue + SideCValue) * (SideAValue + SideBValue - SideCValue) * (SideAValue - SideBValue + SideCValue) * (-SideAValue + SideBValue + SideCValue)) / 4;
        }

        /*// Конструктор тепер приймає лише значення, а не TextBox
        public DataCalculationsForTriangle(double sideAValue, double sideBValue, double sideCValue)
        {
            SideAValue = sideAValue;
            SideBValue = sideBValue;
            SideCValue = sideCValue;
            // Calculate AreaValue and HeightValue based on the sides
        }*/
    }


    internal class DataCalculationsForRectangle
    {
        public double AreaValue { get; set; }
        public double LengthValue { get; set; }
        public double WidthValue { get; set; }
    }
}
