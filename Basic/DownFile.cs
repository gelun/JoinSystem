using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Basic
{
    public class DownLoadFile
    {
        /// <summary>
        /// HttpContext.Current.Response.AddHeader实现下载
        /// </summary>
        /// <param name="strApplicant">在数据库中存储的路径，例如：'/UploadFile/XueLiJiNeng/ApplicantFile/2013071810323072.doc'</param>
        public static void DownFile(string strApplicant)
        {
            try
            {
                //方法一

                //提供下载的文件，不编码的话文件名会乱码
                string fileName = HttpContext.Current.Server.UrlEncode(strApplicant.Substring(strApplicant.LastIndexOf("/") + 1));//文件名
                string filePath = HttpContext.Current.Server.MapPath(strApplicant);//完整的文件路径

                FileInfo fileInfo = new FileInfo(filePath);
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ClearContent();
                HttpContext.Current.Response.ClearHeaders();
                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=" + HttpContext.Current.Server.UrlPathEncode(fileName));
                HttpContext.Current.Response.AddHeader("Content-Length", fileInfo.Length.ToString());
                // HttpContext.Current.Response.AddHeader("Content-Transfer-Encoding", "binary");
                HttpContext.Current.Response.ContentType = "application/octet-stream"; //文件生成后，直接弹出另存为窗口
                HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
                HttpContext.Current.Response.WriteFile(fileInfo.FullName);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();


                //方法二
                //System.IO.FileInfo fi = new System.IO.FileInfo(str);
                //System.Web.HttpContext.Current.Response.Clear();
                //System.Web.HttpContext.Current.Response.ClearHeaders();
                //System.Web.HttpContext.Current.Response.Buffer = false;
                //System.Web.HttpContext.Current.Response.ContentType = "application/octet-stream";
                //System.Web.HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(fi.FullName, System.Text.Encoding.UTF8));
                //System.Web.HttpContext.Current.Response.AppendHeader("Content-Length", fi.Length.ToString());
                //System.Web.HttpContext.Current.Response.WriteFile(fi.FullName);
                //System.Web.HttpContext.Current.Response.Flush();
                //System.Web.HttpContext.Current.Response.End();


                //方法三
                ////以字符流的形式下载文件 
                //FileStream fs = new FileStream(filePath, FileMode.Open);
                //byte[] bytes = new byte[(int)fs.Length];
                //fs.Read(bytes, 0, bytes.Length);
                //fs.Close();
                //HttpContext.Current.Response.ContentType = "application/octet-stream";

                ////通知浏览器下载文件而不是打开 
                //HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                //HttpContext.Current.Response.BinaryWrite(bytes);
                //HttpContext.Current.Response.Flush();
                //HttpContext.Current.Response.End();
            }
            catch (Exception e)
            {
                Basic.MsgHelper.AlertBackMsg(e.Message);
            }
        }


        /// <summary>
        /// HttpContext.Current.Response.AddHeader实现下载
        /// </summary>
        /// <param name="strApplicant">在数据库中存储的路径，例如：'/UploadFile/XueLiJiNeng/ApplicantFile/2013071810323072.doc'</param>
        public static void DownFileWord(string strApplicant)
        {
            try
            {
                string fileName = HttpContext.Current.Server.UrlEncode(strApplicant.Substring(strApplicant.LastIndexOf("/") + 1));//文件名
                string filePath = HttpContext.Current.Server.MapPath(strApplicant);//完整的文件路径

                FileInfo fileInfo = new FileInfo(filePath);
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ClearContent();
                HttpContext.Current.Response.ClearHeaders();
                HttpContext.Current.Response.Charset = "utf-8";
                HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;

                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=" + HttpContext.Current.Server.UrlPathEncode(fileName));
                HttpContext.Current.Response.AddHeader("Content-Length", fileInfo.Length.ToString());
                // HttpContext.Current.Response.AddHeader("Content-Transfer-Encoding", "binary");
                HttpContext.Current.Response.ContentType = "application/ms-word";
                HttpContext.Current.Response.WriteFile(fileInfo.FullName);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();
            }
            catch (Exception e)
            {
                Basic.MsgHelper.AlertBackMsg(e.Message);
            }
        }


        /// <summary>
        /// HttpContext.Current.Response.AddHeader实现下载
        /// </summary>
        /// <param name="strApplicant">在数据库中存储的路径，例如：'/UploadFile/XueLiJiNeng/ApplicantFile/2013071810323072.doc'</param>
        public static void DownFile3(string strApplicant)
        {
            try
            {
                //方法三
                //提供下载的文件，不编码的话文件名会乱码
                string fileName = HttpContext.Current.Server.UrlEncode(strApplicant.Substring(strApplicant.LastIndexOf("/") + 1));//文件名
                string filePath = HttpContext.Current.Server.MapPath(strApplicant);//完整的文件路径

                //以字符流的形式下载文件 
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                HttpContext.Current.Response.ContentType = "application/octet-stream";

                //通知浏览器下载文件而不是打开 
                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                HttpContext.Current.Response.BinaryWrite(bytes);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();
            }
            catch (Exception e)
            {
                Basic.MsgHelper.AlertBackMsg(e.Message);
            }
        }
    }
}