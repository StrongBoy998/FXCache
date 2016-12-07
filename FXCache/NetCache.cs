using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FXCache
{
    class NetCache:ICache
    {
        public void Insert(String key, Object o,int Second=7200)
        {
            HttpContext.Current.Cache.Insert(key, o,null,DateTime.Now.AddSeconds(Second),new TimeSpan(7200*1000*10));
        }
        public T Get<T>(String key)
        {
            return (T)HttpContext.Current.Cache.Get(key);
        }
        public void Remove(String key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

    }
}
