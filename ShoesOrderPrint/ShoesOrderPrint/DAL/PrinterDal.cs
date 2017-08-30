// ===============================================================================
// 项目名称  :    ShoesOrderPrint.DAL
// 项目描述  :    
// ===============================================================================
// 类名称    :    PrinterDal
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-30 15:16:50
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using ShoesOrderPrint.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint.DAL
{
    /// <summary>
    /// 打印机业务处理类
    /// </summary>
    public class PrinterDal
    {
       
        #region 向数据库中添加一条记录 +int Insert(MPrinter model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MPrinter model)
        {
            #region SQL语句
            const string sql = @"
INSERT INTO [T_Printer] (
	[UUID]
	,[NowHeight]
	,[ExpressName]
	,[Printer]
	,[PrintFoward]
	,[PrintNum]
	,[LeftAway]
	,[TopAway]
	,[IniWeight]
	,[IniHeight]
	,[NowWeight]
)
VALUES (
	 @UUID
	,@NowHeight
	,@ExpressName
	,@Printer
	,@PrintFoward
	,@PrintNum
	,@LeftAway
	,@TopAway
	,@IniWeight
	,@IniHeight
	,@NowWeight
);";
            #endregion
            var res = SqlHelper.ExecuteScalar(CommandType.Text,sql,
					new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),					
					new SQLiteParameter("@NowHeight", SqlHelper.ToNullDBValue(model.NowHeight)),					
					new SQLiteParameter("@ExpressName", SqlHelper.ToNullDBValue(model.ExpressName)),					
					new SQLiteParameter("@Printer", SqlHelper.ToNullDBValue(model.Printer)),					
					new SQLiteParameter("@PrintFoward", SqlHelper.ToNullDBValue(model.PrintFoward)),					
					new SQLiteParameter("@PrintNum", SqlHelper.ToNullDBValue(model.PrintNum)),					
					new SQLiteParameter("@LeftAway", SqlHelper.ToNullDBValue(model.LeftAway)),					
					new SQLiteParameter("@TopAway", SqlHelper.ToNullDBValue(model.TopAway)),					
					new SQLiteParameter("@IniWeight", SqlHelper.ToNullDBValue(model.IniWeight)),					
					new SQLiteParameter("@IniHeight", SqlHelper.ToNullDBValue(model.IniHeight)),					
					new SQLiteParameter("@NowWeight", SqlHelper.ToNullDBValue(model.NowWeight))					
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(string uuid)
        public int Delete(string uuid)
        {
            const string sql = "DELETE FROM [dbo].[T_Printer] WHERE [UUID] = @UUID";
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql, new SQLiteParameter("@UUID", uuid));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(MPrinter model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MPrinter model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [T_Printer]
SET 
	[UUID] = @UUID
	,[NowHeight] = @NowHeight
	,[ExpressName] = @ExpressName
	,[Printer] = @Printer
	,[PrintFoward] = @PrintFoward
	,[PrintNum] = @PrintNum
	,[LeftAway] = @LeftAway
	,[TopAway] = @TopAway
	,[IniWeight] = @IniWeight
	,[IniHeight] = @IniHeight
	,[NowWeight] = @NowWeight
WHERE [UUID] = @UUID";
            #endregion
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql,
					new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),					
					new SQLiteParameter("@NowHeight", SqlHelper.ToNullDBValue(model.NowHeight)),					
					new SQLiteParameter("@ExpressName", SqlHelper.ToNullDBValue(model.ExpressName)),					
					new SQLiteParameter("@Printer", SqlHelper.ToNullDBValue(model.Printer)),					
					new SQLiteParameter("@PrintFoward", SqlHelper.ToNullDBValue(model.PrintFoward)),					
					new SQLiteParameter("@PrintNum", SqlHelper.ToNullDBValue(model.PrintNum)),					
					new SQLiteParameter("@LeftAway", SqlHelper.ToNullDBValue(model.LeftAway)),					
					new SQLiteParameter("@TopAway", SqlHelper.ToNullDBValue(model.TopAway)),					
					new SQLiteParameter("@IniWeight", SqlHelper.ToNullDBValue(model.IniWeight)),					
					new SQLiteParameter("@IniHeight", SqlHelper.ToNullDBValue(model.IniHeight)),					
					new SQLiteParameter("@NowWeight", SqlHelper.ToNullDBValue(model.NowWeight))					
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<MPrinter> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<MPrinter> QueryList(object wheres)
        {
            string sql = string.Format("select * from T_Printer {0}", wheres);
            using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<MPrinter>(reader);
                    }
                }
            }
        }
        #endregion

        #region 查询单个模型实体 +MPrinter QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public MPrinter QueryModel(object wheres)
        {
            var list = QueryList(wheres);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +MPrinter QuerySingle(string uuid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="uuid">key</param>
        /// <returns>实体</returns>
        public MPrinter QuerySingle(string uuid)
        {
            const string sql = "SELECT [UUID], [NowHeight], [ExpressName], [Printer], [PrintFoward], [PrintNum], [LeftAway], [TopAway], [IniWeight], [IniHeight], [NowWeight] FROM [T_Printer] WHERE [UUID] = @UUID";
            using (var reader = SqlHelper.ExecuteReader(CommandType.Text,sql, new SQLiteParameter("@UUID", uuid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<MPrinter>(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

     
	}
}
