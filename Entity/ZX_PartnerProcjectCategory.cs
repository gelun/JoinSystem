using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ZX_PartnerProcjectCategory
	{
		#region ZX_PartnerProcjectCategory Entity Begin
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
		private int _partnerid;
		public int PartnerId
		{
			set { _partnerid = value;}
			get { return _partnerid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _pcid;
		public int PCid
		{
			set { _pcid = value;}
			get { return _pcid;}
		}
		
		#endregion ZX_PartnerProcjectCategory Entity End
	}
}

