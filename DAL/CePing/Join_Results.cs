using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_Results
    {
        
		#region  Join_Results
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_ResultsAdd(Entity.Join_Results info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@ResultsContent", SqlDbType.Int, 4, info.ResultsContent),
				SqlDB.MakeInParam("@AddTime", SqlDbType.Int, 4, info.AddTime),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_ResultsAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_ResultsEdit(Entity.Join_Results info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@ResultsId", SqlDbType.Int, 4, info.ResultsId),
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@ResultsContent", SqlDbType.Int, 4, info.ResultsContent),
				SqlDB.MakeInParam("@AddTime", SqlDbType.Int, 4, info.AddTime),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_ResultsEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ResultsList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_Results] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_Results] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="ResultsId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ResultsGet(int ResultsId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Results] WHERE ResultsId = "+ResultsId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="ResultsId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_Results Join_ResultsEntityGet(int ResultsId)
		{
			Entity.Join_Results info = new Entity.Join_Results();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Results] WHERE ResultsId = "+ResultsId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.ResultsId = Basic.Utils.StrToInt(dt.Rows[0]["ResultsId"].ToString(),0);
				info.UserId = Basic.Utils.StrToInt(dt.Rows[0]["UserId"].ToString(),0);
				info.ResultsContent = Basic.Utils.StrToInt(dt.Rows[0]["ResultsContent"].ToString(),0);
				info.AddTime = Basic.Utils.StrToInt(dt.Rows[0]["AddTime"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="ResultsId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_ResultsDel(int ResultsId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_Results]  WHERE ResultsId =  " + ResultsId);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取前多少的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <param name="TopNumber">数量</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ResultsTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Results] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Results] ;";
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
		public static DataTable Join_ResultsPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_Results");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY ResultsId DESC");
			DataSet ds = new DataSet();
			ds = SqlDB.ExecuteDataset((PageIndex-1)*PageSize, PageSize, CommandType.Text, sbSql.ToString());
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
		public static int Join_ResultsCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_Results] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_Results] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

