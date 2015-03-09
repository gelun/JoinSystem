using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class CooperativePartner
	{
		#region  CooperativePartner
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int CooperativePartnerAdd(Entity.CooperativePartner info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@PartnerType", SqlDbType.Int, 4, info.PartnerType),
				SqlDB.MakeInParam("@SerialNumber", SqlDbType.NVarChar, 50, info.SerialNumber),
				SqlDB.MakeInParam("@PartnerName", SqlDbType.NVarChar, 50, info.PartnerName),
				SqlDB.MakeInParam("@ShortName", SqlDbType.NVarChar, 20, info.ShortName),
				SqlDB.MakeInParam("@OldName", SqlDbType.NVarChar, 50, info.OldName),
				SqlDB.MakeInParam("@ProvinceId", SqlDbType.Int, 4, info.ProvinceId),
				SqlDB.MakeInParam("@CityId", SqlDbType.Int, 4, info.CityId),
				SqlDB.MakeInParam("@DistinctId", SqlDbType.Int, 4, info.DistinctId),
				SqlDB.MakeInParam("@Address", SqlDbType.NVarChar, 200, info.Address),
				SqlDB.MakeInParam("@ZipCode", SqlDbType.NVarChar, 6, info.ZipCode),
				SqlDB.MakeInParam("@TelPhone", SqlDbType.NVarChar, 50, info.TelPhone),
				SqlDB.MakeInParam("@State", SqlDbType.Int, 4, info.State),
				SqlDB.MakeInParam("@OpeningDate", SqlDbType.DateTime, 8, info.OpeningDate),
				SqlDB.MakeInParam("@OpeningMemo", SqlDbType.NVarChar, 500, info.OpeningMemo),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@ParentId", SqlDbType.Int, 4, info.ParentId),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "CooperativePartnerAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool CooperativePartnerEdit(Entity.CooperativePartner info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@PartnerType", SqlDbType.Int, 4, info.PartnerType),
				SqlDB.MakeInParam("@SerialNumber", SqlDbType.NVarChar, 50, info.SerialNumber),
				SqlDB.MakeInParam("@PartnerName", SqlDbType.NVarChar, 50, info.PartnerName),
				SqlDB.MakeInParam("@ShortName", SqlDbType.NVarChar, 20, info.ShortName),
				SqlDB.MakeInParam("@OldName", SqlDbType.NVarChar, 50, info.OldName),
				SqlDB.MakeInParam("@ProvinceId", SqlDbType.Int, 4, info.ProvinceId),
				SqlDB.MakeInParam("@CityId", SqlDbType.Int, 4, info.CityId),
				SqlDB.MakeInParam("@DistinctId", SqlDbType.Int, 4, info.DistinctId),
				SqlDB.MakeInParam("@Address", SqlDbType.NVarChar, 200, info.Address),
				SqlDB.MakeInParam("@ZipCode", SqlDbType.NVarChar, 6, info.ZipCode),
				SqlDB.MakeInParam("@TelPhone", SqlDbType.NVarChar, 50, info.TelPhone),
				SqlDB.MakeInParam("@State", SqlDbType.Int, 4, info.State),
				SqlDB.MakeInParam("@OpeningDate", SqlDbType.DateTime, 8, info.OpeningDate),
				SqlDB.MakeInParam("@OpeningMemo", SqlDbType.NVarChar, 500, info.OpeningMemo),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@ParentId", SqlDbType.Int, 4, info.ParentId),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "CooperativePartnerEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable CooperativePartnerList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [CooperativePartner] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [CooperativePartner] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable CooperativePartnerGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [CooperativePartner] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.CooperativePartner CooperativePartnerEntityGet(int Id)
		{
			Entity.CooperativePartner info = new Entity.CooperativePartner();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [CooperativePartner] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.PartnerType = Basic.Utils.StrToInt(dt.Rows[0]["PartnerType"].ToString(),0);
				info.SerialNumber = dt.Rows[0]["SerialNumber"].ToString();
				info.PartnerName = dt.Rows[0]["PartnerName"].ToString();
				info.ShortName = dt.Rows[0]["ShortName"].ToString();
				info.OldName = dt.Rows[0]["OldName"].ToString();
				info.ProvinceId = Basic.Utils.StrToInt(dt.Rows[0]["ProvinceId"].ToString(),0);
				info.CityId = Basic.Utils.StrToInt(dt.Rows[0]["CityId"].ToString(),0);
				info.DistinctId = Basic.Utils.StrToInt(dt.Rows[0]["DistinctId"].ToString(),0);
				info.Address = dt.Rows[0]["Address"].ToString();
				info.ZipCode = dt.Rows[0]["ZipCode"].ToString();
				info.TelPhone = dt.Rows[0]["TelPhone"].ToString();
				info.State = Basic.Utils.StrToInt(dt.Rows[0]["State"].ToString(),0);
				info.OpeningMemo = dt.Rows[0]["OpeningMemo"].ToString();
				info.AddWid = Basic.Utils.StrToInt(dt.Rows[0]["AddWid"].ToString(),0);
				info.ParentId = Basic.Utils.StrToInt(dt.Rows[0]["ParentId"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool CooperativePartnerDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [CooperativePartner]  WHERE Id =  " + Id);
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
		public static DataTable CooperativePartnerTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [CooperativePartner] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [CooperativePartner] ;";
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
		public static DataTable CooperativePartnerPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM CooperativePartner");
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
		public static int CooperativePartnerCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [CooperativePartner] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [CooperativePartner] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

