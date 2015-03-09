using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ZX_PayHistory
	{
		#region ZX_PayHistory Entity Begin
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
		private int _ordersid;
		public int OrdersId
		{
			set { _ordersid = value;}
			get { return _ordersid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _receiveamount;
		public decimal ReceiveAmount
		{
			set { _receiveamount = value;}
			get { return _receiveamount;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _receivetime;
		public DateTime ReceiveTime
		{
			set { _receivetime = value;}
			get { return _receivetime;}
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
		
		#endregion ZX_PayHistory Entity End
	}
}

