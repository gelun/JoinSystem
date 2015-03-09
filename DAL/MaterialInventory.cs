using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class MaterialInventory
	{
		#region  MaterialInventory
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int MaterialInventoryAdd(Entity.MaterialInventory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TypeId", SqlDbType.Int, 4, info.TypeId),
				SqlDB.MakeInParam("@ProjectCategoryId", SqlDbType.Int, 4, info.ProjectCategoryId),
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@Name", SqlDbType.VarChar, 200, info.Name),
				SqlDB.MakeInParam("@Price", SqlDbType.Money, 8, info.Price),
				SqlDB.MakeInParam("@SurplusNumber", SqlDbType.Int, 4, info.SurplusNumber),
				SqlDB.MakeInParam("@TotalStorageNumber", SqlDbType.Int, 4, info.TotalStorageNumber),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "MaterialInventoryAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool MaterialInventoryEdit(Entity.MaterialInventory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@TypeId", SqlDbType.Int, 4, info.TypeId),
				SqlDB.MakeInParam("@ProjectCategoryId", SqlDbType.Int, 4, info.ProjectCategoryId),
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@Name", SqlDbType.VarChar, 200, info.Name),
				SqlDB.MakeInParam("@Price", SqlDbType.Money, 8, info.Price),
				SqlDB.MakeInParam("@SurplusNumber", SqlDbType.Int, 4, info.SurplusNumber),
				SqlDB.MakeInParam("@TotalStorageNumber", SqlDbType.Int, 4, info.TotalStorageNumber),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "MaterialInventoryEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 暂停该值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>暂停成功返回ture，否则返回false</returns>
		public static bool MaterialInventoryPause(Entity.MaterialInventory info)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [MaterialInventory] SET IsPause = "+  info.IsPause +"  WHERE Id =  " +  info.Id);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MaterialInventoryList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [MaterialInventory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [MaterialInventory] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MaterialInventoryGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MaterialInventory] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.MaterialInventory MaterialInventoryEntityGet(int Id)
		{
			Entity.MaterialInventory info = new Entity.MaterialInventory();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MaterialInventory] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.TypeId = Basic.Utils.StrToInt(dt.Rows[0]["TypeId"].ToString(),0);
				info.ProjectCategoryId = Basic.Utils.StrToInt(dt.Rows[0]["ProjectCategoryId"].ToString(),0);
				info.DianId = Basic.Utils.StrToInt(dt.Rows[0]["DianId"].ToString(),0);
				info.Name = dt.Rows[0]["Name"].ToString();
				info.SurplusNumber = Basic.Utils.StrToInt(dt.Rows[0]["SurplusNumber"].ToString(),0);
				info.TotalStorageNumber = Basic.Utils.StrToInt(dt.Rows[0]["TotalStorageNumber"].ToString(),0);
				info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(),0);
				info.AddWid = Basic.Utils.StrToInt(dt.Rows[0]["AddWid"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool MaterialInventoryDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [MaterialInventory]  WHERE Id =  " + Id);
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
		public static DataTable MaterialInventoryTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MaterialInventory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MaterialInventory] ;";
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
		public static DataTable MaterialInventoryPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM MaterialInventory");
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
		public static int MaterialInventoryCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [MaterialInventory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [MaterialInventory] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

