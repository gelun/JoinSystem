using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using Encoder = System.Drawing.Imaging.Encoder;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;

namespace Basic
{

    public struct JsosG
    {
        public string msg { get; set; }
        public string msbox { get; set; }
    }
	/// <summary>
	/// Thumbnail 的摘要说明。
	/// </summary>
	public class Upload
    {
        #region 保存文件
        public static string SaveFile(string DestPath, string strExtension)
        {

            string filename = Path.GetFileName(HttpContext.Current.Request.Files[0].FileName);
            string fileextname = Path.GetExtension(filename);
            string filetype = HttpContext.Current.Request.Files[0].ContentType.ToLower();
            string newfilename;

            if (String.IsNullOrEmpty(strExtension))
                strExtension = fileextname;

            // 判断 文件扩展名/文件大小/文件类型 是否符合要求
            if (fileextname.ToLower().Equals(strExtension))
            {
                StringBuilder savedir = new StringBuilder();
                savedir.Append(DestPath);

                // 如果指定目录不存在则建立
                if (!Directory.Exists(GetMapPath(savedir.ToString())))
                {
                    CreateDir(GetMapPath(savedir.ToString()));
                }

                Random random = new Random();
                newfilename = DateTime.Now.ToString("yyyyMMddHHmmss") + random.Next(1000, 9999).ToString() + fileextname;

                string newfileurl = savedir.ToString() + newfilename;
                HttpContext.Current.Request.Files[0].SaveAs(GetMapPath(newfileurl));
                return newfilename;
            }
            return "";
        }
        
        /// <summary>
		/// 保存上传头像
		/// </summary>
		/// <param name="MaxAllowFileSize">最大允许的头像文件尺寸(单位:KB)</param>
		/// <returns>保存文件的相对路径</returns>
		public static string SaveRequestImageFile(string DestPath,int userid, int MaxAllowFileSize)
		{

			string filename = Path.GetFileName(HttpContext.Current.Request.Files[0].FileName);
			string fileextname = Path.GetExtension(filename);
			string filetype = HttpContext.Current.Request.Files[0].ContentType.ToLower();
            string newfilename;
			//int filesize = HttpContext.Current.Request.Files[0].ContentLength;
			// 判断 文件扩展名/文件大小/文件类型 是否符合要求
			if ((fileextname.ToLower().Equals(".jpg") || fileextname.ToLower().Equals(".gif") || fileextname.ToLower().Equals(".png")) && (filetype.StartsWith("image")))
			{
				StringBuilder savedir = new StringBuilder();
				savedir.Append(DestPath);

                savedir.Append(DateTime.Now.ToString("yyyy"));
				savedir.Append(Path.DirectorySeparatorChar);
				savedir.Append(DateTime.Now.ToString("MM"));
				savedir.Append(Path.DirectorySeparatorChar);
				savedir.Append(DateTime.Now.ToString("dd"));
				savedir.Append(Path.DirectorySeparatorChar);
			    
                // 如果指定目录不存在则建立
                if (!Directory.Exists(GetMapPath(savedir.ToString())))
				{
					CreateDir(GetMapPath(savedir.ToString()));
				}

                Random random = new Random();
                newfilename = savedir.ToString() + Environment.TickCount.ToString() +  random.Next(1000,9999).ToString() + "." + fileextname;

                if (System.IO.File.Exists(GetMapPath(newfilename)))
                    newfilename = savedir.ToString() + Environment.TickCount.ToString() + random.Next(1000, 9999).ToString() + "." + fileextname;
                //File.Delete(GetMapPath(savedir.ToString()) + userid.ToString() + ".jpg");
                //File.Delete(GetMapPath(savedir.ToString()) + userid.ToString() + ".gif");
                //File.Delete(GetMapPath(savedir.ToString()) + userid.ToString() + ".png");

                //int FileLength = fuFileUpload.FileBytes.Length;
                //double x;
                //x = FileLength / 1048576;
                //int EndLength = int.Parse(x.ToString());
                //if (EndLength > 30)
                //30M
                //if (HttpContext.Current.Request.Files[0].ContentLength <= MaxAllowFileSize)
                //{
					HttpContext.Current.Request.Files[0].SaveAs(GetMapPath(newfilename));
					return newfilename;
                //}
			}
			return "";
        }		
		
		/// <summary>
		/// 保存上传的文件
		/// </summary>
		/// <param name="forumid">版块id</param>
		/// <param name="MaxAllowFileCount">最大允许的上传文件个数</param>
		/// <param name="MaxSizePerDay">每天允许的附件大小总数</param>
		/// <param name="MaxFileSize">单个最大允许的文件字节数</param>/// 
		/// <param name="TodayUploadedSize">今天已经上传的附件字节总数</param>
		/// <param name="AllowFileType">允许的文件类型, 以string[]形式提供</param>
		/// <param name="config">附件保存方式 0=按年/月/日存入不同目录 1=按年/月/日/论坛存入不同目录 2=按论坛存入不同目录 3=按文件类型存入不同目录</param>
		/// <param name="watermarkstatus">图片水印位置</param>
		/// <param name="filekey">File控件的Key(即Name属性)</param>
		/// <returns>文件信息结构</returns>
        //public static AttachmentInfo[] SaveRequestFiles(int forumid, int MaxAllowFileCount, int MaxSizePerDay, int MaxFileSize, int TodayUploadedSize, string AllowFileType, int watermarkstatus, ConfigInfo config, string filekey)
        //{
        //    string[] tmp = Utils.SplitString(AllowFileType, "\r\n");
        //    string[] AllowFileExtName = new string[tmp.Length];
        //    int[] MaxSize = new int[tmp.Length];
			

        //    for (int i = 0; i < tmp.Length; i++)
        //    {
        //        AllowFileExtName[i] = Utils.CutString(tmp[i],0, tmp[i].LastIndexOf(","));
        //        MaxSize[i] = Utils.StrToInt(Utils.CutString(tmp[i], tmp[i].LastIndexOf(",") + 1), 0);
        //    }
				
        //    int saveFileCount = 0;
			
        //    int fCount = Math.Min(MaxAllowFileCount, HttpContext.Current.Request.Files.Count);

        //    for (int i = 0; i < fCount; i++)
        //    {
        //        if (!HttpContext.Current.Request.Files[i].FileName.Equals("") && HttpContext.Current.Request.Files.AllKeys[i].Equals(filekey))
        //        {
        //            saveFileCount++;
        //        }
        //    }

        //    AttachmentInfo[] attachmentinfo = new AttachmentInfo[saveFileCount];

        //    saveFileCount = 0;

        //    Random random = new Random(unchecked((int)DateTime.Now.Ticks)); 


        //    for (int i = 0; i < fCount; i++)
        //    {
        //        if (!HttpContext.Current.Request.Files[i].FileName.Equals("") && HttpContext.Current.Request.Files.AllKeys[i].Equals(filekey))
        //        {
        //            string filename = Path.GetFileName(HttpContext.Current.Request.Files[i].FileName);
        //            string fileextname = Utils.CutString(filename, filename.LastIndexOf(".") + 1).ToLower();
        //            string filetype = HttpContext.Current.Request.Files[i].ContentType.ToLower();
        //            int filesize = HttpContext.Current.Request.Files[i].ContentLength;
        //            string newfilename = "";
						
        //            attachmentinfo[saveFileCount] = new AttachmentInfo();

        //            attachmentinfo[saveFileCount].Sys_noupload = "";

        //            // 判断 文件扩展名/文件大小/文件类型 是否符合要求
        //            if (!(Utils.IsImgFilename(filename) && !filetype.StartsWith("image")))
        //            {
        //                int extnameid = Utils.GetInArrayID(fileextname, AllowFileExtName);

        //                if (extnameid >= 0 && (filesize <= MaxSize[extnameid]) && (MaxFileSize >= filesize /*|| MaxAllSize == 0*/) && (MaxSizePerDay - TodayUploadedSize >= filesize))
        //                {
        //                    TodayUploadedSize = TodayUploadedSize + filesize;
        //                    string UploadDir = Utils.GetMapPath(BaseConfigFactory.GetForumPath + "upload/");
        //                    StringBuilder savedir = new StringBuilder("");
        //                    //附件保存方式 0=按年/月/日存入不同目录 1=按年/月/日/论坛存入不同目录 2=按论坛存入不同目录 3=按文件类型存入不同目录
        //                    if (config.Attachsave == 1)
        //                    {
        //                        savedir.Append(DateTime.Now.ToString("yyyy"));
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                        savedir.Append(DateTime.Now.ToString("MM"));
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                        savedir.Append(DateTime.Now.ToString("dd"));
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                        savedir.Append(forumid.ToString());
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                    }	
        //                    else if (config.Attachsave == 2)
        //                    {
        //                        savedir.Append(forumid);
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                    }
        //                    else if (config.Attachsave == 3)
        //                    {
        //                        savedir.Append(fileextname);
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                    }
        //                    else
        //                    {
        //                        savedir.Append(DateTime.Now.ToString("yyyy"));
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                        savedir.Append(DateTime.Now.ToString("MM"));
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                        savedir.Append(DateTime.Now.ToString("dd"));
        //                        savedir.Append(Path.DirectorySeparatorChar);
        //                    }
        //                    // 如果指定目录不存在则建立
        //                    if (!Directory.Exists(UploadDir + savedir.ToString()))
        //                    {
        //                        Utils.CreateDir(UploadDir + savedir.ToString());
        //                    }
						
        //                    newfilename = savedir.ToString() + Environment.TickCount.ToString() +  i.ToString() + random.Next(1000,9999).ToString() + "." + fileextname;
						
						
        //                    try
        //                    {
        //                        // 如果是bmp jpg png图片类型
        //                        if ((fileextname == "bmp" || fileextname == "jpg" || fileextname == "jpeg" || fileextname == "png") && filetype.StartsWith("image"))
        //                        {
														
        //                            Image img = Image.FromStream(HttpContext.Current.Request.Files[i].InputStream);
        //                            if (config.Attachimgmaxwidth > 0 && img.Width > config.Attachimgmaxwidth)
        //                            {
        //                                attachmentinfo[saveFileCount].Sys_noupload = "图片宽度为" + img.Width.ToString() + ", 系统允许的最大宽度为" + config.Attachimgmaxwidth.ToString();
	
        //                            }
        //                            if (config.Attachimgmaxheight > 0 && img.Height > config.Attachimgmaxheight)
        //                            {
        //                                attachmentinfo[saveFileCount].Sys_noupload = "图片高度为" + img.Width.ToString() + ", 系统允许的最大高度为" + config.Attachimgmaxheight.ToString();
        //                            }									
        //                            if (attachmentinfo[saveFileCount].Sys_noupload == "")
        //                            {
        //                                if (watermarkstatus == 0)
        //                                {
        //                                    HttpContext.Current.Request.Files[i].SaveAs(UploadDir + newfilename);
        //                                    attachmentinfo[saveFileCount].Filesize = filesize;
        //                                }
        //                                else
        //                                {
        //                                    if (config.Watermarktype == 1 && File.Exists(Utils.GetMapPath(BaseConfigFactory.GetForumPath + "watermark/" + config.Watermarkpic)))
        //                                    {
        //                                        AddImageSignPic(img, UploadDir + newfilename, Utils.GetMapPath(BaseConfigFactory.GetForumPath + "watermark/" + config.Watermarkpic), config.Watermarkstatus, config.Attachimgquality, config.Watermarktransparency);
        //                                    }
        //                                    else
        //                                    {
        //                                        string watermarkText;
        //                                        watermarkText = config.Watermarktext.Replace("{1}", config.Forumtitle);
        //                                        watermarkText = watermarkText.Replace("{2}", config.Forumurl);
        //                                        watermarkText = watermarkText.Replace("{3}", Utils.GetDate());
        //                                        watermarkText = watermarkText.Replace("{4}", Utils.GetTime());
        //                                        AddImageSignText(img, UploadDir + newfilename, watermarkText, config.Watermarkstatus, config.Attachimgquality, config.Watermarkfontname, config.Watermarkfontsize);
        //                                    }
        //                                    // 获得加水印后的文件长度
        //                                    attachmentinfo[saveFileCount].Filesize = new FileInfo(UploadDir + newfilename).Length;
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            HttpContext.Current.Request.Files[i].SaveAs(UploadDir + newfilename);
        //                            attachmentinfo[saveFileCount].Filesize = filesize;
        //                        }
        //                    }
        //                    catch
        //                    {
        //                        if (!(Utils.FileExists(UploadDir + newfilename)))
        //                        {
        //                            HttpContext.Current.Request.Files[i].SaveAs(UploadDir + newfilename);
        //                            attachmentinfo[saveFileCount].Filesize = filesize;
        //                        }
        //                    }
						
        //                }
        //                else
        //                {
        //                    if (extnameid < 0)
        //                    {
        //                        attachmentinfo[saveFileCount].Sys_noupload = "文件格式无效";
        //                    }
        //                    else if (MaxSizePerDay - TodayUploadedSize < filesize)
        //                    {
        //                        attachmentinfo[saveFileCount].Sys_noupload = "文件大于今天允许上传的字节数";
        //                    }
        //                    else if (filesize > MaxSize[extnameid])
        //                    {
        //                        attachmentinfo[saveFileCount].Sys_noupload = "文件大于该类型附件允许的字节数";
        //                    }
        //                    else
        //                    {
        //                        attachmentinfo[saveFileCount].Sys_noupload = "文件大于单个文件允许上传的字节数";
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                attachmentinfo[saveFileCount].Sys_noupload = "文件格式无效";
        //            }
        //            attachmentinfo[saveFileCount].Filename = newfilename;
        //            attachmentinfo[saveFileCount].Description = fileextname;
        //            attachmentinfo[saveFileCount].Filetype = filetype;
        //            attachmentinfo[saveFileCount].Attachment = filename;
        //            attachmentinfo[saveFileCount].Downloads = 0;
        //            attachmentinfo[saveFileCount].Postdatetime = DateTime.Now.ToString();
        //            attachmentinfo[saveFileCount].Sys_index = i;
        //            saveFileCount++;
        //        }
        //    }
        //    return attachmentinfo;

        //}
        #endregion


        /// <summary>
        /// 判断是否有上传的文件
        /// </summary>
        /// <returns>是否有上传的文件</returns>
        public static bool IsPostFile()
        {
            for (int i = 0; i < HttpContext.Current.Request.Files.Count; i++)
            {
                if (HttpContext.Current.Request.Files[i].FileName != "")
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 获得当前绝对路径
        /// </summary>
        /// <param name="strPath">指定的路径</param>
        /// <returns>绝对路径</returns>
        private static string GetMapPath(string strPath)
        {
            if (HttpContext.Current != null)
            {
                return HttpContext.Current.Server.MapPath(strPath);
            }
            else //非web程序引用
            {
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, strPath);
            }
        }

        private static bool CreateDir(string name)
        {
            return MakeSureDirectoryPathExists(name);
        }

        [DllImport("dbgHelp", SetLastError = true)]
        private static extern bool MakeSureDirectoryPathExists(string name);



	}





    public class UpLoading
    {
      
         string basePath="/UpFile/";
      

        public UpLoading(string  file)
        {
           basePath=file;
        }

        #region  上传图片

        /// <summary>
        /// 上传图片：http图片文件，写水印，写缩略图，写小图
        /// </summary>
        /// <param name="_postedFile">http图片文件</param>
        /// <returns></returns>
        public string ImagUploading(HttpPostedFile _postedFile)
        {
            //判断是否正常，否则返回错误信息
             JavaScriptSerializer js = new JavaScriptSerializer();

            try
            {


                String serverFileName = "";//大图路径

                string _fileExt = _postedFile.FileName.Substring(_postedFile.FileName.LastIndexOf(".") + 1);  //获取文件格式


              

                #region  检测图片是否合格

                //检测图片是否符合要求
                string dfileJson = DetectionFiel(_fileExt);
                JsosG aa = js.Deserialize<JsosG>(dfileJson); //检测图片是否符合要求
                if (aa.msg != "0") return dfileJson;//返回错误信息


                #endregion


                #region  创建文件夹，文件保存路径
                string _fileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + "." + _fileExt; //创建随机文件名


                //检查系统设置的保存的路径 是否有/开头结尾
                if (this.basePath.StartsWith("/") == false) this.basePath = "/" + this.basePath;
                if (this.basePath.EndsWith("/") == false) this.basePath = this.basePath + "/";


                //按日期归类保存：公用
                string _datePath =basePath+DateTime.Now.ToString("yyyyMMdd")  + "/";

      

                //创建文件夹
                if (!Directory.Exists(HttpContext.Current.Server.MapPath(_datePath)))  //保存的文件夹
                {
                    Directory.CreateDirectory(HttpContext.Current.Server.MapPath(_datePath));
                }

                //创建保存到数据库的路径
                serverFileName = _datePath + _fileName;

                #endregion        

          
                //保存文件
                 _postedFile.SaveAs(HttpContext.Current.Server.MapPath(_datePath) + _fileName);
                     
                #endregion 


                return "{\"msg\":\"1\", \"msbox\": \"" + serverFileName + "\"}";
            }
            catch(Exception ex)
            {
                return "{\"msg\":\"0\", \"msbox\": \"上传过程中发生意外错误！\"}";
            }
        }

       



        #region   检验文件格式 大小要求

        /// <summary>
        /// 通过文件扩展名和文件及是否为图片检测是否符合类型
        /// </summary>
        /// <param name="_fileExt">扩展名不包含点</param>
        /// <param name="_postedFile">文件</param>
        /// <param name="isImage">是否为图片</param>
        /// <returns></returns>
        private string DetectionFiel(string _fileExt)
        {
          
                if (!CheckFileExt("BMP|JPEG|JPG|GIF|PNG|TIFF", _fileExt))
                {
                    return "{msg: 1, msbox: \"不允许上传" + _fileExt + "类型的文件！\"}";
                }
                return "{msg: 0, msbox: \"文件可以上传\"}";
        }

        #endregion

        #region  对比文件格式
        /// <summary>
        /// 检查是否为合法的上传文件
        /// </summary>
        /// <returns></returns>
        private bool CheckFileExt(string _fileType, string _fileExt)
        {
            string[] allowExt = _fileType.Split('|');
            for (int i = 0; i < allowExt.Length; i++)
            {
                if (allowExt[i].ToLower() == _fileExt.ToLower()) { return true; }
            }
            return false;
        }

        #endregion 
    }
}


