using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class GaoKaoCard
	{
		#region GaoKaoCard Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _id;
		public int ID
		{
			set { _id = value;}
			get { return _id;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _kahao;
		public string KaHao
		{
			set { _kahao = value;}
			get { return _kahao;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _mima;
		public string MiMa
		{
			set { _mima = value;}
			get { return _mima;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _studentid;
		public int StudentId
		{
			set { _studentid = value;}
			get { return _studentid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _provinceid;
		public int ProvinceId
		{
			set { _provinceid = value;}
			get { return _provinceid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _belong;
		public int Belong
		{
			set { _belong = value;}
			get { return _belong;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _dianid;
		public int DianId
		{
			set { _dianid = value;}
			get { return _dianid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _cardlevel;
		public int CardLevel
		{
			set { _cardlevel = value;}
			get { return _cardlevel;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _ispause;
		public int IsPause
		{
			set { _ispause = value;}
			get { return _ispause;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _registerdate;
		public DateTime RegisterDate
		{
			set { _registerdate = value;}
			get { return _registerdate;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _allowchangecount;
		public int AllowChangeCount
		{
			set { _allowchangecount = value;}
			get { return _allowchangecount;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _havechangecount;
		public int HaveChangeCount
		{
			set { _havechangecount = value;}
			get { return _havechangecount;}
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
		private string _dingdanhao;
		public string DingDanHao
		{
			set { _dingdanhao = value;}
			get { return _dingdanhao;}
		}
		
		#endregion GaoKaoCard Entity End
	}
}

