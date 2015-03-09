using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using Basic.Generic;

namespace Basic
{
    /// <summary>
    /// Template为页面模板类.
    /// </summary>
    public abstract class PageNumber
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataNumberAll">所有要显示的数量</param>
        /// <param name="PageSize">页面显示数量</param>
        /// <param name="CurrentPageNumber">当前页码，不能为0</param>
        /// <param name="ArroundNumber">当前页吗，前面或后面显示的数量</param>
        /// <param name="PageUrl">替换的Url地址，必须是处理好的后面直接加数字就OK</param>
        /// <returns></returns>
        public static string CreatPageNumberThis(int DataNumberAll, int PageSize, int CurrentPageNumber, int ArroundNumber, string PageUrl)
        {
            if (DataNumberAll <= PageSize)
                return "";

            //肯定要大于1页了
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            int PageAll = GetPageAll(DataNumberAll, PageSize);
            CurrentPageNumber = GetCurrentPageNumber(CurrentPageNumber, PageAll);
            //如果当前页不是第一页
            if (CurrentPageNumber != 1)
            {
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber - 1);
                sb.Append("\">&laquo;</a>\n");
            }
            else
            {
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber - 1);
                sb.Append("\">&laquo;</a>\n");
            }

            //处理当前页码前的显示
            int tempBegin = CurrentPageNumber - ArroundNumber;
            if (tempBegin > 2)
            {
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append("1\">1</a>\n");
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append("\" class=\"Cese\">…</a>\n");
            }
            else
            {
                tempBegin = 1;
            }

            for (int i = tempBegin; i < CurrentPageNumber; i++)
            {
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append(i);
                sb.Append("\">");
                sb.Append(i);
                sb.Append("</a>\n");
            }

            //当前页吗
            sb.Append("<a href=\"");
            sb.Append(PageUrl);
            sb.Append(CurrentPageNumber);
            sb.Append("\" class=\"Cese\">");
            sb.Append(CurrentPageNumber);
            sb.Append("</a>\n");

            //处理当前页码后的显示
            int tempEnd = CurrentPageNumber + ArroundNumber;
            if (tempEnd > PageAll)
            {
                tempEnd = PageAll;
            }
            for (int i = CurrentPageNumber + 1; i <= tempEnd; i++)
            {
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append(i);
                sb.Append("\">");
                sb.Append(i);
                sb.Append("</a>\n");
            }

            if (tempEnd < PageAll)
            {
                sb.Append("<a href=\"#\" class=\"Cese\">…</a>\n");
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append(PageAll);
                sb.Append("\">");
                sb.Append(PageAll);
                sb.Append("</a>\n");
            }


            //如果当前页不是最后一页
            if (CurrentPageNumber != PageAll)
            {
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber + 1);
                sb.Append("\">&raquo;</a>\n");
            }
            else
            {
                sb.Append("<a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber + 1);
                sb.Append("\">&raquo;</a>\n");
            }
            sb.Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataNumberAll">所有要显示的数量</param>
        /// <param name="PageSize">页面显示数量</param>
        /// <param name="CurrentPageNumber">当前页码，不能为0</param>
        /// <param name="ArroundNumber">当前页吗，前面或后面显示的数量</param>
        /// <param name="PageUrl">替换的Url地址，必须是处理好的后面直接加数字就OK</param>
        /// <returns></returns>
        public static string CreatPageNumber(int DataNumberAll, int PageSize, int CurrentPageNumber, int ArroundNumber, string PageUrl)
        {
            if (DataNumberAll <= PageSize)
                return "";

            //<ul>
            //  
            //  <li class="active"><a href="#">1</a></li>
            //  <li><a href="#">2</a></li>
            //  <li><a href="#">3</a></li>
            //  <li><a href="#">4</a></li>
            //  <li><a href="#">Next</a></li>
            //</ul>

            //肯定要大于1页了
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul class=\"pagination\">\n");
            int PageAll = GetPageAll(DataNumberAll, PageSize);
            CurrentPageNumber = GetCurrentPageNumber(CurrentPageNumber, PageAll);
            //如果当前页不是第一页
            if (CurrentPageNumber != 1)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber - 1);
                sb.Append("\">&laquo;</a></li>\n");
            }
            else
            {
                sb.Append("<li class=\"disabled\"><a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber - 1);
                sb.Append("\">&laquo;</a></li>\n");
            }

            //处理当前页码前的显示
            int tempBegin = CurrentPageNumber - ArroundNumber;
            if (tempBegin > 2)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append("1\">1</a></li>\n");
                sb.Append("<li class=\"active\"><a href=\"");
                sb.Append(PageUrl);
                sb.Append("\">…</a></li>\n");
            }
            else
            {
                tempBegin = 1;
            }

            for (int i = tempBegin; i < CurrentPageNumber; i++)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(i);
                sb.Append("\">");
                sb.Append(i);
                sb.Append("</a></li>\n");
            }

            //当前页吗
            sb.Append("<li class=\"active\"><a href=\"");
            sb.Append(PageUrl);
            sb.Append(CurrentPageNumber);
            sb.Append("\">");
            sb.Append(CurrentPageNumber);
            sb.Append("</a></li>\n");

            //处理当前页码后的显示
            int tempEnd = CurrentPageNumber + ArroundNumber;
            if (tempEnd > PageAll)
            {
                tempEnd = PageAll;
            }
            for (int i = CurrentPageNumber + 1; i <= tempEnd; i++)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(i);
                sb.Append("\">");
                sb.Append(i);
                sb.Append("</a></li>\n");
            }

            if (tempEnd < PageAll)
            {
                sb.Append("<li class=\"active\"><a href=\"#\">…</a></li>\n");
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(PageAll);
                sb.Append("\">");
                sb.Append(PageAll);
                sb.Append("</a></li>\n");
            }


            //如果当前页不是最后一页
            if (CurrentPageNumber != PageAll)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber + 1);
                sb.Append("\">&raquo;</a><li>\n");
            }
            else
            {
                sb.Append("<li class=\"disabled\"><a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber + 1);
                sb.Append("\">&raquo;</a></li>\n");
            }
            sb.Append("</ul>\n");
            return sb.ToString();
        }

        public static string CreatPageNumberForHuaShu(int DataNumberAll, int PageSize, int CurrentPageNumber, int ArroundNumber, string PageUrl)
        {
            if (DataNumberAll <= PageSize)
                return "";
            //肯定要大于1页了
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul>\n");
            int PageAll = GetPageAll(DataNumberAll, PageSize);
            CurrentPageNumber = GetCurrentPageNumber(CurrentPageNumber, PageAll);
            //如果当前页不是第一页
            if (CurrentPageNumber != 1)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber - 1);
                sb.Append(")\">&laquo;</a></li>\n");
            }
            else
            {
                sb.Append("<li class=\"disabled\"><a href=\"");
                sb.Append(PageUrl);
                sb.Append(1);
                sb.Append(")\">&laquo;</a></li>\n");
            }

            //处理当前页码前的显示
            int tempBegin = CurrentPageNumber - ArroundNumber;
            if (tempBegin > 2)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append("1)\">1</a></li>\n");
                sb.Append("<li class=\"active\"><a href=\"");
                sb.Append(PageUrl);
                sb.Append(")\">…</a></li>\n");
            }
            else
            {
                tempBegin = 1;
            }

            for (int i = tempBegin; i < CurrentPageNumber; i++)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(i);
                sb.Append(")\">");
                sb.Append(i);
                sb.Append("</a></li>\n");
            }

            //当前页吗
            sb.Append("<li class=\"active\"><a href=\"");
            sb.Append(PageUrl);
            sb.Append(CurrentPageNumber);
            sb.Append(")\">");
            sb.Append(CurrentPageNumber);
            sb.Append("</a></li>\n");

            //处理当前页码后的显示
            int tempEnd = CurrentPageNumber + ArroundNumber;
            if (tempEnd > PageAll)
            {
                tempEnd = PageAll;
            }
            for (int i = CurrentPageNumber + 1; i <= tempEnd; i++)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(i);
                sb.Append(")\">");
                sb.Append(i);
                sb.Append("</a></li>\n");
            }

            if (tempEnd < PageAll)
            {
                sb.Append("<li class=\"active\"><a href=\"#\">…</a></li>\n");
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(PageAll);
                sb.Append(")\">");
                sb.Append(PageAll);
                sb.Append("</a></li>\n");
            }


            //如果当前页不是最后一页
            if (CurrentPageNumber != PageAll)
            {
                sb.Append("<li><a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber + 1);
                sb.Append(")\">&raquo;</a><li>\n");
            }
            else
            {
                sb.Append("<li class=\"disabled\"><a href=\"");
                sb.Append(PageUrl);
                sb.Append(CurrentPageNumber);
                sb.Append(")\">&raquo;</a></li>\n");
            }
            sb.Append("</ul>\n");
            return sb.ToString();
        }


        /// <summary>
        /// 根据数据数量，得到真实的页码
        /// </summary>
        /// <param name="DataNumberAll"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static int GetPageAll(int DataNumberAll, int PageSize)
        {
            int PageAll = 1;

            if ((DataNumberAll % PageSize) > 0)
            {
                PageAll = DataNumberAll / PageSize + 1;
            }
            else
            {
                PageAll = DataNumberAll / PageSize;
            }
            return PageAll;
        }

        /// <summary>
        /// 验证目前的页码，并设置为真正的页码
        /// </summary>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public static int GetCurrentPageNumber(int CurrentPageNumber, int PageAll)
        {
            if (CurrentPageNumber <= 1)
                return 1;
            else if (CurrentPageNumber > PageAll)
            {
                    return PageAll;
            }
            else
                return CurrentPageNumber;
        }
    }
}