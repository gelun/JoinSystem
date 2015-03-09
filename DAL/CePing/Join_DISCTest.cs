using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_DISCTest
    {
        
		#region  Join_DISCTest
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_DISCTestAdd(Entity.Join_DISCTest info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TestNumber", SqlDbType.Int, 4, info.TestNumber),
				SqlDB.MakeInParam("@TestTitle", SqlDbType.NVarChar, 50, info.TestTitle),
				SqlDB.MakeInParam("@Option", SqlDbType.NVarChar, 10, info.Option),
				SqlDB.MakeInParam("@TestType", SqlDbType.Int, 4, info.TestType),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_DISCTestAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_DISCTestEdit(Entity.Join_DISCTest info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TestId", SqlDbType.Int, 4, info.TestId),
				SqlDB.MakeInParam("@TestNumber", SqlDbType.Int, 4, info.TestNumber),
				SqlDB.MakeInParam("@TestTitle", SqlDbType.NVarChar, 50, info.TestTitle),
				SqlDB.MakeInParam("@Option", SqlDbType.NVarChar, 10, info.Option),
				SqlDB.MakeInParam("@TestType", SqlDbType.Int, 4, info.TestType),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_DISCTestEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
	
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_DISCTestList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_DISCTest] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_DISCTest] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}




        /// <summary>
        /// 获取所有的的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_DISCGoupTestList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT TestType FROM [Join_DISCTest] WHERE " + strWhere + "group by  TestType  order by  TestType  asc";
            else
                strSql = "SELECT TestType FROM [Join_DISCTest] group by  TestType  order by  TestType  asc";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="TestId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_DISCTestGet(int TestId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_DISCTest] WHERE TestId = "+TestId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="TestId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_DISCTest Join_DISCTestEntityGet(int TestId)
		{
			Entity.Join_DISCTest info = new Entity.Join_DISCTest();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_DISCTest] WHERE TestId = "+TestId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.TestId = Basic.Utils.StrToInt(dt.Rows[0]["TestId"].ToString(),0);
				info.TestNumber = Basic.Utils.StrToInt(dt.Rows[0]["TestNumber"].ToString(),0);
				info.TestTitle = dt.Rows[0]["TestTitle"].ToString();
				info.Option = dt.Rows[0]["Option"].ToString();
				info.TestType = Basic.Utils.StrToInt(dt.Rows[0]["TestType"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="TestId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_DISCTestDel(int TestId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_DISCTest]  WHERE TestId =  " + TestId);
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
		public static DataTable Join_DISCTestTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_DISCTest] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_DISCTest] ;";
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
		public static DataTable Join_DISCTestPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_DISCTest");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY TestId DESC");
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
		public static int Join_DISCTestCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_DISCTest] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_DISCTest] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

