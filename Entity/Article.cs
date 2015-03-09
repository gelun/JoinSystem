using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Article
	{
		#region Article Entity Begin
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
		private string _title;
		public string Title
		{
			set { _title = value;}
			get { return _title;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _content;
		public string Content
		{
			set { _content = value;}
			get { return _content;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _articletypeid;
		public int ArticleTypeId
		{
			set { _articletypeid = value;}
			get { return _articletypeid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _porjectcategoryid;
		public int PorjectCategoryId
		{
			set { _porjectcategoryid = value;}
			get { return _porjectcategoryid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _addwid;
		public int AddWid
		{
			set { _addwid = value;}
			get { return _addwid;}
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
		
		/// <summary>
		/// 
		/// </summary>
		private int _ischeck;
		public int IsCheck
		{
			set { _ischeck = value;}
			get { return _ischeck;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _checkwid;
		public int CheckWid
		{
			set { _checkwid = value;}
			get { return _checkwid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _checktime;
		public DateTime CheckTime
		{
			set { _checktime = value;}
			get { return _checktime;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _editwid;
		public int EditWid
		{
			set { _editwid = value;}
			get { return _editwid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _edittime;
		public DateTime EditTime
		{
			set { _edittime = value;}
			get { return _edittime;}
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
		
		/// <summary>
		/// 
		/// </summary>
		private int _iszhiding;
		public int IsZhiDing
		{
			set { _iszhiding = value;}
			get { return _iszhiding;}
		}
		
		#endregion Article Entity End
	}
}

