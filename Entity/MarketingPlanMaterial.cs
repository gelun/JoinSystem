using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class MarketingPlanMaterial
	{
		#region MarketingPlanMaterial Entity Begin
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
		private int _marketingplanid;
		public int MarketingPlanId
		{
			set { _marketingplanid = value;}
			get { return _marketingplanid;}
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
		private int _materialnumber;
		public int MaterialNumber
		{
			set { _materialnumber = value;}
			get { return _materialnumber;}
		}
		
		#endregion MarketingPlanMaterial Entity End
	}
}

