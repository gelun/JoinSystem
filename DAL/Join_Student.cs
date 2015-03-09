using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
    public class Join_Student
    {
        #region  Join_Student
        /// <summary>
        /// 调用存储过程增加一个
        /// </summary>
        /// <param name="info">实体对象</param>
        /// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
        public static int Join_StudentAdd(Entity.Join_Student info)
        {
            SqlParameter[] prams = {
				SqlDB.MakeInParam("@StudentBank", SqlDbType.VarChar, 20, info.StudentBank),
				SqlDB.MakeInParam("@StudentPass", SqlDbType.VarChar, 20, info.StudentPass),
				SqlDB.MakeInParam("@StudenName", SqlDbType.VarChar, 50, info.StudenName),
				SqlDB.MakeInParam("@CellTel", SqlDbType.VarChar, 50, info.CellTel),
				SqlDB.MakeInParam("@CellPhone", SqlDbType.VarChar, 50, info.CellPhone),
				SqlDB.MakeInParam("@Address", SqlDbType.VarChar, 100, info.Address),
				SqlDB.MakeInParam("@IdNumber", SqlDbType.VarChar, 18, info.IdNumber),
				SqlDB.MakeInParam("@BirthDate", SqlDbType.Char, 10, info.BirthDate),
				SqlDB.MakeInParam("@RegisterWay", SqlDbType.Int, 4, info.RegisterWay),
				SqlDB.MakeInParam("@RegisterOrigin", SqlDbType.VarChar, 500, info.RegisterOrigin),
				SqlDB.MakeInParam("@DldId", SqlDbType.Int, 4, info.DldId),
				SqlDB.MakeInParam("@UserCategory", SqlDbType.Int, 4, info.UserCategory),
				SqlDB.MakeInParam("@PositionCase", SqlDbType.VarChar, 500, info.PositionCase),
				SqlDB.MakeInParam("@RegisterTime", SqlDbType.DateTime, 8, info.RegisterTime),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
			};
            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.StoredProcedure, "Join_StudentAdd", prams).ToString(), -1);
        }

        /// <summary>
        /// 调用存储过程修改一个
        /// </summary>
        /// <param name="info">实体对象</param>
        /// <returns>更新成功返回ture，否则返回false</returns>
        public static bool Join_StudentEdit(Entity.Join_Student info)
        {
            SqlParameter[] prams = {
				SqlDB.MakeInParam("@StudentId", SqlDbType.Int, 4, info.StudentId),
				SqlDB.MakeInParam("@StudentBank", SqlDbType.VarChar, 20, info.StudentBank),
				SqlDB.MakeInParam("@StudentPass", SqlDbType.VarChar, 20, info.StudentPass),
				SqlDB.MakeInParam("@StudenName", SqlDbType.VarChar, 50, info.StudenName),
				SqlDB.MakeInParam("@CellTel", SqlDbType.VarChar, 50, info.CellTel),
				SqlDB.MakeInParam("@CellPhone", SqlDbType.VarChar, 50, info.CellPhone),
				SqlDB.MakeInParam("@Address", SqlDbType.VarChar, 100, info.Address),
				SqlDB.MakeInParam("@IdNumber", SqlDbType.VarChar, 18, info.IdNumber),
				SqlDB.MakeInParam("@BirthDate", SqlDbType.Char, 10, info.BirthDate),
				SqlDB.MakeInParam("@RegisterWay", SqlDbType.Int, 4, info.RegisterWay),
				SqlDB.MakeInParam("@RegisterOrigin", SqlDbType.VarChar, 500, info.RegisterOrigin),
				SqlDB.MakeInParam("@DldId", SqlDbType.Int, 4, info.DldId),
				SqlDB.MakeInParam("@UserCategory", SqlDbType.Int, 4, info.UserCategory),
				SqlDB.MakeInParam("@PositionCase", SqlDbType.VarChar, 500, info.PositionCase),
				SqlDB.MakeInParam("@RegisterTime", SqlDbType.DateTime, 8, info.RegisterTime),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				};
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.StoredProcedure, "Join_StudentEdit", prams);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 暂停该值
        /// </summary>
        /// <param name="StudentId">自增id的值</param>
        /// <returns>暂停成功返回ture，否则返回false</returns>
        public static bool Join_StudentPause(Entity.Join_Student info)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "UPDATE [Join_Student] SET IsPause = " + info.IsPause + "  WHERE StudentId =  " + info.StudentId);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 获取所有的的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_StudentList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT * FROM [Join_Student] WHERE " + strWhere + ";";
            else
                strSql = "SELECT * FROM [Join_Student] ;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }


        /// <summary>
        /// 获取某一个DataTable
        /// </summary>
        /// <param name="StudentId">标识</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_StudentGet(int StudentId)
        {
            return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Student] WHERE StudentId = " + StudentId + ";").Tables[0];
        }

        /// <summary>
        /// 获取某一个实体
        /// </summary>
        /// <param name="StudentId">标识</param>
        /// <returns>返回Entity</returns>
        public static Entity.Join_Student Join_StudentEntityGet(int StudentId)
        {
            Entity.Join_Student info = new Entity.Join_Student();
            DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [Join_Student] WHERE StudentId = " + StudentId + ";").Tables[0];
            if (dt != null && dt.Rows.Count > 0)
            {
                info.StudentId = Basic.Utils.StrToInt(dt.Rows[0]["StudentId"].ToString(), 0);
                info.StudentBank = dt.Rows[0]["StudentBank"].ToString();
                info.StudentPass = dt.Rows[0]["StudentPass"].ToString();
                info.StudenName = dt.Rows[0]["StudenName"].ToString();
                info.StudentName = dt.Rows[0]["StudentName"].ToString();
                info.Sex = Basic.Utils.StrToInt(dt.Rows[0]["Sex"].ToString(), 0);
                info.CellTel = dt.Rows[0]["CellTel"].ToString();
                info.CellPhone = dt.Rows[0]["CellPhone"].ToString();
                info.CellPhoneCheck = Basic.Utils.StrToInt(dt.Rows[0]["CellPhoneCheck"].ToString(), 0);
                info.Address = dt.Rows[0]["Address"].ToString();
                info.SchoolName = dt.Rows[0]["SchoolName"].ToString();
                info.IdNumber = dt.Rows[0]["IdNumber"].ToString();
                info.CheckIdNumber = Basic.Utils.StrToInt(dt.Rows[0]["CheckIdNumber"].ToString(), 0);
                info.IdNumberPic = dt.Rows[0]["IdNumberPic"].ToString();
                info.BirthDate = dt.Rows[0]["BirthDate"].ToString();
                info.RegisterWay = Basic.Utils.StrToInt(dt.Rows[0]["RegisterWay"].ToString(), 0);
                info.RegisterOrigin = dt.Rows[0]["RegisterOrigin"].ToString();
                info.DldId = Basic.Utils.StrToInt(dt.Rows[0]["DldId"].ToString(), 0);
                info.UserCategory = Basic.Utils.StrToInt(dt.Rows[0]["UserCategory"].ToString(), 0);
                info.PositionCase = dt.Rows[0]["PositionCase"].ToString();
                info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(), 0);
                info.Mail = dt.Rows[0]["Mail"].ToString();
                info.QQ = dt.Rows[0]["QQ"].ToString();
                info.About = dt.Rows[0]["About"].ToString();
                info.Company = dt.Rows[0]["Company"].ToString();
                info.MSN = dt.Rows[0]["MSN"].ToString();
                info.ArtDialog = Basic.Utils.StrToInt(dt.Rows[0]["ArtDialog"].ToString(), 0);
                info.FuQinPhone = dt.Rows[0]["FuQinPhone"].ToString();
                info.MuQinPhone = dt.Rows[0]["MuQinPhone"].ToString();
                info.WenLi = Basic.Utils.StrToInt(dt.Rows[0]["WenLi"].ToString(), 0);
                info.BanJi = dt.Rows[0]["BanJi"].ToString();
                info.BanZhuRen = dt.Rows[0]["BanZhuRen"].ToString();
                info.ProvinceId = Basic.Utils.StrToInt(dt.Rows[0]["ProvinceId"].ToString(), 0);
                info.CityId = Basic.Utils.StrToInt(dt.Rows[0]["CityId"].ToString(), 0);
                info.CountyId = Basic.Utils.StrToInt(dt.Rows[0]["CountyId"].ToString(), 0);
                info.IsAutoCreat = Basic.Utils.StrToInt(dt.Rows[0]["IsAutoCreat"].ToString(), 0);
                info.BanZhuRenMobile = dt.Rows[0]["BanZhuRenMobile"].ToString();
                info.StudentLevel = Basic.Utils.StrToInt(dt.Rows[0]["StudentLevel"].ToString(), 0);
                info.GKYear = Basic.Utils.StrToInt(dt.Rows[0]["GKYear"].ToString(), 0);

                info.RegisterTime = Basic.Utils.StrToDateTime(dt.Rows[0]["RegisterTime"].ToString());

                return info;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 删除一个值
        /// </summary>
        /// <param name="StudentId">自增id的值</param>
        /// <returns>删除成功返回ture，否则返回false</returns>
        public static bool Join_StudentDel(int StudentId)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [Join_Student]  WHERE StudentId =  " + StudentId);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 获取前多少的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <param name="TopNumber">数量</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_StudentTopGet(string strWhere, int TopNumber)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Student] WHERE " + strWhere + ";";
            else
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [Join_Student] ;";
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
        public static DataTable Join_StudentPageList(string strWhere, int PageSize, int PageIndex)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("SELECT * FROM Join_Student");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.Append(" WHERE " + strWhere);
            }
            sbSql.Append(" ORDER BY StudentId DESC");
            DataSet ds = new DataSet();
            ds = SqlDB.ExecuteDataset((PageIndex - 1) * PageSize, PageSize, CommandType.Text, sbSql.ToString());
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return new DataTable();
        }

        ///
        /// <summary>
        /// 获取前多少的值
        /// </summary>
        /// <param name="TopNumber">数量</param>
        /// <param name="PageSize">每页显示多少个</param>
        /// <param name="PageIndex">当前页码，最少为1</param>
        /// <returns>返回DataTable</returns>
        public static DataTable Join_StudentPageListNew(string strWhere, int PageSize, int PageIndex)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("SELECT s.*,d.DianName FROM Join_Student as s,Join_JiaMengDian as d where s.DldId = d.DianId");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.Append(" and " + strWhere);
            }
            sbSql.Append(" ORDER BY s.StudentId DESC");
            DataSet ds = new DataSet();
            ds = SqlDB.ExecuteDataset((PageIndex - 1) * PageSize, PageSize, CommandType.Text, sbSql.ToString());
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
        public static int Join_StudentCount(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT COUNT(*) FROM [Join_Student] WHERE " + strWhere + ";";
            else
                strSql = "SELECT COUNT(*)  FROM [Join_Student] ;";
            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
        }
        #endregion

    }
}

