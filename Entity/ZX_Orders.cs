using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ZX_Orders
	{
		#region ZX_Orders Entity Begin
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
		private string _orderno;
		public string OrderNo
		{
			set { _orderno = value;}
			get { return _orderno;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _goodsnamelist;
		public string GoodsNameList
		{
			set { _goodsnamelist = value;}
			get { return _goodsnamelist;}
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
		private decimal _totalprice;
		public decimal TotalPrice
		{
			set { _totalprice = value;}
			get { return _totalprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _iscontainingtax;
		public int IsContainingTax
		{
			set { _iscontainingtax = value;}
			get { return _iscontainingtax;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _receivedamount;
		public decimal ReceivedAmount
		{
			set { _receivedamount = value;}
			get { return _receivedamount;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _orderstate;
		public int OrderState
		{
			set { _orderstate = value;}
			get { return _orderstate;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _ishasarrears;
		public int IsHasArrears
		{
			set { _ishasarrears = value;}
			get { return _ishasarrears;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _isconfirmorder;
		public int IsConfirmOrder
		{
			set { _isconfirmorder = value;}
			get { return _isconfirmorder;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _confirmorderwid;
		public int ConfirmOrderWid
		{
			set { _confirmorderwid = value;}
			get { return _confirmorderwid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _confirmordertime;
		public DateTime ConfirmOrderTime
		{
			set { _confirmordertime = value;}
			get { return _confirmordertime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _consignee;
		public string Consignee
		{
			set { _consignee = value;}
			get { return _consignee;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _consigneemobile;
		public string ConsigneeMobile
		{
			set { _consigneemobile = value;}
			get { return _consigneemobile;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _consigneezipcode;
		public string ConsigneeZipCode
		{
			set { _consigneezipcode = value;}
			get { return _consigneezipcode;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _consigneeaddress;
		public string ConsigneeAddress
		{
			set { _consigneeaddress = value;}
			get { return _consigneeaddress;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _isneedinvoice;
		public int IsNeedInvoice
		{
			set { _isneedinvoice = value;}
			get { return _isneedinvoice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _invoicetype;
		public int InvoiceType
		{
			set { _invoicetype = value;}
			get { return _invoicetype;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _invoicecontent;
		public string InvoiceContent
		{
			set { _invoicecontent = value;}
			get { return _invoicecontent;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _invoicetitle;
		public string InvoiceTitle
		{
			set { _invoicetitle = value;}
			get { return _invoicetitle;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _invoiceamount;
		public decimal InvoiceAmount
		{
			set { _invoiceamount = value;}
			get { return _invoiceamount;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _financialcontacts;
		public string FinancialContacts
		{
			set { _financialcontacts = value;}
			get { return _financialcontacts;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _financialcontactsmobile;
		public string FinancialContactsMobile
		{
			set { _financialcontactsmobile = value;}
			get { return _financialcontactsmobile;}
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
		
		#endregion ZX_Orders Entity End
	}
}

