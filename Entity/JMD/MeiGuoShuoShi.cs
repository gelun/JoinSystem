using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class MeiGuoShuoShi
    {
        #region MeiGuoShuoShi Entity Begin
        /// <summary>
        /// 
        /// </summary>
        private int _id;
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _num;
        public string Num
        {
            set { _num = value; }
            get { return _num; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _schoolchinesename;
        public string SchoolChineseName
        {
            set { _schoolchinesename = value; }
            get { return _schoolchinesename; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _zongherandings;
        public float ZongHeRandings
        {
            set { _zongherandings = value; }
            get { return _zongherandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _alexa;
        public float Alexa
        {
            set { _alexa = value; }
            get { return _alexa; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _concern;
        public string Concern
        {
            set { _concern = value; }
            get { return _concern; }
        }

        /// <summary>
        /// 
        /// </summary>
        private DateTime _deadlines;
        public DateTime Deadlines
        {
            set { _deadlines = value; }
            get { return _deadlines; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _englishname;
        public string EnglishName
        {
            set { _englishname = value; }
            get { return _englishname; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _schooltype;
        public string SchoolType
        {
            set { _schooltype = value; }
            get { return _schooltype; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _totalcost;
        public float TotalCost
        {
            set { _totalcost = value; }
            get { return _totalcost; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _fees;
        public float Fees
        {
            set { _fees = value; }
            get { return _fees; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _roomfee;
        public float RoomFee
        {
            set { _roomfee = value; }
            get { return _roomfee; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _domesticwebsite;
        public string DomesticWebSite
        {
            set { _domesticwebsite = value; }
            get { return _domesticwebsite; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _otherfee;
        public float OtherFee
        {
            set { _otherfee = value; }
            get { return _otherfee; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _oblast;
        public string Oblast
        {
            set { _oblast = value; }
            get { return _oblast; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _areatype;
        public string AreaType
        {
            set { _areatype = value; }
            get { return _areatype; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _city;
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _schoolbeginyear;
        public string SchoolBeginYear
        {
            set { _schoolbeginyear = value; }
            get { return _schoolbeginyear; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _schoolproperty;
        public string SchoolProperty
        {
            set { _schoolproperty = value; }
            get { return _schoolproperty; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _schoolsex;
        public string SchoolSex
        {
            set { _schoolsex = value; }
            get { return _schoolsex; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _ratioofadmission;
        public float RatioOfAdmission
        {
            set { _ratioofadmission = value; }
            get { return _ratioofadmission; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _levels;
        public string Levels
        {
            set { _levels = value; }
            get { return _levels; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _totleofundergraduate;
        public float TotleOfUndergraduate
        {
            set { _totleofundergraduate = value; }
            get { return _totleofundergraduate; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _totleofinternational;
        public float TotleOfInternational
        {
            set { _totleofinternational = value; }
            get { return _totleofinternational; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _ratioofgirl;
        public float RatioOfGirl
        {
            set { _ratioofgirl = value; }
            get { return _ratioofgirl; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _ratioofstudentandteacher;
        public string RatioOfStudentAndTeacher
        {
            set { _ratioofstudentandteacher = value; }
            get { return _ratioofstudentandteacher; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _demandofgre;
        public bool DemandOfGRE
        {
            set { _demandofgre = value; }
            get { return _demandofgre; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _minscoreofgre;
        public float MinScoreOfGRE
        {
            set { _minscoreofgre = value; }
            get { return _minscoreofgre; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _demandofgmat;
        public bool DemandOfGMAT
        {
            set { _demandofgmat = value; }
            get { return _demandofgmat; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _minscoreofgmat;
        public float MinScoreOfGMAT
        {
            set { _minscoreofgmat = value; }
            get { return _minscoreofgmat; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _recommendmajor;
        public float RecommendMajor
        {
            set { _recommendmajor = value; }
            get { return _recommendmajor; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _gpaofnewstudent;
        public float GPAOfNewStudent
        {
            set { _gpaofnewstudent = value; }
            get { return _gpaofnewstudent; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _scholarship;
        public bool Scholarship
        {
            set { _scholarship = value; }
            get { return _scholarship; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _officialwebsite;
        public string OfficialWebSite
        {
            set { _officialwebsite = value; }
            get { return _officialwebsite; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _demandoftoefl;
        public bool DemandOfToefl
        {
            set { _demandoftoefl = value; }
            get { return _demandoftoefl; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _minscoreoftoefl;
        public float MinScoreOfTOEFL
        {
            set { _minscoreoftoefl = value; }
            get { return _minscoreoftoefl; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _havebranchschool;
        public bool HaveBranchSchool
        {
            set { _havebranchschool = value; }
            get { return _havebranchschool; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _religion;
        public string Religion
        {
            set { _religion = value; }
            get { return _religion; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _inlandorcoastal;
        public string InLandOrCoastal
        {
            set { _inlandorcoastal = value; }
            get { return _inlandorcoastal; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _graduateschool;
        public bool GraduateSchool
        {
            set { _graduateschool = value; }
            get { return _graduateschool; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _hotmajor;
        public string HotMajor
        {
            set { _hotmajor = value; }
            get { return _hotmajor; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _cooperationperson;
        public string CooperationPerson
        {
            set { _cooperationperson = value; }
            get { return _cooperationperson; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _department;
        public string Department
        {
            set { _department = value; }
            get { return _department; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _cum;
        public string CUM
        {
            set { _cum = value; }
            get { return _cum; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _email;
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _mobile;
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _othercollege;
        public string OtherCollege
        {
            set { _othercollege = value; }
            get { return _othercollege; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _weatchertype;
        public string WeatcherType
        {
            set { _weatchertype = value; }
            get { return _weatchertype; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _planeline;
        public string PlaneLine
        {
            set { _planeline = value; }
            get { return _planeline; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _mapwebsite;
        public string MapWebSite
        {
            set { _mapwebsite = value; }
            get { return _mapwebsite; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _oblastintro;
        public string OblastIntro
        {
            set { _oblastintro = value; }
            get { return _oblastintro; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _certific;
        public bool Certific
        {
            set { _certific = value; }
            get { return _certific; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _bachelor;
        public bool Bachelor
        {
            set { _bachelor = value; }
            get { return _bachelor; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _postbaccalaureatecertificate;
        public bool PostBaccalaureateCertificate
        {
            set { _postbaccalaureatecertificate = value; }
            get { return _postbaccalaureatecertificate; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _mastes;
        public bool Mastes
        {
            set { _mastes = value; }
            get { return _mastes; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _postmastercertificate;
        public bool PostMasterCertificate
        {
            set { _postmastercertificate = value; }
            get { return _postmastercertificate; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _reserachschoolarship;
        public bool ReserachSchoolarship
        {
            set { _reserachschoolarship = value; }
            get { return _reserachschoolarship; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _professionalpractice;
        public bool ProfessionalPractice
        {
            set { _professionalpractice = value; }
            get { return _professionalpractice; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _professionalother;
        public bool ProfessionalOther
        {
            set { _professionalother = value; }
            get { return _professionalother; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _languagecoursename;
        public string LanguageCourseName
        {
            set { _languagecoursename = value; }
            get { return _languagecoursename; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _languagecoursecycle;
        public string LanguageCourseCycle
        {
            set { _languagecoursecycle = value; }
            get { return _languagecoursecycle; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _languagecoursefee;
        public float LanguageCourseFee
        {
            set { _languagecoursefee = value; }
            get { return _languagecoursefee; }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _yuke;
        public bool YuKe
        {
            set { _yuke = value; }
            get { return _yuke; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _yukefee;
        public float YuKeFee
        {
            set { _yukefee = value; }
            get { return _yukefee; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _yukecycle;
        public string YuKeCycle
        {
            set { _yukecycle = value; }
            get { return _yukecycle; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _ztpingjia;
        public float ZtPingJia
        {
            set { _ztpingjia = value; }
            get { return _ztpingjia; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _qualityofteach;
        public float QualityOfTeach
        {
            set { _qualityofteach = value; }
            get { return _qualityofteach; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _researchability;
        public float ResearchAbility
        {
            set { _researchability = value; }
            get { return _researchability; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _zongheenvironment;
        public float ZongHeEnvironment
        {
            set { _zongheenvironment = value; }
            get { return _zongheenvironment; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _qualityofstudent;
        public float QualityOfStudent
        {
            set { _qualityofstudent = value; }
            get { return _qualityofstudent; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _brandvalue;
        public float BrandValue
        {
            set { _brandvalue = value; }
            get { return _brandvalue; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _newbaoyoulv;
        public float NewBaoYouLv
        {
            set { _newbaoyoulv = value; }
            get { return _newbaoyoulv; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _graduationrate;
        public float GraduationRate
        {
            set { _graduationrate = value; }
            get { return _graduationrate; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _newrate;
        public float NewRate
        {
            set { _newrate = value; }
            get { return _newrate; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawschoolrankings;
        public float LawSchoolRankings
        {
            set { _lawschoolrankings = value; }
            get { return _lawschoolrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawclinicaltrainingrankings;
        public float LawClinicalTrainingRankings
        {
            set { _lawclinicaltrainingrankings = value; }
            get { return _lawclinicaltrainingrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawdisputeresolutionrankings;
        public float LawDisputeResolutionRankings
        {
            set { _lawdisputeresolutionrankings = value; }
            get { return _lawdisputeresolutionrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawenvironmentrankings;
        public float LawEnvironmentRankings
        {
            set { _lawenvironmentrankings = value; }
            get { return _lawenvironmentrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawhealthrankings;
        public float LawHealthRankings
        {
            set { _lawhealthrankings = value; }
            get { return _lawhealthrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawiprankings;
        public float LawIpRankings
        {
            set { _lawiprankings = value; }
            get { return _lawiprankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawinternalrankings;
        public float LawInternalRankings
        {
            set { _lawinternalrankings = value; }
            get { return _lawinternalrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawfirmsrankschoolsrankings;
        public float LawFirmsRankSchoolsRankings
        {
            set { _lawfirmsrankschoolsrankings = value; }
            get { return _lawfirmsrankschoolsrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawlegalwriterankings;
        public float LawLegalWriteRankings
        {
            set { _lawlegalwriterankings = value; }
            get { return _lawlegalwriterankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawparttimelawrankings;
        public float LawPartTimeLawRankings
        {
            set { _lawparttimelawrankings = value; }
            get { return _lawparttimelawrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawtaxrankings;
        public float LawTaxRankings
        {
            set { _lawtaxrankings = value; }
            get { return _lawtaxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lawtrialadvocacyrankings;
        public float LawTrialAdvocacyRankings
        {
            set { _lawtrialadvocacyrankings = value; }
            get { return _lawtrialadvocacyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _businesscollegerankings;
        public float BusinessCollegeRankings
        {
            set { _businesscollegerankings = value; }
            get { return _businesscollegerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _busenessadminrankings;
        public float BusenessAdminRankings
        {
            set { _busenessadminrankings = value; }
            get { return _busenessadminrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _internalbusinessrankings;
        public float InternalBusinessRankings
        {
            set { _internalbusinessrankings = value; }
            get { return _internalbusinessrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _financialrankings;
        public float FinancialRankings
        {
            set { _financialrankings = value; }
            get { return _financialrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _managerankings;
        public float ManageRankings
        {
            set { _managerankings = value; }
            get { return _managerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _marketingrankings;
        public float MarketingRankings
        {
            set { _marketingrankings = value; }
            get { return _marketingrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _zzmbarankings;
        public float ZZMBARankings
        {
            set { _zzmbarankings = value; }
            get { return _zzmbarankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _publicmanagerankings;
        public float PublicManageRankings
        {
            set { _publicmanagerankings = value; }
            get { return _publicmanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _supplyandwuliurankings;
        public float SupplyAndWuLiuRankings
        {
            set { _supplyandwuliurankings = value; }
            get { return _supplyandwuliurankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _proopemanagerankings;
        public float ProOpeManageRankings
        {
            set { _proopemanagerankings = value; }
            get { return _proopemanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _informationrankings;
        public float InformationRankings
        {
            set { _informationrankings = value; }
            get { return _informationrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _qiyemanagerankings;
        public float QiyeManageRankings
        {
            set { _qiyemanagerankings = value; }
            get { return _qiyemanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _kuaijirankings;
        public float KuaiJiRankings
        {
            set { _kuaijirankings = value; }
            get { return _kuaijirankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _wmgrankings;
        public float WMGRankings
        {
            set { _wmgrankings = value; }
            get { return _wmgrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _chemistryrankings;
        public float ChemistryRankings
        {
            set { _chemistryrankings = value; }
            get { return _chemistryrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _civilengrankings;
        public float CivilEngRankings
        {
            set { _civilengrankings = value; }
            get { return _civilengrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _biomedicinerankings;
        public float BiomedicineRankings
        {
            set { _biomedicinerankings = value; }
            get { return _biomedicinerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _materialsrankings;
        public float MaterialsRankings
        {
            set { _materialsrankings = value; }
            get { return _materialsrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lifeandfarmrankings;
        public float LifeAndFarmRankings
        {
            set { _lifeandfarmrankings = value; }
            get { return _lifeandfarmrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _computerrankings;
        public float ComputerRankings
        {
            set { _computerrankings = value; }
            get { return _computerrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _environmentrankings;
        public float EnvironmentRankings
        {
            set { _environmentrankings = value; }
            get { return _environmentrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _machinerankings;
        public float MachineRankings
        {
            set { _machinerankings = value; }
            get { return _machinerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _communicaterankings;
        public float CommunicateRankings
        {
            set { _communicaterankings = value; }
            get { return _communicaterankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _nuclearrankings;
        public float NuclearRankings
        {
            set { _nuclearrankings = value; }
            get { return _nuclearrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _industryrankings;
        public float IndustryRankings
        {
            set { _industryrankings = value; }
            get { return _industryrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _aviationrankings;
        public float AviationRankings
        {
            set { _aviationrankings = value; }
            get { return _aviationrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _educollegerankings;
        public float EduCollegeRankings
        {
            set { _educollegerankings = value; }
            get { return _educollegerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _eduxinlirankings;
        public float EduxinliRankings
        {
            set { _eduxinlirankings = value; }
            get { return _eduxinlirankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _primaryedurankings;
        public float PrimaryEduRankings
        {
            set { _primaryedurankings = value; }
            get { return _primaryedurankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _edumanagerankings;
        public float EduManageRankings
        {
            set { _edumanagerankings = value; }
            get { return _edumanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _courseandteachrankings;
        public float CourseAndTeachRankings
        {
            set { _courseandteachrankings = value; }
            get { return _courseandteachrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _fudaofuwurankings;
        public float FudaoFuwuRankings
        {
            set { _fudaofuwurankings = value; }
            get { return _fudaofuwurankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _jnzyrankings;
        public float JnzyRankings
        {
            set { _jnzyrankings = value; }
            get { return _jnzyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _specialedurankings;
        public float SpecialEduRankings
        {
            set { _specialedurankings = value; }
            get { return _specialedurankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _gdedurankings;
        public float GdEduRankings
        {
            set { _gdedurankings = value; }
            get { return _gdedurankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _edupolicyrandings;
        public float EduPolicyRandings
        {
            set { _edupolicyrandings = value; }
            get { return _edupolicyrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _middleschedurankings;
        public float MiddleSchEduRankings
        {
            set { _middleschedurankings = value; }
            get { return _middleschedurankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lisaudiologyrankings;
        public float LisAudiologyRankings
        {
            set { _lisaudiologyrankings = value; }
            get { return _lisaudiologyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _lcxlxrankings;
        public float LcxlxRankings
        {
            set { _lcxlxrankings = value; }
            get { return _lcxlxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _nurseanesthesiarankings;
        public float NurseAnesthesiaRankings
        {
            set { _nurseanesthesiarankings = value; }
            get { return _nurseanesthesiarankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _healthmanagerankings;
        public float HealthManageRankings
        {
            set { _healthmanagerankings = value; }
            get { return _healthmanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _hlnursingrankings;
        public float HlNursingRankings
        {
            set { _hlnursingrankings = value; }
            get { return _hlnursingrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _zchlrankings;
        public float ZchlRankings
        {
            set { _zchlrankings = value; }
            get { return _zchlrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _occupationaltherapyrankings;
        public float OccupationalTherapyRankings
        {
            set { _occupationaltherapyrankings = value; }
            get { return _occupationaltherapyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major1;
        public string Major1
        {
            set { _major1 = value; }
            get { return _major1; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major1xuezhi;
        public string Major1XueZhi
        {
            set { _major1xuezhi = value; }
            get { return _major1xuezhi; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _major1fee;
        public float Major1Fee
        {
            set { _major1fee = value; }
            get { return _major1fee; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major1level;
        public string Major1Level
        {
            set { _major1level = value; }
            get { return _major1level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major2;
        public string Major2
        {
            set { _major2 = value; }
            get { return _major2; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major2level;
        public string Major2Level
        {
            set { _major2level = value; }
            get { return _major2level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major3;
        public string Major3
        {
            set { _major3 = value; }
            get { return _major3; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major3level;
        public string Major3Level
        {
            set { _major3level = value; }
            get { return _major3level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major4;
        public string Major4
        {
            set { _major4 = value; }
            get { return _major4; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major4level;
        public string Major4Level
        {
            set { _major4level = value; }
            get { return _major4level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major5;
        public string Major5
        {
            set { _major5 = value; }
            get { return _major5; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major5level;
        public string Major5Level
        {
            set { _major5level = value; }
            get { return _major5level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major6;
        public string Major6
        {
            set { _major6 = value; }
            get { return _major6; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major6level;
        public string Major6Level
        {
            set { _major6level = value; }
            get { return _major6level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major7;
        public string Major7
        {
            set { _major7 = value; }
            get { return _major7; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major7level;
        public string Major7Level
        {
            set { _major7level = value; }
            get { return _major7level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major8;
        public string Major8
        {
            set { _major8 = value; }
            get { return _major8; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major8level;
        public string Major8Level
        {
            set { _major8level = value; }
            get { return _major8level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major9;
        public string Major9
        {
            set { _major9 = value; }
            get { return _major9; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major9level;
        public string Major9Level
        {
            set { _major9level = value; }
            get { return _major9level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major10;
        public string Major10
        {
            set { _major10 = value; }
            get { return _major10; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major10level;
        public string Major10Level
        {
            set { _major10level = value; }
            get { return _major10level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major11;
        public string Major11
        {
            set { _major11 = value; }
            get { return _major11; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major11level;
        public string Major11Level
        {
            set { _major11level = value; }
            get { return _major11level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major12;
        public string Major12
        {
            set { _major12 = value; }
            get { return _major12; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major12level;
        public string Major12Level
        {
            set { _major12level = value; }
            get { return _major12level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major13;
        public string Major13
        {
            set { _major13 = value; }
            get { return _major13; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major13xuezhi;
        public string Major13Xuezhi
        {
            set { _major13xuezhi = value; }
            get { return _major13xuezhi; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _major13fee;
        public float Major13Fee
        {
            set { _major13fee = value; }
            get { return _major13fee; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major13level;
        public string Major13Level
        {
            set { _major13level = value; }
            get { return _major13level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major14;
        public string Major14
        {
            set { _major14 = value; }
            get { return _major14; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major14level;
        public string Major14Level
        {
            set { _major14level = value; }
            get { return _major14level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major15;
        public string Major15
        {
            set { _major15 = value; }
            get { return _major15; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major15level;
        public string Major15Level
        {
            set { _major15level = value; }
            get { return _major15level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major16;
        public string Major16
        {
            set { _major16 = value; }
            get { return _major16; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major16level;
        public string Major16Level
        {
            set { _major16level = value; }
            get { return _major16level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major17;
        public string Major17
        {
            set { _major17 = value; }
            get { return _major17; }
        }

        /// <summary>
        /// 
        /// </summary>
        private string _major17level;
        public string Major17Level
        {
            set { _major17level = value; }
            get { return _major17level; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _physicaltherapyrankings;
        public float PhysicalTherapyRankings
        {
            set { _physicaltherapyrankings = value; }
            get { return _physicaltherapyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _mediastinusrankings;
        public float MediastinusRankings
        {
            set { _mediastinusrankings = value; }
            get { return _mediastinusrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _publichealrankings;
        public float PublicHealRankings
        {
            set { _publichealrankings = value; }
            get { return _publichealrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _kfzxrankings;
        public float KfzxRankings
        {
            set { _kfzxrankings = value; }
            get { return _kfzxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _socialworkrankings;
        public float SocialWorkRankings
        {
            set { _socialworkrankings = value; }
            get { return _socialworkrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _veterinarymedicinerankings;
        public float VeterinaryMedicineRankings
        {
            set { _veterinarymedicinerankings = value; }
            get { return _veterinarymedicinerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _languageblrankings;
        public float LanguageBlRankings
        {
            set { _languageblrankings = value; }
            get { return _languageblrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _yjrankings;
        public float YjRankings
        {
            set { _yjrankings = value; }
            get { return _yjrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _yixuerankings;
        public float YixueRankings
        {
            set { _yixuerankings = value; }
            get { return _yixuerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _femalehealthrankings;
        public float FemaleHealthRankings
        {
            set { _femalehealthrankings = value; }
            get { return _femalehealthrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _countryyxrankings;
        public float CountryYxRankings
        {
            set { _countryyxrankings = value; }
            get { return _countryyxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _babyrankings;
        public float BabyRankings
        {
            set { _babyrankings = value; }
            get { return _babyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _nkyxrankings;
        public float NkyxRankings
        {
            set { _nkyxrankings = value; }
            get { return _nkyxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _oldyxrankings;
        public float OldYxRankings
        {
            set { _oldyxrankings = value; }
            get { return _oldyxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _familyyxrankings;
        public float FamilyYxRankings
        {
            set { _familyyxrankings = value; }
            get { return _familyyxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _dpjjrankings;
        public float DpjjRankings
        {
            set { _dpjjrankings = value; }
            get { return _dpjjrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _aidsrankings;
        public float AIDSRankings
        {
            set { _aidsrankings = value; }
            get { return _aidsrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _ylzyrankings;
        public float YlzyRankings
        {
            set { _ylzyrankings = value; }
            get { return _ylzyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _publicpolicyfxrankings;
        public float PublicPolicyFxRankings
        {
            set { _publicpolicyfxrankings = value; }
            get { return _publicpolicyfxrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _publictranrankings;
        public float PublicTranRankings
        {
            set { _publictranrankings = value; }
            get { return _publictranrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _publicczysrankings;
        public float PublicCzYsRankings
        {
            set { _publicczysrankings = value; }
            get { return _publicczysrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _socialpolicyrankings;
        public float SocialPolicyRankings
        {
            set { _socialpolicyrankings = value; }
            get { return _socialpolicyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _citymanagepolicyrankings;
        public float CityManagePolicyRankings
        {
            set { _citymanagepolicyrankings = value; }
            get { return _citymanagepolicyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _environmentpolicymanagerankings;
        public float EnvironmentPolicyManageRankings
        {
            set { _environmentpolicymanagerankings = value; }
            get { return _environmentpolicymanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _healthpolicymanagerankings;
        public float HealthPolicyManageRankings
        {
            set { _healthpolicymanagerankings = value; }
            get { return _healthpolicymanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _informanazyrankings;
        public float InforManazyRankings
        {
            set { _informanazyrankings = value; }
            get { return _informanazyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _fylpublicmanagerankings;
        public float FylPublicManageRankings
        {
            set { _fylpublicmanagerankings = value; }
            get { return _fylpublicmanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _zfpublicmanagerankings;
        public float ZfPublicManageRankings
        {
            set { _zfpublicmanagerankings = value; }
            get { return _zfpublicmanagerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _bhzyrankings;
        public float BhzyRankings
        {
            set { _bhzyrankings = value; }
            get { return _bhzyrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _snsjrankings;
        public float SnsjRankings
        {
            set { _snsjrankings = value; }
            get { return _snsjrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _xwysrankings;
        public float XwysRankings
        {
            set { _xwysrankings = value; }
            get { return _xwysrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _metalzbrankings;
        public float MetalZbRankings
        {
            set { _metalzbrankings = value; }
            get { return _metalzbrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _yscollegerankings;
        public float YsCollegeRankings
        {
            set { _yscollegerankings = value; }
            get { return _yscollegerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _industrialdesignrankings;
        public float IndustrialDesignRankings
        {
            set { _industrialdesignrankings = value; }
            get { return _industrialdesignrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _drawrankings;
        public float DrawRankings
        {
            set { _drawrankings = value; }
            get { return _drawrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _sculpturerankings;
        public float SculptureRankings
        {
            set { _sculpturerankings = value; }
            get { return _sculpturerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _ceramrankings;
        public float CeramRankings
        {
            set { _ceramrankings = value; }
            get { return _ceramrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _glassartrankings;
        public float GlassArtRankings
        {
            set { _glassartrankings = value; }
            get { return _glassartrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _drawdesignrankings;
        public float DrawDesignRankings
        {
            set { _drawdesignrankings = value; }
            get { return _drawdesignrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _mediarankings;
        public float MediaRankings
        {
            set { _mediarankings = value; }
            get { return _mediarankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _filmrankings;
        public float FilmRankings
        {
            set { _filmrankings = value; }
            get { return _filmrankings; }
        }

        #endregion MeiGuoShuoShi Entity End
    }
}