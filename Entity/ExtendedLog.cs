using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ExtendedLog
	{
		#region ExtendedLog Entity Begin
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
		private int _marketingplanid;
		public int MarketingPlanId
		{
			set { _marketingplanid = value;}
			get { return _marketingplanid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _extendeddate;
		public DateTime ExtendedDate
		{
			set { _extendeddate = value;}
			get { return _extendeddate;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _fulltimenumber;
		public int FullTimeNumber
		{
			set { _fulltimenumber = value;}
			get { return _fulltimenumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _parttimenumber;
		public int PartTimeNumber
		{
			set { _parttimenumber = value;}
			get { return _parttimenumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _parttimeprice;
		public decimal PartTimePrice
		{
			set { _parttimeprice = value;}
			get { return _parttimeprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _boothprice;
		public decimal BoothPrice
		{
			set { _boothprice = value;}
			get { return _boothprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _materialprice;
		public decimal MaterialPrice
		{
			set { _materialprice = value;}
			get { return _materialprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _shijirenshu;
		public int ShiJiRenShu
		{
			set { _shijirenshu = value;}
			get { return _shijirenshu;}
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
		
		#endregion ExtendedLog Entity End
	}
}

