using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_Test
    {
        
		#region  Join_Test
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_TestAdd(Entity.Join_Test info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TestTitle", SqlDbType.Int, 4, info.TestTitle),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_TestAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_TestEdit(Entity.Join_Test info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TestTitle", SqlDbType.NVarChar, 500, info.TestTitle),
				SqlDB.MakeInParam("@TestId", SqlDbType.Int, 4, info.TestId),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_TestEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
        ///// <summary>
        ///// 暂停该值
        ///// </summary>
        ///// <param name="TestTitle">自增id的值</param>
        ///// <returns>暂停成功返回ture，否则返回false</returns>
        //public static bool Join_TestPause(Entity.Join_Test info)
        //{
        //    int intReturnValue = 0;
        //    intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [Join_Test] SET IsPause = "+  info.IsPause +"  WHERE TestTitle =  " +  info.TestTitle);
        //    if(intReturnValue == 1)
        //        return true;
        //    return false;
        //}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_TestList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_Test] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_Test] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="TestTitle">标识</param>
		/// <returns>返回DataTable</returns>
        public static DataTable Join_TestGet(int TestId)
		{
            return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Test] WHERE TestId = " + TestId + ";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="TestTitle">标识</param>
		/// <returns>返回Entity</returns>
        public static Entity.Join_Test Join_TestEntityGet(int TestId)
		{
			Entity.Join_Test info = new Entity.Join_Test();
            DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Test] WHERE TestId = " + TestId + ";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.TestTitle = dt.Rows[0]["TestTitle"].ToString();
				info.TestId = Basic.Utils.StrToInt(dt.Rows[0]["TestId"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="TestTitle">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
        public static bool Join_TestDel(int TestId)
		{
			int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_Test]  WHERE TestId =  " + TestId);
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
		public static DataTable Join_TestTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Test] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Test] ;";
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
		public static DataTable Join_TestPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_Test");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
            sbSql.Append(" ORDER BY TestId asc");
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
		public static int Join_TestCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_Test] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_Test] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

