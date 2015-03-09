using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class ArticleType
	{
		#region ArticleType Entity Begin
		/// <summary>
		/// 
		/// </summary>
		private int _typeid;
		public int TypeId
		{
			set { _typeid = value;}
			get { return _typeid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _typename;
		public string TypeName
		{
			set { _typename = value;}
			get { return _typename;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _parentid;
		public int ParentId
		{
			set { _parentid = value;}
			get { return _parentid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _sort;
		public int Sort
		{
			set { _sort = value;}
			get { return _sort;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _ispublic;
		public int IsPublic
		{
			set { _ispublic = value;}
			get { return _ispublic;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _ispause;
		public int IsPause
		{
			set { _ispause = value;}
			get { return _ispause;}
		}
		
		#endregion ArticleType Entity End
	}
}

