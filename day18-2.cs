using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    interface IAndroid//안드로이드 폰은 무조건 구굴 아이디가 있어야 한다-> 하지만 인터페이스는 필드를 가질 수 없다. -> 프로퍼티를 통해서 강제한다.
    {
        string GoogleID { get; }//프로퍼티
    }
    class Phone
    {

    }
    class Galaxy : Phone, IAndroid
    {
        public string GoogleID
        {
            get;
        }
    }
    class Xperia : Phone,IAndroid
    {
        public string GoogleID
        {
            get;
        }
    }

    class Pixel : Phone,IAndroid
    {
        public string GoogleID
        {
            get;
        }
    }
    class IPhone: Phone
    {

    }

    class GooglePlay<T> where T : IAndroid
    {
        T _phone;

    }

    internal class day18_2
    {
    }

}
