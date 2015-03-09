using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_ZhiYeMaoTest
	{
		#region Join_ZhiYeMaoTest Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _testid;
		public int TestId
		{
			set { _testid = value;}
			get { return _testid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _testnumber;
		public int TestNumber
		{
			set { _testnumber = value;}
			get { return _testnumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _testtitle;
		public string TestTitle
		{
			set { _testtitle = value;}
			get { return _testtitle;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _testtype;
		public int TestType
		{
			set { _testtype = value;}
			get { return _testtype;}
		}
		
		#endregion Join_ZhiYeMaoTest Entity End
	}
}

