using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
	public class Join_Student
    {
        #region Join_Student Entity Begin
        /// <summary>
        /// 
        /// </summary>
        private int _studentid;
        public int StudentId
        {
            set { _studentid = value; }
            get { return _studentid; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _studentbank;
        public string StudentBank
        {
            set { _studentbank = value; }
            get { return _studentbank; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _studentpass;
        public string StudentPass
        {
            set { _studentpass = value; }
            get { return _studentpass; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _studenname;
        public string StudenName
        {
            set { _studenname = value; }
            get { return _studenname; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _studentname;
        public string StudentName
        {
            set { _studentname = value; }
            get { return _studentname; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _sex;
        public int Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _celltel;
        public string CellTel
        {
            set { _celltel = value; }
            get { return _celltel; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _cellphone;
        public string CellPhone
        {
            set { _cellphone = value; }
            get { return _cellphone; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _cellphonecheck;
        public int CellPhoneCheck
        {
            set { _cellphonecheck = value; }
            get { return _cellphonecheck; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _address;
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _schoolname;
        public string SchoolName
        {
            set { _schoolname = value; }
            get { return _schoolname; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _idnumber;
        public string IdNumber
        {
            set { _idnumber = value; }
            get { return _idnumber; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _checkidnumber;
        public int CheckIdNumber
        {
            set { _checkidnumber = value; }
            get { return _checkidnumber; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _idnumberpic;
        public string IdNumberPic
        {
            set { _idnumberpic = value; }
            get { return _idnumberpic; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _birthdate;
        public string BirthDate
        {
            set { _birthdate = value; }
            get { return _birthdate; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _registerway;
        public int RegisterWay
        {
            set { _registerway = value; }
            get { return _registerway; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _registerorigin;
        public string RegisterOrigin
        {
            set { _registerorigin = value; }
            get { return _registerorigin; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _dldid;
        public int DldId
        {
            set { _dldid = value; }
            get { return _dldid; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _usercategory;
        public int UserCategory
        {
            set { _usercategory = value; }
            get { return _usercategory; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _positioncase;
        public string PositionCase
        {
            set { _positioncase = value; }
            get { return _positioncase; }
        }

        /// <summary>
        /// 
        /// </summary>
        private DateTime _registertime;
        public DateTime RegisterTime
        {
            set { _registertime = value; }
            get { return _registertime; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _ispause;
        public int IsPause
        {
            set { _ispause = value; }
            get { return _ispause; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _mail;
        public string Mail
        {
            set { _mail = value; }
            get { return _mail; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _qq;
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _about;
        public string About
        {
            set { _about = value; }
            get { return _about; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _company;
        public string Company
        {
            set { _company = value; }
            get { return _company; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _msn;
        public string MSN
        {
            set { _msn = value; }
            get { return _msn; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _artdialog;
        public int ArtDialog
        {
            set { _artdialog = value; }
            get { return _artdialog; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _fuqinphone;
        public string FuQinPhone
        {
            set { _fuqinphone = value; }
            get { return _fuqinphone; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _muqinphone;
        public string MuQinPhone
        {
            set { _muqinphone = value; }
            get { return _muqinphone; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _wenli;
        public int WenLi
        {
            set { _wenli = value; }
            get { return _wenli; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _banji;
        public string BanJi
        {
            set { _banji = value; }
            get { return _banji; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _banzhuren;
        public string BanZhuRen
        {
            set { _banzhuren = value; }
            get { return _banzhuren; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _provinceid;
        public int ProvinceId
        {
            set { _provinceid = value; }
            get { return _provinceid; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _cityid;
        public int CityId
        {
            set { _cityid = value; }
            get { return _cityid; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _countyid;
        public int CountyId
        {
            set { _countyid = value; }
            get { return _countyid; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _isautocreat;
        public int IsAutoCreat
        {
            set { _isautocreat = value; }
            get { return _isautocreat; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _banzhurenmobile;
        public string BanZhuRenMobile
        {
            set { _banzhurenmobile = value; }
            get { return _banzhurenmobile; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _studentlevel;
        public int StudentLevel
        {
            set { _studentlevel = value; }
            get { return _studentlevel; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int _gkyear;
        public int GKYear
        {
            set { _gkyear = value; }
            get { return _gkyear; }
        }

        #endregion Join_Student Entity End
	}
}

