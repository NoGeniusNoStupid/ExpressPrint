// ===============================================================================
// 项目名称  :    ShoesOrderPrint.DAL
// 项目描述  :    
// ===============================================================================
// 类名称    :    ColumnStyleDal
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-15 16:48:22
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
    public class ColumnStyleDal
    {
        #region 向数据库中添加一条记录 +int Insert(TColumnStyle model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MColumnStyle model)
        {
            #region SQL语句
            const string sql = @"
INSERT INTO [T_Column_Style] (
	[Column_Id]
	,[Style_Name]
	,[Column_Name]
	,[Column_Caption]
	,[Column_Type]
	,[Column_Index]
	,[Column_Width]
	,[Column_Visible]
	,[Update_Sign]
)
VALUES (
	@ColumnId
	,@StyleName
	,@ColumnName
	,@ColumnCaption
	,@ColumnType
	,@ColumnIndex
	,@ColumnWidth
	,@ColumnVisible
	,@UpdateSign
);";
            #endregion
            var res = SqlHelper.ExecuteNonQuery(CommandType.Text, sql,
                    new SQLiteParameter("@ColumnId", SqlHelper.ToNullDBValue(model.ColumnId)),
                    new SQLiteParameter("@StyleName", SqlHelper.ToNullDBValue(model.StyleName)),
                    new SQLiteParameter("@ColumnName", SqlHelper.ToNullDBValue(model.ColumnName)),
                    new SQLiteParameter("@ColumnCaption", SqlHelper.ToNullDBValue(model.ColumnCaption)),
                    new SQLiteParameter("@ColumnType", SqlHelper.ToNullDBValue(model.ColumnType)),
                    new SQLiteParameter("@ColumnIndex", SqlHelper.ToNullDBValue(model.ColumnIndex)),
                    new SQLiteParameter("@ColumnWidth", SqlHelper.ToNullDBValue(model.ColumnWidth)),
                    new SQLiteParameter("@ColumnVisible", SqlHelper.ToNullDBValue(model.ColumnVisible)),
                    new SQLiteParameter("@UpdateSign", SqlHelper.ToNullDBValue(model.UpdateSign))
                );
            return  Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(string columnid)
        public int Delete(string columnid)
        {
            const string sql = "DELETE FROM T_Column_Style WHERE [Column_Id] = @ColumnId";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, new SQLiteParameter("@ColumnId", columnid));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(TColumnStyle model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MColumnStyle model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [T_Column_Style]
SET 
	[Column_Id] = @ColumnId
	,[Style_Name] = @StyleName
	,[Column_Name] = @ColumnName
	,[Column_Caption] = @ColumnCaption
	,[Column_Type] = @ColumnType
	,[Column_Index] = @ColumnIndex
	,[Column_Width] = @ColumnWidth
	,[Column_Visible] = @ColumnVisible
	,[Update_Sign] = @UpdateSign
WHERE [ColumnId] = @ColumnId";
            #endregion
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql,
					new SQLiteParameter("@ColumnId", SqlHelper.ToNullDBValue(model.ColumnId)),					
					new SQLiteParameter("@StyleName", SqlHelper.ToNullDBValue(model.StyleName)),					
					new SQLiteParameter("@ColumnName", SqlHelper.ToNullDBValue(model.ColumnName)),					
					new SQLiteParameter("@ColumnCaption", SqlHelper.ToNullDBValue(model.ColumnCaption)),					
					new SQLiteParameter("@ColumnType", SqlHelper.ToNullDBValue(model.ColumnType)),					
					new SQLiteParameter("@ColumnIndex", SqlHelper.ToNullDBValue(model.ColumnIndex)),					
					new SQLiteParameter("@ColumnWidth", SqlHelper.ToNullDBValue(model.ColumnWidth)),					
					new SQLiteParameter("@ColumnVisible", SqlHelper.ToNullDBValue(model.ColumnVisible)),					
					new SQLiteParameter("@UpdateSign", SqlHelper.ToNullDBValue(model.UpdateSign))					
                );
        }

        public int Update(int columnWidth,string columnCaption, string styleName)
        {
            string sql =string.Format(@"update T_Column_Style set Column_Width={0}
        where Style_Name='{1}' and Column_Caption ='{2}'", columnWidth, styleName, columnCaption);
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql);
        }
        #endregion

        #region 查询单个模型实体 +TColumnStyle QuerySingle(string columnid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="columnid">key</param>
        /// <returns>实体</returns>
        public MColumnStyle QuerySingle(string columnid)
        {
            const string sql = "SELECT * FROM [T_Column_Style] WHERE [ColumnId] = @ColumnId";
            using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql, new SQLiteParameter("@ColumnId", columnid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<MColumnStyle>(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<TColumnStyle> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<MColumnStyle> QueryList(object wheres = null)
        {
            string sql = string.Format("select * from T_Column_Style {0}", wheres);
            using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<MColumnStyle>(reader);
                    }
                }
            }


        }
        #endregion
    }
}
