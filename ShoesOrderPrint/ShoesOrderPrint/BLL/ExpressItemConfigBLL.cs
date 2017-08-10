using ShoesOrderPrint.DAL;
using ShoesOrderPrint.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint.BLL
{
    /// <summary>
    /// 表示打印项配置的管理类
    /// </summary>
   public class ExpressItemConfigBLL
    {
        /// <summary>
        /// 数据库操作对象
        /// </summary>
       private ExpressItemConfigDal _dao = new ExpressItemConfigDal();

        #region 向数据库中添加一条记录 +int Insert(T_PrintItem model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MExpressItemConfig model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region 删除一条记录 +int Delete(string itemid)
        public int Delete(string itemid)
        {
            return _dao.Delete(itemid);
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(T_PrintItem model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MExpressItemConfig model)
        {
            return _dao.Update(model);
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
        public IEnumerable<MExpressItemConfig> QueryList(object wheres)
        {
            return _dao.QueryList(wheres);
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
            return _dao.QuerySingle(wheres);
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
            return _dao.QuerySingle(itemid);
        }
        #endregion

        #region 查询条数 +int QueryCount(object wheres)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns>实体</returns>
        public int QueryCount(object wheres)
        {
            return _dao.QueryCount(wheres);
        }
        #endregion
    }
}
