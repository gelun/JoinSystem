using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_AbilityTest
	{
		#region Join_AbilityTest Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _abilityid;
		public int AbilityId
		{
			set { _abilityid = value;}
			get { return _abilityid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _abilitynumber;
		public int AbilityNumber
		{
			set { _abilitynumber = value;}
			get { return _abilitynumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _abilitytitle;
		public string AbilityTitle
		{
			set { _abilitytitle = value;}
			get { return _abilitytitle;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _groupnumber;
		public int GroupNumber
		{
			set { _groupnumber = value;}
			get { return _groupnumber;}
		}
		
		#endregion Join_AbilityTest Entity End
	}
}

