using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_MbitAnswer
    {
        
		#region  Join_MbitAnswer
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_MbitAnswerAdd(Entity.Join_MbitAnswer info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TestId", SqlDbType.Int, 4, info.TestId),
				SqlDB.MakeInParam("@AnswerContent", SqlDbType.NVarChar, 50, info.AnswerContent),
				SqlDB.MakeInParam("@Opetion", SqlDbType.NVarChar, 50, info.Opetion),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_MbitAnswerAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_MbitAnswerEdit(Entity.Join_MbitAnswer info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@AnswerId", SqlDbType.Int, 4, info.AnswerId),
				SqlDB.MakeInParam("@TestId", SqlDbType.Int, 4, info.TestId),
				SqlDB.MakeInParam("@AnswerContent", SqlDbType.NVarChar, 50, info.AnswerContent),
				SqlDB.MakeInParam("@Opetion", SqlDbType.NVarChar, 50, info.Opetion),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_MbitAnswerEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
	
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_MbitAnswerList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_MbitAnswer] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_MbitAnswer] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="AnswerId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_MbitAnswerGet(int AnswerId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_MbitAnswer] WHERE AnswerId = "+AnswerId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="AnswerId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_MbitAnswer Join_MbitAnswerEntityGet(int AnswerId)
		{
			Entity.Join_MbitAnswer info = new Entity.Join_MbitAnswer();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_MbitAnswer] WHERE AnswerId = "+AnswerId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.AnswerId = Basic.Utils.StrToInt(dt.Rows[0]["AnswerId"].ToString(),0);
				info.TestId = Basic.Utils.StrToInt(dt.Rows[0]["TestId"].ToString(),0);
				info.AnswerContent = dt.Rows[0]["AnswerContent"].ToString();
				info.Opetion = dt.Rows[0]["Opetion"].ToString();
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="AnswerId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_MbitAnswerDel(int AnswerId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_MbitAnswer]  WHERE AnswerId =  " + AnswerId);
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
		public static DataTable Join_MbitAnswerTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_MbitAnswer] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_MbitAnswer] ;";
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
		public static DataTable Join_MbitAnswerPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_MbitAnswer");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY AnswerId DESC");
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
		public static int Join_MbitAnswerCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_MbitAnswer] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_MbitAnswer] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

