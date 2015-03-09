using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_Ability_Major
    {
        
		#region  Join_Ability_Major
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_Ability_MajorAdd(Entity.Join_Ability_Major info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@MajorName", SqlDbType.Int, 4, info.MajorName),
				SqlDB.MakeInParam("@GradeList", SqlDbType.Int, 4, info.GradeList),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_Ability_MajorAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_Ability_MajorEdit(Entity.Join_Ability_Major info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@MajorId", SqlDbType.Int, 4, info.MajorId),
				SqlDB.MakeInParam("@MajorName", SqlDbType.Int, 4, info.MajorName),
				SqlDB.MakeInParam("@GradeList", SqlDbType.Int, 4, info.GradeList),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_Ability_MajorEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
        ///// <summary>
        ///// 暂停该值
        ///// </summary>
        ///// <param name="MajorId">自增id的值</param>
        ///// <returns>暂停成功返回ture，否则返回false</returns>
        //public static bool Join_Ability_MajorPause(Entity.Join_Ability_Major info)
        //{
        //    int intReturnValue = 0;
        //    intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [Join_Ability_Major] SET IsPause = "+  info.IsPause +"  WHERE MajorId =  " +  info.MajorId);
        //    if(intReturnValue == 1)
        //        return true;
        //    return false;
        //}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_Ability_MajorList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_Ability_Major] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_Ability_Major] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="MajorId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_Ability_MajorGet(int MajorId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Ability_Major] WHERE MajorId = "+MajorId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="MajorId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_Ability_Major Join_Ability_MajorEntityGet(int MajorId)
		{
			Entity.Join_Ability_Major info = new Entity.Join_Ability_Major();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Ability_Major] WHERE MajorId = "+MajorId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.MajorId = Basic.Utils.StrToInt(dt.Rows[0]["MajorId"].ToString(),0);
				info.MajorName = Basic.Utils.StrToInt(dt.Rows[0]["MajorName"].ToString(),0);
				info.GradeList = Basic.Utils.StrToInt(dt.Rows[0]["GradeList"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="MajorId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_Ability_MajorDel(int MajorId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_Ability_Major]  WHERE MajorId =  " + MajorId);
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
		public static DataTable Join_Ability_MajorTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Ability_Major] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Ability_Major] ;";
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
		public static DataTable Join_Ability_MajorPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_Ability_Major");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY MajorId DESC");
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
		public static int Join_Ability_MajorCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_Ability_Major] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_Ability_Major] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

