using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Svg;
using System.Drawing.Imaging;

namespace DAL.CePing.WordDoc
{
    public static class HuiTu
    {

        //根据svg生成图片
        public static void svgHuiTu(string tSvg, string strImgPath, string strImg)
        {
            strImgPath = System.Web.HttpContext.Current.Server.MapPath(strImgPath);
            if (!Directory.Exists(strImgPath))
            {
                Directory.CreateDirectory(strImgPath);
            }

            MemoryStream tData = new MemoryStream(Encoding.UTF8.GetBytes(tSvg));
            MemoryStream tStream = new MemoryStream();
            string tTmp = new Random().Next().ToString();

            Svg.SvgDocument tSvgObj = SvgDocument.Open(tData);
            tSvgObj.Draw().Save(tStream, ImageFormat.Png);

            FileStream fls = new FileStream(strImgPath + strImg, FileMode.Create);//创建文件  
            tStream.WriteTo(fls);
            tStream.Close();
            fls.Close();
        }
    }
}
