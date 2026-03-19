using System;
using System.Collections.Generic;
using System.Text;

namespace RealSample.Ioc {
    public class ServiceLocator {
        // 存储服务实例或工厂的容器
        private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        /// <summary>
        /// 注册服务实例
        /// </summary>
        public static void Register<T>(T service) {
            Type type = typeof(T);
            if (!_services.ContainsKey(type)) {
                _services.Add(type, service);
            }
        }

        /// <summary>
        /// 获取服务实例
        /// </summary>
        public static T Get<T>() {
            Type type = typeof(T);
            if (!_services.ContainsKey(type)) {
                throw new Exception("未注册服务类型: " + type.FullName);
            }
            return (T)_services[type];
        }
    }
}
