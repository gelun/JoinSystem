using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

namespace Basic
{
    public class CreateMD5
    {
        /// <summary>
        ///方法一：计算字符串的Md5值。
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md5Encrypt(string str)
        {
            StringBuilder sb = new StringBuilder();

            //创建一个md5算法类。
            MD5 md5 = MD5.Create();

        
            //把字符串转换为字节流
            byte[] byts = System.Text.Encoding.UTF8.GetBytes(str);

            //加密后的byte数组
            byte[] md5Byts = md5.ComputeHash(byts);


            for (int i = 0; i < md5Byts.Length; i++)
            {
                sb.Append(md5Byts[i].ToString("x2"));
            }

            //释放资源
            md5.Clear();
            return sb.ToString();
        }



        /// <summary>
        /// 方法二：获取md5码
        /// </summary>
        /// <param name="source">待转换字符串</param>
        /// <returns>md5加密后的字符串</returns>
        public static string GetMD5(string source)
        {
            string result = "";
            try
            {
                MD5 getmd5 = new MD5CryptoServiceProvider();
                byte[] targetStr = getmd5.ComputeHash(UnicodeEncoding.UTF8.GetBytes(source));
                result = BitConverter.ToString(targetStr).Replace("-", "");
                return result;
            }
            catch (Exception)
            {
                return "0";
            }

        }

    }
}