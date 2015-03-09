using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class S_Province
	{
		#region S_Province Entity Begin
		/// <summary>
		/// 
		/// </summary>
        private int _provinceid;
        public int ProvinceID
		{
			set { _provinceid = value;}
			get { return _provinceid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _provincename;
		public string ProvinceName
		{
			set { _provincename = value;}
			get { return _provincename;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _datecreated;
		public DateTime DateCreated
		{
			set { _datecreated = value;}
			get { return _datecreated;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _dateupdated;
		public DateTime DateUpdated
		{
			set { _dateupdated = value;}
			get { return _dateupdated;}
		}
		
		#endregion S_Province Entity End
	}
}

