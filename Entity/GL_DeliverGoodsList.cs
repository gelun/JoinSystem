using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class GL_DeliverGoodsList
	{
		#region GL_DeliverGoodsList Entity Begin
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
		private int _gl_delivergoodsid;
		public int GL_DeliverGoodsId
		{
			set { _gl_delivergoodsid = value;}
			get { return _gl_delivergoodsid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _materialid;
		public int MaterialId
		{
			set { _materialid = value;}
			get { return _materialid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _number;
		public int Number
		{
			set { _number = value;}
			get { return _number;}
		}
		
		#endregion GL_DeliverGoodsList Entity End
	}
}

