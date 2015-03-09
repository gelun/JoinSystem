using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_JiaMengDian
	{
		#region Join_JiaMengDian Entity Begin
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
		private string _dianname;
		public string DianName
		{
			set { _dianname = value;}
			get { return _dianname;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _parentdid;
		public int ParentDid
		{
			set { _parentdid = value;}
			get { return _parentdid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _topparentdid;
		public int TopParentDid
		{
			set { _topparentdid = value;}
			get { return _topparentdid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _parentdpath;
		public string ParentDPath
		{
			set { _parentdpath = value;}
			get { return _parentdpath;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _ddepth;
		public int DDepth
		{
			set { _ddepth = value;}
			get { return _ddepth;}
		}

        /// <summary>
        /// 
        /// </summary>
        private int _ishasson;
        public int IsHasSon
        {
            set { _ishasson = value; }
            get { return _ishasson; }
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
		private string _contacttel;
		public string ContactTel
		{
			set { _contacttel = value;}
			get { return _contacttel;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _contactphone;
		public string ContactPhone
		{
			set { _contactphone = value;}
			get { return _contactphone;}
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
		private int _districtid;
		public int DistrictId
		{
			set { _districtid = value;}
			get { return _districtid;}
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
		private DateTime _addtime;
		public DateTime AddTime
		{
			set { _addtime = value;}
			get { return _addtime;}
		}
		
		#endregion Join_JiaMengDian Entity End
	}
}

