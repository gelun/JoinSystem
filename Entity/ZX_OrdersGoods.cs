using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ZX_OrdersGoods
	{
		#region ZX_OrdersGoods Entity Begin
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
		private int _materialid;
		public int MaterialId
		{
			set { _materialid = value;}
			get { return _materialid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _number;
		public int Number
		{
			set { _number = value;}
			get { return _number;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _unitprice;
		public decimal UnitPrice
		{
			set { _unitprice = value;}
			get { return _unitprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _totalprice;
		public decimal TotalPrice
		{
			set { _totalprice = value;}
			get { return _totalprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _detail;
		public string Detail
		{
			set { _detail = value;}
			get { return _detail;}
		}
		
		#endregion ZX_OrdersGoods Entity End
	}
}

