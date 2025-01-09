using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krovlya
{
    internal static class GlobalData
    {
        public static string LabelOrder {  get; set; }
        public static string LabelData { get; set; }
        public static string LabelCustomer { get; set; }
        public static string LabelManager { get; set; }
        public static string Label22 { get; set; }
        public static string NameOfMetalTile { get; set; }
        public static string MaxLengthZavodMetal { get; set; }
        public static string DiskretOfMetal { get; set; }
    }

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

    internal static class selectedElement
    {
        public static string SelectComp { get; set;  }
        /*public static double DataOfCompA { get; set;}
        public static double DataOfCompB { get; set; }
        public static double DataOfCompC { get; set; }
        public static double DataOfCompD { get; set; }*/
    }
}
