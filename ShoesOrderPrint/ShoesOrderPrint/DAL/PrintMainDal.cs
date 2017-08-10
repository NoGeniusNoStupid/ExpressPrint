// ===============================================================================
// 项目名称  :    ShoesOrderPrint.DAL
// 项目描述  :    
// ===============================================================================
// 类名称    :    PrintMainDal
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-3 17:28:52
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
    public class PrintMainDal
    {
        #region 向数据库中添加一条记录 +int Insert(MPrintMain model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MPrintMain model)
        {
            #region SQL语句
            const string sql = @"
INSERT INTO [T_PrintMain] (
	[UUID]
	,[TemplateName]
	,[BackImage]
	,[TemplateType]
)
VALUES (
	@UUID
	,@TemplateName
	,@BackImage
	,@TemplateType
);";
            #endregion
            var res = SqlHelper.ExecuteScalar(CommandType.Text,sql,
                    new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                    new SQLiteParameter("@TemplateName", SqlHelper.ToNullDBValue(model.TemplateName)),
                    new SQLiteParameter("@BackImage", SqlHelper.ToNullDBValue(model.BackImage)),
                    new SQLiteParameter("@TemplateType", SqlHelper.ToNullDBValue(model.TemplateType))
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(string uuid)
        public int Delete(string uuid)
        {
            const string sql = "DELETE FROM [dbo].[T_PrintMain] WHERE [UUID] = @UUID";
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql, new SQLiteParameter("@UUID", uuid));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(MPrintMain model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MPrintMain model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [T_PrintMain]
SET 
	[UUID] = @UUID
	,[TemplateName] = @TemplateName
	,[BackImage] = @BackImage
	,[TemplateType] = @TemplateType
WHERE [UUID] = @UUID";
            #endregion
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql,
                    new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                    new SQLiteParameter("@TemplateName", SqlHelper.ToNullDBValue(model.TemplateName)),
                    new SQLiteParameter("@BackImage", SqlHelper.ToNullDBValue(model.BackImage)),
                    new SQLiteParameter("@TemplateType", SqlHelper.ToNullDBValue(model.TemplateType))
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<MPrintMain> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<MPrintMain> QueryList(object wheres = null)
        {

            string sql = string.Format("select * from T_PrintMain {0}", wheres);
            using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<MPrintMain>(reader);
                    }
                }
            }
        }
        #endregion

        #region 查询单个模型实体 +MPrintMain QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public MPrintMain QuerySingle(object wheres)
        {
            var list = QueryList(wheres);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +MPrintMain QuerySingle(string uuid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="uuid">key</param>
        /// <returns>实体</returns>
        public MPrintMain QuerySingle(string uuid)
        {
            const string sql = "SELECT  [UUID], [TemplateName], [BackImage], [TemplateType] FROM [T_PrintMain] WHERE [UUID] = @UUID";
            using (var reader = SqlHelper.ExecuteReader(CommandType.Text,sql, new SQLiteParameter("@UUID", uuid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<MPrintMain>(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region 查询条数 +int QueryCount(object wheres)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns>条数</returns>
        public int QueryCount(object wheres)
        {
            var parameters = new List<SQLiteParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // 操作符
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SQLiteParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("T_PrintMain", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(CommandType.Text,sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
    }
}
