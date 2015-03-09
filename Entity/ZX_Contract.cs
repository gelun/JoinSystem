using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ZX_Contract
	{
		#region ZX_Contract Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _id;
		public int Id
		{
			set { _id = value;}
			get { return _id;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _partnerid;
		public int PartnerId
		{
			set { _partnerid = value;}
			get { return _partnerid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _contractno;
		public string ContractNO
		{
			set { _contractno = value;}
			get { return _contractno;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _signingtime;
		public DateTime SigningTime
		{
			set { _signingtime = value;}
			get { return _signingtime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _begintime;
		public DateTime BeginTime
		{
			set { _begintime = value;}
			get { return _begintime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _endtime;
		public DateTime EndTime
		{
			set { _endtime = value;}
			get { return _endtime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _memo;
		public string Memo
		{
			set { _memo = value;}
			get { return _memo;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _addwid;
		public int AddWid
		{
			set { _addwid = value;}
			get { return _addwid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _addtime;
		public DateTime AddTime
		{
			set { _addtime = value;}
			get { return _addtime;}
		}
		
		#endregion ZX_Contract Entity End
	}
}

