using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FXCache
{
    public static class Cache
    {
        static ICache cache = null;

        static Cache()
        {
            Init();
        }

        static void Init()
        {
            String cacheType = System.Configuration.ConfigurationManager.AppSettings["CacheType"];
            switch (cacheType)
            {
                case "Net": cache = new NetCache(); break;
                case "Memcache": cache = new Memcache(); break;
                default: cache = null; break;
            }
        }



        public static void Insert(String key, Object o, int Second=7200)
        {
            if (cache == null)
                return;
            cache.Insert(key, o,Second);
        }

        public static void Remove(String key)
        {
            if (cache == null)
                return;
            cache.Remove(key); 
        }

        public static T Get<T>(String key)
        {
            if (cache == null)
                return default(T);
            return cache.Get<T>(key);
        }
    }
}
