﻿using System.Web.Caching;
using YanZhiwei.DotNet.Core.Config;
using YanZhiwei.DotNet.Core.Model;
using YanZhiwei.DotNet.MVC.AdminPanel.Config.Model;
using YanZhiwei.DotNet2.Utilities.WebForm.Core;

namespace YanZhiwei.DotNet.MVC.AdminPanel.Config
{
    public class CachedConfigContext : ConfigContext
    {
        /// <summary>
        /// 重写基类的取配置，加入缓存机制
        /// </summary>
        public override T Get<T>(string index = null)
        {
            var fileName = this.GetConfigFileName<T>(index);
            var key = "ConfigFile_" + fileName;
            var content = CacheManger.Get(key);
            if (content != null)
                return (T)content;

            var value = base.Get<T>(index);
            CacheManger.Set(key, value, new CacheDependency(ConfigService.GetFilePath(fileName)));
            return value;
        }

        public static CachedConfigContext Current = new CachedConfigContext();

        public DaoConfig DaoConfig
        {
            get
            {
                return this.Get<DaoConfig>();
            }
        }

        public CacheConfig CacheConfig
        {
            get
            {
                return this.Get<CacheConfig>();
            }
        }
    }
}