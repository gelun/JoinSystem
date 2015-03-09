using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_Card
	{
		#region  Join_Card
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_CardAdd(Entity.Join_Card info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@CardBank", SqlDbType.VarChar, 50, info.CardBank),
				SqlDB.MakeInParam("@CardPass", SqlDbType.VarChar, 16, info.CardPass),
				SqlDB.MakeInParam("@IsValid", SqlDbType.Int, 4, info.IsValid),
				SqlDB.MakeInParam("@UseState", SqlDbType.Int, 4, info.UseState),
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@OpenCardTime", SqlDbType.DateTime, 8, info.OpenCardTime),
				SqlDB.MakeInParam("@StudentId", SqlDbType.VarChar, 50, info.StudentId),
				SqlDB.MakeInParam("@UseTime", SqlDbType.DateTime, 8, info.UseTime),
				SqlDB.MakeInParam("@UseIp", SqlDbType.VarChar, 1, info.UseIp),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_CardAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_CardEdit(Entity.Join_Card info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@CardId", SqlDbType.Int, 4, info.CardId),
				SqlDB.MakeInParam("@CardBank", SqlDbType.VarChar, 50, info.CardBank),
				SqlDB.MakeInParam("@CardPass", SqlDbType.VarChar, 16, info.CardPass),
				SqlDB.MakeInParam("@IsValid", SqlDbType.Int, 4, info.IsValid),
				SqlDB.MakeInParam("@UseState", SqlDbType.Int, 4, info.UseState),
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@OpenCardTime", SqlDbType.DateTime, 8, info.OpenCardTime),
				SqlDB.MakeInParam("@StudentId", SqlDbType.VarChar, 50, info.StudentId),
				SqlDB.MakeInParam("@UseTime", SqlDbType.DateTime, 8, info.UseTime),
				SqlDB.MakeInParam("@UseIp", SqlDbType.VarChar, 1, info.UseIp),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_CardEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
	
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_CardList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_Card] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_Card] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="CardId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_CardGet(int CardId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Card] WHERE CardId = "+CardId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="CardId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_Card Join_CardEntityGet(int CardId)
		{
			Entity.Join_Card info = new Entity.Join_Card();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Card] WHERE CardId = "+CardId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.CardId = Basic.Utils.StrToInt(dt.Rows[0]["CardId"].ToString(),0);
				info.CardBank = dt.Rows[0]["CardBank"].ToString();
				info.CardPass = dt.Rows[0]["CardPass"].ToString();
				info.IsValid = Basic.Utils.StrToInt(dt.Rows[0]["IsValid"].ToString(),0);
				info.UseState = Basic.Utils.StrToInt(dt.Rows[0]["UseState"].ToString(),0);
				info.DianId = Basic.Utils.StrToInt(dt.Rows[0]["DianId"].ToString(),0);
				info.StudentId = dt.Rows[0]["StudentId"].ToString();
				info.UseIp = dt.Rows[0]["UseIp"].ToString();
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="CardId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_CardDel(int CardId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_Card]  WHERE CardId =  " + CardId);
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
		public static DataTable Join_CardTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Card] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Card] ;";
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
		public static DataTable Join_CardPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_Card");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY CardId DESC");
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
		public static int Join_CardCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_Card] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_Card] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

