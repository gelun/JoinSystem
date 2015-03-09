using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Entity{
	 	//Join_ProjectCategory
		public class Join_ProjectCategory
	{
   		     
      	/// <summary>
		/// ProjectCategoryId
        /// </summary>		
		private int _projectcategoryid;
        public int ProjectCategoryId
        {
            get{ return _projectcategoryid; }
            set{ _projectcategoryid = value; }
        }        
		/// <summary>
		/// ProjectCategoryName
        /// </summary>		
		private string _projectcategoryname;
        public string ProjectCategoryName
        {
            get{ return _projectcategoryname; }
            set{ _projectcategoryname = value; }
        }        
		/// <summary>
		/// ParentPCid
        /// </summary>		
		private int _parentpcid;
        public int ParentPCid
        {
            get{ return _parentpcid; }
            set{ _parentpcid = value; }
        }        
		/// <summary>
		/// ParentPCPath
        /// </summary>		
		private string _parentpcpath;
        public string ParentPCPath
        {
            get{ return _parentpcpath; }
            set{ _parentpcpath = value; }
        }        
		/// <summary>
		/// PCDepth
        /// </summary>		
		private int _pcdepth;
        public int PCDepth
        {
            get{ return _pcdepth; }
            set{ _pcdepth = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _ishasson;
        public int IsHasSon
        {
            set { _ishasson = value; }
            get { return _ishasson; }
        }       
		/// <summary>
		/// Sort
        /// </summary>		
		private int _sort;
        public int Sort
        {
            get{ return _sort; }
            set{ _sort = value; }
        }        
		/// <summary>
		/// IsPause
        /// </summary>		
		private int _ispause;
        public int IsPause
        {
            get{ return _ispause; }
            set{ _ispause = value; }
        }        
		   
	}
}

