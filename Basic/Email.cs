using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Basic
{
    public class Email
    {

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="to">接收方邮件地址</param>
        /// <param name="title">邮件标题</param>
        /// <param name="content">邮件正文内容</param>
        /// <returns></returns>
        /// <author>Jailu</author>
        /// <date>2007-04-10</date>
        public static bool sendMail(string to, string title, string content)
        {
            //判断邮箱地址是否为空
            if (!string.IsNullOrEmpty(to))
            {
                //判断邮箱格式是否正确
                string regex = "^([a-zA-Z0-9_\\.\\-])+\\@(([a-zA-Z0-9\\-])+\\.)+([a-zA-Z0-9]{2,4})+$";
                if (!Regex.IsMatch(to, regex))
                {
                    //Basic.MsgHelper.AlertBackMsg("您输入的邮箱的格式不正确！");
                    return false;
                }
                else
                {

                    //string strHost = "smtp.163.com";   //STMP服务器地址
                    //string strAccount = strAccount = "15810621454@163.com";       //SMTP服务帐号
                    //string strPwd = "tengxb!@#123";       //SMTP服务密码
                    //string strFrom = "15810621454@163.com";  //发送方邮件地址

                    string strHost = "smtp.exmail.qq.com";   //STMP服务器地址
                    string strAccount = "gelun@gelun.org";       //SMTP服务帐号
                    string strPwd = "glenedu8";       //SMTP服务密码
                    string strFrom = "gelun@gelun.org";  //发送方邮件地址

                    SmtpClient _smtpClient = new SmtpClient();
                    _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
                    _smtpClient.Host = strHost; ;//指定SMTP服务器
                    _smtpClient.Credentials = new System.Net.NetworkCredential(strAccount, strPwd);//用户名和密码

                    MailMessage _mailMessage = new MailMessage(strFrom, to);
                    _mailMessage.Subject = title;//主题
                    _mailMessage.Body = content;//内容
                    _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;//正文编码
                    _mailMessage.IsBodyHtml = true;//设置为HTML格式
                    _mailMessage.Priority = MailPriority.Normal;//优先级 High、Normal、Low

                    try
                    {
                        _smtpClient.Send(_mailMessage);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}