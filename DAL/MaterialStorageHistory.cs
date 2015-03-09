using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class MaterialStorageHistory
	{
		#region  MaterialStorageHistory
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int MaterialStorageHistoryAdd(Entity.MaterialStorageHistory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@MaterialInventoryId", SqlDbType.Int, 4, info.MaterialInventoryId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
				SqlDB.MakeInParam("@Price", SqlDbType.Money, 8, info.Price),
				SqlDB.MakeInParam("@StorageWid", SqlDbType.Int, 4, info.StorageWid),
				SqlDB.MakeInParam("@StorageTime", SqlDbType.DateTime, 8, info.StorageTime),
				SqlDB.MakeInParam("@SurplusNumber", SqlDbType.Int, 4, info.SurplusNumber),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@IsDel", SqlDbType.Int, 4, info.IsDel),
				SqlDB.MakeInParam("@DelTime", SqlDbType.DateTime, 8, info.DelTime),
				SqlDB.MakeInParam("@DelAddWid", SqlDbType.Int, 4, info.DelAddWid),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "MaterialStorageHistoryAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool MaterialStorageHistoryEdit(Entity.MaterialStorageHistory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@MaterialInventoryId", SqlDbType.Int, 4, info.MaterialInventoryId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
				SqlDB.MakeInParam("@Price", SqlDbType.Money, 8, info.Price),
				SqlDB.MakeInParam("@StorageWid", SqlDbType.Int, 4, info.StorageWid),
				SqlDB.MakeInParam("@StorageTime", SqlDbType.DateTime, 8, info.StorageTime),
				SqlDB.MakeInParam("@SurplusNumber", SqlDbType.Int, 4, info.SurplusNumber),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@IsDel", SqlDbType.Int, 4, info.IsDel),
				SqlDB.MakeInParam("@DelTime", SqlDbType.DateTime, 8, info.DelTime),
				SqlDB.MakeInParam("@DelAddWid", SqlDbType.Int, 4, info.DelAddWid),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "MaterialStorageHistoryEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MaterialStorageHistoryList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [MaterialStorageHistory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [MaterialStorageHistory] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MaterialStorageHistoryGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MaterialStorageHistory] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.MaterialStorageHistory MaterialStorageHistoryEntityGet(int Id)
		{
			Entity.MaterialStorageHistory info = new Entity.MaterialStorageHistory();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MaterialStorageHistory] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.MaterialInventoryId = Basic.Utils.StrToInt(dt.Rows[0]["MaterialInventoryId"].ToString(),0);
				info.Number = Basic.Utils.StrToInt(dt.Rows[0]["Number"].ToString(),0);
				info.StorageWid = Basic.Utils.StrToInt(dt.Rows[0]["StorageWid"].ToString(),0);
				info.SurplusNumber = Basic.Utils.StrToInt(dt.Rows[0]["SurplusNumber"].ToString(),0);
				info.AddWid = Basic.Utils.StrToInt(dt.Rows[0]["AddWid"].ToString(),0);
				info.IsDel = Basic.Utils.StrToInt(dt.Rows[0]["IsDel"].ToString(),0);
				info.DelAddWid = Basic.Utils.StrToInt(dt.Rows[0]["DelAddWid"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool MaterialStorageHistoryDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [MaterialStorageHistory]  WHERE Id =  " + Id);
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
		public static DataTable MaterialStorageHistoryTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MaterialStorageHistory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MaterialStorageHistory] ;";
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
		public static DataTable MaterialStorageHistoryPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM MaterialStorageHistory");
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
		public static int MaterialStorageHistoryCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [MaterialStorageHistory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [MaterialStorageHistory] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

