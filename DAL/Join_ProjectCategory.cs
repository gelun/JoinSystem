using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;
using System.Web.UI.WebControls;

namespace DAL
{
	public class Join_ProjectCategory
	{
		#region  Join_ProjectCategory
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int Join_ProjectCategoryAdd(Entity.Join_ProjectCategory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@ProjectCategoryName", SqlDbType.NVarChar, 200, info.ProjectCategoryName),
				SqlDB.MakeInParam("@ParentPCid", SqlDbType.Int, 4, info.ParentPCid),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_ProjectCategoryAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool Join_ProjectCategoryEdit(Entity.Join_ProjectCategory info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@ProjectCategoryId", SqlDbType.Int, 4, info.ProjectCategoryId),
				SqlDB.MakeInParam("@ProjectCategoryName", SqlDbType.NVarChar, 200, info.ProjectCategoryName),
				SqlDB.MakeInParam("@ParentPCid", SqlDbType.Int, 4, info.ParentPCid),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_ProjectCategoryEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 暂停该值
		/// </summary>
		/// <param name="ProjectCategoryId">自增id的值</param>
		/// <returns>暂停成功返回ture，否则返回false</returns>
		public static bool Join_ProjectCategoryPause(Entity.Join_ProjectCategory info)
		{

            SqlParameter[] prams = {
				SqlDB.MakeInParam("@ProjectCategoryId", SqlDbType.Int, 4, info.ProjectCategoryId),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				};
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_ProjectCategoryPause", prams);
            if (intReturnValue == 1)
                return true;
            return false;
		}

        /// <summary>
        /// 获取所有的的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_ProjectCategoryList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT * FROM [Join_ProjectCategory] WHERE " + strWhere + " Order by Sort ASC;";
            else
                strSql = "SELECT * FROM [Join_ProjectCategory] Order by Sort ASC;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }	

        //总部加盟店店员
        public static DataTable Join_LoginSMSProjectCategoryList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc where pc.ProjectCategoryId = wpc.PCid and pc.IsPause = 0 and " + strWhere + " Order by pc.ProjectCategoryId ASC";
            else
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc where pc.ProjectCategoryId = wpc.PCid and pc.IsPause = 0  Order by pc.ProjectCategoryId ASC ";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }

        //加盟店店员
        public static DataTable Join_DianYuanLoginSMSProjectCategoryList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_DianUserPCidRelation as upc where pc.ProjectCategoryId = upc.PCid and pc.IsPause = 0 and " + strWhere + " Order by pc.ProjectCategoryId ASC";
            else
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_DianUserPCidRelation as upc where pc.ProjectCategoryId = upc.PCid and pc.IsPause = 0  Order by pc.ProjectCategoryId ASC ";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }

        //生成树状
        public static void Recursion(DataTable dt, DropDownList ddl, int pId, int depth, string style)
        {
            string dephtNbj = "";
            for (int i = 0; i < depth; i++)
            {
                dephtNbj += "　";
            }

            depth++;

            DataRow[] drs = dt.Select("ParentPCid=" + pId);
            if (drs.Length > 0)
            {
                ListItem li;
                foreach (DataRow dr in drs)
                {
                    li = new ListItem();
                    if (depth != 1)
                    {
                        li.Text = dephtNbj + style + dr["ProjectCategoryName"].ToString();
                    }
                    else
                    {
                        li.Text = dephtNbj + dr["ProjectCategoryName"].ToString();
                    }
                    li.Value = dr["ProjectCategoryId"].ToString();
                    ddl.Items.Add(li);
                    Recursion(dt, ddl, int.Parse(dr["ProjectCategoryId"].ToString()), depth, style);
                }

            }
        }

        //生成树状
        public static void TreeDDL(DataTable dt, DropDownList ddl, int pId, int depth, string style)
        {
            string dephtNbj = "";
            for (int i = 0; i < depth; i++)
            {
                dephtNbj += "　";
            }

            depth++;

            DataRow[] drs = dt.Select("ParentPCid=" + pId);
            if (drs.Length > 0)
            {
                ListItem li;
                foreach (DataRow dr in drs)
                {
                    li = new ListItem();
                    if (depth != 1)
                    {
                        li.Text = dephtNbj + style + dr["ProjectCategoryName"].ToString();
                    }
                    else
                    {
                        li.Text = dephtNbj + dr["ProjectCategoryName"].ToString();
                    }
                    
                    //li.Value = dr["ProjectCategoryId"].ToString();
                    ddl.Items.Add(li);
                    TreeDDL(dt, ddl, int.Parse(dr["ProjectCategoryId"].ToString()), depth, style);
                }

            }
        }
        

        //执行一个简单 的sql语句
        public static int Join_ProjectCategoryExSqlString(string sqlString)
        {

            return SqlDB.ExecuteNonQuery(CommandType.Text,sqlString);
        }
		#endregion
		
		
		#region  Join_ProjectCategory
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="ProjectCategoryId">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable Join_ProjectCategoryGet(int ProjectCategoryId)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ProjectCategory] WHERE ProjectCategoryId = "+ProjectCategoryId+";").Tables[0];
		}



        /// <summary>
        /// 获取某一个DataTable
        /// </summary>
        /// <param name="ProjectCategoryId">标识</param>
        /// <returns>返回DataTable</returns>
        public static string Join_ProjectCategoryGetName(int ProjectCategoryId)
        {
            return SqlDB.ExecuteScalarToStr(CommandType.Text, "SELECT ProjectCategoryName FROM [Join_ProjectCategory] WHERE ProjectCategoryId = " + ProjectCategoryId + ";");
        }
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="ProjectCategoryId">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.Join_ProjectCategory Join_ProjectCategoryEntityGet(int ProjectCategoryId)
		{
			Entity.Join_ProjectCategory info = new Entity.Join_ProjectCategory();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_ProjectCategory] WHERE ProjectCategoryId = "+ProjectCategoryId+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.ProjectCategoryId = Basic.Utils.StrToInt(dt.Rows[0]["ProjectCategoryId"].ToString(),0);
				info.ProjectCategoryName = dt.Rows[0]["ProjectCategoryName"].ToString();
				info.ParentPCid = Basic.Utils.StrToInt(dt.Rows[0]["ParentPCid"].ToString(),0);
				info.ParentPCPath = dt.Rows[0]["ParentPCPath"].ToString();
                info.PCDepth = Basic.Utils.StrToInt(dt.Rows[0]["PCDepth"].ToString(), 0);
                info.IsHasSon = Basic.Utils.StrToInt(dt.Rows[0]["IsHasSon"].ToString(), 0);
				info.Sort = Basic.Utils.StrToInt(dt.Rows[0]["Sort"].ToString(),0);
				info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(),0);
                return info;
			}
            return null;
			
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="ProjectCategoryId">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool Join_ProjectCategoryDel(int ProjectCategoryId)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_ProjectCategory]  WHERE ProjectCategoryId =  " + ProjectCategoryId);
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
		public static DataTable Join_ProjectCategoryTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ProjectCategory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_ProjectCategory] ;";
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
		public static DataTable Join_ProjectCategoryPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM Join_ProjectCategory");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				sbSql.Append(" WHERE " + strWhere);
			}
            sbSql.Append(" ORDER BY Sort asc");
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
		public static int Join_ProjectCategoryCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [Join_ProjectCategory] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [Join_ProjectCategory] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion

        #region 新增
        /// <summary>
        /// 员工项目分配关系列表
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_LoginProjectCategoryList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc WHERE (pc.ProjectCategoryId = wpc.PCid or pc.ParentPCPath like '%,'+cast(wpc.PCid as nvarchar(200))+',%') and  pc.IsPause = 0 " + strWhere + "  Order by pc.ProjectCategoryId ASC;";
            //strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc  WHERE pc.ProjectCategoryId = wpc.PCid and " + strWhere + " Order by Sort ASC;";
            else
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc WHERE (pc.ProjectCategoryId = wpc.PCid or pc.ParentPCPath like '%,'+cast(wpc.PCid as nvarchar(200))+',%') and  pc.IsPause = 0 Order by pc.ProjectCategoryId ASC;";
                //strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc  WHERE pc.ProjectCategoryId = wpc.PCid Order by Sort ASC;";
                return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }

        public static DataTable Join_LoginProjectCategoryList2(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc WHERE (pc.ProjectCategoryId = wpc.PCid) and  pc.IsPause = 0 " + strWhere + "  Order by pc.ProjectCategoryId ASC;";
            //strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc  WHERE pc.ProjectCategoryId = wpc.PCid and " + strWhere + " Order by Sort ASC;";
            else
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc WHERE (pc.ProjectCategoryId = wpc.PCid) and  pc.IsPause = 0 Order by pc.ProjectCategoryId ASC;";
            //strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_WorkerProjectCategory as wpc  WHERE pc.ProjectCategoryId = wpc.PCid Order by Sort ASC;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }

        /// <summary>
        /// 店员项目分配关系列表
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_DianUserLoginProjectCategoryList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_DianUserPCidRelation as upc WHERE (pc.ProjectCategoryId = upc.PCid or pc.ParentPCPath like '%,'+cast(upc.PCid as nvarchar(200))+',%') and  pc.IsPause = 0 " + strWhere + "  Order by pc.ProjectCategoryId ASC;";
            //strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_DianUserPCidRelation as upc  WHERE (pc.ProjectCategoryId = upc.PCid or pc.ParentPCPath like '%,'+cast(wpc.PCid as nvarchar(200))+',%') and pc.IsPause = 0 " + strWhere + " Order by pc.ProjectCategoryId ASC;";
            else
                strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_DianUserPCidRelation as upc WHERE (pc.ProjectCategoryId = upc.PCid or pc.ParentPCPath like '%,'+cast(upc.PCid as nvarchar(200))+',%') and  pc.IsPause = 0 Order by pc.ProjectCategoryId ASC;";
                //strSql = "SELECT pc.* FROM [Join_ProjectCategory] as pc,Join_DianUserPCidRelation as upc  WHERE pc.ProjectCategoryId = upc.PCid Order by Sort ASC;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }
        #endregion

    }
}

