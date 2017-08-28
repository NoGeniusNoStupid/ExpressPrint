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
    /// 流水号业务逻辑类
    /// </summary>
   public class ExpressNumBll
   {
        #region 向数据库中插入一条记录
       /// <summary>
        /// 数据库操作对象
        /// </summary>
       private ExpressNumDal _dao = new ExpressNumDal();
       #endregion

        #region 向数据库中添加一条记录 +int Insert(T_Column_Style model)
       /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
       public int Insert(MExpressNum model)
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
        public int Update(MExpressNum model)
        {
            return _dao.Update(model);
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
        public List<MExpressNum> QueryList(object wheres= null)
        {

            IEnumerable<MExpressNum> myList = _dao.QueryList(wheres);
            if (myList == null)
                return null;
            List<MExpressNum> list = new List<MExpressNum>();
            foreach (MExpressNum item in myList)
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
        public MExpressNum QuerySingle(string column_id)
        {
            return _dao.QuerySingle(column_id);
        }
        #endregion

       #region 获取快递流水号
        public string GetExpressNo(string expressName)
        {
            string expressNo = string.Empty;
            List<MExpressNum> List = QueryList(string.Format("where ExpressName='{0}'", expressName));
            if (List == null || List.Count <= 0)
                return null;
            MExpressNum mExpressNum = List[0];
            if (mExpressNum.ExrepssNumRule == "否")
                return null;
            if (mExpressNum.MaxNum == 0)
            {
                expressNo = mExpressNum.ExpressBeforeNum + mExpressNum.ExpressStartNum.ToString().PadLeft(mExpressNum.SerialNum,'0');
            }
            else
            {
                expressNo = mExpressNum.ExpressBeforeNum + mExpressNum.MaxNum.ToString().PadLeft(mExpressNum.SerialNum, '0');
            }
            return expressNo;
        }
       #endregion
   }
}
