// ===============================================================================
// 项目名称  :    ShoesOrderPrint
// 项目描述  :    
// ===============================================================================
// 类名称    :    SqlHelper
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-7-19 17:18:07
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint
{
    public static class SqlHelper
    {
        //定义数据库连接串
        public static string connStr = string.Format(@"Data Source={0}DataBase\SHOEDB.db;Version=3;", AppDomain.CurrentDomain.BaseDirectory);
        // 存贮Cache缓存的Hashtable集合

        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
        /// <summary>
        /// 使用连接字符串，执行一个SQLiteCommand命令（没有记录返回）
        /// 使用提供的参数集.
        /// </summary>
        /// <remarks>
        /// 示例:int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SQLiteParameter("@prodid", 24));   
        /// </remarks>
        /// <param name="connectionString">一个有效的SQLiteConnection连接串</param>
        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>
        /// <param name="commandText">存贮过程名称或是一个T-SQLite语句串</param>
        /// <param name="commandParameters">执行命令的参数集</param>
        /// <returns>受此命令影响的行数</returns>

        public static int ExecuteNonQuery(CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                //通过PrepareCommand方法将参数逐个加入到SQLiteCommand的参数集合中
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                int val = cmd.ExecuteNonQuery();
                //清空SQLiteCommand中的参数列表
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 在一个存在的连接上执行数据库的命令操作
        /// 使用提供的参数集.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(connection, CommandType.StoredProcedure, "PublishOrders", new SQLiteParameter("@prodid", 24));
        /// </remarks>
        /// <param name="conn">一个存在的数据库连接对象</param>
        /// <param name="commandType">命令类型CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">存贮过程名称或是一个T-SQLite语句串</param>
        /// <param name="commandParameters">执行命令的参数集</param>
        /// <returns>受此命令影响的行数</returns>

        public static int ExecuteNonQuery(SQLiteConnection connection, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// 在一个事务的连接上执行数据库的命令操作
        /// 使用提供的参数集.
        /// </summary>        
        /// <remarks>
        /// e.g.:  
        ///  int result = ExecuteNonQuery(trans, CommandType.StoredProcedure, "PublishOrders", new SQLiteParameter("@prodid", 24));
        /// </remarks>
        /// <param name="trans">一个存在的事务</param>
        /// <param name="commandType">命令类型CommandType (stored procedure, text, etc.)</param>
        /// <param name="commandText">存贮过程名称或是一个T-SQLite语句串</param>
        /// <param name="commandParameters">执行命令的参数集</param>
        /// <returns>受此命令影响的行数</returns>

        public static int ExecuteNonQuery(SQLiteTransaction trans, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// 在一个连接串上执行一个命令，返回一个SQLiteDataReader对象
        /// 使用提供的参数.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  SQLiteDataReader r = ExecuteReader(connString, CommandType.StoredProcedure, "PublishOrders", new SQLiteParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">一个有效的SQLiteConnection连接串(改了参数名称)</param>
        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>
        /// <param name="commandText">存贮过程名称或是一个T-SQLite语句串</param>
        /// <param name="commandParameters">执行命令的参数集</param>
        /// <returns>一个结果集对象SQLiteDataReader</returns>

        public static SQLiteDataReader ExecuteReader(CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteConnection conn = new SQLiteConnection(connStr);

            // 如果不存在要查询的对象，则发生异常
            // 连接要关闭
            // CommandBehavior.CloseConnection在异常时不发生作用

            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SQLiteDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        /// <summary>
        /// 在一个连接串上执行一个命令，返回一个SQLiteDataAdapter对象
        /// 使用提供的参数.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  SQLiteDataReader r = ExecuteAdapter(connString, CommandType.StoredProcedure, "PublishOrders", new SQLiteParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">一个有效的SQLiteConnection连接串(改了参数名称)</param>
        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>
        /// <param name="commandText">存贮过程名称或是一个T-SQLite语句串</param>
        /// <param name="commandParameters">执行命令的参数集</param>
        /// <returns>一个结果集对象SQLiteDataReader</returns>
        public static SQLiteDataAdapter ExecuteAdapter(CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
        {

            SQLiteConnection conn = new SQLiteConnection(connStr);
            SQLiteCommand cmd = new SQLiteCommand();

            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
                SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
                cmd.Parameters.Clear();
                return adp;
            }
            catch
            {
                conn.Close();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        public static SQLiteDataAdapter Adapter(CommandType cmdType, string cmdText, params SQLiteParameter[] cmdParms)
        {

            SQLiteConnection conn = new SQLiteConnection(connStr);
            SQLiteDataAdapter adp = new SQLiteDataAdapter();
            SQLiteCommand cmd = new SQLiteCommand();
            PrepareCommand(cmd, conn, cmdType, cmdText, cmdParms);
            adp.SelectCommand = cmd;
            return adp;
        }

        /// <summary>
        /// 在一个连接串上执行一个命令，返回表中第一行，第一列的值
        /// 使用提供的参数.
        /// </summary>        
        /// <remarks>
        /// e.g.:  
        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SQLiteParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">一个有效的SQLiteConnection连接串</param>
        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>
        /// <param name="commandText">存贮过程名称或是一个T-SQLite语句串</param>
        /// <param name="commandParameters">执行命令的参数集</param>        
        /// <returns>返回的对象，在使用时记得类型转换</returns>

        public static object ExecuteScalar(CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            using (SQLiteConnection connection = new SQLiteConnection(connStr))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 在一个连接上执行一个命令，返回表中第一行，第一列的值
        /// 使用提供的参数.
        /// </summary>
        /// <remarks>
        /// e.g.:  
        ///  Object obj = ExecuteScalar(connString, CommandType.StoredProcedure, "PublishOrders", new SQLiteParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">一个有效的SQLiteConnection连接</param>
        /// <param name="commandType">命令类型CommandType(stored procedure, text, etc.)</param>
        /// <param name="commandText">存贮过程名称或是一个T-SQLite语句串</param>
        /// <param name="commandParameters">执行命令的参数集</param>        /// <returns>返回的对象，在使用时记得类型转换</returns>

        public static object ExecuteScalar(SQLiteTransaction tran, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            using (SQLiteConnection connection = new SQLiteConnection(connStr))
            {
                PrepareCommand(cmd, connection, tran, cmdType, cmdText, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 在缓存中添加参数数组
        /// </summary>
        /// <param name="cacheKey">参数的Key</param>
        /// <param name="cmdParms">参数数组</param>

        public static void CacheParameters(string cacheKey, params SQLiteParameter[] commandParameters)
        {
            parmCache[cacheKey] = commandParameters;
        }

        /// <summary>
        /// 提取缓存的参数数组
        /// </summary>
        /// <param name="cacheKey">查找缓存的key</param>
        /// <returns>返回被缓存的参数数组</returns>

        public static SQLiteParameter[] GetCachedParameters(string cacheKey)
        {

            SQLiteParameter[] cachedParms = (SQLiteParameter[])parmCache[cacheKey];
            if (cachedParms == null)
                return null;
            SQLiteParameter[] clonedParms = new SQLiteParameter[cachedParms.Length];
            for (int i = 0, j = cachedParms.Length; i < j; i++)
                clonedParms[i] = (SQLiteParameter)((ICloneable)cachedParms[i]).Clone();
            return clonedParms;
        }

        /// <summary>
        /// 提供一个SQLiteCommand对象的设置
        /// </summary>
        /// <param name="cmd">SQLiteCommand对象</param>
        /// <param name="conn">SQLiteConnection 对象</param>
        /// <param name="trans">SQLiteTransaction 对象</param>
        /// <param name="cmdType">CommandType 如存贮过程，T-SQLite</param>
        /// <param name="cmdText">存贮过程名或查询串</param>
        /// <param name="cmdParms">命令中用到的参数集</param>

        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, CommandType cmdType, string cmdText, SQLiteParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            if (cmdParms != null)
            {                
                foreach (SQLiteParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        /// <summary>
        /// 提供一个SQLiteCommand对象的设置
        /// </summary>
        /// <param name="cmd">SQLiteCommand对象</param>
        /// <param name="conn">SQLiteConnection 对象</param>
        /// <param name="trans">SQLiteTransaction 对象</param>
        /// <param name="cmdType">CommandType 如存贮过程，T-SQLite</param>
        /// <param name="cmdText">存贮过程名或查询串</param>
        /// <param name="cmdParms">命令中用到的参数集</param>

        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, CommandType cmdType, string cmdText, SQLiteParameter[] cmdParms)
        {

            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (SQLiteParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }


        public static object ToNullDBValue(this object value)
        {
            return value == null ? DBNull.Value : value;
        }

        public static object FromDBValue(this object dbValue)
        {
            return dbValue == DBNull.Value ? null : dbValue;
        }


        #region 将一个SqlDataReader对象转换成一个实体类对象 +static TEntity MapEntity<TEntity>(SqlDataReader reader) where TEntity : class,new()
        /// <summary>
        /// 将一个SqlDataReader对象转换成一个实体类对象
        /// </summary>
        /// <typeparam name="TEntity">实体类型</typeparam>
        /// <param name="reader">当前指向的reader</param>
        /// <returns>实体对象</returns>
        public static TEntity MapEntity<TEntity>(SQLiteDataReader reader) where TEntity : class,new()
        {
            try
            {
                var props = typeof(TEntity).GetProperties();//表示实体对象
                var entity = new TEntity();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    foreach (var prop in props)
                    {
                        string name = reader.GetName(i).Replace("_", "");
                        if (name == prop.Name)
                        {
                            try
                            {
                                var index = reader.GetOrdinal(reader.GetName(i));
                                var data = reader.GetValue(index);
                                if (data != DBNull.Value)
                                {
                                    prop.SetValue(entity, Convert.ChangeType(data, prop.PropertyType), null);
                                    break;
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                continue;
                            }
                        }
                    }
                }              
                return entity;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 生成分页查询数据库语句 +static string GenerateQuerySql(string table, string[] columns, int index, int size, string wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 生成分页查询数据库语句, 返回生成的T-SQL语句
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="columns">列集合, 多个列用英文逗号分割(colum1,colum2...)</param>
        /// <param name="index">页码(即第几页)(传入-1则表示忽略分页取出全部)</param>
        /// <param name="size">显示页面大小(即显示条数)</param>
        /// <param name="where">条件语句(忽略则传入null)</param>
        /// <param name="orderField">排序字段(即根据那个字段排序)(忽略则传入null)</param>
        /// <param name="isDesc">排序方式(0:降序(desc)|1:升序(asc))(忽略则传入-1)</param>
        /// <returns>生成的T-SQL语句</returns>
        public static string GenerateQuerySql(string table, string[] columns, int index, int size, string where, string orderField, bool isDesc = true)
        {
            if (index == 1)
            {
                // 生成查询第一页SQL
                return GenerateQuerySql(table, columns, size, where, orderField, isDesc);
            }
            if (index < 1)
            {
                // 取全部数据
                return GenerateQuerySql(table, columns, where, orderField, isDesc);
            }
            if (string.IsNullOrEmpty(orderField))
            {
                throw new ArgumentNullException("orderField");
            }
            // 其他情况, 生成row_number分页查询语句
            // SQL模版
            const string format = @"select {0} from
                                    (
                                        select ROW_NUMBER() over(order by [{1}] {2}) as num, {0} from [{3}] {4}
                                    )
                                    as tbl
                                    where
                                        tbl.num between ({5}-1)*{6} + 1 and {5}*{6};";
            // where语句组建
            where = string.IsNullOrEmpty(where) ? string.Empty : "where " + where;
            // 查询字段拼接
            string column = columns != null && columns.Any() ? string.Join(" , ", columns) : "*";
            return string.Format(format, column, orderField, isDesc ? "desc" : string.Empty, table, where, index, size);
        }
        #endregion

        #region 生成查询数据库语句查询全部 +static string GenerateQuerySql(string table, string[] columns, string wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 生成查询数据库语句查询全部, 返回生成的T-SQL语句
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="columns">列集合</param>
        /// <param name="where">条件语句(忽略则传入null)</param>
        /// <param name="orderField">排序字段(即根据那个字段排序)(忽略则传入null)</param>
        /// <param name="isDesc">排序方式(0:降序(desc)|1:升序(asc))(忽略则传入-1)</param>
        /// <returns>生成的T-SQL语句</returns>
        public static string GenerateQuerySql(string table, string[] columns, string where, string orderField, bool isDesc = true)
        {
            // where语句组建
            where = string.IsNullOrEmpty(where) ? string.Empty : "where " + where;
            // 查询字段拼接
            string column = columns != null && columns.Any() ? string.Join(" , ", columns) : "*";
            const string format = "select {0} from [{1}] {2} {3} {4}";
            return string.Format(format, column, table, where,
                string.IsNullOrEmpty(orderField) ? string.Empty : "order by " + orderField,
                isDesc && !string.IsNullOrEmpty(orderField) ? "desc" : string.Empty);
        }
        #endregion

        #region 生成分页查询数据库语句查询第一页 +static string GenerateQuerySql(string table, string[] columns, int size, string where, string orderField, bool isDesc = true)
        /// <summary>
        /// 生成分页查询数据库语句查询第一页, 返回生成的T-SQL语句
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="columns">列集合</param>
        /// <param name="size">显示页面大小(即显示条数)</param>
        /// <param name="where">条件语句(忽略则传入null)</param>
        /// <param name="orderField">排序字段(即根据那个字段排序)(忽略则传入null)</param>
        /// <param name="isDesc">排序方式(0:降序(desc)|1:升序(asc))(忽略则传入-1)</param>
        /// <returns>生成的T-SQL语句</returns>
        public static string GenerateQuerySql(string table, string[] columns, int size, string where, string orderField, bool isDesc = true)
        {
            // where语句组建
            where = string.IsNullOrEmpty(where) ? string.Empty : "where " + where;
            // 查询字段拼接
            string column = columns != null && columns.Any() ? string.Join(" , ", columns) : "*";
            const string format = "select top {0} {1} from [{2}] {3} {4} {5}";
            return string.Format(format, size, column, table, where,
                  string.IsNullOrEmpty(orderField) ? string.Empty : "order by " + orderField,
                  isDesc && !string.IsNullOrEmpty(orderField) ? "desc" : string.Empty);
        }
        #endregion

    }
}
