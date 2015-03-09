using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_Results
	{
		#region Join_Results Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _resultsid;
		public int ResultsId
		{
			set { _resultsid = value;}
			get { return _resultsid;}
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
		private int _resultscontent;
		public int ResultsContent
		{
			set { _resultscontent = value;}
			get { return _resultscontent;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _addtime;
		public int AddTime
		{
			set { _addtime = value;}
			get { return _addtime;}
		}
		
		#endregion Join_Results Entity End
	}
}

