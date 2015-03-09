using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class MaterialDeliveryHistory
	{
		#region MaterialDeliveryHistory Entity Begin
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
		private int _materialstoragehistoryid;
		public int MaterialStorageHistoryId
		{
			set { _materialstoragehistoryid = value;}
			get { return _materialstoragehistoryid;}
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
		private int _deliverywid;
		public int DeliveryWid
		{
			set { _deliverywid = value;}
			get { return _deliverywid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _deliverytime;
		public DateTime DeliveryTime
		{
			set { _deliverytime = value;}
			get { return _deliverytime;}
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
		
		/// <summary>
		/// 
		/// </summary>
		private string _pici;
		public string PiCi
		{
			set { _pici = value;}
			get { return _pici;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _isextendedlog;
		public int IsExtendedLog
		{
			set { _isextendedlog = value;}
			get { return _isextendedlog;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _extendedlog_materialid;
		public int ExtendedLog_MaterialId
		{
			set { _extendedlog_materialid = value;}
			get { return _extendedlog_materialid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _isdel;
		public int IsDel
		{
			set { _isdel = value;}
			get { return _isdel;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _deltime;
		public DateTime DelTime
		{
			set { _deltime = value;}
			get { return _deltime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _deladdwid;
		public int DelAddWid
		{
			set { _deladdwid = value;}
			get { return _deladdwid;}
		}
		
		#endregion MaterialDeliveryHistory Entity End
	}
}

