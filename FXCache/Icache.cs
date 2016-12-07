using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FXCache
{
    interface ICache
    {
        void Insert(String key, Object o,int Second=7200);
        T Get<T>(String key);
        void Remove(String key);
    }
}
