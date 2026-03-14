using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace RealSample.DBUtilities {
    /// <summary>
    /// 基于 DbProviderFactory 的通用数据库访问辅助类（非静态，可实例化）
    /// </summary>
    public class SqlHelper {
        private readonly string _connectionString;
        private readonly DbProviderFactory _providerFactory;

        #region 构造函数

        /// <summary>
        /// 从配置文件读取连接字符串（默认名称为 "DBConnection"）
        /// </summary>
        public SqlHelper() {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            if (settings == null)
                throw new InvalidOperationException("请在配置文件的 connectionStrings 节点中添加名为 'DefaultConnection' 的连接字符串。");

            _connectionString = settings.ConnectionString;
            string providerName = settings.ProviderName;
            if (string.IsNullOrEmpty(providerName))
                providerName = "System.Data.SqlClient"; // 默认使用 SQL Server

            _providerFactory = DbProviderFactories.GetFactory(providerName);
        }

        /// <summary>
        /// 手动指定连接字符串和提供程序名称
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="providerName">提供程序名称（如 "System.Data.SqlClient"）</param>
        public SqlHelper(string connectionString, string providerName) {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");
            if (string.IsNullOrEmpty(providerName))
                throw new ArgumentNullException("providerName");

            _connectionString = connectionString;
            _providerFactory = DbProviderFactories.GetFactory(providerName);
        }

        #endregion

        #region 私有辅助方法

        private DbConnection GetConnection() {
            DbConnection conn = _providerFactory.CreateConnection();
            conn.ConnectionString = _connectionString;
            return conn;
        }

        private DbCommand GetCommand() {
            return _providerFactory.CreateCommand();
        }

        private void AddParameters(DbCommand cmd, params DbParameter[] parameters) {
            if (parameters != null) {
                foreach (DbParameter param in parameters) {
                    cmd.Parameters.Add(param);
                }
            }
        }

        #endregion

        #region 参数创建（实例方法，使用当前提供程序）

        /// <summary>
        /// 创建 DbParameter（参数名需与目标数据库占位符一致）
        /// </summary>
        public DbParameter CreateParameter(string name, object value) {
            DbParameter param = _providerFactory.CreateParameter();
            param.ParameterName = name;
            param.Value = value ?? DBNull.Value;
            return param;
        }

        /// <summary>
        /// 创建 DbParameter（指定 DbType）
        /// </summary>
        public DbParameter CreateParameter(string name, DbType dbType, object value) {
            DbParameter param = _providerFactory.CreateParameter();
            param.ParameterName = name;
            param.DbType = dbType;
            param.Value = value ?? DBNull.Value;
            return param;
        }

        // 可根据需要扩展其他重载（如指定大小、方向等）

        #endregion

        #region 执行方法

        /// <summary>
        /// 执行命令，返回受影响的行数
        /// </summary>
        public int ExecuteNonQuery(string commandText, CommandType commandType, params DbParameter[] parameters) {
            using (DbConnection conn = GetConnection()) {
                DbCommand cmd = GetCommand();
                cmd.Connection = conn;
                cmd.CommandText = commandText;
                cmd.CommandType = commandType;
                AddParameters(cmd, parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 在事务中执行命令，返回受影响的行数
        /// </summary>
        public int ExecuteNonQuery(DbTransaction trans, string commandText, CommandType commandType, params DbParameter[] parameters) {
            if (trans == null)
                throw new ArgumentNullException("trans");
            DbCommand cmd = GetCommand();
            cmd.Connection = trans.Connection;
            cmd.Transaction = trans;
            cmd.CommandText = commandText;
            cmd.CommandType = commandType;
            AddParameters(cmd, parameters);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 执行命令，返回第一行第一列的值
        /// </summary>
        public object ExecuteScalar(string commandText, CommandType commandType, params DbParameter[] parameters) {
            using (DbConnection conn = GetConnection()) {
                DbCommand cmd = GetCommand();
                cmd.Connection = conn;
                cmd.CommandText = commandText;
                cmd.CommandType = commandType;
                AddParameters(cmd, parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// 执行命令，返回 DbDataReader（调用者需自行关闭 Reader）
        /// </summary>
        public DbDataReader ExecuteReader(string commandText, CommandType commandType, params DbParameter[] parameters) {
            DbConnection conn = GetConnection();
            DbCommand cmd = GetCommand();
            cmd.Connection = conn;
            cmd.CommandText = commandText;
            cmd.CommandType = commandType;
            AddParameters(cmd, parameters);
            conn.Open();
            // CommandBehavior.CloseConnection 确保 DataReader 关闭时连接自动关闭
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 执行命令，返回 DataSet
        /// </summary>
        public DataSet ExecuteDataSet(string commandText, CommandType commandType, params DbParameter[] parameters) {
            using (DbConnection conn = GetConnection()) {
                DbCommand cmd = GetCommand();
                cmd.Connection = conn;
                cmd.CommandText = commandText;
                cmd.CommandType = commandType;
                AddParameters(cmd, parameters);
                DbDataAdapter adapter = _providerFactory.CreateDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }

        #endregion

        #region 存储过程快捷方式

        public int ExecuteProcedureNonQuery(string procedureName, params DbParameter[] parameters) {
            return ExecuteNonQuery(procedureName, CommandType.StoredProcedure, parameters);
        }

        public object ExecuteProcedureScalar(string procedureName, params DbParameter[] parameters) {
            return ExecuteScalar(procedureName, CommandType.StoredProcedure, parameters);
        }

        public DbDataReader ExecuteProcedureReader(string procedureName, params DbParameter[] parameters) {
            return ExecuteReader(procedureName, CommandType.StoredProcedure, parameters);
        }

        public DataSet ExecuteProcedureDataSet(string procedureName, params DbParameter[] parameters) {
            return ExecuteDataSet(procedureName, CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region 事务管理

        /// <summary>
        /// 开启一个新事务（调用者需负责提交/回滚并释放连接）
        /// </summary>
        public DbTransaction BeginTransaction() {
            DbConnection conn = GetConnection();
            conn.Open();
            return conn.BeginTransaction();
        }

        #endregion
    }
}
