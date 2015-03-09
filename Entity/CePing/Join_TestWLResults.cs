using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_TestWLResults
	{
		#region Join_TestWLResults Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _wlid;
		public int WlId
		{
			set { _wlid = value;}
			get { return _wlid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _userid;
		public int UserId
		{
			set { _userid = value;}
			get { return _userid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _wk;
		public int WK
		{
			set { _wk = value;}
			get { return _wk;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _lk;
		public int LK
		{
			set { _lk = value;}
			get { return _lk;}
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
		
		#endregion Join_TestWLResults Entity End
	}
}

