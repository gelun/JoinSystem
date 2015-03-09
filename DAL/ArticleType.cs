using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class ArticleType
	{
		#region  ArticleType
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int ArticleTypeAdd(Entity.ArticleType info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TypeName", SqlDbType.NVarChar, 100, info.TypeName),
				SqlDB.MakeInParam("@ParentId", SqlDbType.Int, 4, info.ParentId),
				SqlDB.MakeInParam("@Sort", SqlDbType.Int, 4, info.Sort),
				SqlDB.MakeInParam("@IsPublic", SqlDbType.Int, 4, info.IsPublic),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "ArticleTypeAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool ArticleTypeEdit(Entity.ArticleType info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@TypeId", SqlDbType.Int, 4, info.TypeId),
				SqlDB.MakeInParam("@TypeName", SqlDbType.NVarChar, 100, info.TypeName),
				SqlDB.MakeInParam("@ParentId", SqlDbType.Int, 4, info.ParentId),
				SqlDB.MakeInParam("@Sort", SqlDbType.Int, 4, info.Sort),
				SqlDB.MakeInParam("@IsPublic", SqlDbType.Int, 4, info.IsPublic),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "ArticleTypeEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 暂停该值
		/// </summary>
		/// <param name="TypeId">自增id的值</param>
		/// <returns>暂停成功返回ture，否则返回false</returns>
		public static bool ArticleTypePause(Entity.ArticleType info)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [ArticleType] SET IsPause = "+  info.IsPause +"  WHERE TypeId =  " +  info.TypeId);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ArticleTypeList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [ArticleType] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [ArticleType] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="TypeId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable ArticleTypeGet(int TypeId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [ArticleType] WHERE TypeId = "+TypeId+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="TypeId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.ArticleType ArticleTypeEntityGet(int TypeId)
		{
			Entity.ArticleType info = new Entity.ArticleType();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [ArticleType] WHERE TypeId = "+TypeId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.TypeId = Basic.Utils.StrToInt(dt.Rows[0]["TypeId"].ToString(),0);
				info.TypeName = dt.Rows[0]["TypeName"].ToString();
				info.ParentId = Basic.Utils.StrToInt(dt.Rows[0]["ParentId"].ToString(),0);
				info.Sort = Basic.Utils.StrToInt(dt.Rows[0]["Sort"].ToString(),0);
				info.IsPublic = Basic.Utils.StrToInt(dt.Rows[0]["IsPublic"].ToString(),0);
				info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="TypeId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool ArticleTypeDel(int TypeId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [ArticleType]  WHERE TypeId =  " + TypeId);
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
		public static DataTable ArticleTypeTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [ArticleType] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [ArticleType] ;";
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
		public static DataTable ArticleTypePageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM ArticleType");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
			sbSql.Append(" ORDER BY TypeId DESC");
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
		public static int ArticleTypeCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [ArticleType] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [ArticleType] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

