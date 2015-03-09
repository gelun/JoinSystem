using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using Basic;
using Entity;

namespace DAL
{
    public class GaoKaoCard
    {
        protected static string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["GaoKaoBaoKao_ConnectionString"].ToString();

        #region  GaoKaoCard
        /// <summary>
        /// 调用存储过程增加一个
        /// </summary>
        /// <param name="info">实体对象</param>
        /// <returns>正常返回大于 0 的自增id, 0代表重复，否则返回-1</returns>
        public static int GaoKaoCardAdd(Entity.GaoKaoCard info)
        {
            SqlParameter[] prams = {
				SqlDB.MakeInParam("@KaHao", SqlDbType.NVarChar, 50, info.KaHao),
				SqlDB.MakeInParam("@MiMa", SqlDbType.NVarChar, 50, info.MiMa),
				SqlDB.MakeInParam("@StudentId", SqlDbType.Int, 4, info.StudentId),
				SqlDB.MakeInParam("@ProvinceId", SqlDbType.Int, 4, info.ProvinceId),
				SqlDB.MakeInParam("@Belong", SqlDbType.Int, 4, info.Belong),
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@CardLevel", SqlDbType.Int, 4, info.CardLevel),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
			//	SqlDB.MakeInParam("@RegisterDate", SqlDbType.DateTime, 8, info.RegisterDate),
				SqlDB.MakeInParam("@AllowChangeCount", SqlDbType.Int, 4, info.AllowChangeCount),
				SqlDB.MakeInParam("@HaveChangeCount", SqlDbType.Int, 4, info.HaveChangeCount),
				SqlDB.MakeInParam("@EndTime", SqlDbType.DateTime, 8, info.EndTime),
				SqlDB.MakeInParam("@Memo", SqlDbType.NVarChar, 500, info.Memo),
				SqlDB.MakeInParam("@DingDanHao", SqlDbType.NVarChar, 100, info.DingDanHao),
			};
            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(strCon,CommandType.StoredProcedure, "GaoKaoCardAdd", prams).ToString(), -1);
        }

        /// <summary>
        /// 调用存储过程修改一个
        /// </summary>
        /// <param name="info">实体对象</param>
        /// <returns>更新成功返回ture，否则返回false</returns>
        public static bool GaoKaoCardEdit(Entity.GaoKaoCard info)
        {
            SqlParameter[] prams = {
				SqlDB.MakeInParam("@ID", SqlDbType.Int, 4, info.ID),
				SqlDB.MakeInParam("@KaHao", SqlDbType.NVarChar, 50, info.KaHao),
				SqlDB.MakeInParam("@MiMa", SqlDbType.NVarChar, 50, info.MiMa),
				SqlDB.MakeInParam("@StudentId", SqlDbType.Int, 4, info.StudentId),
				SqlDB.MakeInParam("@ProvinceId", SqlDbType.Int, 4, info.ProvinceId),
				SqlDB.MakeInParam("@Belong", SqlDbType.Int, 4, info.Belong),
				SqlDB.MakeInParam("@DianId", SqlDbType.Int, 4, info.DianId),
				SqlDB.MakeInParam("@CardLevel", SqlDbType.Int, 4, info.CardLevel),
				SqlDB.MakeInParam("@IsPause", SqlDbType.Int, 4, info.IsPause),
				SqlDB.MakeInParam("@RegisterDate", SqlDbType.DateTime, 8, info.RegisterDate),
				SqlDB.MakeInParam("@AllowChangeCount", SqlDbType.Int, 4, info.AllowChangeCount),
				SqlDB.MakeInParam("@HaveChangeCount", SqlDbType.Int, 4, info.HaveChangeCount),
				SqlDB.MakeInParam("@EndTime", SqlDbType.DateTime, 8, info.EndTime),
				SqlDB.MakeInParam("@Memo", SqlDbType.NVarChar, 500, info.Memo),
				SqlDB.MakeInParam("@DingDanHao", SqlDbType.NVarChar, 100, info.DingDanHao),
				};
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(strCon,CommandType.StoredProcedure, "GaoKaoCardEdit", prams);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 暂停该值
        /// </summary>
        /// <param name="ID">自增id的值</param>
        /// <returns>暂停成功返回ture，否则返回false</returns>
        public static bool GaoKaoCardPause(Entity.GaoKaoCard info)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(strCon,CommandType.Text, "UPDATE [GaoKaoCard] SET IsPause = " + info.IsPause + "  WHERE ID =  " + info.ID);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 获取所有的的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable GaoKaoCardList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT * FROM [GaoKaoCard] WHERE " + strWhere + ";";
            else
                strSql = "SELECT * FROM [GaoKaoCard] ;";
            return SqlDB.ExecuteDataset(strCon,CommandType.Text, strSql).Tables[0];
        }


        /// <summary>
        /// 获取某一个DataTable
        /// </summary>
        /// <param name="ID">标识</param>
        /// <returns>返回DataTable</returns>
        public static DataTable GaoKaoCardGet(int ID)
        {
            return SqlDB.ExecuteDataset(strCon,CommandType.Text, "SELECT * FROM [GaoKaoCard] WHERE ID = " + ID + ";").Tables[0];
        }

        /// <summary>
        /// 获取某一个实体
        /// </summary>
        /// <param name="ID">标识</param>
        /// <returns>返回Entity</returns>
        public static Entity.GaoKaoCard GaoKaoCardEntityGetByStudentId(int StudentId)
        {
            Entity.GaoKaoCard info = new Entity.GaoKaoCard();
            DataTable dt = SqlDB.ExecuteDataset(strCon,CommandType.Text, "SELECT * FROM [GaoKaoCard] WHERE StudentId = " + StudentId + " ORDER BY ID DESC").Tables[0];
            if (dt.Rows.Count > 0)
            {
                info.ID = Basic.Utils.StrToInt(dt.Rows[0]["ID"].ToString(), 0);
                info.KaHao = dt.Rows[0]["KaHao"].ToString();
                info.MiMa = dt.Rows[0]["MiMa"].ToString();
                info.StudentId = Basic.Utils.StrToInt(dt.Rows[0]["StudentId"].ToString(), 0);
                info.ProvinceId = Basic.Utils.StrToInt(dt.Rows[0]["ProvinceId"].ToString(), 0);
                info.Belong = Basic.Utils.StrToInt(dt.Rows[0]["Belong"].ToString(), 0);
                info.DianId = Basic.Utils.StrToInt(dt.Rows[0]["DianId"].ToString(), 0);
                info.CardLevel = Basic.Utils.StrToInt(dt.Rows[0]["CardLevel"].ToString(), 0);
                info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(), 0);
                info.AllowChangeCount = Basic.Utils.StrToInt(dt.Rows[0]["AllowChangeCount"].ToString(), 0);
                info.HaveChangeCount = Basic.Utils.StrToInt(dt.Rows[0]["HaveChangeCount"].ToString(), 0);
                info.Memo = dt.Rows[0]["Memo"].ToString();
                info.DingDanHao = dt.Rows[0]["DingDanHao"].ToString();
                info.EndTime = Basic.TypeConverter.StrToDateTime(dt.Rows[0]["EndTime"].ToString());
                info.RegisterDate = Basic.TypeConverter.StrToDateTime(dt.Rows[0]["RegisterDate"].ToString());
                return info;
            }
            else
                return null;
        }

        /// <summary>
        /// 删除一个值
        /// </summary>
        /// <param name="ID">自增id的值</param>
        /// <returns>删除成功返回ture，否则返回false</returns>
        public static bool GaoKaoCardDel(int ID)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(strCon,CommandType.Text, "DELETE [GaoKaoCard]  WHERE ID =  " + ID);
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
        public static DataTable GaoKaoCardTopGet(string strWhere, int TopNumber)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [GaoKaoCard] WHERE " + strWhere + ";";
            else
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [GaoKaoCard] ;";
            return SqlDB.ExecuteDataset(strCon,CommandType.Text, strSql).Tables[0];
        }

        ///
        /// <summary>
        /// 获取前多少的值
        /// </summary>
        /// <param name="TopNumber">数量</param>
        /// <param name="PageSize">每页显示多少个</param>
        /// <param name="PageIndex">当前页码，最少为1</param>
        /// <returns>返回DataTable</returns>
        public static DataTable GaoKaoCardPageList(string strWhere, int PageSize, int PageIndex)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("SELECT * FROM GaoKaoCard");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.Append(" WHERE " + strWhere);
            }
            sbSql.Append(" ORDER BY ID DESC");
            DataSet ds = new DataSet();
            ds = SqlDB.ExecuteDataset((PageIndex - 1) * PageSize, PageSize, strCon,CommandType.Text, sbSql.ToString());
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
        public static int GaoKaoCardCount(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT COUNT(*) FROM [GaoKaoCard] WHERE " + strWhere + ";";
            else
                strSql = "SELECT COUNT(*)  FROM [GaoKaoCard] ;";
            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(strCon,CommandType.Text, strSql).ToString(), 0);
        }
        #endregion



        public static bool SetGaoKaoCardStudentId(int intStudentId, string KaHao, int ProvinceId)
        {
            SqlParameter[] prams = {
				SqlDB.MakeInParam("@StudentId", SqlDbType.Int, 4, intStudentId),
				SqlDB.MakeInParam("@GaoKaoCardBank", SqlDbType.NVarChar, 200, KaHao),
				SqlDB.MakeInParam("@ProvinceId", SqlDbType.Int, 4, ProvinceId),
			};
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(strCon,CommandType.StoredProcedure, "SetGaoKaoCardStudentId", prams);
            if (intReturnValue >= 2)
                return true;
            return false;
        }


        public static bool GaoKaoCardHaveChangeCount(Entity.GaoKaoCard info)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(strCon,CommandType.Text, "UPDATE [GaoKaoCard] SET HaveChangeCount = " + info.HaveChangeCount + "  WHERE ID =  " + info.ID);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        public static Entity.GaoKaoCard GaoKaoCardEntityGetByKaHao(string strKaoHao, string strMiMa)
        {
            Entity.GaoKaoCard info = new Entity.GaoKaoCard();

            SqlParameter[] prams = {
				SqlDB.MakeInParam("@KaHao", SqlDbType.NVarChar, 500, strKaoHao),
				SqlDB.MakeInParam("@MiMa", SqlDbType.NVarChar, 50, strMiMa),
			};
            DataTable dt = SqlDB.ExecuteDataset(strCon,CommandType.StoredProcedure, "GaoKaoCardEntityGet", prams).Tables[0];

            //DataTable dt = SqlDB.ExecuteDataset(strCon,CommandType.Text, "SELECT * FROM [GaoKaoCard] WHERE KaHao = '" + strKaoHao + "' AND MiMa = '" + strMiMa + "'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                info.ID = Basic.Utils.StrToInt(dt.Rows[0]["ID"].ToString(), 0);
                info.KaHao = dt.Rows[0]["KaHao"].ToString();
                info.MiMa = dt.Rows[0]["MiMa"].ToString();
                info.StudentId = Basic.Utils.StrToInt(dt.Rows[0]["StudentId"].ToString(), 0);
                info.ProvinceId = Basic.Utils.StrToInt(dt.Rows[0]["ProvinceId"].ToString(), 0);
                info.Belong = Basic.Utils.StrToInt(dt.Rows[0]["Belong"].ToString(), 0);
                info.DianId = Basic.Utils.StrToInt(dt.Rows[0]["DianId"].ToString(), 0);
                info.CardLevel = Basic.Utils.StrToInt(dt.Rows[0]["CardLevel"].ToString(), 0);
                info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(), 0);
                info.AllowChangeCount = Basic.Utils.StrToInt(dt.Rows[0]["AllowChangeCount"].ToString(), 0);
                info.HaveChangeCount = Basic.Utils.StrToInt(dt.Rows[0]["HaveChangeCount"].ToString(), 0);
                info.Memo = dt.Rows[0]["Memo"].ToString();
                info.DingDanHao = dt.Rows[0]["DingDanHao"].ToString();

                info.EndTime = Basic.TypeConverter.StrToDateTime(dt.Rows[0]["EndTime"].ToString());
                info.RegisterDate = Basic.TypeConverter.StrToDateTime(dt.Rows[0]["RegisterDate"].ToString());

                return info;
            }
            else
                return null;
        }


        public static Entity.GaoKaoCard GaoKaoCardEntityGetByKaHao(string strKaoHao)
        {
            Entity.GaoKaoCard info = new Entity.GaoKaoCard();
            DataTable dt = SqlDB.ExecuteDataset(strCon,CommandType.Text, "SELECT * FROM [GaoKaoCard] WHERE KaHao = '" + strKaoHao + "'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                info.ID = Basic.Utils.StrToInt(dt.Rows[0]["ID"].ToString(), 0);
                info.KaHao = dt.Rows[0]["KaHao"].ToString();
                info.MiMa = dt.Rows[0]["MiMa"].ToString();
                info.StudentId = Basic.Utils.StrToInt(dt.Rows[0]["StudentId"].ToString(), 0);
                info.ProvinceId = Basic.Utils.StrToInt(dt.Rows[0]["ProvinceId"].ToString(), 0);
                info.Belong = Basic.Utils.StrToInt(dt.Rows[0]["Belong"].ToString(), 0);
                info.DianId = Basic.Utils.StrToInt(dt.Rows[0]["DianId"].ToString(), 0);
                info.CardLevel = Basic.Utils.StrToInt(dt.Rows[0]["CardLevel"].ToString(), 0);
                info.IsPause = Basic.Utils.StrToInt(dt.Rows[0]["IsPause"].ToString(), 0);
                info.AllowChangeCount = Basic.Utils.StrToInt(dt.Rows[0]["AllowChangeCount"].ToString(), 0);
                info.HaveChangeCount = Basic.Utils.StrToInt(dt.Rows[0]["HaveChangeCount"].ToString(), 0);
                info.Memo = dt.Rows[0]["Memo"].ToString();
                info.DingDanHao = dt.Rows[0]["DingDanHao"].ToString();

                info.EndTime = Basic.TypeConverter.StrToDateTime(dt.Rows[0]["DingDanHao"].ToString());
                info.RegisterDate = Basic.TypeConverter.StrToDateTime(dt.Rows[0]["RegisterDate"].ToString());

                return info;
            }
            else
                return null;
        }
    }
}

