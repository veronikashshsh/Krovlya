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
        public double HeightValue { get; set; }
        public double SideAValue { get; set; }
        public double SideBValue { get; set; } //роб ширина
        public double SideCValue { get; set; }
        public double AreaValue { get; set; }
        public double AreaCalc()
        {
            if (HeightValue > 0 && SideBValue > 0) // Якщо є висота
            {
                AreaValue = (SideBValue * HeightValue) / 2; // Формула площі через висоту
            }
            else if (SideAValue > 0 && SideBValue > 0 && SideCValue > 0) // Якщо висота не задана, але є всі сторони
            {
                // Формула Герона
                double semiPerimeter = (SideAValue + SideBValue + SideCValue) / 2;
                AreaValue = Math.Sqrt(semiPerimeter *
                                      (semiPerimeter - SideAValue) *
                                      (semiPerimeter - SideBValue) *
                                      (semiPerimeter - SideCValue));
            }
            
            return AreaValue;
        }
      
        /*public double CalculateHeight()
        {
            double semiPerimeter = (SideAValue + SideBValue + SideCValue) / 2;
            double area = Math.Sqrt(semiPerimeter *
                                    (semiPerimeter - SideAValue) *
                                    (semiPerimeter - SideBValue) *
                                    (semiPerimeter - SideCValue));

            if (SideBValue <= 0)
            {
                throw new InvalidOperationException("Сторона B має бути більшою за нуль.");
            }
            // Розрахунок висоти
            HeightValue = (2 * area) / SideBValue;

            return HeightValue;
        }*/
    }


    internal class DataCalculationsForRectangle
    {
        public double AreaValue { get; set; }
        public double LengthValue { get; set; }
        public double WidthValue { get; set; }
    }
}
