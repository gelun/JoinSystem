using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class ZX_Orders
	{
		#region  ZX_Orders
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int ZX_OrdersAdd(Entity.ZX_Orders info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@OrderNo", SqlDbType.NVarChar, 50, info.OrderNo),
				SqlDB.MakeInParam("@GoodsNameList", SqlDbType.NVarChar, 1000, info.GoodsNameList),
				SqlDB.MakeInParam("@PartnerId", SqlDbType.Int, 4, info.PartnerId),
				SqlDB.MakeInParam("@TotalPrice", SqlDbType.Money, 8, info.TotalPrice),
				SqlDB.MakeInParam("@IsContainingTax", SqlDbType.Int, 4, info.IsContainingTax),
				SqlDB.MakeInParam("@ReceivedAmount", SqlDbType.Money, 8, info.ReceivedAmount),
				SqlDB.MakeInParam("@OrderState", SqlDbType.Int, 4, info.OrderState),
				SqlDB.MakeInParam("@IsHasArrears", SqlDbType.Int, 4, info.IsHasArrears),
				SqlDB.MakeInParam("@IsConfirmOrder", SqlDbType.Int, 4, info.IsConfirmOrder),
				SqlDB.MakeInParam("@ConfirmOrderWid", SqlDbType.Int, 4, info.ConfirmOrderWid),
				SqlDB.MakeInParam("@ConfirmOrderTime", SqlDbType.DateTime, 8, info.ConfirmOrderTime),
				SqlDB.MakeInParam("@Consignee", SqlDbType.NVarChar, 50, info.Consignee),
				SqlDB.MakeInParam("@ConsigneeMobile", SqlDbType.NVarChar, 11, info.ConsigneeMobile),
				SqlDB.MakeInParam("@ConsigneeZipCode", SqlDbType.NVarChar, 6, info.ConsigneeZipCode),
				SqlDB.MakeInParam("@ConsigneeAddress", SqlDbType.NVarChar, 200, info.ConsigneeAddress),
				SqlDB.MakeInParam("@IsNeedInvoice", SqlDbType.Int, 4, info.IsNeedInvoice),
				SqlDB.MakeInParam("@InvoiceType", SqlDbType.Int, 4, info.InvoiceType),
				SqlDB.MakeInParam("@InvoiceContent", SqlDbType.NVarChar, 400, info.InvoiceContent),
				SqlDB.MakeInParam("@InvoiceTitle", SqlDbType.NVarChar, 100, info.InvoiceTitle),
				SqlDB.MakeInParam("@InvoiceAmount", SqlDbType.Money, 8, info.InvoiceAmount),
				SqlDB.MakeInParam("@FinancialContacts", SqlDbType.NVarChar, 50, info.FinancialContacts),
				SqlDB.MakeInParam("@FinancialContactsMobile", SqlDbType.NVarChar, 11, info.FinancialContactsMobile),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "ZX_OrdersAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool ZX_OrdersEdit(Entity.ZX_Orders info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@OrderNo", SqlDbType.NVarChar, 50, info.OrderNo),
				SqlDB.MakeInParam("@GoodsNameList", SqlDbType.NVarChar, 1000, info.GoodsNameList),
				SqlDB.MakeInParam("@PartnerId", SqlDbType.Int, 4, info.PartnerId),
				SqlDB.MakeInParam("@TotalPrice", SqlDbType.Money, 8, info.TotalPrice),
				SqlDB.MakeInParam("@IsContainingTax", SqlDbType.Int, 4, info.IsContainingTax),
				SqlDB.MakeInParam("@ReceivedAmount", SqlDbType.Money, 8, info.ReceivedAmount),
				SqlDB.MakeInParam("@OrderState", SqlDbType.Int, 4, info.OrderState),
				SqlDB.MakeInParam("@IsHasArrears", SqlDbType.Int, 4, info.IsHasArrears),
				SqlDB.MakeInParam("@IsConfirmOrder", SqlDbType.Int, 4, info.IsConfirmOrder),
				SqlDB.MakeInParam("@ConfirmOrderWid", SqlDbType.Int, 4, info.ConfirmOrderWid),
				SqlDB.MakeInParam("@ConfirmOrderTime", SqlDbType.DateTime, 8, info.ConfirmOrderTime),
				SqlDB.MakeInParam("@Consignee", SqlDbType.NVarChar, 50, info.Consignee),
				SqlDB.MakeInParam("@ConsigneeMobile", SqlDbType.NVarChar, 11, info.ConsigneeMobile),
				SqlDB.MakeInParam("@ConsigneeZipCode", SqlDbType.NVarChar, 6, info.ConsigneeZipCode),
				SqlDB.MakeInParam("@ConsigneeAddress", SqlDbType.NVarChar, 200, info.ConsigneeAddress),
				SqlDB.MakeInParam("@IsNeedInvoice", SqlDbType.Int, 4, info.IsNeedInvoice),
				SqlDB.MakeInParam("@InvoiceType", SqlDbType.Int, 4, info.InvoiceType),
				SqlDB.MakeInParam("@InvoiceContent", SqlDbType.NVarChar, 400, info.InvoiceContent),
				SqlDB.MakeInParam("@InvoiceTitle", SqlDbType.NVarChar, 100, info.InvoiceTitle),
				SqlDB.MakeInParam("@InvoiceAmount", SqlDbType.Money, 8, info.InvoiceAmount),
				SqlDB.MakeInParam("@FinancialContacts", SqlDbType.NVarChar, 50, info.FinancialContacts),
				SqlDB.MakeInParam("@FinancialContactsMobile", SqlDbType.NVarChar, 11, info.FinancialContactsMobile),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "ZX_OrdersEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ZX_OrdersList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [ZX_Orders] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [ZX_Orders] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ZX_OrdersGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [ZX_Orders] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.ZX_Orders ZX_OrdersEntityGet(int Id)
		{
			Entity.ZX_Orders info = new Entity.ZX_Orders();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [ZX_Orders] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.OrderNo = dt.Rows[0]["OrderNo"].ToString();
				info.GoodsNameList = dt.Rows[0]["GoodsNameList"].ToString();
				info.PartnerId = Basic.Utils.StrToInt(dt.Rows[0]["PartnerId"].ToString(),0);
				info.IsContainingTax = Basic.Utils.StrToInt(dt.Rows[0]["IsContainingTax"].ToString(),0);
				info.OrderState = Basic.Utils.StrToInt(dt.Rows[0]["OrderState"].ToString(),0);
				info.IsHasArrears = Basic.Utils.StrToInt(dt.Rows[0]["IsHasArrears"].ToString(),0);
				info.IsConfirmOrder = Basic.Utils.StrToInt(dt.Rows[0]["IsConfirmOrder"].ToString(),0);
				info.ConfirmOrderWid = Basic.Utils.StrToInt(dt.Rows[0]["ConfirmOrderWid"].ToString(),0);
				info.Consignee = dt.Rows[0]["Consignee"].ToString();
				info.ConsigneeMobile = dt.Rows[0]["ConsigneeMobile"].ToString();
				info.ConsigneeZipCode = dt.Rows[0]["ConsigneeZipCode"].ToString();
				info.ConsigneeAddress = dt.Rows[0]["ConsigneeAddress"].ToString();
				info.IsNeedInvoice = Basic.Utils.StrToInt(dt.Rows[0]["IsNeedInvoice"].ToString(),0);
				info.InvoiceType = Basic.Utils.StrToInt(dt.Rows[0]["InvoiceType"].ToString(),0);
				info.InvoiceContent = dt.Rows[0]["InvoiceContent"].ToString();
				info.InvoiceTitle = dt.Rows[0]["InvoiceTitle"].ToString();
				info.FinancialContacts = dt.Rows[0]["FinancialContacts"].ToString();
				info.FinancialContactsMobile = dt.Rows[0]["FinancialContactsMobile"].ToString();
				info.AddWid = Basic.Utils.StrToInt(dt.Rows[0]["AddWid"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool ZX_OrdersDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [ZX_Orders]  WHERE Id =  " + Id);
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
		public static DataTable ZX_OrdersTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [ZX_Orders] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [ZX_Orders] ;";
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
		public static DataTable ZX_OrdersPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM ZX_Orders");
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
		public static int ZX_OrdersCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [ZX_Orders] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [ZX_Orders] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

