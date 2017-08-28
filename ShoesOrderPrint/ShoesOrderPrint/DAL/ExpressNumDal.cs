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
   public class ExpressNumDal
    {
       #region 向数据库中添加一条记录 +int Insert(TColumnStyle model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
       public int Insert(MExpressNum model)
        {
            #region SQL语句
            const string sql = @"
INSERT INTO [T_ExpressNum] (
	 [UUID]
	,[ExpressName]
	,[ModuleId]
	,[ExrepssNumRule]
	,[ExpressStartNum]
	,[SerialNum]
	,[MaxNum]
	,[ExpressBeforeNum]
)
VALUES (
 	 @UUID
	,@ExpressName
	,@ModuleId
	,@ExrepssNumRule
    ,@ExpressStartNum
	,@SerialNum
	,@MaxNum
	,@ExpressBeforeNum
);";
            #endregion
            var res = SqlHelper.ExecuteNonQuery(CommandType.Text, sql,
                    new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                    new SQLiteParameter("@ExpressName", SqlHelper.ToNullDBValue(model.ModuleId)),
                    new SQLiteParameter("@ModuleId", SqlHelper.ToNullDBValue(model.ExpressName)),
                    new SQLiteParameter("@ExrepssNumRule", SqlHelper.ToNullDBValue(model.ExrepssNumRule)),
                    new SQLiteParameter("@ExpressStartNum", SqlHelper.ToNullDBValue(model.ExpressStartNum)),
                    new SQLiteParameter("@SerialNum", SqlHelper.ToNullDBValue(model.SerialNum)),
                    new SQLiteParameter("@MaxNum", SqlHelper.ToNullDBValue(model.MaxNum)),
                    new SQLiteParameter("@ExpressBeforeNum", SqlHelper.ToNullDBValue(model.ExpressBeforeNum)));
            return Convert.ToInt32(res);
        }
        #endregion

       #region 删除一条记录 +int Delete(string UUID)
       public int Delete(string UUID)
       {
           const string sql = "DELETE FROM T_ExpressNum WHERE [UUID] = @UUID";
           return SqlHelper.ExecuteNonQuery(CommandType.Text, sql, new SQLiteParameter("@UUID", UUID));
       }
       #endregion
       
       #region 根据主键ID更新一条记录 +int Update(TColumnStyle model)
       /// <summary>
       /// 根据主键ID更新一条记录
       /// </summary>
       /// <param name="model">更新后的实体</param>
       /// <returns>执行结果受影响行数</returns>
       public int Update(MExpressNum model)
       {
           #region SQL语句
           const string sql = @"
UPDATE [T_ExpressNum]
SET 
	 [UUID] = @UUID
	,[ExpressName] = @ExpressName
	,[ModuleId] = @ModuleId
	,[ExrepssNumRule] = @ExrepssNumRule
	,[ExpressStartNum] = @ExpressStartNum
	,[SerialNum] = @SerialNum
	,[MaxNum] = @MaxNum
	,[ExpressBeforeNum] = @ExpressBeforeNum
WHERE [UUID] = @UUID";
           #endregion
           return SqlHelper.ExecuteNonQuery(CommandType.Text, sql,
                   new SQLiteParameter("@UUID", SqlHelper.ToNullDBValue(model.UUID)),
                   new SQLiteParameter("@ExpressName", SqlHelper.ToNullDBValue(model.ExpressName)),
                   new SQLiteParameter("@ModuleId", SqlHelper.ToNullDBValue(model.ModuleId)),
                   new SQLiteParameter("@ExrepssNumRule", SqlHelper.ToNullDBValue(model.ExrepssNumRule)),
                   new SQLiteParameter("@ExpressStartNum", SqlHelper.ToNullDBValue(model.ExpressStartNum)),
                   new SQLiteParameter("@SerialNum", SqlHelper.ToNullDBValue(model.SerialNum)),
                   new SQLiteParameter("@MaxNum", SqlHelper.ToNullDBValue(model.MaxNum)),
                   new SQLiteParameter("@ExpressBeforeNum", SqlHelper.ToNullDBValue(model.ExpressBeforeNum))
               );
       }
    
       #endregion

       #region 查询单个模型实体 +TColumnStyle QuerySingle(string columnid)
       /// <summary>
       /// 查询单个模型实体
       /// </summary>
       /// <param name="columnid">key</param>
       /// <returns>实体</returns>
       public MExpressNum QuerySingle(string columnid)
       {
           const string sql = "SELECT * FROM [T_ExpressNum] WHERE [UUID] = @UUID";
           using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql, new SQLiteParameter("@ColumnId", columnid)))
           {
               if (reader.HasRows)
               {
                   reader.Read();
                   return SqlHelper.MapEntity<MExpressNum>(reader);
               }
               else
               {
                   return null;
               }
           }
       }
       #endregion

       #region 分页查询一个集合 +IEnumerable<MExpressNum> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
       /// <summary>
       /// 分页查询一个集合
       /// </summary>
       /// <param name="index">页码</param>
       /// <param name="size">页大小</param>
       /// <param name="wheres">条件匿名类</param>
       /// <param name="orderField">排序字段</param>
       /// <param name="isDesc">是否降序排序</param>
       /// <returns>实体集合</returns>
       public IEnumerable<MExpressNum> QueryList(object wheres = null)
       {
           string sql = string.Format("select * from T_ExpressNum {0}", wheres);
           using (var reader = SqlHelper.ExecuteReader(CommandType.Text, sql))
           {
               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       yield return SqlHelper.MapEntity<MExpressNum>(reader);
                   }
               }
           }


       }
       #endregion
    }
}
