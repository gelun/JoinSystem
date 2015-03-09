using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
    public class Join_HollandResults
    {
        
        #region  Join_HollandResults
        /// <summary>
        /// 调用存储过程增加一个
        /// </summary>
        /// <param name="info">实体对象</param>
        /// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
        public static int Join_HollandResultsAdd(Entity.Join_HollandResults info)
        {
            SqlParameter[] prams = {
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@Reality", SqlDbType.Int, 4, info.Reality),
				SqlDB.MakeInParam("@Study", SqlDbType.Int, 4, info.Study),
				SqlDB.MakeInParam("@Art", SqlDbType.Int, 4, info.Art),
				SqlDB.MakeInParam("@Society", SqlDbType.Int, 4, info.Society),
				SqlDB.MakeInParam("@Business", SqlDbType.Int, 4, info.Business),
				SqlDB.MakeInParam("@Tradition", SqlDbType.Int, 4, info.Tradition),
			};
            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_HollandResultsAdd", prams).ToString(), -1);
        }

        /// <summary>
        /// 调用存储过程修改一个
        /// </summary>
        /// <param name="info">实体对象</param>
        /// <returns>更新成功返回ture，否则返回false</returns>
        public static bool Join_HollandResultsEdit(Entity.Join_HollandResults info)
        {
            SqlParameter[] prams = {
				SqlDB.MakeInParam("@HollandResultsId", SqlDbType.Int, 4, info.HollandResultsId),
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@Reality", SqlDbType.Int, 4, info.Reality),
				SqlDB.MakeInParam("@Study", SqlDbType.Int, 4, info.Study),
				SqlDB.MakeInParam("@Art", SqlDbType.Int, 4, info.Art),
				SqlDB.MakeInParam("@Society", SqlDbType.Int, 4, info.Society),
				SqlDB.MakeInParam("@Business", SqlDbType.Int, 4, info.Business),
				SqlDB.MakeInParam("@Tradition", SqlDbType.Int, 4, info.Tradition),
				};
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_HollandResultsEdit", prams);
            if (intReturnValue == 1)
                return true;
            return false;
        }


        /// <summary>
        /// 获取所有的的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_HollandResultsList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT * FROM [Join_HollandResults] WHERE " + strWhere + ";";
            else
                strSql = "SELECT * FROM [Join_HollandResults] ;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }


        /// <summary>
        /// 获取某一个DataTable
        /// </summary>
        /// <param name="HollandResultsId">标识</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_HollandResultsGet(int HollandResultsId)
        {
            return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_HollandResults] WHERE HollandResultsId = " + HollandResultsId + ";").Tables[0];
        }

        /// <summary>
        /// 获取某一个实体
        /// </summary>
        /// <param name="HollandResultsId">标识</param>
        /// <returns>返回Entity</returns>
        public static Entity.Join_HollandResults Join_HollandResultsEntityGet(int HollandResultsId)
        {
            Entity.Join_HollandResults info = new Entity.Join_HollandResults();
            DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_HollandResults] WHERE HollandResultsId = " + HollandResultsId + ";").Tables[0];
            if (dt != null || dt.Rows.Count > 0)
            {
                info.HollandResultsId = Basic.Utils.StrToInt(dt.Rows[0]["HollandResultsId"].ToString(), 0);
                info.UserId = Basic.Utils.StrToInt(dt.Rows[0]["UserId"].ToString(), 0);
                info.Reality = Basic.Utils.StrToInt(dt.Rows[0]["Reality"].ToString(), 0);
                info.Study = Basic.Utils.StrToInt(dt.Rows[0]["Study"].ToString(), 0);
                info.Art = Basic.Utils.StrToInt(dt.Rows[0]["Art"].ToString(), 0);
                info.Society = Basic.Utils.StrToInt(dt.Rows[0]["Society"].ToString(), 0);
                info.Business = Basic.Utils.StrToInt(dt.Rows[0]["Business"].ToString(), 0);
                info.Tradition = Basic.Utils.StrToInt(dt.Rows[0]["Tradition"].ToString(), 0);

                return info;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 删除一个值
        /// </summary>
        /// <param name="HollandResultsId">自增id的值</param>
        /// <returns>删除成功返回ture，否则返回false</returns>
        public static bool Join_HollandResultsDel(int HollandResultsId)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_HollandResults]  WHERE HollandResultsId =  " + HollandResultsId);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 获取前多少的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <param name="TopNumber">数量</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_HollandResultsTopGet(string strWhere, int TopNumber)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_HollandResults] WHERE " + strWhere + ";";
            else
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_HollandResults] ;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }

        ///
        /// <summary>
        /// 获取前多少的值
        /// </summary>
        /// <param name="TopNumber">数量</param>
        /// <param name="PageSize">每页显示多少个</param>
        /// <param name="PageIndex">当前页码，最少为1</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_HollandResultsPageList(string strWhere, int PageSize, int PageIndex)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("SELECT * FROM Join_HollandResults");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.Append(" WHERE " + strWhere);
            }
            sbSql.Append(" ORDER BY HollandResultsId DESC");
            DataSet ds = new DataSet();
            ds = SqlDB.ExecuteDataset((PageIndex - 1) * PageSize, PageSize, CommandType.Text, sbSql.ToString());
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return new DataTable();
        }

        /// <summary>
        /// 获取该条件下的总的数量
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>如果没有就返回0</returns>
        public static int Join_HollandResultsCount(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT COUNT(*) FROM [Join_HollandResults] WHERE " + strWhere + ";";
            else
                strSql = "SELECT COUNT(*)  FROM [Join_HollandResults] ;";
            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
        }
        #endregion

    }
}

