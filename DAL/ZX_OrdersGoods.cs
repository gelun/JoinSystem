using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class ZX_OrdersGoods
	{
		#region  ZX_OrdersGoods
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int ZX_OrdersGoodsAdd(Entity.ZX_OrdersGoods info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@OrdersId", SqlDbType.Int, 4, info.OrdersId),
				SqlDB.MakeInParam("@MaterialId", SqlDbType.Int, 4, info.MaterialId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
				SqlDB.MakeInParam("@UnitPrice", SqlDbType.Money, 8, info.UnitPrice),
				SqlDB.MakeInParam("@TotalPrice", SqlDbType.Money, 8, info.TotalPrice),
				SqlDB.MakeInParam("@Detail", SqlDbType.NVarChar, 2000, info.Detail),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "ZX_OrdersGoodsAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool ZX_OrdersGoodsEdit(Entity.ZX_OrdersGoods info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@OrdersId", SqlDbType.Int, 4, info.OrdersId),
				SqlDB.MakeInParam("@MaterialId", SqlDbType.Int, 4, info.MaterialId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
				SqlDB.MakeInParam("@UnitPrice", SqlDbType.Money, 8, info.UnitPrice),
				SqlDB.MakeInParam("@TotalPrice", SqlDbType.Money, 8, info.TotalPrice),
				SqlDB.MakeInParam("@Detail", SqlDbType.NVarChar, 2000, info.Detail),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "ZX_OrdersGoodsEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ZX_OrdersGoodsList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [ZX_OrdersGoods] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [ZX_OrdersGoods] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ZX_OrdersGoodsGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [ZX_OrdersGoods] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.ZX_OrdersGoods ZX_OrdersGoodsEntityGet(int Id)
		{
			Entity.ZX_OrdersGoods info = new Entity.ZX_OrdersGoods();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [ZX_OrdersGoods] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.OrdersId = Basic.Utils.StrToInt(dt.Rows[0]["OrdersId"].ToString(),0);
				info.MaterialId = Basic.Utils.StrToInt(dt.Rows[0]["MaterialId"].ToString(),0);
				info.Number = Basic.Utils.StrToInt(dt.Rows[0]["Number"].ToString(),0);
				info.Detail = dt.Rows[0]["Detail"].ToString();
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool ZX_OrdersGoodsDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [ZX_OrdersGoods]  WHERE Id =  " + Id);
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
		public static DataTable ZX_OrdersGoodsTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [ZX_OrdersGoods] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [ZX_OrdersGoods] ;";
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
		public static DataTable ZX_OrdersGoodsPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM ZX_OrdersGoods");
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
		public static int ZX_OrdersGoodsCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [ZX_OrdersGoods] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [ZX_OrdersGoods] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

