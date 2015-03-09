using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_EvaluationUser
    {
        
		#region  Join_EvaluationUser
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_EvaluationUserAdd(Entity.Join_EvaluationUser info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@EvaluationUserName", SqlDbType.NVarChar, 20, info.EvaluationUserName),
				SqlDB.MakeInParam("@EvaluationUserSex", SqlDbType.Int, 4, info.EvaluationUserSex),
				SqlDB.MakeInParam("@EvaluationUserBirthday", SqlDbType.NVarChar, 50, info.EvaluationUserBirthday),
				SqlDB.MakeInParam("@EvaluationUserGrade", SqlDbType.NVarChar, 50, info.EvaluationUserGrade),
				SqlDB.MakeInParam("@EvaluationUserMail", SqlDbType.NVarChar, 50, info.EvaluationUserMail),
				SqlDB.MakeInParam("@EvaluationUserTel", SqlDbType.NVarChar, 18, info.EvaluationUserTel),
				SqlDB.MakeInParam("@EvaluationUserPhone", SqlDbType.NVarChar, 11, info.EvaluationUserPhone),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_EvaluationUserAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_EvaluationUserEdit(Entity.Join_EvaluationUser info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@EvaluationUserId", SqlDbType.Int, 4, info.EvaluationUserId),
				SqlDB.MakeInParam("@EvaluationUserName", SqlDbType.NVarChar, 20, info.EvaluationUserName),
				SqlDB.MakeInParam("@EvaluationUserSex", SqlDbType.Int, 4, info.EvaluationUserSex),
				SqlDB.MakeInParam("@EvaluationUserBirthday", SqlDbType.NVarChar, 50, info.EvaluationUserBirthday),
				SqlDB.MakeInParam("@EvaluationUserGrade", SqlDbType.NVarChar, 50, info.EvaluationUserGrade),
				SqlDB.MakeInParam("@EvaluationUserMail", SqlDbType.NVarChar, 50, info.EvaluationUserMail),
				SqlDB.MakeInParam("@EvaluationUserTel", SqlDbType.NVarChar, 18, info.EvaluationUserTel),
				SqlDB.MakeInParam("@EvaluationUserPhone", SqlDbType.NVarChar, 11, info.EvaluationUserPhone),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_EvaluationUserEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
        ///// <summary>
        ///// 暂停该值
        ///// </summary>
        ///// <param name="EvaluationUserId">自增id的值</param>
        ///// <returns>暂停成功返回ture，否则返回false</returns>
        //public static bool Join_EvaluationUserPause(Entity.Join_EvaluationUser info)
        //{
        //    int intReturnValue = 0;
        //    intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [Join_EvaluationUser] SET IsPause = "+  info.IsPause +"  WHERE EvaluationUserId =  " +  info.EvaluationUserId);
        //    if(intReturnValue == 1)
        //        return true;
        //    return false;
        //}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_EvaluationUserList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_EvaluationUser] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_EvaluationUser] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="EvaluationUserId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_EvaluationUserGet(int EvaluationUserId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_EvaluationUser] WHERE EvaluationUserId = "+EvaluationUserId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="EvaluationUserId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_EvaluationUser Join_EvaluationUserEntityGet(int EvaluationUserId)
		{
			Entity.Join_EvaluationUser info = new Entity.Join_EvaluationUser();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_EvaluationUser] WHERE EvaluationUserId = "+EvaluationUserId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.EvaluationUserId = Basic.Utils.StrToInt(dt.Rows[0]["EvaluationUserId"].ToString(),0);
				info.EvaluationUserName = dt.Rows[0]["EvaluationUserName"].ToString();
				info.EvaluationUserSex = Basic.Utils.StrToInt(dt.Rows[0]["EvaluationUserSex"].ToString(),0);
				info.EvaluationUserBirthday = dt.Rows[0]["EvaluationUserBirthday"].ToString();
				info.EvaluationUserGrade = dt.Rows[0]["EvaluationUserGrade"].ToString();
				info.EvaluationUserMail = dt.Rows[0]["EvaluationUserMail"].ToString();
				info.EvaluationUserTel = dt.Rows[0]["EvaluationUserTel"].ToString();
				info.EvaluationUserPhone = dt.Rows[0]["EvaluationUserPhone"].ToString();
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="EvaluationUserId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_EvaluationUserDel(int EvaluationUserId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_EvaluationUser]  WHERE EvaluationUserId =  " + EvaluationUserId);
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
		public static DataTable Join_EvaluationUserTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_EvaluationUser] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_EvaluationUser] ;";
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
		public static DataTable Join_EvaluationUserPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_EvaluationUser");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY EvaluationUserId DESC");
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
		public static int Join_EvaluationUserCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_EvaluationUser] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_EvaluationUser] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

