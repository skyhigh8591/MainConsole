using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole.FolderMethod
{
    public class MethodController
    {

        private static MethodController instance;
        private MethodData methodData;

        private MethodController()
        {
            methodData = new MethodData();
        }

        public static MethodController Instance()
        {
            if (instance == null)
            {
                instance = new MethodController();
            }
            return instance;
        }

        /// <summary>
        /// 判斷是否為奇數
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsOdd(int num)
        {
            return Convert.ToBoolean(num % 2);
        }

        /// <summary>
        /// 陣列 統計奇數與偶數 數量
        /// </summary>
        /// <returns></returns>
        public List<int> ArrayIsOdd()
        {
            int odd = 0;
            int even = 0;

            foreach (var array in methodData.Arr0711)
            {
                if (IsOdd(array))
                {
                    odd++;
                }
                else
                {
                    even++;
                }
            }

            List<int> arrayOdd = new List<int>();
            arrayOdd.Add(odd);
            arrayOdd.Add(even);

            return arrayOdd;
        }

        /// <summary>
        /// 陣列 最長的字串
        /// </summary>
        /// <returns></returns>
        public string ArrayStrMax()
        {
            string maxStr = "";
            maxStr = methodData.Arr0711_Str.Max(x => x);

            return maxStr;
        }

        /// <summary>
        /// 陣列最大值 與 最小值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string,int> ArrayNumMaxMin()
        {
            Dictionary<string, int> array = new Dictionary<string, int>();

            array.Add("Max", methodData.Arr0711.Max(x => x));
            array.Add("Min", methodData.Arr0711.Min(x => x));

            return array;
        }

        /// <summary>
        /// 陣列 幾個字串包含 "C" or "c"
        /// </summary>
        /// <returns></returns>
        public int ArraySelectStr()
        {
            int select = 0;

            foreach(var str in methodData.Arr0711_Str.Where(x => x.Contains("C") || x.Contains("c")))
            {
                select++;
            }

            return select;
        }



    }



}
