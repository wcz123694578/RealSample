using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace RealSample.Shared {
    public class HashHelper {
        /// <summary>
        /// 获取文件的 SHA256 哈希值
        /// </summary>
        /// <param name="filePath">完整的文件路径</param>
        /// <returns>返回 64 位的十六进制字符串</returns>
        public static string GetFileSha256(string filePath) {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("待计算的文件不存在", filePath);

            // 1. 创建 SHA256 算法实例
            // 注意：在 .NET 2.0 中使用 SHA256Managed
            using (SHA256 hashAlgorithm = SHA256Managed.Create()) {
                using (FileStream stream = File.OpenRead(filePath)) {
                    // 2. 计算哈希字节数组
                    byte[] hashBytes = hashAlgorithm.ComputeHash(stream);

                    // 3. 将字节数组转换为十六进制字符串
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++) {
                        // "x2" 表示十六进制，且始终占两位（不足补0）
                        sb.Append(hashBytes[i].ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
        }
    }
}
