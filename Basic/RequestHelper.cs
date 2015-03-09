using System;
using System.Web;

namespace Basic
{
	/// <summary>
	/// Request操作类
	/// </summary>
	public class RequestHelper
	{
		/// <summary>
		/// 判断当前页面是否接收到了Post请求
		/// </summary>
		/// <returns>是否接收到了Post请求</returns>
		public static bool IsPost()
		{
			return HttpContext.Current.Request.HttpMethod.Equals("POST");
		}

		/// <summary>
		/// 判断当前页面是否接收到了Get请求
		/// </summary>
		/// <returns>是否接收到了Get请求</returns>
		public static bool IsGet()
		{
			return HttpContext.Current.Request.HttpMethod.Equals("GET");
		}

		/// <summary>
		/// 返回指定的服务器变量信息
		/// </summary>
		/// <param name="strName">服务器变量名</param>
		/// <returns>服务器变量信息</returns>
		public static string GetServerString(string strName)
		{
			if (HttpContext.Current.Request.ServerVariables[strName] == null)
				return "";

            return HttpContext.Current.Request.ServerVariables[strName].ToString();
		}

		/// <summary>
		/// 返回上一个页面的地址
		/// </summary>
		/// <returns>上一个页面的地址</returns>
		public static string GetUrlReferrer()
		{
			string retVal = null;
    
			try
			{
				retVal = HttpContext.Current.Request.UrlReferrer.ToString();
			}
			catch{}
			
			if (retVal == null)
				return "";
    
			return retVal;
		}
		
		/// <summary>
		/// 得到当前完整主机头
		/// </summary>
		/// <returns></returns>
		public static string GetCurrentFullHost()
		{
			HttpRequest request = System.Web.HttpContext.Current.Request;
			if (!request.Url.IsDefaultPort)
				return string.Format("{0}:{1}", request.Url.Host, request.Url.Port.ToString());

            return request.Url.Host;
		}

		/// <summary>
		/// 得到主机头
		/// </summary>
		/// <returns></returns>
		public static string GetHost()
		{
			return HttpContext.Current.Request.Url.Host;
		}


		/// <summary>
		/// 获取当前请求的原始 URL(URL 中域信息之后的部分,包括查询字符串(如果存在))
		/// </summary>
		/// <returns>原始 URL</returns>
		public static string GetRawUrl()
		{
			return HttpContext.Current.Server.UrlPathEncode(HttpContext.Current.Request.RawUrl);
		}

		/// <summary>
		/// 判断当前访问是否来自浏览器软件
		/// </summary>
		/// <returns>当前访问是否来自浏览器软件</returns>
		public static bool IsBrowserGet()
		{
			string[] BrowserName = {"ie", "opera", "netscape", "mozilla", "konqueror", "firefox"};
			string curBrowser = HttpContext.Current.Request.Browser.Type.ToLower();
			for (int i = 0; i < BrowserName.Length; i++)
			{
				if (curBrowser.IndexOf(BrowserName[i]) >= 0)
					return true;
			}
			return false;
		}

		/// <summary>
		/// 判断是否来自搜索引擎链接
		/// </summary>
		/// <returns>是否来自搜索引擎链接</returns>
		public static bool IsSearchEnginesGet()
		{
            if (HttpContext.Current.Request.UrlReferrer == null)
                return false;

            string[] SearchEngine = {"google", "yahoo", "msn", "baidu", "sogou", "sohu", "sina", "163", "lycos", "tom", "yisou", "iask", "soso", "gougou", "zhongsou"};
			string tmpReferrer = HttpContext.Current.Request.UrlReferrer.ToString().ToLower();
			for (int i = 0; i < SearchEngine.Length; i++)
			{
				if (tmpReferrer.IndexOf(SearchEngine[i]) >= 0)
					return true;
			}
			return false;
		}

		/// <summary>
		/// 获得当前完整Url地址
		/// </summary>
		/// <returns>当前完整Url地址</returns>
		public static string GetUrl()
		{
			return HttpContext.Current.Request.Url.ToString();
		}

        /// <summary>
        /// 获得当前页面名称，“/default.aspx”
        /// </summary>
        /// <returns>当前完整Url地址的path</returns>
        public static string GetPath()
        {
            return HttpContext.Current.Request.Path;
        }

		/// <summary>
		/// 获得当前页面的名称
		/// </summary>
		/// <returns>当前页面的名称</returns>
		public static string GetPageName()
		{
			string [] urlArr = HttpContext.Current.Request.Url.AbsolutePath.Split('/');
			return urlArr[urlArr.Length - 1].ToLower();
		}

        /// <summary>
        /// 获得当前页面的服务器路径
        /// </summary>
        /// <returns>当前页面的名称</returns>
        public static string GetPagePath()
        {
            string AbsolutePath = HttpContext.Current.Request.Url.AbsolutePath;
            string[] urlArr = AbsolutePath.Split('/');

            return AbsolutePath.Substring(0, AbsolutePath.Length - urlArr[urlArr.Length - 1].Length);
        }
		/// <summary>
		/// 返回表单或Url参数的总个数
		/// </summary>
		/// <returns></returns>
		public static int GetParamCount()
		{
			return HttpContext.Current.Request.Form.Count + HttpContext.Current.Request.QueryString.Count;
		}

        #region 获取表单或URL参数值
        /// <summary>
        /// 获得指定Url参数的值
        /// </summary>
        /// <param name="strName">Url参数</param>
        /// <returns>Url参数的值</returns>
        public static string GetQueryString(string strName)
        {
            return GetQueryString(strName, false);
        }

        /// <summary>
        /// 获得指定Url参数的值
        /// </summary> 
        /// <param name="strName">Url参数</param>
        /// <param name="sqlSafeCheck">是否进行SQL安全检查</param>
        /// <returns>Url参数的值</returns>
        public static string GetQueryString(string strName, bool sqlSafeCheck)
        {
            if (HttpContext.Current.Request.QueryString[strName] == null)
                return "";

            if (sqlSafeCheck && !Utils.IsSafeSqlString(HttpContext.Current.Request.QueryString[strName]))
                return "unsafe string";

            return HttpContext.Current.Request.QueryString[strName];
        }

        /// <summary>
		/// 获得指定表单参数的值
		/// </summary>
		/// <param name="strName">表单参数</param>
		/// <returns>表单参数的值</returns>
		public static string GetFormString(string strName)
		{
			return GetFormString(strName, false);
		}

        /// <summary>
        /// 获得指定表单参数的值
        /// </summary>
        /// <param name="strName">表单参数</param>
        /// <param name="sqlSafeCheck">是否进行SQL安全检查</param>
        /// <returns>表单参数的值</returns>
        public static string GetFormString(string strName, bool sqlSafeCheck)
        {
            if (HttpContext.Current.Request.Form[strName] == null)
                return "";

            if (sqlSafeCheck && !Utils.IsSafeSqlString(HttpContext.Current.Request.Form[strName]))
                return "unsafe string";

            return HttpContext.Current.Request.Form[strName];
        }

		/// <summary>
		/// 获得Url或表单参数的值, 先判断Url参数是否为空字符串, 如为True则返回表单参数的值
		/// </summary>
		/// <param name="strName">参数</param>
		/// <returns>Url或表单参数的值</returns>
		public static string GetString(string strName)
		{
            return GetString(strName, false);
		}

        /// <summary>
        /// 获得Url或表单参数的值, 先判断Url参数是否为空字符串, 如为True则返回表单参数的值
        /// </summary>
        /// <param name="strName">参数</param>
        /// <param name="sqlSafeCheck">是否进行SQL安全检查</param>
        /// <returns>Url或表单参数的值</returns>
        public static string GetString(string strName, bool sqlSafeCheck)
        {
            if ("".Equals(GetQueryString(strName)))
                return GetFormString(strName, sqlSafeCheck);
            else
                return GetQueryString(strName, sqlSafeCheck);
        }

        /// <summary>
        /// 获得指定Url参数的int类型值
        /// </summary>
        /// <param name="strName">Url参数</param>
        /// <returns>Url参数的int类型值</returns>
        public static int GetQueryInt(string strName)
        {
            return Utils.StrToInt(HttpContext.Current.Request.QueryString[strName], 0);
        }


		/// <summary>
		/// 获得指定Url参数的int类型值
		/// </summary>
		/// <param name="strName">Url参数</param>
		/// <param name="defValue">缺省值</param>
		/// <returns>Url参数的int类型值</returns>
		public static int GetQueryInt(string strName, int defValue)
		{
			return Utils.StrToInt(HttpContext.Current.Request.QueryString[strName], defValue);
		}


		/// <summary>
		/// 获得指定表单参数的int类型值
		/// </summary>
		/// <param name="strName">表单参数</param>
		/// <param name="defValue">缺省值</param>
		/// <returns>表单参数的int类型值</returns>
		public static int GetFormInt(string strName, int defValue)
		{
			return Utils.StrToInt(HttpContext.Current.Request.Form[strName], defValue);
		}

        #region Decimal
        public static decimal GetQueryDecimal(string strName)
        {
            return Utils.StrToDecimal(HttpContext.Current.Request.QueryString[strName], 0m);
        }
        public static decimal GetQueryDecimal(string strName, decimal defValue)
        {
            return Utils.StrToDecimal(HttpContext.Current.Request.QueryString[strName], defValue);
        }
        public static decimal GetFormDecimal(string strName, decimal defValue)
        {
            return Utils.StrToDecimal(HttpContext.Current.Request.Form[strName], defValue);
        }
        #endregion

        /// <summary>
		/// 获得指定Url或表单参数的int类型值, 先判断Url参数是否为缺省值, 如为True则返回表单参数的值
		/// </summary>
		/// <param name="strName">Url或表单参数</param>
		/// <param name="defValue">缺省值</param>
		/// <returns>Url或表单参数的int类型值</returns>
		public static int GetInt(string strName, int defValue)
		{
			if (GetQueryInt(strName, defValue) == defValue)
				return GetFormInt(strName, defValue);
			else
				return GetQueryInt(strName, defValue);
		}

        #region float
        /// <summary>
		/// 获得指定Url参数的float类型值
		/// </summary>
		/// <param name="strName">Url参数</param>
		/// <param name="defValue">缺省值</param>
		/// <returns>Url参数的int类型值</returns>
		public static float GetQueryFloat(string strName, float defValue)
		{
			return Utils.StrToFloat(HttpContext.Current.Request.QueryString[strName], defValue);
		}


		/// <summary>
		/// 获得指定表单参数的float类型值
		/// </summary>
		/// <param name="strName">表单参数</param>
		/// <param name="defValue">缺省值</param>
		/// <returns>表单参数的float类型值</returns>
		public static float GetFormFloat(string strName, float defValue)
		{
			return Utils.StrToFloat(HttpContext.Current.Request.Form[strName], defValue);
		}
		
		/// <summary>
		/// 获得指定Url或表单参数的float类型值, 先判断Url参数是否为缺省值, 如为True则返回表单参数的值
		/// </summary>
		/// <param name="strName">Url或表单参数</param>
		/// <param name="defValue">缺省值</param>
		/// <returns>Url或表单参数的int类型值</returns>
		public static float GetFloat(string strName, float defValue)
		{
			if (GetQueryFloat(strName, defValue) == defValue)
				return GetFormFloat(strName, defValue);
			else
				return GetQueryFloat(strName, defValue);
		}
        #endregion

        /// <summary>
        /// 获得指定Url参数的值,默认1900年1月1日
        /// </summary>
        /// <param name="strName">Url参数</param>
        /// <returns>Url参数的值，或者1900年1月1日</returns>
        public static DateTime GetQueryDateTime(string strName)
        {
            return GetQueryDateTime(strName, Convert.ToDateTime("1900-1-1 00:00:01"));
        }

        /// <summary>
        /// 获取URL参数的时间
        /// </summary>
        /// <param name="strName">Url参数</param>
        /// <param name="datetime"></param>
        /// <returns>Url参数的值</returns>
        public static DateTime GetQueryDateTime(string strName, DateTime datetime)
        {
            if (HttpContext.Current.Request.QueryString[strName] == null)
            {
                return datetime;
            }
            string str = HttpContext.Current.Request.QueryString[strName];
            if (str == "")
                return datetime;
            else
                return Convert.ToDateTime(str);
        }

        /// <summary>
        /// 获得指定Form参数的值,默认1900年1月1日
        /// </summary>
        /// <param name="strName">Url参数</param>
        /// <returns>Url参数的值，或者1900年1月1日</returns>
        public static DateTime GetFormDateTime(string strName)
        {
            return GetFormDateTime(strName, Convert.ToDateTime("1900-1-1 00:00:01"));
        }

        /// <summary>
        /// 获取URL参数的时间
        /// </summary>
        /// <param name="strName">Url参数</param>
        /// <param name="datetime"></param>
        /// <returns>Url参数的值</returns>
        public static DateTime GetFormDateTime(string strName, DateTime datetime)
        {
            if (HttpContext.Current.Request.Form[strName] == null)
            {
                return datetime;
            }
            string str = HttpContext.Current.Request.Form[strName];
            if (str == "")
                return datetime;
            else
                return Convert.ToDateTime(str);
        }

        /// <summary>
        /// 页面多个一值的form取值,必须是int值
        /// </summary>
        /// <param name="strName"></param>
        /// <returns>空或者字符串最后又一个,</returns>
        public static string GetFormListInt(string strName)
        {
            if (HttpContext.Current.Request.Form[strName] == null)
                return "";

            string str = HttpContext.Current.Request.Form[strName];
            if (string.IsNullOrEmpty(str) || ! System.Text.RegularExpressions.Regex.IsMatch(str.Trim(), @"^[1-9]([,]|[0-9])*$"))
                return "";
            else
                return str+",";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cbl"></param>
        /// <returns>空字符串或者 数字中间用，分隔开</returns>
        public static string GetCheckBoxListValue(System.Web.UI.WebControls.CheckBoxList cbl)
        {
            //取得CheckBoxList选中项的值
            string returnValue = "";
            if (cbl != null)
            {
                foreach (System.Web.UI.WebControls.ListItem item in cbl.Items)
                {
                    if(item.Selected == true)
                    {
                        returnValue += "," + item.Value;
                    }
                }
            }
            if (!string.IsNullOrEmpty(returnValue))
                returnValue = returnValue.Substring(1);
            return returnValue;
        }
        #endregion

        

        /// <summary>
		/// 获得当前页面客户端的IP
		/// </summary>
		/// <returns>当前页面客户端的IP</returns>
		public static string GetIP()
		{
			string result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
			if (string.IsNullOrEmpty(result))
                result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

			if (string.IsNullOrEmpty(result))
				result = HttpContext.Current.Request.UserHostAddress;

			if (string.IsNullOrEmpty(result) || !Utils.IsIP(result))
				return "127.0.0.1";

			return result;
		}

		/// <summary>
		/// 保存用户上传的文件
		/// </summary>
		/// <param name="path">保存路径</param>
		public static void SaveRequestFile(string path)
		{
			if (HttpContext.Current.Request.Files.Count > 0)
			{
				HttpContext.Current.Request.Files[0].SaveAs(path);
			}
		}
	}
}
