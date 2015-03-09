using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class WorkerAll
	{
		#region  WorkerAll
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int WorkerAllAdd(Entity.WorkerAll info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@PartnerId", SqlDbType.Int, 4, info.PartnerId),
				SqlDB.MakeInParam("@Name", SqlDbType.NVarChar, 20, info.Name),
				SqlDB.MakeInParam("@Sex", SqlDbType.Int, 4, info.Sex),
				SqlDB.MakeInParam("@Mobile", SqlDbType.NVarChar, 11, info.Mobile),
				SqlDB.MakeInParam("@Bank", SqlDbType.NVarChar, 50, info.Bank),
				SqlDB.MakeInParam("@Pwd", SqlDbType.NVarChar, 32, info.Pwd),
				SqlDB.MakeInParam("@OtherContactWay", SqlDbType.NVarChar, 50, info.OtherContactWay),
				SqlDB.MakeInParam("@QQ", SqlDbType.NVarChar, 15, info.QQ),
				SqlDB.MakeInParam("@Email", SqlDbType.NVarChar, 50, info.Email),
				SqlDB.MakeInParam("@HomeAddress", SqlDbType.NVarChar, 50, info.HomeAddress),
				SqlDB.MakeInParam("@IdentityNumber", SqlDbType.NVarChar, 18, info.IdentityNumber),
				SqlDB.MakeInParam("@BirthDay", SqlDbType.NVarChar, 10, info.BirthDay),
				SqlDB.MakeInParam("@RoleList", SqlDbType.NVarChar, 50, info.RoleList),
				SqlDB.MakeInParam("@IsBoss", SqlDbType.Int, 4, info.IsBoss),
				SqlDB.MakeInParam("@IsZongBu", SqlDbType.Int, 4, info.IsZongBu),
				SqlDB.MakeInParam("@DepartmentId", SqlDbType.Int, 4, info.DepartmentId),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "WorkerAllAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool WorkerAllEdit(Entity.WorkerAll info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@PartnerId", SqlDbType.Int, 4, info.PartnerId),
				SqlDB.MakeInParam("@Name", SqlDbType.NVarChar, 20, info.Name),
				SqlDB.MakeInParam("@Sex", SqlDbType.Int, 4, info.Sex),
				SqlDB.MakeInParam("@Mobile", SqlDbType.NVarChar, 11, info.Mobile),
				SqlDB.MakeInParam("@Bank", SqlDbType.NVarChar, 50, info.Bank),
				SqlDB.MakeInParam("@Pwd", SqlDbType.NVarChar, 32, info.Pwd),
				SqlDB.MakeInParam("@OtherContactWay", SqlDbType.NVarChar, 50, info.OtherContactWay),
				SqlDB.MakeInParam("@QQ", SqlDbType.NVarChar, 15, info.QQ),
				SqlDB.MakeInParam("@Email", SqlDbType.NVarChar, 50, info.Email),
				SqlDB.MakeInParam("@HomeAddress", SqlDbType.NVarChar, 50, info.HomeAddress),
				SqlDB.MakeInParam("@IdentityNumber", SqlDbType.NVarChar, 18, info.IdentityNumber),
				SqlDB.MakeInParam("@BirthDay", SqlDbType.NVarChar, 10, info.BirthDay),
				SqlDB.MakeInParam("@RoleList", SqlDbType.NVarChar, 50, info.RoleList),
				SqlDB.MakeInParam("@IsBoss", SqlDbType.Int, 4, info.IsBoss),
				SqlDB.MakeInParam("@IsZongBu", SqlDbType.Int, 4, info.IsZongBu),
				SqlDB.MakeInParam("@DepartmentId", SqlDbType.Int, 4, info.DepartmentId),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "WorkerAllEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 暂停该值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>暂停成功返回ture，否则返回false</returns>
		public static bool WorkerAllPause(Entity.WorkerAll info)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [WorkerAll] SET IsPause = "+  info.IsPause +"  WHERE Id =  " +  info.Id);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable WorkerAllList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [WorkerAll] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [WorkerAll] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable WorkerAllGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [WorkerAll] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.WorkerAll WorkerAllEntityGet(int Id)
		{
			Entity.WorkerAll info = new Entity.WorkerAll();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [WorkerAll] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.PartnerId = Basic.Utils.StrToInt(dt.Rows[0]["PartnerId"].ToString(),0);
				info.Name = dt.Rows[0]["Name"].ToString();
				info.Sex = Basic.Utils.StrToInt(dt.Rows[0]["Sex"].ToString(),0);
				info.Mobile = dt.Rows[0]["Mobile"].ToString();
				info.Bank = dt.Rows[0]["Bank"].ToString();
				info.Pwd = dt.Rows[0]["Pwd"].ToString();
				info.OtherContactWay = dt.Rows[0]["OtherContactWay"].ToString();
				info.QQ = dt.Rows[0]["QQ"].ToString();
				info.Email = dt.Rows[0]["Email"].ToString();
				info.HomeAddress = dt.Rows[0]["HomeAddress"].ToString();
				info.IdentityNumber = dt.Rows[0]["IdentityNumber"].ToString();
				info.BirthDay = dt.Rows[0]["BirthDay"].ToString();
				info.RoleList = dt.Rows[0]["RoleList"].ToString();
				info.IsBoss = Basic.Utils.StrToInt(dt.Rows[0]["IsBoss"].ToString(),0);
				info.IsZongBu = Basic.Utils.StrToInt(dt.Rows[0]["IsZongBu"].ToString(),0);
				info.DepartmentId = Basic.Utils.StrToInt(dt.Rows[0]["DepartmentId"].ToString(),0);
				info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool WorkerAllDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [WorkerAll]  WHERE Id =  " + Id);
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
		public static DataTable WorkerAllTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [WorkerAll] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [WorkerAll] ;";
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
		public static DataTable WorkerAllPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM WorkerAll");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY Id DESC");
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
		public static int WorkerAllCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [WorkerAll] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [WorkerAll] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

