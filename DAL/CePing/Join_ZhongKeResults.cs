using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Join_ZhongKeResults
    {
        
		#region  Join_ZhongKeResults
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_ZhongKeResultsAdd(Entity.Join_ZhongKeResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@BeiDong", SqlDbType.Int, 4, info.BeiDong),
				SqlDB.MakeInParam("@YanXue", SqlDbType.Int, 4, info.YanXue),
				SqlDB.MakeInParam("@XinXiCaiJi", SqlDbType.Int, 4, info.XinXiCaiJi),
				SqlDB.MakeInParam("@FangFa", SqlDbType.Int, 4, info.FangFa),
				SqlDB.MakeInParam("@BiJiao", SqlDbType.Int, 4, info.BiJiao),
				SqlDB.MakeInParam("@ZiJian", SqlDbType.Int, 4, info.ZiJian),
				SqlDB.MakeInParam("@QuDao", SqlDbType.Int, 4, info.QuDao),
				SqlDB.MakeInParam("@FenXi", SqlDbType.Int, 4, info.FenXi),
				SqlDB.MakeInParam("@ZiKong", SqlDbType.Int, 4, info.ZiKong),
				SqlDB.MakeInParam("@GouTong", SqlDbType.Int, 4, info.GouTong),
				SqlDB.MakeInParam("@SiWei", SqlDbType.Int, 4, info.SiWei),
				SqlDB.MakeInParam("@ChengDan", SqlDbType.Int, 4, info.ChengDan),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_ZhongKeResultsAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_ZhongKeResultsEdit(Entity.Join_ZhongKeResults info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@UserId", SqlDbType.Int, 4, info.UserId),
				SqlDB.MakeInParam("@BeiDong", SqlDbType.Int, 4, info.BeiDong),
				SqlDB.MakeInParam("@YanXue", SqlDbType.Int, 4, info.YanXue),
				SqlDB.MakeInParam("@XinXiCaiJi", SqlDbType.Int, 4, info.XinXiCaiJi),
				SqlDB.MakeInParam("@FangFa", SqlDbType.Int, 4, info.FangFa),
				SqlDB.MakeInParam("@BiJiao", SqlDbType.Int, 4, info.BiJiao),
				SqlDB.MakeInParam("@ZiJian", SqlDbType.Int, 4, info.ZiJian),
				SqlDB.MakeInParam("@QuDao", SqlDbType.Int, 4, info.QuDao),
				SqlDB.MakeInParam("@FenXi", SqlDbType.Int, 4, info.FenXi),
				SqlDB.MakeInParam("@ZiKong", SqlDbType.Int, 4, info.ZiKong),
				SqlDB.MakeInParam("@GouTong", SqlDbType.Int, 4, info.GouTong),
				SqlDB.MakeInParam("@SiWei", SqlDbType.Int, 4, info.SiWei),
				SqlDB.MakeInParam("@ChengDan", SqlDbType.Int, 4, info.ChengDan),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_ZhongKeResultsEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
	 
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ZhongKeResultsList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Join_ZhongKeResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Join_ZhongKeResults] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ZhongKeResultsGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ZhongKeResults] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_ZhongKeResults Join_ZhongKeResultsEntityGet(int Id)
		{
			Entity.Join_ZhongKeResults info = new Entity.Join_ZhongKeResults();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ZhongKeResults] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.UserId = Basic.Utils.StrToInt(dt.Rows[0]["UserId"].ToString(),0);
				info.BeiDong = Basic.Utils.StrToInt(dt.Rows[0]["BeiDong"].ToString(),0);
				info.YanXue = Basic.Utils.StrToInt(dt.Rows[0]["YanXue"].ToString(),0);
				info.XinXiCaiJi = Basic.Utils.StrToInt(dt.Rows[0]["XinXiCaiJi"].ToString(),0);
				info.FangFa = Basic.Utils.StrToInt(dt.Rows[0]["FangFa"].ToString(),0);
				info.BiJiao = Basic.Utils.StrToInt(dt.Rows[0]["BiJiao"].ToString(),0);
				info.ZiJian = Basic.Utils.StrToInt(dt.Rows[0]["ZiJian"].ToString(),0);
				info.QuDao = Basic.Utils.StrToInt(dt.Rows[0]["QuDao"].ToString(),0);
				info.FenXi = Basic.Utils.StrToInt(dt.Rows[0]["FenXi"].ToString(),0);
				info.ZiKong = Basic.Utils.StrToInt(dt.Rows[0]["ZiKong"].ToString(),0);
				info.GouTong = Basic.Utils.StrToInt(dt.Rows[0]["GouTong"].ToString(),0);
				info.SiWei = Basic.Utils.StrToInt(dt.Rows[0]["SiWei"].ToString(),0);
				info.ChengDan = Basic.Utils.StrToInt(dt.Rows[0]["ChengDan"].ToString(),0);
                info.AddTime = DateTime.Parse(dt.Rows[0]["AddTime"].ToString());
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_ZhongKeResultsDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_ZhongKeResults]  WHERE Id =  " + Id);
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
		public static DataTable Join_ZhongKeResultsTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ZhongKeResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ZhongKeResults] ;";
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
		public static DataTable Join_ZhongKeResultsPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_ZhongKeResults");
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
		public static int Join_ZhongKeResultsCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_ZhongKeResults] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_ZhongKeResults] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

