using System;

namespace Basic
{
	/// <summary>
	/// Email配置信息类
	/// </summary>
	[Serializable]
    public class EmailConfigInfo
    {
        #region 私有字段

        private string smtp; //smtp 地址

		private int port = 25; //端口号

		private string sysemail;  //系统邮件地址

        private string showname;  //邮件帐号

		private string username;  //邮件帐号

		private string password;  //邮件密码

        #endregion

        public EmailConfigInfo()
		{
        }

        #region 属性

        /// <summary>
		/// smtp服务器
		/// </summary>
		public string Smtp
		{
			get { return smtp;}
			set { smtp = value;}
		}

		/// <summary>
		/// 端口号
		/// </summary>
		public int Port
		{
			get { return port;}
			set { port = value;}
		}
		

		/// <summary>
		/// 系统Email地址
		/// </summary>
		public string Sysemail
		{
			get { return sysemail;}
			set { sysemail = value;}
		}

        /// <summary>
        /// 邮件显示名称
        /// </summary>
        public string Showname
        {
            get { return showname; }
            set { showname = value; }
        }


		/// <summary>
		/// 用户名
		/// </summary>
		public string Username
		{
			get { return username;}
			set { username = value;}
		}

		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			get { return password;}
			set { password = value;}
		}

        #endregion


        //下面开始发送邮件，提示用户验证邮箱吧
        //Basic.Emails.SendSignalMail(Email, CName, "请激活你的转运中国注册账户", "Email 地址验证<br />" + CName + "， 这封信是由 转运中国 发送的。<br />你收到这封邮件，是因为在我们网站的新用户注册，或用户修改 Email 使用 了你的地址。如果你并没有访问过我们的网站，或没有进行上述操作，请忽 略这封邮件。你不需要退订或进行其他进一步的操作。<br /><br />----------------------------------------------------------------------<br />帐号激活说明<br />----------------------------------------------------------------------<br />你是我们论坛的新用户，或在修改你的注册 Email 时使用了本地址，我们需 要对你的地址有效性进行验证以避免垃圾邮件或地址被滥用。<br />你只需点击下面的链接即可激活你的帐号：<br /><a href=\"http://www.uszcn.com/VerifyEmail.aspx?code=" + VerifyCode + "\">http://www.uszcn.com/VerifyEmail.aspx?code=" + VerifyCode + "</a><br />(如果上面不是链接形式，请将地址手工粘贴到浏览器地址栏再访问)<br />感谢你的访问，祝你使用愉快！<br />此致<br />转运中国网站<br />http://www.uszcn.com/");

        //Response.Write("登陆成功,请登陆邮箱验证你的Email地址<a href=\"VerifyEmail.aspx?code=" + VerifyCode + "\">" + "VerifyEmail.aspx?code=" + VerifyCode + "</a>");
    }
}
