using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class GL_DeliverGoods
	{
		#region GL_DeliverGoods Entity Begin
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
		private DateTime _delivergoodstime;
		public DateTime DeliverGoodsTime
		{
			set { _delivergoodstime = value;}
			get { return _delivergoodstime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _couriercompany;
		public string CourierCompany
		{
			set { _couriercompany = value;}
			get { return _couriercompany;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _billnumber;
		public string BillNumber
		{
			set { _billnumber = value;}
			get { return _billnumber;}
		}
		
		#endregion GL_DeliverGoods Entity End
	}
}

