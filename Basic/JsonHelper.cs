using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace Basic
{
    /// <summary>
    /// Json处理类
    /// </summary>
    public class JsonHelper
    {
        /// <summary>  
        /// 过滤特殊字符  
        /// </summary>  
        /// <param name="s"></param>  
        /// <returns></returns>  
        private static string String2Json(String s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s.ToCharArray()[i];
                switch (c)
                {
                    case '\"':
                        sb.Append("\\\""); break;
                    case '\\':
                        sb.Append("\\\\"); break;
                    case '/':
                        sb.Append("\\/"); break;
                    case '\b':
                        sb.Append("\\b"); break;
                    case '\f':
                        sb.Append("\\f"); break;
                    case '\n':
                        sb.Append("\\n"); break;
                    case '\r':
                        sb.Append("\\r"); break;
                    case '\t':
                        sb.Append("\\t"); break;
                    default:
                        sb.Append(c); break;
                }
            }
            return sb.ToString();
        }

        ///// <summary>  
        ///// 格式化字符型、日期型、布尔型  
        ///// </summary>  
        ///// <param name="str"></param>  
        ///// <param name="type"></param>  
        ///// <returns></returns>  
        //private static string StringFormat(string str, Type type)
        //{
        //    if (type == typeof(string))
        //    {
        //        str = String2Json(str);
        //        str = "\"" + str + "\"";
        //    }
        //    else if (type == typeof(DateTime))
        //    {
        //        str = "\"" + str + "\"";
        //    }
        //    else if (type == typeof(bool))
        //    {
        //        str = str.ToLower();
        //    }
        //    return str;
        //}

        
        /// <summary>
        /// 包含最外侧的图片,且默认的listName，含有{}
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="listName">生成Json串的名称</param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt, String listName)
        {
            return DataTable2Json(dt, listName, true);
        }

        /// <summary>
        /// 包含最外侧图片，包含最外面的{}
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt)
        {
            return DataTable2Json(dt, true);
        }

        /// <summary>
        /// 遍历DataTable的行和列生成Json
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Flag">true包含最外面的{}</param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt,Boolean Flag)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            if (Flag) jsonBuilder.Append("{");
            jsonBuilder.Append("\"");
            jsonBuilder.Append(dt.TableName);
            jsonBuilder.Append("\":[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(String2Json(dt.Rows[i][j].ToString()));
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            if (dt.Rows.Count > 0)
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");
            if (Flag) jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// 遍历DataTable行和列生成Json，可控制性较差
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="listName">生成Json串的名称</param>
        /// <param name="Flag">是否含有开始结尾的{}</param>
        /// <returns></returns>
        public static string DataTable2Json(DataTable dt, String listName, Boolean Flag)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            if (Flag) jsonBuilder.Append("{");
            jsonBuilder.Append("\"");
            jsonBuilder.Append(listName);
            jsonBuilder.Append("\":[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(String2Json(dt.Rows[i][j].ToString()));
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            if (dt.Rows.Count > 0)
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");
            if (Flag) jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// 遍历DataTable的行和列生成Json，可控制性较差
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="Flag">是否含有开始结尾的{}</param>
        /// <returns></returns>
        public static string DataTableFirstRow2Json(DataTable dt, Boolean Flag)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{");
             for (int j = 0; j < dt.Columns.Count; j++)
            {
                jsonBuilder.Append("\"");
                jsonBuilder.Append(dt.Columns[j].ColumnName);
                jsonBuilder.Append("\":\"");
                jsonBuilder.Append(String2Json(dt.Rows[0][j].ToString()));
                jsonBuilder.Append("\",");
            }
             if (dt.Rows.Count > 0)
                 jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
             jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// 遍历DataTable的行和列生成Json，控制数据列，专门为FlexiGrid提供便捷的数据源生成
        /// </summary>
        /// <param name="dt">DataTable对象</param>
        /// <param name="cols">Json中的数据列</param>
        /// <returns></returns>
        public static string Json4FlexiGrid(DataTable dt, string cols)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            string[] colarr = cols.Split(',');

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    jsonBuilder.Append("{");
                    jsonBuilder.Append("\"id\":");
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Rows[i]["ID"].ToString());
                    jsonBuilder.Append("\",\"cell\":[");
                    foreach (string col in colarr)
                    {
                        jsonBuilder.Append("\"");
                        jsonBuilder.Append(String2Json(dt.Rows[i][col].ToString()));
                        jsonBuilder.Append("\",");
                    }
                    jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                    jsonBuilder.Append("]},");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            }

            return jsonBuilder.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static string Dataset2Json(DataSet ds)
        {
            StringBuilder json = new StringBuilder();
            
            foreach (DataTable dt in ds.Tables)
            {
                json.Append("{\"");
                json.Append(dt.TableName);
                json.Append("\":");
                json.Append(DataTable2Json(dt));
                json.Append("}");
            }
            return json.ToString();
        }
    }
    
}
