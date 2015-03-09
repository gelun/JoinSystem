using System;
using System.Web;

namespace Basic
{
	/// <summary>
	/// MsgClass 的摘要说明。
	/// </summary>
	public class MsgHelper
	{
		public static void AlertMsg(string Msg) 
		{
			AlertJsMsg(Msg,"",false);
		}
		public static void AlertBackMsg(string Msg) 
		{
			AlertJsMsg(Msg,"BACK",true);
		}
		public static void AlertCloseMsg(string Msg) 
		{
			AlertJsMsg(Msg,"CLOSE",true);
		}
		public static void AlertUrlMsg(string Msg,string URL) 
		{
			AlertJsMsg(Msg,URL,true);
		}

        public static void AlertToParentUrlMsg(string Msg,string URL) 
		{
            AlertJsMsgToParentUrl(Msg,URL);
		}
        public static void AlertToParentUrlMsg(string URL)
        {
            AlertJsMsgToParentUrl("", URL);
        }

        

		#region 实际调用的js弹出窗口
		/// <summary>
		/// 提示信息后，跳转到URL对应页，当URL为BACK时，页面将退到上一页，当URL为CLOSE时，则关闭窗口
		/// </summary>
		/// <param name="Msg">提示信息</param>
		/// <param name="URL">提示信息后要跳转的页面</param>
		/// <param name="allowBack">跳转后是否允许回到上一页</param>
        private static void AlertJsMsg(string Msg, string URL, bool allowBack)
        {
            HttpContext.Current.Response.Write("<Script Language=Javascript>alert('");
            HttpContext.Current.Response.Write(Msg);
            HttpContext.Current.Response.Write("');");

            switch (URL.ToUpper())
            {
                case "BACK":
                    HttpContext.Current.Response.Write("history.go(-1);");
                    break;
                case "CLOSE":
                    HttpContext.Current.Response.Write("window.close();");
                    break;
                default:
                    {
                        if (allowBack)
                        {
                            HttpContext.Current.Response.Write("location.href='");
                            HttpContext.Current.Response.Write(URL);
                            HttpContext.Current.Response.Write("';");
                        }
                        else
                        {
                            HttpContext.Current.Response.Write("location.replace('");
                            HttpContext.Current.Response.Write(URL);
                            HttpContext.Current.Response.Write("');");
                        }
                        break;
                    }
            }
            HttpContext.Current.Response.Write("</Script>");
            HttpContext.Current.Response.End();
        }
        
        private static void AlertJsMsgToParentUrl(string Msg,string URL) 
		{
            if (Msg == "")
                HttpContext.Current.Response.Write("<Script Language=Javascript>");
            else
            {
                HttpContext.Current.Response.Write("<Script Language=Javascript>alert('");
                HttpContext.Current.Response.Write(Msg);
                HttpContext.Current.Response.Write("');");
            }
            HttpContext.Current.Response.Write("parent.location.href='");
		    HttpContext.Current.Response.Write(URL);
		    HttpContext.Current.Response.Write("';");
			HttpContext.Current.Response.Write("</Script>");
			HttpContext.Current.Response.End();
		}
        
		#endregion
	}
}
