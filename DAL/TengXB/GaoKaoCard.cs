using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Basic;
using System.Data.SqlClient;

namespace DAL.TengXB
{
    public class GaoKaoCard
    {
        //加盟店高考卡数量
        public static int JMD_GaoKaoCardCount(string strWhere)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select count(1) from [GaoKaoBaoKao].[dbo].GaoKaoCard as gkc , [Join].[dbo].Join_JiaMengDian as jmd ,[GaoKaoBaoKao].[dbo].Province as pro where gkc.Belong = 3 and gkc.DianId = jmd.DianId and gkc.ProvinceId = pro.ProvinceID");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.Append(" AND " + strWhere);
            }

            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, sbSql.ToString()).ToString(), 0);
        }

        //加盟店高考卡分页
        public static DataTable JMD_GaoKaoCardPageList(string strWhere, int PageSize, int PageIndex)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select gkc.* , pro.ProvinceName ,jmd.DianName from [GaoKaoBaoKao].[dbo].GaoKaoCard as gkc , [Join].[dbo].Join_JiaMengDian as jmd ,[GaoKaoBaoKao].[dbo].Province as pro where gkc.Belong = 3 and gkc.DianId = jmd.DianId and gkc.ProvinceId = pro.ProvinceID");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.Append(" AND " + strWhere);
            }
            sbSql.Append(" ORDER BY ID DESC");
            DataSet ds = new DataSet();
            ds = SqlDB.ExecuteDataset((PageIndex - 1) * PageSize, PageSize, CommandType.Text, sbSql.ToString());
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return new DataTable();
        }
        //
    }
}
