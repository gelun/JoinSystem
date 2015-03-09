using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class WorkerProcjectCategory
	{
		#region WorkerProcjectCategory Entity Begin
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
		private int _wid;
		public int Wid
		{
			set { _wid = value;}
			get { return _wid;}
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
		
		#endregion WorkerProcjectCategory Entity End
	}
}

