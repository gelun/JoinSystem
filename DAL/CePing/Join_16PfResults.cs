using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_16PfResults
    {
        
		#region  Join_16PfResults
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_16PfResultsAdd(Entity.Join_16PfResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@A_type", SqlDbType.Int, 4, info.A_type),
				SqlDB.MakeInParam("@B_type", SqlDbType.Int, 4, info.B_type),
				SqlDB.MakeInParam("@C_type", SqlDbType.Int, 4, info.C_type),
				SqlDB.MakeInParam("@E_type", SqlDbType.Int, 4, info.E_type),
				SqlDB.MakeInParam("@F_type", SqlDbType.Int, 4, info.F_type),
				SqlDB.MakeInParam("@G_type", SqlDbType.Int, 4, info.G_type),
				SqlDB.MakeInParam("@H_type", SqlDbType.Int, 4, info.H_type),
				SqlDB.MakeInParam("@I_type", SqlDbType.Int, 4, info.I_type),
				SqlDB.MakeInParam("@L_type", SqlDbType.Int, 4, info.L_type),
				SqlDB.MakeInParam("@M_type", SqlDbType.Int, 4, info.M_type),
				SqlDB.MakeInParam("@N_type", SqlDbType.Int, 4, info.N_type),
				SqlDB.MakeInParam("@O_type", SqlDbType.Int, 4, info.O_type),
				SqlDB.MakeInParam("@Q1_type", SqlDbType.Int, 4, info.Q1_type),
				SqlDB.MakeInParam("@Q2_type", SqlDbType.Int, 4, info.Q2_type),
				SqlDB.MakeInParam("@Q3_type", SqlDbType.Int, 4, info.Q3_type),
				SqlDB.MakeInParam("@Q4_type", SqlDbType.Int, 4, info.Q4_type),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_16PfResultsAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_16PfResultsEdit(Entity.Join_16PfResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@PfResultsId", SqlDbType.Int, 4, info.PfResultsId),
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@A_type", SqlDbType.Int, 4, info.A_type),
				SqlDB.MakeInParam("@B_type", SqlDbType.Int, 4, info.B_type),
				SqlDB.MakeInParam("@C_type", SqlDbType.Int, 4, info.C_type),
				SqlDB.MakeInParam("@E_type", SqlDbType.Int, 4, info.E_type),
				SqlDB.MakeInParam("@F_type", SqlDbType.Int, 4, info.F_type),
				SqlDB.MakeInParam("@G_type", SqlDbType.Int, 4, info.G_type),
				SqlDB.MakeInParam("@H_type", SqlDbType.Int, 4, info.H_type),
				SqlDB.MakeInParam("@I_type", SqlDbType.Int, 4, info.I_type),
				SqlDB.MakeInParam("@L_type", SqlDbType.Int, 4, info.L_type),
				SqlDB.MakeInParam("@M_type", SqlDbType.Int, 4, info.M_type),
				SqlDB.MakeInParam("@N_type", SqlDbType.Int, 4, info.N_type),
				SqlDB.MakeInParam("@O_type", SqlDbType.Int, 4, info.O_type),
				SqlDB.MakeInParam("@Q1_type", SqlDbType.Int, 4, info.Q1_type),
				SqlDB.MakeInParam("@Q2_type", SqlDbType.Int, 4, info.Q2_type),
				SqlDB.MakeInParam("@Q3_type", SqlDbType.Int, 4, info.Q3_type),
				SqlDB.MakeInParam("@Q4_type", SqlDbType.Int, 4, info.Q4_type),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_16PfResultsEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		

		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_16PfResultsList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_16PfResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_16PfResults] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="PfResultsId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_16PfResultsGet(int PfResultsId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_16PfResults] WHERE PfResultsId = "+PfResultsId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="PfResultsId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_16PfResults Join_16PfResultsEntityGet(int PfResultsId)
		{
			Entity.Join_16PfResults info = new Entity.Join_16PfResults();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_16PfResults] WHERE PfResultsId = "+PfResultsId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.PfResultsId = Basic.Utils.StrToInt(dt.Rows[0]["PfResultsId"].ToString(),0);
				info.UserId = Basic.Utils.StrToInt(dt.Rows[0]["UserId"].ToString(),0);
				info.A_type = Basic.Utils.StrToInt(dt.Rows[0]["A_type"].ToString(),0);
				info.B_type = Basic.Utils.StrToInt(dt.Rows[0]["B_type"].ToString(),0);
				info.C_type = Basic.Utils.StrToInt(dt.Rows[0]["C_type"].ToString(),0);
				info.E_type = Basic.Utils.StrToInt(dt.Rows[0]["E_type"].ToString(),0);
				info.F_type = Basic.Utils.StrToInt(dt.Rows[0]["F_type"].ToString(),0);
				info.G_type = Basic.Utils.StrToInt(dt.Rows[0]["G_type"].ToString(),0);
				info.H_type = Basic.Utils.StrToInt(dt.Rows[0]["H_type"].ToString(),0);
				info.I_type = Basic.Utils.StrToInt(dt.Rows[0]["I_type"].ToString(),0);
				info.L_type = Basic.Utils.StrToInt(dt.Rows[0]["L_type"].ToString(),0);
				info.M_type = Basic.Utils.StrToInt(dt.Rows[0]["M_type"].ToString(),0);
				info.N_type = Basic.Utils.StrToInt(dt.Rows[0]["N_type"].ToString(),0);
				info.O_type = Basic.Utils.StrToInt(dt.Rows[0]["O_type"].ToString(),0);
				info.Q1_type = Basic.Utils.StrToInt(dt.Rows[0]["Q1_type"].ToString(),0);
				info.Q2_type = Basic.Utils.StrToInt(dt.Rows[0]["Q2_type"].ToString(),0);
				info.Q3_type = Basic.Utils.StrToInt(dt.Rows[0]["Q3_type"].ToString(),0);
				info.Q4_type = Basic.Utils.StrToInt(dt.Rows[0]["Q4_type"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="PfResultsId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_16PfResultsDel(int PfResultsId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_16PfResults]  WHERE PfResultsId =  " + PfResultsId);
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
		public static DataTable Join_16PfResultsTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_16PfResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_16PfResults] ;";
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
		public static DataTable Join_16PfResultsPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_16PfResults");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY PfResultsId DESC");
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
		public static int Join_16PfResultsCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_16PfResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_16PfResults] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

