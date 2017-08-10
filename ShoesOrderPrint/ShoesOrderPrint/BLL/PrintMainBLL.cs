// ===============================================================================
// 项目名称  :    ShoesOrderPrint.BLL
// 项目描述  :    
// ===============================================================================
// 类名称    :    PrintMainBLL
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-3 17:29:03
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using ShoesOrderPrint.DAL;
using ShoesOrderPrint.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint.BLL
{
    public class PrintMainBLL
    {

        /// <summary>
        /// 数据库操作对象
        /// </summary>
        private PrintMainDal _dao = new PrintMainDal();

        #region 向数据库中添加一条记录 +int Insert(T_PrintMain model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MPrintMain model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region 删除一条记录 +int Delete(string uuid)
        public int Delete(string uuid)
        {
            return _dao.Delete(uuid);
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(T_PrintMain model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MPrintMain model)
        {
            return _dao.Update(model);
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<T_PrintMain> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<MPrintMain> QueryList(object wheres)
        {
            return _dao.QueryList(wheres);
        }
        #endregion

        #region 查询单个模型实体 +T_PrintMain QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public MPrintMain QuerySingle(object wheres)
        {
            return _dao.QuerySingle(wheres);
        }
        #endregion

        #region 查询单个模型实体 +T_PrintMain QuerySingle(string uuid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="uuid">key</param>
        /// <returns>实体</returns>
        public MPrintMain QuerySingle(string uuid)
        {
            return _dao.QuerySingle(uuid);
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
