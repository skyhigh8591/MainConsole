using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Dictionary<string, int> ArrayNumMaxMin()
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
            foreach (var str in methodData.Arr0711_Str.Where(x => x.Contains("C") || x.Contains("c")))
            {
                select++;
            }
            return select;
        }

        /// <summary>
        /// 陣列外圍與內圈不同數字
        /// </summary>
        /// <param name="outNum">外圍數字</param>
        /// <param name="inNum">內圈數字</param>
        /// <returns></returns>
        public string ArrayOut(string outNum, string inNum)
        {
            string[,] array = new string[5, 10];
            string str = "";
            for (int one = 0; one < array.GetLength(0); one++)
            {
                for (int two = 0; two < array.GetLength(1); two++)
                {
                    if (one == 0 || one == (array.GetLength(0) - 1) || two == 0 || two == (array.GetLength(1) - 1))
                    {
                        str += outNum;
                    }
                    else
                    {
                        str += inNum;
                    }
                }
                str += "\n";
            }
            return str;
        }

       

        /// <summary>
        /// 陣列交錯產生0與1
        /// </summary>
        /// <returns></returns>
        public string ArrayExchange()
        {
            string[,] array = new string[5, 10];
            string str = "";

            for (int one = 0; one < array.GetLength(0); one++)
            {
                for (int two = 0; two < array.GetLength(1); two++)
                {
                    if (IsOdd(one))
                    {
                        str += IsOdd(two) ? "1" : "0";
                    }
                    else
                    {
                        str += !IsOdd(two) ? "1" : "0";
                    }
                }
                str += "\n";
            }
            return str;
        }

        /// <summary>
        /// 數值互換
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Swap(ref int a, ref int b)
        {
            b = Interlocked.Exchange(ref a, b);
        }

        /// <summary>
        /// 取的陣列的加總
        /// </summary>
        /// <returns></returns>
        public string ArraySum()
        {
            string array = "";
            array += String.Join(", ", methodData.Arr0711.ToArray());
            array += "\nSum = " + methodData.Arr0711.Sum();
            return array;
        }

        /// <summary>
        /// 取的陣列的最大值
        /// </summary>
        /// <returns></returns>
        public string ArrayMax()
        {
            string array = "";
            array += String.Join(", ", methodData.Arr0711.ToArray());
            array += "\nMax = " + methodData.Arr0711.Max();
            return array;
        }

        /// <summary>
        /// 取得陣列的最小值
        /// </summary>
        /// <returns></returns>
        public string ArrayMin()
        {
            string array = "";
            array += String.Join(", ", methodData.Arr0711.ToArray());
            array += "\nMin = " + methodData.Arr0711.Min();
            return array;
        }


    }



}
