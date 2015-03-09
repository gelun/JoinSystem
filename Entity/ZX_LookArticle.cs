using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ZX_LookArticle
	{
		#region ZX_LookArticle Entity Begin
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
		private int _articleid;
		public int ArticleId
		{
			set { _articleid = value;}
			get { return _articleid;}
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
		private int _istoboss;
		public int IsToBoss
		{
			set { _istoboss = value;}
			get { return _istoboss;}
		}
		
		#endregion ZX_LookArticle Entity End
	}
}

