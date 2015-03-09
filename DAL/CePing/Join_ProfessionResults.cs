using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_ProfessionResults
    {
        
		#region  Join_ProfessionResults
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_ProfessionResultsAdd(Entity.Join_ProfessionResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@Group1", SqlDbType.Int, 4, info.Group1),
				SqlDB.MakeInParam("@Group2", SqlDbType.Int, 4, info.Group2),
				SqlDB.MakeInParam("@Group3", SqlDbType.Int, 4, info.Group3),
				SqlDB.MakeInParam("@Group4", SqlDbType.Int, 4, info.Group4),
				SqlDB.MakeInParam("@Group5", SqlDbType.Int, 4, info.Group5),
				SqlDB.MakeInParam("@Group6", SqlDbType.Int, 4, info.Group6),
				SqlDB.MakeInParam("@Group7", SqlDbType.Int, 4, info.Group7),
				SqlDB.MakeInParam("@Group8", SqlDbType.Int, 4, info.Group8),
				SqlDB.MakeInParam("@Group9", SqlDbType.Int, 4, info.Group9),
				SqlDB.MakeInParam("@Group10", SqlDbType.Int, 4, info.Group10),
				SqlDB.MakeInParam("@Group11", SqlDbType.Int, 4, info.Group11),
				SqlDB.MakeInParam("@Group12", SqlDbType.Int, 4, info.Group12),
				SqlDB.MakeInParam("@Group13", SqlDbType.Int, 4, info.Group13),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_ProfessionResultsAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_ProfessionResultsEdit(Entity.Join_ProfessionResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@ProfessionResultsId", SqlDbType.Int, 4, info.ProfessionResultsId),
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@Group1", SqlDbType.Int, 4, info.Group1),
				SqlDB.MakeInParam("@Group2", SqlDbType.Int, 4, info.Group2),
				SqlDB.MakeInParam("@Group3", SqlDbType.Int, 4, info.Group3),
				SqlDB.MakeInParam("@Group4", SqlDbType.Int, 4, info.Group4),
				SqlDB.MakeInParam("@Group5", SqlDbType.Int, 4, info.Group5),
				SqlDB.MakeInParam("@Group6", SqlDbType.Int, 4, info.Group6),
				SqlDB.MakeInParam("@Group7", SqlDbType.Int, 4, info.Group7),
				SqlDB.MakeInParam("@Group8", SqlDbType.Int, 4, info.Group8),
				SqlDB.MakeInParam("@Group9", SqlDbType.Int, 4, info.Group9),
				SqlDB.MakeInParam("@Group10", SqlDbType.Int, 4, info.Group10),
				SqlDB.MakeInParam("@Group11", SqlDbType.Int, 4, info.Group11),
				SqlDB.MakeInParam("@Group12", SqlDbType.Int, 4, info.Group12),
				SqlDB.MakeInParam("@Group13", SqlDbType.Int, 4, info.Group13),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_ProfessionResultsEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
	
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ProfessionResultsList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_ProfessionResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_ProfessionResults] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="ProfessionResultsId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ProfessionResultsGet(int ProfessionResultsId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ProfessionResults] WHERE ProfessionResultsId = "+ProfessionResultsId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="ProfessionResultsId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_ProfessionResults Join_ProfessionResultsEntityGet(int ProfessionResultsId)
		{
			Entity.Join_ProfessionResults info = new Entity.Join_ProfessionResults();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ProfessionResults] WHERE ProfessionResultsId = "+ProfessionResultsId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.ProfessionResultsId = Basic.Utils.StrToInt(dt.Rows[0]["ProfessionResultsId"].ToString(),0);
				info.UserId = Basic.Utils.StrToInt(dt.Rows[0]["UserId"].ToString(),0);
				info.Group1 = Basic.Utils.StrToInt(dt.Rows[0]["Group1"].ToString(),0);
				info.Group2 = Basic.Utils.StrToInt(dt.Rows[0]["Group2"].ToString(),0);
				info.Group3 = Basic.Utils.StrToInt(dt.Rows[0]["Group3"].ToString(),0);
				info.Group4 = Basic.Utils.StrToInt(dt.Rows[0]["Group4"].ToString(),0);
				info.Group5 = Basic.Utils.StrToInt(dt.Rows[0]["Group5"].ToString(),0);
				info.Group6 = Basic.Utils.StrToInt(dt.Rows[0]["Group6"].ToString(),0);
				info.Group7 = Basic.Utils.StrToInt(dt.Rows[0]["Group7"].ToString(),0);
				info.Group8 = Basic.Utils.StrToInt(dt.Rows[0]["Group8"].ToString(),0);
				info.Group9 = Basic.Utils.StrToInt(dt.Rows[0]["Group9"].ToString(),0);
				info.Group10 = Basic.Utils.StrToInt(dt.Rows[0]["Group10"].ToString(),0);
				info.Group11 = Basic.Utils.StrToInt(dt.Rows[0]["Group11"].ToString(),0);
				info.Group12 = Basic.Utils.StrToInt(dt.Rows[0]["Group12"].ToString(),0);
				info.Group13 = Basic.Utils.StrToInt(dt.Rows[0]["Group13"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="ProfessionResultsId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_ProfessionResultsDel(int ProfessionResultsId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_ProfessionResults]  WHERE ProfessionResultsId =  " + ProfessionResultsId);
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
		public static DataTable Join_ProfessionResultsTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ProfessionResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ProfessionResults] ;";
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
		public static DataTable Join_ProfessionResultsPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_ProfessionResults");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY ProfessionResultsId DESC");
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
		public static int Join_ProfessionResultsCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_ProfessionResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_ProfessionResults] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

