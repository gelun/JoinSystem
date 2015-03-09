using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class GL_DeliverGoodsList
	{
		#region  GL_DeliverGoodsList
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int GL_DeliverGoodsListAdd(Entity.GL_DeliverGoodsList info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@GL_DeliverGoodsId", SqlDbType.Int, 4, info.GL_DeliverGoodsId),
				SqlDB.MakeInParam("@MaterialId", SqlDbType.Int, 4, info.MaterialId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "GL_DeliverGoodsListAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool GL_DeliverGoodsListEdit(Entity.GL_DeliverGoodsList info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@GL_DeliverGoodsId", SqlDbType.Int, 4, info.GL_DeliverGoodsId),
				SqlDB.MakeInParam("@MaterialId", SqlDbType.Int, 4, info.MaterialId),
				SqlDB.MakeInParam("@Number", SqlDbType.Int, 4, info.Number),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "GL_DeliverGoodsListEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable GL_DeliverGoodsListList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [GL_DeliverGoodsList] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [GL_DeliverGoodsList] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable GL_DeliverGoodsListGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [GL_DeliverGoodsList] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.GL_DeliverGoodsList GL_DeliverGoodsListEntityGet(int Id)
		{
			Entity.GL_DeliverGoodsList info = new Entity.GL_DeliverGoodsList();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [GL_DeliverGoodsList] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.GL_DeliverGoodsId = Basic.Utils.StrToInt(dt.Rows[0]["GL_DeliverGoodsId"].ToString(),0);
				info.MaterialId = Basic.Utils.StrToInt(dt.Rows[0]["MaterialId"].ToString(),0);
				info.Number = Basic.Utils.StrToInt(dt.Rows[0]["Number"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool GL_DeliverGoodsListDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [GL_DeliverGoodsList]  WHERE Id =  " + Id);
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
		public static DataTable GL_DeliverGoodsListTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [GL_DeliverGoodsList] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [GL_DeliverGoodsList] ;";
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
		public static DataTable GL_DeliverGoodsListPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM GL_DeliverGoodsList");
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
		public static int GL_DeliverGoodsListCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [GL_DeliverGoodsList] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [GL_DeliverGoodsList] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

