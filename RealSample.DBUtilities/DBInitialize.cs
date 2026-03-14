using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Data;

namespace RealSample.DBUtilities {
    public class DBInitialize {
        public void TryExecuteScript(string scriptName) { 
            string script = ReadEmbeddedResource(scriptName);
            if (string.IsNullOrEmpty(script))
                throw new InvalidOperationException("嵌入式脚本内容为空。");

            // 执行整个脚本（假设数据库支持一次执行多条语句）
            SqlHelperFactory.GetDefault().ExecuteNonQuery(script, CommandType.Text);
        }

        private string ReadEmbeddedResource(string scriptName)
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(scriptName))
            {
                if (stream == null)
                    throw new Exception("未找到嵌入式资源: " + scriptName + "。请确认资源名称是否正确，并已将文件设为嵌入资源。");

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
