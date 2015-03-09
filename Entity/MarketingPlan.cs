using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class MarketingPlan
	{
		#region MarketingPlan Entity Begin
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
		private int _dianid;
		public int DianId
		{
			set { _dianid = value;}
			get { return _dianid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _projectcategoryid;
		public int ProjectCategoryId
		{
			set { _projectcategoryid = value;}
			get { return _projectcategoryid;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _projectleader;
		public int ProjectLeader
		{
			set { _projectleader = value;}
			get { return _projectleader;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _address;
		public string Address
		{
			set { _address = value;}
			get { return _address;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _promotionway;
		public string PromotionWay
		{
			set { _promotionway = value;}
			get { return _promotionway;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _begindate;
		public DateTime BeginDate
		{
			set { _begindate = value;}
			get { return _begindate;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _enddate;
		public DateTime EndDate
		{
			set { _enddate = value;}
			get { return _enddate;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _expecteddays;
		public int ExpectedDays
		{
			set { _expecteddays = value;}
			get { return _expecteddays;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _expectedfulltimenumber;
		public int ExpectedFullTimeNumber
		{
			set { _expectedfulltimenumber = value;}
			get { return _expectedfulltimenumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _expectedparttimenumber;
		public int ExpectedPartTimeNumber
		{
			set { _expectedparttimenumber = value;}
			get { return _expectedparttimenumber;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _expectedparttimeprice;
		public decimal ExpectedPartTimePrice
		{
			set { _expectedparttimeprice = value;}
			get { return _expectedparttimeprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _expectedboothprice;
		public decimal ExpectedBoothPrice
		{
			set { _expectedboothprice = value;}
			get { return _expectedboothprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _expectedbudget;
		public decimal ExpectedBudget
		{
			set { _expectedbudget = value;}
			get { return _expectedbudget;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _expectedrenshu;
		public int ExpectedRenShu
		{
			set { _expectedrenshu = value;}
			get { return _expectedrenshu;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _parttimeprice;
		public decimal PartTimePrice
		{
			set { _parttimeprice = value;}
			get { return _parttimeprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _boothprice;
		public decimal BoothPrice
		{
			set { _boothprice = value;}
			get { return _boothprice;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private decimal _totledecimal;
		public decimal TotleMoney
		{
			set { _totledecimal = value;}
			get { return _totledecimal;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _shijirenshu;
		public int ShiJiRenShu
		{
			set { _shijirenshu = value;}
			get { return _shijirenshu;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _state;
		public int State
		{
			set { _state = value;}
			get { return _state;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _isfinish;
		public int IsFinish
		{
			set { _isfinish = value;}
			get { return _isfinish;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private DateTime _finishdate;
		public DateTime FinishDate
		{
			set { _finishdate = value;}
			get { return _finishdate;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private string _evaluation;
		public string Evaluation
		{
			set { _evaluation = value;}
			get { return _evaluation;}
		}
		
		/// <summary>
		/// 
		/// </summary>
		private int _evaluationlevel;
		public int EvaluationLevel
		{
			set { _evaluationlevel = value;}
			get { return _evaluationlevel;}
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
		
		#endregion MarketingPlan Entity End
	}
}

