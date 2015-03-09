using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_Ability_Major
	{
		#region Join_Ability_Major Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _majorid;
		public int MajorId
		{
			set { _majorid = value;}
			get { return _majorid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _majorname;
		public int MajorName
		{
			set { _majorname = value;}
			get { return _majorname;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _gradelist;
		public int GradeList
		{
			set { _gradelist = value;}
			get { return _gradelist;}
		}
		
		#endregion Join_Ability_Major Entity End
	}
}

