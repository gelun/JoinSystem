using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class CooperativePartner
	{
		#region CooperativePartner Entity Begin
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
		private int _partnertype;
		public int PartnerType
		{
			set { _partnertype = value;}
			get { return _partnertype;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _serialnumber;
		public string SerialNumber
		{
			set { _serialnumber = value;}
			get { return _serialnumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _partnername;
		public string PartnerName
		{
			set { _partnername = value;}
			get { return _partnername;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _shortname;
		public string ShortName
		{
			set { _shortname = value;}
			get { return _shortname;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _oldname;
		public string OldName
		{
			set { _oldname = value;}
			get { return _oldname;}
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
		private int _cityid;
		public int CityId
		{
			set { _cityid = value;}
			get { return _cityid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _distinctid;
		public int DistinctId
		{
			set { _distinctid = value;}
			get { return _distinctid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _address;
		public string Address
		{
			set { _address = value;}
			get { return _address;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _zipcode;
		public string ZipCode
		{
			set { _zipcode = value;}
			get { return _zipcode;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _telphone;
		public string TelPhone
		{
			set { _telphone = value;}
			get { return _telphone;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _state;
		public int State
		{
			set { _state = value;}
			get { return _state;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _openingdate;
		public DateTime OpeningDate
		{
			set { _openingdate = value;}
			get { return _openingdate;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _openingmemo;
		public string OpeningMemo
		{
			set { _openingmemo = value;}
			get { return _openingmemo;}
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
		private int _parentid;
		public int ParentId
		{
			set { _parentid = value;}
			get { return _parentid;}
		}
		
		#endregion CooperativePartner Entity End
	}
}

