using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal class ArrayHelper<T>
    {
        T[] myArr;
        public int GetArrLength()
        {
            return myArr.Length;

        }
        public T GetArrFirstElement()
        {
            return myArr[0];
        }
        public void SetArrayByLength(int arrLength)
        {
            myArr = new T[arrLength];
        }

    }
}
