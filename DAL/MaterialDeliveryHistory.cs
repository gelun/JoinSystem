using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class MaterialDeliveryHistory
	{
		#region  MaterialDeliveryHistory
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int MaterialDeliveryHistoryAdd(Entity.MaterialDeliveryHistory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@MaterialStorageHistoryId", SqlDbType.Int, 4, info.MaterialStorageHistoryId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
				SqlDB.MakeInParam("@DeliveryWid", SqlDbType.Int, 4, info.DeliveryWid),
				SqlDB.MakeInParam("@DeliveryTime", SqlDbType.DateTime, 8, info.DeliveryTime),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@PiCi", SqlDbType.VarChar, 50, info.PiCi),
				SqlDB.MakeInParam("@IsExtendedLog", SqlDbType.Int, 4, info.IsExtendedLog),
				SqlDB.MakeInParam("@ExtendedLog_MaterialId", SqlDbType.Int, 4, info.ExtendedLog_MaterialId),
				SqlDB.MakeInParam("@IsDel", SqlDbType.Int, 4, info.IsDel),
				SqlDB.MakeInParam("@DelTime", SqlDbType.DateTime, 8, info.DelTime),
				SqlDB.MakeInParam("@DelAddWid", SqlDbType.Int, 4, info.DelAddWid),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "MaterialDeliveryHistoryAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool MaterialDeliveryHistoryEdit(Entity.MaterialDeliveryHistory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@MaterialStorageHistoryId", SqlDbType.Int, 4, info.MaterialStorageHistoryId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
				SqlDB.MakeInParam("@DeliveryWid", SqlDbType.Int, 4, info.DeliveryWid),
				SqlDB.MakeInParam("@DeliveryTime", SqlDbType.DateTime, 8, info.DeliveryTime),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@PiCi", SqlDbType.VarChar, 50, info.PiCi),
				SqlDB.MakeInParam("@IsExtendedLog", SqlDbType.Int, 4, info.IsExtendedLog),
				SqlDB.MakeInParam("@ExtendedLog_MaterialId", SqlDbType.Int, 4, info.ExtendedLog_MaterialId),
				SqlDB.MakeInParam("@IsDel", SqlDbType.Int, 4, info.IsDel),
				SqlDB.MakeInParam("@DelTime", SqlDbType.DateTime, 8, info.DelTime),
				SqlDB.MakeInParam("@DelAddWid", SqlDbType.Int, 4, info.DelAddWid),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "MaterialDeliveryHistoryEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MaterialDeliveryHistoryList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [MaterialDeliveryHistory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [MaterialDeliveryHistory] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MaterialDeliveryHistoryGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MaterialDeliveryHistory] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.MaterialDeliveryHistory MaterialDeliveryHistoryEntityGet(int Id)
		{
			Entity.MaterialDeliveryHistory info = new Entity.MaterialDeliveryHistory();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MaterialDeliveryHistory] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.MaterialStorageHistoryId = Basic.Utils.StrToInt(dt.Rows[0]["MaterialStorageHistoryId"].ToString(),0);
				info.Number = Basic.Utils.StrToInt(dt.Rows[0]["Number"].ToString(),0);
				info.DeliveryWid = Basic.Utils.StrToInt(dt.Rows[0]["DeliveryWid"].ToString(),0);
				info.AddWid = Basic.Utils.StrToInt(dt.Rows[0]["AddWid"].ToString(),0);
				info.PiCi = dt.Rows[0]["PiCi"].ToString();
				info.IsExtendedLog = Basic.Utils.StrToInt(dt.Rows[0]["IsExtendedLog"].ToString(),0);
				info.ExtendedLog_MaterialId = Basic.Utils.StrToInt(dt.Rows[0]["ExtendedLog_MaterialId"].ToString(),0);
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
		public static bool MaterialDeliveryHistoryDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [MaterialDeliveryHistory]  WHERE Id =  " + Id);
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
		public static DataTable MaterialDeliveryHistoryTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MaterialDeliveryHistory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MaterialDeliveryHistory] ;";
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
		public static DataTable MaterialDeliveryHistoryPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM MaterialDeliveryHistory");
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
		public static int MaterialDeliveryHistoryCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [MaterialDeliveryHistory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [MaterialDeliveryHistory] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

