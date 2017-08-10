using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace ShoesOrderPrint
{
    /// <summary>
    /// 表单快递单的数据库链路层
    /// </summary>
    public class ExpressDal
    {
       private CommandType myCommandType = new CommandType();

        #region 向数据库中添加一条记录 +int Insert(MExpress model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MExpress model)
        {
           
            #region SQL语句
            const string sql = @"
INSERT INTO [T_Express] (
	[UUID]
	,[Sender_Tel]
	,[Sender_Province]
	,[Sender_City]
	,[Receive_Province]
	,[Receive_City]
	,[Receive_Name]
	,[Receive_ZipCode]
	,[Receive_Address]
	,[Receive_Company_Name]
	,[Receive_Phone]
	,[Express_No]
	,[Receive_Tel]
	,[Goods_Pic]
	,[Goods_Name]
	,[Goods_Size]
	,[Sum]
	,[Is_Stock]
	,[Is_Print]
	,[Status]
	,[Expree_Type]
	,[Expree_Date]
	,[Sender_Name]
	,[Sender_ZipCode]
	,[Sender_Address]
	,[Sender_Company_Name]
	,[Sender_Phone]
)
VALUES (
	@UUID
	,@Sender_Tel
	,@Sender_Province
	,@Sender_City
	,@Receive_Province
	,@Receive_City
	,@Receive_Name
	,@Receive_ZipCode
	,@Receive_Address
	,@Receive_Company_Name
	,@Receive_Phone
	,@Express_No
	,@Receive_Tel
	,@Goods_Pic
	,@Goods_Name
	,@Goods_Size
	,@Sum
	,@Is_Stock
	,@Is_Print
	,@Status
	,@Expree_Type
	,@Expree_Date
	,@Sender_Name
	,@Sender_ZipCode
	,@Sender_Address
	,@Sender_Company_Name
	,@Sender_Phone
);";
            #endregion
            var res = SqlHelper.ExecuteNonQuery(CommandType.Text, sql,
                    new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                    new SQLiteParameter("@Sender_Tel", SqlHelper.ToNullDBValue(model.SenderTel)),
                    new SQLiteParameter("@Sender_Province", SqlHelper.ToNullDBValue(model.SenderProvince)),
                    new SQLiteParameter("@Sender_City", SqlHelper.ToNullDBValue(model.SenderCity)),
                    new SQLiteParameter("@Receive_Province", SqlHelper.ToNullDBValue(model.ReceiveProvince)),
                    new SQLiteParameter("@Receive_City", SqlHelper.ToNullDBValue(model.ReceiveCity)),
                    new SQLiteParameter("@Receive_Name", SqlHelper.ToNullDBValue(model.ReceiveName)),
                    new SQLiteParameter("@Receive_ZipCode", SqlHelper.ToNullDBValue(model.ReceiveZipCode)),
                    new SQLiteParameter("@Receive_Address", SqlHelper.ToNullDBValue(model.ReceiveAddress)),
                    new SQLiteParameter("@Receive_Company_Name", SqlHelper.ToNullDBValue(model.ReceiveCompanyName)),
                    new SQLiteParameter("@Receive_Phone", SqlHelper.ToNullDBValue(model.ReceivePhone)),
                    new SQLiteParameter("@Express_No", SqlHelper.ToNullDBValue(model.ExpressNo)),
                    new SQLiteParameter("@Receive_Tel", SqlHelper.ToNullDBValue(model.ReceiveTel)),
                    new SQLiteParameter("@Goods_Pic", SqlHelper.ToNullDBValue(model.GoodsPic)),
                    new SQLiteParameter("@Goods_Name", SqlHelper.ToNullDBValue(model.GoodsName)),
                    new SQLiteParameter("@Goods_Size", SqlHelper.ToNullDBValue(model.GoodsSize)),
                    new SQLiteParameter("@Sum", SqlHelper.ToNullDBValue(model.Sum)),
                    new SQLiteParameter("@Is_Stock", SqlHelper.ToNullDBValue(model.IsStock)),
                    new SQLiteParameter("@Is_Print", SqlHelper.ToNullDBValue(model.IsPrint)),
                    new SQLiteParameter("@Status", SqlHelper.ToNullDBValue(model.Status)),
                    new SQLiteParameter("@Expree_Type", SqlHelper.ToNullDBValue(model.ExpreeType)),
                    new SQLiteParameter("@Expree_Date", SqlHelper.ToNullDBValue(model.ExpreeDate)),
                    new SQLiteParameter("@Sender_Name", SqlHelper.ToNullDBValue(model.SenderName)),
                    new SQLiteParameter("@Sender_ZipCode", SqlHelper.ToNullDBValue(model.SenderZipCode)),
                    new SQLiteParameter("@Sender_Address", SqlHelper.ToNullDBValue(model.SenderAddress)),
                    new SQLiteParameter("@Sender_Company_Name", SqlHelper.ToNullDBValue(model.SenderCompanyName)),
                    new SQLiteParameter("@Sender_Phone", SqlHelper.ToNullDBValue(model.SenderPhone))
                );
            return  Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(string uuid)
        public int Delete(string uuid)
        {
            const string sql = "DELETE FROM [T_Express] WHERE [UUID] = @UUID";
            return SqlHelper.ExecuteNonQuery(myCommandType,sql, new SQLiteParameter("@UUID", uuid));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(MExpress model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MExpress model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [T_Express]
SET 
	 [UUID] = @UUID
	,[Sender_Tel] = @Sender_Tel
	,[Sender_Province] = @Sender_Province
	,[Sender_City] = @Sender_City
	,[Receive_Province] = @Receive_Province
	,[Receive_City] = @Receive_City
	,[Receive_Name] = @Receive_Name
	,[Receive_ZipCode] = @Receive_ZipCode
	,[Receive_Address] = @Receive_Address
	,[Receive_Company_Name] = @Receive_Company_Name
	,[Receive_Phone] = @Receive_Phone
	,[Express_No] = @Express_No
	,[Receive_Tel] = @Receive_Tel
	,[Goods_Pic] = @Goods_Pic
	,[Goods_Name] = @Goods_Name
	,[Goods_Size] = @Goods_Size
	,[Sum] = @Sum
	,[Is_Stock] = @Is_Stock
	,[Is_Print] = @Is_Print
	,[Status] = @Status
	,[Expree_Type] = @Expree_Type
	,[Expree_Date] = @Expree_Date
	,[Sender_Name] = @Sender_Name
	,[Sender_ZipCode] = @Sender_ZipCode
	,[Sender_Address] = @Sender_Address
	,[Sender_Company_Name] = @Sender_Company_Name
	,[Sender_Phone] = @Sender_Phone
WHERE [UUID] = @UUID";
            #endregion
            return SqlHelper.ExecuteNonQuery(myCommandType,sql,
                   new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                    new SQLiteParameter("@Sender_Tel", SqlHelper.ToNullDBValue(model.SenderTel)),
                    new SQLiteParameter("@Sender_Province", SqlHelper.ToNullDBValue(model.SenderProvince)),
                    new SQLiteParameter("@Sender_City", SqlHelper.ToNullDBValue(model.SenderCity)),
                    new SQLiteParameter("@Receive_Province", SqlHelper.ToNullDBValue(model.ReceiveProvince)),
                    new SQLiteParameter("@Receive_City", SqlHelper.ToNullDBValue(model.ReceiveCity)),
                    new SQLiteParameter("@Receive_Name", SqlHelper.ToNullDBValue(model.ReceiveName)),
                    new SQLiteParameter("@Receive_ZipCode", SqlHelper.ToNullDBValue(model.ReceiveZipCode)),
                    new SQLiteParameter("@Receive_Address", SqlHelper.ToNullDBValue(model.ReceiveAddress)),
                    new SQLiteParameter("@Receive_Company_Name", SqlHelper.ToNullDBValue(model.ReceiveCompanyName)),
                    new SQLiteParameter("@Receive_Phone", SqlHelper.ToNullDBValue(model.ReceivePhone)),
                    new SQLiteParameter("@Express_No", SqlHelper.ToNullDBValue(model.ExpressNo)),
                    new SQLiteParameter("@Receive_Tel", SqlHelper.ToNullDBValue(model.ReceiveTel)),
                    new SQLiteParameter("@Goods_Pic", SqlHelper.ToNullDBValue(model.GoodsPic)),
                    new SQLiteParameter("@Goods_Name", SqlHelper.ToNullDBValue(model.GoodsName)),
                    new SQLiteParameter("@Goods_Size", SqlHelper.ToNullDBValue(model.GoodsSize)),
                    new SQLiteParameter("@Sum", SqlHelper.ToNullDBValue(model.Sum)),
                    new SQLiteParameter("@Is_Stock", SqlHelper.ToNullDBValue(model.IsStock)),
                    new SQLiteParameter("@Is_Print", SqlHelper.ToNullDBValue(model.IsPrint)),
                    new SQLiteParameter("@Status", SqlHelper.ToNullDBValue(model.Status)),
                    new SQLiteParameter("@Expree_Type", SqlHelper.ToNullDBValue(model.ExpreeType)),
                    new SQLiteParameter("@Expree_Date", SqlHelper.ToNullDBValue(model.ExpreeDate)),
                    new SQLiteParameter("@Sender_Name", SqlHelper.ToNullDBValue(model.SenderName)),
                    new SQLiteParameter("@Sender_ZipCode", SqlHelper.ToNullDBValue(model.SenderZipCode)),
                    new SQLiteParameter("@Sender_Address", SqlHelper.ToNullDBValue(model.SenderAddress)),
                    new SQLiteParameter("@Sender_Company_Name", SqlHelper.ToNullDBValue(model.SenderCompanyName)),
                    new SQLiteParameter("@Sender_Phone", SqlHelper.ToNullDBValue(model.SenderPhone))
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<T_Express> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<MExpress> QueryList(object wheres=null)
        {
            
            string sql = string.Format("select * from T_Express {0}",wheres);      
            using (var reader = SqlHelper.ExecuteReader(myCommandType,sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<MExpress>(reader);
                    }
                }
            }
        }
        #endregion

        #region 查询单个模型实体 +T_Express QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public MExpress QuerySingle(object wheres)
        {
            var list = QueryList(wheres);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +MExpress QuerySingle(string uuid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="uuid">key</param>
        /// <returns>实体</returns>
        public MExpress QuerySingle(string uuid)
        {
            const string sql = "SELECT [UUID], [Sender_Tel], [Sender_Province], [Sender_City], [Receive_Province], [Receive_City], [Receive_Name], [Receive_ZipCode], [Receive_Address], [Receive_Company_Name], [Receive_Phone], [Express_No], [Receive_Tel], [Goods_Pic], [Goods_Name], [Goods_Size], [Sum], [Is_Stock], [Is_Print], [Status], [Expree_Type], [Expree_Date], [Sender_Name], [Sender_ZipCode], [Sender_Address], [Sender_Company_Name], [Sender_Phone] FROM [T_Express] WHERE [UUID] = @UUID";
            using (var reader = SqlHelper.ExecuteReader(CommandType.Text,sql, new SQLiteParameter("@UUID", uuid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<MExpress>(reader);
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
            var sql = SqlHelper.GenerateQuerySql("T_Express", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(myCommandType,sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
    }
}
