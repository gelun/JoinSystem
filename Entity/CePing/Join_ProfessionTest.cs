using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_ProfessionTest
	{
		#region Join_ProfessionTest Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _professionid;
		public int ProfessionId
		{
			set { _professionid = value;}
			get { return _professionid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _professionnumber;
		public int ProfessionNumber
		{
			set { _professionnumber = value;}
			get { return _professionnumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _professiontitle;
		public string ProfessionTitle
		{
			set { _professiontitle = value;}
			get { return _professiontitle;}
		}
		
		#endregion Join_ProfessionTest Entity End
	}
}

