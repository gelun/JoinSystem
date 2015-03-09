using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Basic;
//using System.Web.UI.WebControls;

namespace DAL
{
    public class Comm
    {
        public static DataTable GetCeping(int userid)
        {

            string sqlstring = "";

            sqlstring = " select  AddTime,TestName='性格测试', url='http://ceping.glenedu.net/GLGKZYXZ/Rports/Rports.aspx'  from  Join_16PfResults  where UserId=  " + userid;

            sqlstring += " union all ";

            sqlstring += " select  AddTime,TestName='职业能力',url='http://ceping.glenedu.net/GLGKZYXZ/Rports/Rports.aspx'  from  Join_AbilityResults  where UserId=  " + userid;

            sqlstring += " union all ";

            sqlstring += "select  AddTime,TestName='职业兴趣',url='http://ceping.glenedu.net/GLGKZYXZ/Rports/Rports.aspx'  from  Join_HollandResults  where UserId=  " + userid;

            sqlstring += " union all ";

            sqlstring += " select  AddTime,TestName='职业价值观',url='http://ceping.glenedu.net/GLGKZYXZ/Rports/Rports.aspx'  from  Join_ProfessionResults  where  UserId=  " + userid;




            DataSet ds = Basic.SqlDB.ExecuteDataset(CommandType.Text, sqlstring);

            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }

            return null;
        }


        //检测激活
        public static bool JCJH(int userid)
        {

            DataTable dt = DAL.Join_Card.Join_CardList(" StudentId=" + userid + " and UseState=1 ");

            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            return false;

        }


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sqlString">sql语句</param>

        public static bool ExecuteSql(string sqlString)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, sqlString);
            if (intReturnValue == 1)
                return true;
            return false;
        }



        ///// <summary>
        ///// 获取树状分类DropDownList
        ///// </summary>
        ///// <param name="ddl">DropDownList控件</param>
        ///// <param name="pid">父编号</param>
        ///// <param name="dt">数据源</param>
        ///// <param name="depth">深度</param>
        ///// <param name="style">样式</param>
        ///// <returns></returns>
        //public static DropDownList TreeDropDownList(DropDownList ddl, int pid, DataTable dt, int depth, string style)
        //{
        //    string dephtNbj = "";

        //    for (int i = 0; i < depth; i++)
        //    {
        //        dephtNbj += "　";
        //    }

        //    depth++;

        //    DataRow[] drs = dt.Select("ParentId=" + pid);
        //    if (drs.Length > 0)
        //    {
        //        ListItem li;
        //        foreach (DataRow dr in drs)
        //        {
        //            li = new ListItem();
        //            if (depth != 1)
        //            {
        //                li.Text = dephtNbj + style + dr["CategoryName"].ToString();
        //            }
        //            else
        //            {
        //                li.Text = dephtNbj + dr["CategoryName"].ToString();
        //            }
        //            li.Value = dr["CategoryId"].ToString();
        //            ddl.Items.Add(li);
        //            TreeDropDownList(ddl, int.Parse(dr["CategoryId"].ToString()), dt, depth, style);
        //        }

        //    }

        //    return ddl;
        //}


        /// <summary>
        /// 冒泡排序，倒叙
        /// </summary>
        /// <param name="list"></param>
        public static void BubbleSortDow(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i; j < list.Length; j++)
                {
                    if (list[i] < list[j])
                    {

                        //如果发现比自己大的则交换数据
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }

            }
        }


        /// <summary>
        /// 冒泡排序，顺序
        /// </summary>
        /// <param name="list"></param>
        public static void BubbleSortUp(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {

                        //如果发现比自己大的则交换数据
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }

            }
        }

    }

}

