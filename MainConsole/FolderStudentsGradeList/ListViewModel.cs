using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    /// <summary>
    /// ListView 資料
    /// </summary>
    public class ListViewModel
    {
        /// <summary>
        /// 名子
        /// </summary>
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }
        public int TotalScore { get; set; }
        public int Average { get; set; }
        public string MaxStr { get; set; }
        public string MinStr { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
