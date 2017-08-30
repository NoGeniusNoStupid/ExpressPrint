// ===============================================================================
// 项目名称  :    ShoesOrderPrint.BLL
// 项目描述  :    
// ===============================================================================
// 类名称    :    PrinterBLL
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-30 15:25:46
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
    /// <summary>
    /// 打印机业务逻辑类
    /// </summary>
    public class PrinterBLL
    {
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        private PrinterDal _dao = new PrinterDal();

        #region 向数据库中添加一条记录 +int Insert(T_Printer model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MPrinter model)
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

        #region 根据主键ID更新一条记录 +int Update(T_Printer model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MPrinter model)
        {
            return _dao.Update(model);
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<T_Printer> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
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
            return _dao.QueryList(wheres);
        }
        #endregion

        #region 查询单个模型实体 +T_Printer QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public MPrinter QueryModel(object wheres)
        {
            return _dao.QueryModel(wheres);
        }
        #endregion

        #region 查询单个模型实体 +T_Printer QuerySingle(string uuid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="uuid">key</param>
        /// <returns>实体</returns>
        public MPrinter QuerySingle(string uuid)
        {
            return _dao.QuerySingle(uuid);
        }
        #endregion


    }
}
