using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_MbtiResults
    {
		#region  Join_MbtiResults
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_MbtiResultsAdd(Entity.Join_MbtiResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@StudentId", SqlDbType.Int, 4, info.StudentId),
				SqlDB.MakeInParam("@E", SqlDbType.Int, 4, info.E),
				SqlDB.MakeInParam("@I", SqlDbType.Int, 4, info.I),
				SqlDB.MakeInParam("@S", SqlDbType.Int, 4, info.S),
				SqlDB.MakeInParam("@N", SqlDbType.Int, 4, info.N),
				SqlDB.MakeInParam("@T", SqlDbType.Int, 4, info.T),
				SqlDB.MakeInParam("@F", SqlDbType.Int, 4, info.F),
				SqlDB.MakeInParam("@J", SqlDbType.Int, 4, info.J),
				SqlDB.MakeInParam("@P", SqlDbType.Int, 4, info.P),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_MbtiResultsAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_MbtiResultsEdit(Entity.Join_MbtiResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@StudentId", SqlDbType.Int, 4, info.StudentId),
				SqlDB.MakeInParam("@E", SqlDbType.Int, 4, info.E),
				SqlDB.MakeInParam("@I", SqlDbType.Int, 4, info.I),
				SqlDB.MakeInParam("@S", SqlDbType.Int, 4, info.S),
				SqlDB.MakeInParam("@N", SqlDbType.Int, 4, info.N),
				SqlDB.MakeInParam("@T", SqlDbType.Int, 4, info.T),
				SqlDB.MakeInParam("@F", SqlDbType.Int, 4, info.F),
				SqlDB.MakeInParam("@J", SqlDbType.Int, 4, info.J),
				SqlDB.MakeInParam("@P", SqlDbType.Int, 4, info.P),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_MbtiResultsEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_MbtiResultsList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_MbtiResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_MbtiResults] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_MbtiResultsGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_MbtiResults] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_MbtiResults Join_MbtiResultsEntityGet(int Id)
		{
			Entity.Join_MbtiResults info = new Entity.Join_MbtiResults();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_MbtiResults] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.StudentId = Basic.Utils.StrToInt(dt.Rows[0]["StudentId"].ToString(),0);
				info.E = Basic.Utils.StrToInt(dt.Rows[0]["E"].ToString(),0);
				info.I = Basic.Utils.StrToInt(dt.Rows[0]["I"].ToString(),0);
				info.S = Basic.Utils.StrToInt(dt.Rows[0]["S"].ToString(),0);
				info.N = Basic.Utils.StrToInt(dt.Rows[0]["N"].ToString(),0);
				info.T = Basic.Utils.StrToInt(dt.Rows[0]["T"].ToString(),0);
				info.F = Basic.Utils.StrToInt(dt.Rows[0]["F"].ToString(),0);
				info.J = Basic.Utils.StrToInt(dt.Rows[0]["J"].ToString(),0);
				info.P = Basic.Utils.StrToInt(dt.Rows[0]["P"].ToString(),0);
                info.AddTime = Basic.Utils.StrToDateTime(dt.Rows[0]["AddTime"].ToString());

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
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_MbtiResultsDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_MbtiResults]  WHERE Id =  " + Id);
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
		public static DataTable Join_MbtiResultsTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_MbtiResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_MbtiResults] ;";
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
		public static DataTable Join_MbtiResultsPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_MbtiResults");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY Id DESC");
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
		public static int Join_MbtiResultsCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_MbtiResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_MbtiResults] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

