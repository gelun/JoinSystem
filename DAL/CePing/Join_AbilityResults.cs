using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_AbilityResults
    {
        
		#region  Join_AbilityResults
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_AbilityResultsAdd(Entity.Join_AbilityResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@Language", SqlDbType.Float, 8, info.Language),
				SqlDB.MakeInParam("@Tissue", SqlDbType.Float, 8, info.Tissue),
				SqlDB.MakeInParam("@Among", SqlDbType.Float, 8, info.Among),
				SqlDB.MakeInParam("@Mathematics", SqlDbType.Float, 8, info.Mathematics),
				SqlDB.MakeInParam("@Motion", SqlDbType.Float, 8, info.Motion),
				SqlDB.MakeInParam("@Writing", SqlDbType.Float, 8, info.Writing),
				SqlDB.MakeInParam("@Watch", SqlDbType.Float, 8, info.Watch),
				SqlDB.MakeInParam("@Space", SqlDbType.Float, 8, info.Space),
				SqlDB.MakeInParam("@Art", SqlDbType.Float, 8, info.Art),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_AbilityResultsAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_AbilityResultsEdit(Entity.Join_AbilityResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@AbilityResultsId", SqlDbType.Int, 4, info.AbilityResultsId),
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@Language", SqlDbType.Float, 8, info.Language),
				SqlDB.MakeInParam("@Tissue", SqlDbType.Float, 8, info.Tissue),
				SqlDB.MakeInParam("@Among", SqlDbType.Float, 8, info.Among),
				SqlDB.MakeInParam("@Mathematics", SqlDbType.Float, 8, info.Mathematics),
				SqlDB.MakeInParam("@Motion", SqlDbType.Float, 8, info.Motion),
				SqlDB.MakeInParam("@Writing", SqlDbType.Float, 8, info.Writing),
				SqlDB.MakeInParam("@Watch", SqlDbType.Float, 8, info.Watch),
				SqlDB.MakeInParam("@Space", SqlDbType.Float, 8, info.Space),
				SqlDB.MakeInParam("@Art", SqlDbType.Float, 8, info.Art),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_AbilityResultsEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
	
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_AbilityResultsList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_AbilityResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_AbilityResults] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="AbilityResultsId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_AbilityResultsGet(int AbilityResultsId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_AbilityResults] WHERE AbilityResultsId = "+AbilityResultsId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="AbilityResultsId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_AbilityResults Join_AbilityResultsEntityGet(int AbilityResultsId)
		{
			Entity.Join_AbilityResults info = new Entity.Join_AbilityResults();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_AbilityResults] WHERE AbilityResultsId = "+AbilityResultsId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.AbilityResultsId = Basic.Utils.StrToInt(dt.Rows[0]["AbilityResultsId"].ToString(),0);
				info.UserId = Basic.Utils.StrToInt(dt.Rows[0]["UserId"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="AbilityResultsId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_AbilityResultsDel(int AbilityResultsId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_AbilityResults]  WHERE AbilityResultsId =  " + AbilityResultsId);
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
		public static DataTable Join_AbilityResultsTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_AbilityResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_AbilityResults] ;";
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
		public static DataTable Join_AbilityResultsPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_AbilityResults");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY AbilityResultsId DESC");
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
		public static int Join_AbilityResultsCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_AbilityResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_AbilityResults] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

