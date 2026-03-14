using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.DBUtilities {
    public class SqlHelperFactory {
        // 缓存已创建的实例，键为连接字符串（或自定义名称）
        private static readonly Dictionary<string, SqlHelper> _instances = new Dictionary<string, SqlHelper>();

        /// <summary>
        /// 获取默认的 SQLHelper（使用配置文件连接）
        /// </summary>
        public static SqlHelper GetDefault() {
            return GetInstance("default");  // 用一个固定键表示默认
        }

        /// <summary>
        /// 根据连接字符串和提供程序获取或创建 SQLHelper 实例
        /// </summary>
        public static SqlHelper GetInstance(string connectionString, string providerName) {
            string key = connectionString + "|" + providerName;
            lock (_instances) {
                if (!_instances.ContainsKey(key)) {
                    _instances[key] = new SqlHelper(connectionString, providerName);
                }
                return _instances[key];
            }
        }

        // 内部方法：获取或创建默认实例
        private static SqlHelper GetInstance(string key) {
            lock (_instances) {
                if (!_instances.ContainsKey(key)) {
                    _instances[key] = new SqlHelper();  // 使用配置文件构造
                }
                return _instances[key];
            }
        }
    }
}
