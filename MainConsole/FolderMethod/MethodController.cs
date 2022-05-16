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
			MethodData = new MethodData();
		}

        public MethodData MethodData { get => methodData; set => methodData = value; }

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
		public  bool IsOdd(int num)
		{
			return Convert.ToBoolean(num % 2);
		}


	}

 

}
