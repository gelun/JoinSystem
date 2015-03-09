using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class MaterialStorageHistory
	{
		#region MaterialStorageHistory Entity Begin
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
		private int _materialinventoryid;
		public int MaterialInventoryId
		{
			set { _materialinventoryid = value;}
			get { return _materialinventoryid;}
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
		private decimal _price;
		public decimal Price
		{
			set { _price = value;}
			get { return _price;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _storagewid;
		public int StorageWid
		{
			set { _storagewid = value;}
			get { return _storagewid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _storagetime;
		public DateTime StorageTime
		{
			set { _storagetime = value;}
			get { return _storagetime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _surplusnumber;
		public int SurplusNumber
		{
			set { _surplusnumber = value;}
			get { return _surplusnumber;}
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
		
		#endregion MaterialStorageHistory Entity End
	}
}

