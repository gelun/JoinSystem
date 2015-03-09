using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class S_District
	{
        /// <summary>
        /// DistrictID
        /// </summary>		
        private long _districtid;
        public long DistrictID
        {
            get { return _districtid; }
            set { _districtid = value; }
        }
        /// <summary>
        /// DistrictName
        /// </summary>		
        private string _districtname;
        public string DistrictName
        {
            get { return _districtname; }
            set { _districtname = value; }
        }
        /// <summary>
        /// CityID
        /// </summary>		
        private long _cityid;
        public long CityID
        {
            get { return _cityid; }
            set { _cityid = value; }
        }
        /// <summary>
        /// DateCreated
        /// </summary>		
        private DateTime _datecreated;
        public DateTime DateCreated
        {
            get { return _datecreated; }
            set { _datecreated = value; }
        }
        /// <summary>
        /// DateUpdated
        /// </summary>		
        private DateTime _dateupdated;
        public DateTime DateUpdated
        {
            get { return _dateupdated; }
            set { _dateupdated = value; }
        }        
		   
	}
}

