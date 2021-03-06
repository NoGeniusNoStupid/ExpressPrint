﻿// ===============================================================================
// 项目名称  :    ShoesOrderPrint.BLL
// 项目描述  :    
// ===============================================================================
// 类名称    :    ColumnStyleDal
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-15 16:57:14
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
    public class ColumnStyleBLL
    {
        /// <summary>
        /// 数据库操作对象
        /// </summary>
        private ColumnStyleDal _dao = new ColumnStyleDal();

        #region 向数据库中添加一条记录 +int Insert(T_Column_Style model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(MColumnStyle model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region 删除一条记录 +int Delete(string column_id)
        public int Delete(string column_id)
        {
            return _dao.Delete(column_id);
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(T_Column_Style model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(MColumnStyle model)
        {
            return _dao.Update(model);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="columnWidth"></param>
        /// <param name="columnCaption"></param>
        /// <param name="styleName"></param>
        /// <returns></returns>
        public int Update(int columnWidth, string columnCaption, string styleName)
        {
            return _dao.Update(columnWidth, columnCaption, styleName);
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<T_Column_Style> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public List<MColumnStyle> QueryList(object wheres)
        {

           IEnumerable<MColumnStyle> myList = _dao.QueryList(wheres);
           if (myList == null)
               return null;
           List<MColumnStyle> list = new List<MColumnStyle>();
           foreach (MColumnStyle item in myList)
           {
               list.Add(item);
           }
           return list;
        }
        #endregion

        #region 查询单个模型实体 +T_Column_Style QuerySingle(string column_id)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="column_id">key</param>
        /// <returns>实体</returns>
        public MColumnStyle QuerySingle(string column_id)
        {
            return _dao.QuerySingle(column_id);
        }
        #endregion
 
    }
}
