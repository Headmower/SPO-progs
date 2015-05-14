using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_CSharp
{
    static class ListWorker
    {
        public static int[] GenerateList(int N)
        {
            int[] list = new int[N];
            for (int i = 0; i < N; i++)
            {
                list[i] = i;
            }
            return list;
        }
    }
}
