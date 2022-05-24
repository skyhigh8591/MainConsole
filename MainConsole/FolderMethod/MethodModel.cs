using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderMethod
{
    public class MethodModel
    {
        List<int> arr0711 = new List<int>() { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        List<string> arr0711_Str = new List<string>() { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };

        public List<int> Arr0711 { get => arr0711; set => arr0711 = value; }
        public List<string> Arr0711_Str { get => arr0711_Str; set => arr0711_Str = value; }
    }

}
