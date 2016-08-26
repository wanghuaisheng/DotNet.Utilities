﻿namespace YanZhiwei.DotNet2.Utilities.Operator
{
    using Common;
    using DataOperator;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    /// INI文件操作
    /// </summary>
    /// 时间：2016/8/25 14:59
    /// 备注：
    public class INIOperator
    {
        private static string filePath = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="path">INI文件路径</param>
        /// 时间：2016/8/25 15:00
        /// 备注：
        public INIOperator(string path)
        {
            FileHelper.CreatePath(path);
            filePath = path;
        }

        /// <summary>
        /// 读取INI
        /// </summary>
        /// <param name="section">段落名称</param>
        /// <param name="key">关键字</param>
        /// <returns>读取值</returns>
        public string Get(string section, string key)
        {
            CheckedINIParamter(section, key);
            StringBuilder _builder = new StringBuilder(500);
            GetPrivateProfileString(section, key, string.Empty, _builder, 500, filePath);
            return _builder.ToString();
        }

        /// <summary>
        /// 读取INI
        /// </summary>
        /// <param name="section">段落名称</param>
        /// <param name="key">关键字</param>
        /// <param name="defaultValue">当根据KEY读取不到值得时候缺省值</param>
        /// <returns>读取的值</returns>
        public string Get(string section, string key, string defaultValue)
        {
            CheckedINIParamter(section, key);
            StringBuilder _builder = new StringBuilder(500);
            GetPrivateProfileString(section, key, defaultValue, _builder, 500, filePath);
            return _builder.ToString();
        }

        /// <summary>
        /// 写入INI
        /// eg:_iniHelper.WriteValue("测试", "Name", "YanZhiwei");
        /// </summary>
        /// <param name="section">段落名称</param>
        /// <param name="key">关键字</param>
        /// <param name="value">关键字对应的值</param>
        public void Write(string section, string key, string value)
        {
            CheckedINIParamter(section, key);
            WritePrivateProfileString(section, key, value, filePath);
        }

        /// <summary>
        /// 声明INI文件的读操作函数
        /// </summary>
        /// <param name="section">段落名称</param>
        /// <param name="key">关键字</param>
        /// <param name="def">无法读取时候时候的缺省数值</param>
        /// <param name="retVal">读取数值</param>
        /// <param name="size">数值的大小></param>
        /// <param name="filePath">路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// 声明INI文件的写操作函数
        /// </summary>
        /// <param name="section">段落名称</param>
        /// <param name="key">关键字</param>
        /// <param name="val">关键字对应的值</param>
        /// <param name="filePath">路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        private void CheckedINIParamter(string section, string key)
        {
            ValidateHelper.Begin().NotNullOrEmpty(section, "INI段落").NotNullOrEmpty(key, "INI段落对应KEY");
        }
    }
}