using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class S_City
	{
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
        /// CityName
        /// </summary>		
        private string _cityname;
        public string CityName
        {
            get { return _cityname; }
            set { _cityname = value; }
        }
        /// <summary>
        /// ZipCode
        /// </summary>		
        private string _zipcode;
        public string ZipCode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }
        /// <summary>
        /// ProvinceID
        /// </summary>		
        private long _provinceid;
        public long ProvinceID
        {
            get { return _provinceid; }
            set { _provinceid = value; }
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

