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

    public class selectedElement
    {
        public string SelectComp { get; set;  }
        public List<string> ComponentData { get; set; } = new List<string>(); //список для зберігання даних про компоненти

    }

    public static class numOfComponents
    {
        public static int TotalComponents { get; set; }
        public static int CurrentComponent { get; set; }
       // public static int  { get; set; }
    }
}
