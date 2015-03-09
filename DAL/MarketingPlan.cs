using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
	public class MarketingPlan
	{
		#region  MarketingPlan
		/// <summary>
		/// 调用存储过程增加一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
		public static int MarketingPlanAdd(Entity.MarketingPlan info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@ProjectCategoryId", SqlDbType.Int, 4, info.ProjectCategoryId),
				SqlDB.MakeInParam("@ProjectLeader", SqlDbType.Int, 4, info.ProjectLeader),
				SqlDB.MakeInParam("@Address", SqlDbType.VarChar, 200, info.Address),
				SqlDB.MakeInParam("@PromotionWay", SqlDbType.VarChar, 50, info.PromotionWay),
				SqlDB.MakeInParam("@BeginDate", SqlDbType.DateTime, 8, info.BeginDate),
				SqlDB.MakeInParam("@EndDate", SqlDbType.DateTime, 8, info.EndDate),
				SqlDB.MakeInParam("@ExpectedDays", SqlDbType.Int, 4, info.ExpectedDays),
				SqlDB.MakeInParam("@ExpectedFullTimeNumber", SqlDbType.Int, 4, info.ExpectedFullTimeNumber),
				SqlDB.MakeInParam("@ExpectedPartTimeNumber", SqlDbType.Int, 4, info.ExpectedPartTimeNumber),
				SqlDB.MakeInParam("@ExpectedPartTimePrice", SqlDbType.Money, 8, info.ExpectedPartTimePrice),
				SqlDB.MakeInParam("@ExpectedBoothPrice", SqlDbType.Money, 8, info.ExpectedBoothPrice),
				SqlDB.MakeInParam("@ExpectedBudget", SqlDbType.Money, 8, info.ExpectedBudget),
				SqlDB.MakeInParam("@ExpectedRenShu", SqlDbType.Int, 4, info.ExpectedRenShu),
				SqlDB.MakeInParam("@PartTimePrice", SqlDbType.Money, 8, info.PartTimePrice),
				SqlDB.MakeInParam("@BoothPrice", SqlDbType.Money, 8, info.BoothPrice),
				SqlDB.MakeInParam("@TotleMoney", SqlDbType.Money, 8, info.TotleMoney),
				SqlDB.MakeInParam("@ShiJiRenShu", SqlDbType.Int, 4, info.ShiJiRenShu),
				SqlDB.MakeInParam("@State", SqlDbType.Int, 4, info.State),
				SqlDB.MakeInParam("@IsFinish", SqlDbType.Int, 4, info.IsFinish),
				SqlDB.MakeInParam("@FinishDate", SqlDbType.DateTime, 8, info.FinishDate),
				SqlDB.MakeInParam("@Evaluation", SqlDbType.VarChar, 500, info.Evaluation),
				SqlDB.MakeInParam("@EvaluationLevel", SqlDbType.Int, 4, info.EvaluationLevel),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
			};
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "MarketingPlanAdd", prams).ToString(), -1);
		}
		
		/// <summary>
		/// 调用存储过程修改一个
		/// </summary>
		/// <param name="info">实体对象</param>
		/// <returns>更新成功返回ture，否则返回false</returns>
		public static bool MarketingPlanEdit(Entity.MarketingPlan info)
		{
			SqlParameter[] prams = {
				SqlDB.MakeInParam("@Id", SqlDbType.Int, 4, info.Id),
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@ProjectCategoryId", SqlDbType.Int, 4, info.ProjectCategoryId),
				SqlDB.MakeInParam("@ProjectLeader", SqlDbType.Int, 4, info.ProjectLeader),
				SqlDB.MakeInParam("@Address", SqlDbType.VarChar, 200, info.Address),
				SqlDB.MakeInParam("@PromotionWay", SqlDbType.VarChar, 50, info.PromotionWay),
				SqlDB.MakeInParam("@BeginDate", SqlDbType.DateTime, 8, info.BeginDate),
				SqlDB.MakeInParam("@EndDate", SqlDbType.DateTime, 8, info.EndDate),
				SqlDB.MakeInParam("@ExpectedDays", SqlDbType.Int, 4, info.ExpectedDays),
				SqlDB.MakeInParam("@ExpectedFullTimeNumber", SqlDbType.Int, 4, info.ExpectedFullTimeNumber),
				SqlDB.MakeInParam("@ExpectedPartTimeNumber", SqlDbType.Int, 4, info.ExpectedPartTimeNumber),
				SqlDB.MakeInParam("@ExpectedPartTimePrice", SqlDbType.Money, 8, info.ExpectedPartTimePrice),
				SqlDB.MakeInParam("@ExpectedBoothPrice", SqlDbType.Money, 8, info.ExpectedBoothPrice),
				SqlDB.MakeInParam("@ExpectedBudget", SqlDbType.Money, 8, info.ExpectedBudget),
				SqlDB.MakeInParam("@ExpectedRenShu", SqlDbType.Int, 4, info.ExpectedRenShu),
				SqlDB.MakeInParam("@PartTimePrice", SqlDbType.Money, 8, info.PartTimePrice),
				SqlDB.MakeInParam("@BoothPrice", SqlDbType.Money, 8, info.BoothPrice),
				SqlDB.MakeInParam("@TotleMoney", SqlDbType.Money, 8, info.TotleMoney),
				SqlDB.MakeInParam("@ShiJiRenShu", SqlDbType.Int, 4, info.ShiJiRenShu),
				SqlDB.MakeInParam("@State", SqlDbType.Int, 4, info.State),
				SqlDB.MakeInParam("@IsFinish", SqlDbType.Int, 4, info.IsFinish),
				SqlDB.MakeInParam("@FinishDate", SqlDbType.DateTime, 8, info.FinishDate),
				SqlDB.MakeInParam("@Evaluation", SqlDbType.VarChar, 500, info.Evaluation),
				SqlDB.MakeInParam("@EvaluationLevel", SqlDbType.Int, 4, info.EvaluationLevel),
				SqlDB.MakeInParam("@AddWid", SqlDbType.Int, 4, info.AddWid),
				SqlDB.MakeInParam("@AddTime", SqlDbType.DateTime, 8, info.AddTime),
				};
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "MarketingPlanEdit", prams);
			if(intReturnValue == 1)
				return true;
			return false;
		}
		
		/// <summary>
		/// 获取所有的的值
		/// </summary>
		/// <param name="strWhere">条件，可以为空</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MarketingPlanList(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT * FROM [MarketingPlan] WHERE "+ strWhere +";";
			else
				strSql = "SELECT * FROM [MarketingPlan] ;";
			return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
		}
		
		
		/// <summary>
		/// 获取某一个DataTable
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回DataTable</returns>
		public static DataTable MarketingPlanGet(int Id)
		{
			return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MarketingPlan] WHERE Id = "+Id+";").Tables[0];
		}
		
		/// <summary>
		/// 获取某一个实体
		/// </summary>
		/// <param name="Id">标识</param>
		/// <returns>返回Entity</returns>
		public static Entity.MarketingPlan MarketingPlanEntityGet(int Id)
		{
			Entity.MarketingPlan info = new Entity.MarketingPlan();
			DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MarketingPlan] WHERE Id = "+Id+";").Tables[0];
			if(dt.Rows.Count >0)
			{
				info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(),0);
				info.DianId = Basic.Utils.StrToInt(dt.Rows[0]["DianId"].ToString(),0);
				info.ProjectCategoryId = Basic.Utils.StrToInt(dt.Rows[0]["ProjectCategoryId"].ToString(),0);
				info.ProjectLeader = Basic.Utils.StrToInt(dt.Rows[0]["ProjectLeader"].ToString(),0);
				info.Address = dt.Rows[0]["Address"].ToString();
				info.PromotionWay = dt.Rows[0]["PromotionWay"].ToString();
				info.ExpectedDays = Basic.Utils.StrToInt(dt.Rows[0]["ExpectedDays"].ToString(),0);
				info.ExpectedFullTimeNumber = Basic.Utils.StrToInt(dt.Rows[0]["ExpectedFullTimeNumber"].ToString(),0);
				info.ExpectedPartTimeNumber = Basic.Utils.StrToInt(dt.Rows[0]["ExpectedPartTimeNumber"].ToString(),0);
				info.ExpectedRenShu = Basic.Utils.StrToInt(dt.Rows[0]["ExpectedRenShu"].ToString(),0);
				info.ShiJiRenShu = Basic.Utils.StrToInt(dt.Rows[0]["ShiJiRenShu"].ToString(),0);
				info.State = Basic.Utils.StrToInt(dt.Rows[0]["State"].ToString(),0);
				info.IsFinish = Basic.Utils.StrToInt(dt.Rows[0]["IsFinish"].ToString(),0);
				info.Evaluation = dt.Rows[0]["Evaluation"].ToString();
				info.EvaluationLevel = Basic.Utils.StrToInt(dt.Rows[0]["EvaluationLevel"].ToString(),0);
				info.AddWid = Basic.Utils.StrToInt(dt.Rows[0]["AddWid"].ToString(),0);
			}
			return info;
		}
		
		/// <summary>
		/// 删除一个值
		/// </summary>
		/// <param name="Id">自增id的值</param>
		/// <returns>删除成功返回ture，否则返回false</returns>
		public static bool MarketingPlanDel(int Id)
		{
			int intReturnValue = 0;
			intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [MarketingPlan]  WHERE Id =  " + Id);
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
		public static DataTable MarketingPlanTopGet(string strWhere,int TopNumber)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MarketingPlan] WHERE "+ strWhere +";";
			else
				strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MarketingPlan] ;";
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
		public static DataTable MarketingPlanPageList(string strWhere,int PageSize,int PageIndex)
		{
			StringBuilder sbSql = new StringBuilder();
			sbSql.Append("SELECT * FROM MarketingPlan");
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
		public static int MarketingPlanCount(string strWhere)
		{
			string strSql;
			if (!string.IsNullOrEmpty(strWhere.Trim()))
				strSql = "SELECT COUNT(*) FROM [MarketingPlan] WHERE "+ strWhere +";";
			else
				strSql = "SELECT COUNT(*)  FROM [MarketingPlan] ;";
			return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
		}
	#endregion
		
	}
}

