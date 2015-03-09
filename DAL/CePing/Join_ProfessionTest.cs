using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_ProfessionTest
    {
        
		#region  Join_ProfessionTest
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_ProfessionTestAdd(Entity.Join_ProfessionTest info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@ProfessionNumber", SqlDbType.Int, 4, info.ProfessionNumber),
				SqlDB.MakeInParam("@ProfessionTitle", SqlDbType.NVarChar, 500, info.ProfessionTitle),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_ProfessionTestAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_ProfessionTestEdit(Entity.Join_ProfessionTest info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@ProfessionId", SqlDbType.Int, 4, info.ProfessionId),
				SqlDB.MakeInParam("@ProfessionNumber", SqlDbType.Int, 4, info.ProfessionNumber),
				SqlDB.MakeInParam("@ProfessionTitle", SqlDbType.NVarChar, 500, info.ProfessionTitle),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_ProfessionTestEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
	
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ProfessionTestList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_ProfessionTest] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_ProfessionTest] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="ProfessionId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ProfessionTestGet(int ProfessionId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ProfessionTest] WHERE ProfessionId = "+ProfessionId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="ProfessionId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_ProfessionTest Join_ProfessionTestEntityGet(int ProfessionId)
		{
			Entity.Join_ProfessionTest info = new Entity.Join_ProfessionTest();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ProfessionTest] WHERE ProfessionId = "+ProfessionId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.ProfessionId = Basic.Utils.StrToInt(dt.Rows[0]["ProfessionId"].ToString(),0);
				info.ProfessionNumber = Basic.Utils.StrToInt(dt.Rows[0]["ProfessionNumber"].ToString(),0);
				info.ProfessionTitle = dt.Rows[0]["ProfessionTitle"].ToString();
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="ProfessionId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_ProfessionTestDel(int ProfessionId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_ProfessionTest]  WHERE ProfessionId =  " + ProfessionId);
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
		public static DataTable Join_ProfessionTestTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ProfessionTest] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ProfessionTest] ;";
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
		public static DataTable Join_ProfessionTestPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_ProfessionTest");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY ProfessionId asc");
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
		public static int Join_ProfessionTestCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_ProfessionTest] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_ProfessionTest] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

