using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class Article
	{
		#region  Article
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int ArticleAdd(Entity.Article info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Title", SqlDbType.NVarChar, 400, info.Title),
				SqlDB.MakeInParam("@Content", SqlDbType.NText, 0, info.Content),
				SqlDB.MakeInParam("@ArticleTypeId", SqlDbType.Int, 4, info.ArticleTypeId),
				SqlDB.MakeInParam("@PorjectCategoryId", SqlDbType.Int, 4, info.PorjectCategoryId),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@IsCheck", SqlDbType.Int, 4, info.IsCheck),
				SqlDB.MakeInParam("@CheckWid", SqlDbType.Int, 4, info.CheckWid),
				SqlDB.MakeInParam("@CheckTime", SqlDbType.DateTime, 8, info.CheckTime),
				SqlDB.MakeInParam("@EditWid", SqlDbType.Int, 4, info.EditWid),
				SqlDB.MakeInParam("@EditTime", SqlDbType.DateTime, 8, info.EditTime),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				SqlDB.MakeInParam("@IsZhiDing", SqlDbType.Int, 4, info.IsZhiDing),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "ArticleAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool ArticleEdit(Entity.Article info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@Title", SqlDbType.NVarChar, 400, info.Title),
				SqlDB.MakeInParam("@Content", SqlDbType.NText, 0, info.Content),
				SqlDB.MakeInParam("@ArticleTypeId", SqlDbType.Int, 4, info.ArticleTypeId),
				SqlDB.MakeInParam("@PorjectCategoryId", SqlDbType.Int, 4, info.PorjectCategoryId),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				SqlDB.MakeInParam("@IsCheck", SqlDbType.Int, 4, info.IsCheck),
				SqlDB.MakeInParam("@CheckWid", SqlDbType.Int, 4, info.CheckWid),
				SqlDB.MakeInParam("@CheckTime", SqlDbType.DateTime, 8, info.CheckTime),
				SqlDB.MakeInParam("@EditWid", SqlDbType.Int, 4, info.EditWid),
				SqlDB.MakeInParam("@EditTime", SqlDbType.DateTime, 8, info.EditTime),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				SqlDB.MakeInParam("@IsZhiDing", SqlDbType.Int, 4, info.IsZhiDing),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "ArticleEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 暂停该值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>暂停成功返回ture，否则返回false</returns>
		public static bool ArticlePause(Entity.Article info)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [Article] SET IsPause = "+  info.IsPause +"  WHERE Id =  " +  info.Id);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ArticleList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [Article] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [Article] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ArticleGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Article] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Article ArticleEntityGet(int Id)
		{
			Entity.Article info = new Entity.Article();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Article] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.Title = dt.Rows[0]["Title"].ToString();
				info.Content = dt.Rows[0]["Content"].ToString();
				info.ArticleTypeId = Basic.Utils.StrToInt(dt.Rows[0]["ArticleTypeId"].ToString(),0);
				info.PorjectCategoryId = Basic.Utils.StrToInt(dt.Rows[0]["PorjectCategoryId"].ToString(),0);
				info.AddWid = Basic.Utils.StrToInt(dt.Rows[0]["AddWid"].ToString(),0);
				info.IsCheck = Basic.Utils.StrToInt(dt.Rows[0]["IsCheck"].ToString(),0);
				info.CheckWid = Basic.Utils.StrToInt(dt.Rows[0]["CheckWid"].ToString(),0);
				info.EditWid = Basic.Utils.StrToInt(dt.Rows[0]["EditWid"].ToString(),0);
				info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(),0);
				info.IsZhiDing = Basic.Utils.StrToInt(dt.Rows[0]["IsZhiDing"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool ArticleDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Article]  WHERE Id =  " + Id);
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
		public static DataTable ArticleTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Article] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Article] ;";
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
		public static DataTable ArticlePageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Article");
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
		public static int ArticleCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Article] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Article] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

