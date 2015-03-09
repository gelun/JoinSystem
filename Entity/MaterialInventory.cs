using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class MaterialInventory
	{
		#region MaterialInventory Entity Begin
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
		private int _typeid;
		public int TypeId
		{
			set { _typeid = value;}
			get { return _typeid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _projectcategoryid;
		public int ProjectCategoryId
		{
			set { _projectcategoryid = value;}
			get { return _projectcategoryid;}
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
		private string _name;
		public string Name
		{
			set { _name = value;}
			get { return _name;}
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
		private int _surplusnumber;
		public int SurplusNumber
		{
			set { _surplusnumber = value;}
			get { return _surplusnumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _totalstoragenumber;
		public int TotalStorageNumber
		{
			set { _totalstoragenumber = value;}
			get { return _totalstoragenumber;}
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
		
		#endregion MaterialInventory Entity End
	}
}

