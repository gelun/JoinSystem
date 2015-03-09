using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Basic
{
    public class UpLoadFile
    {

        /// <summary>
        /// 通过控件FileUpload 上传文件
        /// </summary>
        /// <param name="FileUpload1">FileUpload控件的ID</param>
        /// <param name="strDirectorys">文件保存的完整路径，例如："/UploadFile/Files/hehe/"；注意，路径书写的时候，两边都要有斜杠 </param>
        /// <returns></returns>
        public static string upLoadFile(FileUpload FileUpload1, string strDirectorys)
        {
            string strFileName = "";
            if (FileUpload1.PostedFile.FileName != "")
            {
                HttpPostedFile jpeg_image_upload = HttpContext.Current.Request.Files["" + FileUpload1 + ""];
                string filepath = FileUpload1.PostedFile.FileName; //得到的是文件的完整路径,包括文件名，如：C:\Documents and Settings\Administrator\My Documents\My Pictures\20022775_m.jpg 
                int idx = filepath.LastIndexOf(".");
                string suffix = filepath.Substring(idx);//获得上传的图片的后缀名


                Random R = new Random();//创建产生随机数
                int val = 10 + R.Next(99);//产生随机数为99以内任意
                string sc = val.ToString();//产生随机数

                string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;//得到系统时间(格式化)并加上随机数以便生成上传图片名称

                //strIcon = "/uploadimages/" + FileTime + suffix;
                //FileUpload1.SaveAs(Server.MapPath("/" + strIcon));



                ////判断路径，
                ////获取 路径的深度，即几层文件夹            
                //string[] arr = strDirectorys.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                ////根据文件夹的个数进行循环判断，判断文件夹是否存在，如果不存在，创建文件夹
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    string strDirectory = "/";
                //    for (int j = 0; j <= i; j++)
                //    {
                //        strDirectory += arr[j] + "/";
                //    }
                //    Basic.Utils.IsExistDirectory(strDirectory);
                //}

                Basic.Utils.IsExistDirectory(strDirectorys);

                strFileName = strDirectorys + FileTime + suffix;//获取文件的名字
                FileUpload1.SaveAs(HttpContext.Current.Server.MapPath(strFileName));//文件保存到本地

                return strFileName;
            }
            else
            {
                return "";
            }
        }


        /// <summary>
        /// 通过控件FileUpload 上传文件
        /// </summary>
        /// <param name="FileUpload1">FileUpload控件的ID</param>
        /// <param name="fileorder">如果一个页面中上传了多个 FileUpload 文件，则，通过顺序，0,1,2，3 ...... 等等，来进行区别开来</param>
        /// <param name="strDirectorys">文件保存的完整路径，例如："/UploadFile/Files/hehe/"；注意，路径书写的时候，两边都要有斜杠 </param>
        /// <returns></returns>
        public static string upLoadFile(FileUpload FileUpload1, int intFileorder, string strDirectorys)
        {
            string strFileName = "";
            if (FileUpload1.PostedFile.FileName != "")
            {
                HttpPostedFile jpeg_image_upload = HttpContext.Current.Request.Files["" + FileUpload1 + ""];
                string filepath = FileUpload1.PostedFile.FileName; //得到的是文件的完整路径,包括文件名，如：C:\Documents and Settings\Administrator\My Documents\My Pictures\20022775_m.jpg 
                int idx = filepath.LastIndexOf(".");
                string suffix = filepath.Substring(idx);//获得上传的图片的后缀名


                Random R = new Random();//创建产生随机数
                int val = 10 + R.Next(99);//产生随机数为99以内任意
                string sc = val.ToString();//产生随机数

                string FileTime = DateTime.Now.ToString("yyyyMMddHHmmss") + sc;//得到系统时间(格式化)并加上随机数以便生成上传图片名称

                //strIcon = "/uploadimages/" + FileTime + suffix;
                //FileUpload1.SaveAs(Server.MapPath("/" + strIcon));



                ////判断路径，
                ////获取 路径的深度，即几层文件夹            
                //string[] arr = strDirectorys.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                ////根据文件夹的个数进行循环判断，判断文件夹是否存在，如果不存在，创建文件夹
                //for (int i = 0; i < arr.Length; i++)
                //{
                //    string strDirectory = "/";
                //    for (int j = 0; j <= i; j++)
                //    {
                //        strDirectory += arr[j] + "/";
                //    }
                //    Basic.Utils.IsExistDirectory(strDirectory);
                //}

                Basic.Utils.IsExistDirectory(strDirectorys);

                strFileName = strDirectorys + FileTime + intFileorder + suffix;//获取文件的名字
                FileUpload1.SaveAs(HttpContext.Current.Server.MapPath(strFileName));//文件保存到本地

                return strFileName;
            }
            else
            {
                return "";
            }
        }
    }
}