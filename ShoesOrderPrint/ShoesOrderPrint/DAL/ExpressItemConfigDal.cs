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
    ///
    /// </summary>
    public class ExpressItemConfigDal
    {
       
            #region 向数据库中添加一条记录 +int Insert(T_PrintItem model)
            /// <summary>
            /// 向数据库中添加一条记录
            /// </summary>
            /// <param name="model">要添加的实体</param>
            /// <returns>插入数据的ID</returns>
            public int Insert(MExpressItemConfig model)
            {
                #region SQL语句
                const string sql = @"
INSERT INTO [T_PrintItem] (
	[ItemID]
	,[Font]
	,[FontSize]
	,[SeqNo]
	,[Visable]
	,[UUID]
	,[TemplateName]
	,[ItemlName]
	,[ItemlCode]
	,[Wight]
	,[Helght]
	,[LeftAway]
	,[TopAway]
    ,[PrintColor]
)
VALUES (
	@ItemID
	,@Font
	,@FontSize
	,@SeqNo
	,@Visable
	,@UUID
	,@TemplateName
	,@ItemlName
	,@ItemlCode
	,@Wight
	,@Helght
	,@LeftAway
	,@TopAway
    ,@PrintColor
);";
                #endregion
                var res = SqlHelper.ExecuteScalar(CommandType.Text, sql,
                        new SQLiteParameter("@ItemID", SqlHelper.ToNullDBValue(model.ItemID)),
                        new SQLiteParameter("@Font", SqlHelper.ToNullDBValue(model.Font)),
                        new SQLiteParameter("@FontSize", SqlHelper.ToNullDBValue(model.FontSize)),
                        new SQLiteParameter("@SeqNo", SqlHelper.ToNullDBValue(model.SeqNo)),
                        new SQLiteParameter("@Visable", SqlHelper.ToNullDBValue(model.Visable)),
                        new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                        new SQLiteParameter("@TemplateName", SqlHelper.ToNullDBValue(model.TemplateName)),
                        new SQLiteParameter("@ItemlName", SqlHelper.ToNullDBValue(model.ItemlName)),
                        new SQLiteParameter("@ItemlCode", SqlHelper.ToNullDBValue(model.ItemlCode)),
                        new SQLiteParameter("@Wight", SqlHelper.ToNullDBValue(model.Wight)),
                        new SQLiteParameter("@Helght", SqlHelper.ToNullDBValue(model.Helght)),
                        new SQLiteParameter("@LeftAway", SqlHelper.ToNullDBValue(model.LeftAway)),
                        new SQLiteParameter("@TopAway", SqlHelper.ToNullDBValue(model.TopAway)),
                        new SQLiteParameter("@PrintColor", SqlHelper.ToNullDBValue(model.PrintColor))
                    );
                return res == null ? 0 : Convert.ToInt32(res);
            }
            #endregion

            #region 删除一条记录 +int Delete(string itemid)
            public int Delete(string itemid)
            {
                const string sql = "DELETE FROM [T_PrintItem] WHERE [ItemID] = @ItemID";
                return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, new SQLiteParameter("@ItemID", itemid));
            }
            #endregion

            #region 根据主键ID更新一条记录 +int Update(MExpressItemConfig model)
            /// <summary>
            /// 根据主键ID更新一条记录
            /// </summary>
            /// <param name="model">更新后的实体</param>
            /// <returns>执行结果受影响行数</returns>
            public int Update(MExpressItemConfig model)
            {
                #region SQL语句
                const string sql = @"
UPDATE [T_PrintItem]
SET 
	[ItemID] = @ItemID
	,[Font] = @Font
	,[FontSize] = @FontSize
	,[SeqNo] = @SeqNo
	,[Visable] = @Visable
	,[UUID] = @UUID
	,[TemplateName] = @TemplateName
	,[ItemlName] = @ItemlName
	,[ItemlCode] = @ItemlCode
	,[Wight] = @Wight
	,[Helght] = @Helght
	,[LeftAway] = @LeftAway
	,[TopAway] = @TopAway
    ,[PrintColor] = @PrintColor
WHERE [ItemID] = @ItemID";
                #endregion
                return SqlHelper.ExecuteNonQuery(CommandType.Text, sql,
                        new SQLiteParameter("@ItemID", SqlHelper.ToNullDBValue(model.ItemID)),
                        new SQLiteParameter("@Font", SqlHelper.ToNullDBValue(model.Font)),
                        new SQLiteParameter("@FontSize", SqlHelper.ToNullDBValue(model.FontSize)),
                        new SQLiteParameter("@SeqNo", SqlHelper.ToNullDBValue(model.SeqNo)),
                        new SQLiteParameter("@Visable", SqlHelper.ToNullDBValue(model.Visable)),
                        new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                        new SQLiteParameter("@TemplateName", SqlHelper.ToNullDBValue(model.TemplateName)),
                        new SQLiteParameter("@ItemlName", SqlHelper.ToNullDBValue(model.ItemlName)),
                        new SQLiteParameter("@ItemlCode", SqlHelper.ToNullDBValue(model.ItemlCode)),
                        new SQLiteParameter("@Wight", SqlHelper.ToNullDBValue(model.Wight)),
                        new SQLiteParameter("@Helght", SqlHelper.ToNullDBValue(model.Helght)),
                        new SQLiteParameter("@LeftAway", SqlHelper.ToNullDBValue(model.LeftAway)),
                        new SQLiteParameter("@TopAway", SqlHelper.ToNullDBValue(model.TopAway)),
                        new SQLiteParameter("@PrintColor", SqlHelper.ToNullDBValue(model.PrintColor))
                    );
            }
            #endregion

            #region 分页查询一个集合 +IEnumerable<T_PrintItem> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
            /// <summary>
            /// 分页查询一个集合
            /// </summary>
            /// <param name="index">页码</param>
            /// <param name="size">页大小</param>
            /// <param name="wheres">条件匿名类</param>
            /// <param name="orderField">排序字段</param>
            /// <param name="isDesc">是否降序排序</param>
            /// <returns>实体集合</returns>
            public IEnumerable<MExpressItemConfig> QueryList(object wheres = null)
            {
                string sql = string.Format("select * from T_PrintItem {0}", wheres);
                using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql))
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            yield return SqlHelper.MapEntity<MExpressItemConfig>(reader);
                        }
                    }
                }
            }
            #endregion

            #region 查询单个模型实体 +T_PrintItem QuerySingle(object wheres)
            /// <summary>
            /// 查询单个模型实体
            /// </summary>
            /// <param name="wheres">条件匿名类</param>
            /// <returns>实体</returns>
            public MExpressItemConfig QuerySingle(object wheres)
            {
                var list = QueryList(wheres);
                return list != null && list.Any() ? list.FirstOrDefault() : null;
            }
            #endregion

            #region 查询单个模型实体 +T_PrintItem QuerySingle(string itemid)
            /// <summary>
            /// 查询单个模型实体
            /// </summary>
            /// <param name="itemid">key</param>
            /// <returns>实体</returns>
            public MExpressItemConfig QuerySingle(string itemid)
            {
                const string sql = "SELECT  [ItemID], [Font], [FontSize], [SeqNo], [Visable], [UUID], [TemplateName], [ItemlName], [ItemlCode], [Wight], [Helght], [LeftAway], [TopAway] FROM [T_PrintItem] WHERE [ItemID] = @ItemID";
                using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql, new SQLiteParameter("@ItemID", itemid)))
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return SqlHelper.MapEntity<MExpressItemConfig>(reader);
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
                var sql = SqlHelper.GenerateQuerySql("T_PrintItem", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
                var res = SqlHelper.ExecuteScalar(CommandType.Text,sql, parameters.ToArray());
                return res == null ? 0 : Convert.ToInt32(res);
            }
            #endregion
        
    }
}
