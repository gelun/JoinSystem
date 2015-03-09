using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class MeiGuoBenKe
    {
        #region Files Entity Begin

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
        private bool _demandofsat;
        public bool DemandOfSAT
        {
            set { _demandofsat = value; }
            get { return _demandofsat; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _minscoreofsat;
        public float MinScoreOfSAT
        {
            set { _minscoreofsat = value; }
            get { return _minscoreofsat; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _readofsat;
        public float ReadOfSAT
        {
            set { _readofsat = value; }
            get { return _readofsat; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _writeofsat;
        public float WriteOfSAT
        {
            set { _writeofsat = value; }
            get { return _writeofsat; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _mathofsat;
        public float MathOfSAT
        {
            set { _mathofsat = value; }
            get { return _mathofsat; }
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
        private string _rangeofsat;
        public string RangeOfSAT
        {
            set { _rangeofsat = value; }
            get { return _rangeofsat; }
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
        private bool _demandofielts;
        public bool DemandOfIELTS
        {
            set { _demandofielts = value; }
            get { return _demandofielts; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _minscoreofielts;
        public float MinScoreOfIELTS
        {
            set { _minscoreofielts = value; }
            get { return _minscoreofielts; }
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
        private float _businessrankings;
        public float BusinessRankings
        {
            set { _businessrankings = value; }
            get { return _businessrankings; }
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
        private float _proopemanagerankings;
        public float ProOpeManageRankings
        {
            set { _proopemanagerankings = value; }
            get { return _proopemanagerankings; }
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
        private float _manageinforankings;
        public float ManageInfoRankings
        {
            set { _manageinforankings = value; }
            get { return _manageinforankings; }
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
        private float _internalbusinessrankings;
        public float InternalBusinessRankings
        {
            set { _internalbusinessrankings = value; }
            get { return _internalbusinessrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _dlfxrankings;
        public float DlfxRankings
        {
            set { _dlfxrankings = value; }
            get { return _dlfxrankings; }
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
        private float _supplyandwuliurankings;
        public float SupplyAndWuLiuRankings
        {
            set { _supplyandwuliurankings = value; }
            get { return _supplyandwuliurankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _houserankings;
        public float HouseRankings
        {
            set { _houserankings = value; }
            get { return _houserankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _insurerankings;
        public float InsureRankings
        {
            set { _insurerankings = value; }
            get { return _insurerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _projectrankings;
        public float ProjectRankings
        {
            set { _projectrankings = value; }
            get { return _projectrankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _projectsciencerankings;
        public float ProjectScienceRankings
        {
            set { _projectsciencerankings = value; }
            get { return _projectsciencerankings; }
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
        private float _communicaterankings;
        public float CommunicateRankings
        {
            set { _communicaterankings = value; }
            get { return _communicaterankings; }
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
        private float _computerrankings;
        public float ComputerRankings
        {
            set { _computerrankings = value; }
            get { return _computerrankings; }
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
        private float _lifeandfarmrankings;
        public float LifeAndFarmRankings
        {
            set { _lifeandfarmrankings = value; }
            get { return _lifeandfarmrankings; }
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
        private float _aviationrankings;
        public float AviationRankings
        {
            set { _aviationrankings = value; }
            get { return _aviationrankings; }
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
        private float _usacollegerankings;
        public float USACollegeRankings
        {
            set { _usacollegerankings = value; }
            get { return _usacollegerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _wlcollegerankings;
        public float WLCollegeRankings
        {
            set { _wlcollegerankings = value; }
            get { return _wlcollegerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _publiccollegerankings;
        public float PublicCollegeRankings
        {
            set { _publiccollegerankings = value; }
            get { return _publiccollegerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _publicwlcollegerankings;
        public float PublicWLCollegeRankings
        {
            set { _publicwlcollegerankings = value; }
            get { return _publicwlcollegerankings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _undergraduaterandings;
        public float UndergraduateRandings
        {
            set { _undergraduaterandings = value; }
            get { return _undergraduaterandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _wlcollegeundergraduaterandings;
        public float WLCollegeUndergraduateRandings
        {
            set { _wlcollegeundergraduaterandings = value; }
            get { return _wlcollegeundergraduaterandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _adviceusacollegerandings;
        public float AdviceUSACollegeRandings
        {
            set { _adviceusacollegerandings = value; }
            get { return _adviceusacollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _advicewlcollegerandings;
        public float AdviceWLCollegeRandings
        {
            set { _advicewlcollegerandings = value; }
            get { return _advicewlcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _blackcollegerandings;
        public float BlackCollegeRandings
        {
            set { _blackcollegerandings = value; }
            get { return _blackcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _upstatecollegerandings;
        public float UpstateCollegeRandings
        {
            set { _upstatecollegerandings = value; }
            get { return _upstatecollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _upstatecollegeteachrandings;
        public float UpstateCollegeTeachRandings
        {
            set { _upstatecollegeteachrandings = value; }
            get { return _upstatecollegeteachrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _upstatepublicrandings;
        public float UpstatePublicRandings
        {
            set { _upstatepublicrandings = value; }
            get { return _upstatepublicrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _upstateprivaterandings;
        public float UpstateprivateRandings
        {
            set { _upstateprivaterandings = value; }
            get { return _upstateprivaterandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _upstatewlcollegerandings;
        public float UpstateWLCollegeRandings
        {
            set { _upstatewlcollegerandings = value; }
            get { return _upstatewlcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _southcollegerandings;
        public float SouthCollegeRandings
        {
            set { _southcollegerandings = value; }
            get { return _southcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _southcollegeteachrandings;
        public float SouthCollegeTeachRandings
        {
            set { _southcollegeteachrandings = value; }
            get { return _southcollegeteachrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _southpublicrandings;
        public float SouthPublicRandings
        {
            set { _southpublicrandings = value; }
            get { return _southpublicrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _southprivaterandings;
        public float SouthPrivateRandings
        {
            set { _southprivaterandings = value; }
            get { return _southprivaterandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _southwlcollegerandings;
        public float SouthWLCollegeRandings
        {
            set { _southwlcollegerandings = value; }
            get { return _southwlcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _westcollegerandings;
        public float WestCollegeRandings
        {
            set { _westcollegerandings = value; }
            get { return _westcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _westpublicrandings;
        public float WestPublicRandings
        {
            set { _westpublicrandings = value; }
            get { return _westpublicrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _westprivaterandings;
        public float WestPrivateRandings
        {
            set { _westprivaterandings = value; }
            get { return _westprivaterandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _westwlcollegerandings;
        public float WestWLCollegeRandings
        {
            set { _westwlcollegerandings = value; }
            get { return _westwlcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _midwestcollegerandings;
        public float MidWestCollegeRandings
        {
            set { _midwestcollegerandings = value; }
            get { return _midwestcollegerandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _midwestcollegeteachrandings;
        public float MidWestCollegeTeachRandings
        {
            set { _midwestcollegeteachrandings = value; }
            get { return _midwestcollegeteachrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _midwestpublicrandings;
        public float MidWestPublicRandings
        {
            set { _midwestpublicrandings = value; }
            get { return _midwestpublicrandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _midwestprivaterandings;
        public float MidWestPrivateRandings
        {
            set { _midwestprivaterandings = value; }
            get { return _midwestprivaterandings; }
        }

        /// <summary>
        /// 
        /// </summary>
        private float _midwestwlcollegerandings;
        public float MidWestWLCollegeRandings
        {
            set { _midwestwlcollegerandings = value; }
            get { return _midwestwlcollegerandings; }
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

        #endregion Files Entity End
    }
}

