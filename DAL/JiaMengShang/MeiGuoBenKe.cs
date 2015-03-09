using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Basic;
using System.Text;

namespace DAL
{
    public class MeiGuoBenKe
    {
        #region  MeiGuoBenKe
        /// <summary>
        /// 获取所有的的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>返回DataTable</returns>
        public static DataTable MeiGuoBenKeList(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT * FROM [MeiGuoBenKe] WHERE " + strWhere + ";";
            else
                strSql = "SELECT * FROM [MeiGuoBenKe] ;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }

        #endregion


        #region  MeiGuoBenKe
        /// <summary>
        /// 获取某一个DataTable
        /// </summary>
        /// <param name="Num">标识</param>
        /// <returns>返回DataTable</returns>
        public static DataTable MeiGuoBenKeGet(int Id)
        {
            return SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MeiGuoBenKe] WHERE Id = " + Id + ";").Tables[0];
        }

        /// <summary>
        /// 获取某一个实体
        /// </summary>
        /// <param name="Num">标识</param>
        /// <returns>返回Entity</returns>
        public static Entity.MeiGuoBenKe MeiGuoBenKeEntityGet(int Id)
        {
            Entity.MeiGuoBenKe info = new Entity.MeiGuoBenKe();
            DataTable dt = SqlDB.ExecuteDataset(CommandType.Text, "SELECT * FROM [MeiGuoBenKe] WHERE Id = " + Id + ";").Tables[0];
            if (dt.Rows.Count > 0)
            {
                info.Num = dt.Rows[0]["Num"].ToString();
                info.SchoolChineseName = dt.Rows[0]["SchoolChineseName"].ToString();
                info.ZongHeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["ZongHeRandings"].ToString(), 0);
                info.Alexa = Basic.Utils.StrToFloat(dt.Rows[0]["Alexa"].ToString(), 0);
                info.Concern = dt.Rows[0]["Concern"].ToString();
                info.Deadlines = Basic.Utils.StrToDateTime(dt.Rows[0]["Deadlines"].ToString(), DateTime.Now);
                info.EnglishName = dt.Rows[0]["EnglishName"].ToString();
                info.SchoolType = dt.Rows[0]["SchoolType"].ToString();
                info.TotalCost = Basic.Utils.StrToFloat(dt.Rows[0]["TotalCost"].ToString(), 0);
                info.Fees = Basic.Utils.StrToFloat(dt.Rows[0]["Fees"].ToString(), 0);
                info.RoomFee = Basic.Utils.StrToFloat(dt.Rows[0]["RoomFee"].ToString(), 0);
                info.DomesticWebSite = dt.Rows[0]["DomesticWebSite"].ToString();
                info.OtherFee = Basic.Utils.StrToFloat(dt.Rows[0]["OtherFee"].ToString(), 0);
                info.Oblast = dt.Rows[0]["Oblast"].ToString();
                info.AreaType = dt.Rows[0]["AreaType"].ToString();
                info.City = dt.Rows[0]["City"].ToString();
                info.SchoolBeginYear = dt.Rows[0]["SchoolBeginYear"].ToString();
                info.SchoolProperty = dt.Rows[0]["SchoolProperty"].ToString();
                info.SchoolSex = dt.Rows[0]["SchoolSex"].ToString();
                info.RatioOfAdmission = Basic.Utils.StrToFloat(dt.Rows[0]["RatioOfAdmission"].ToString(), 0);
                info.Levels = dt.Rows[0]["Levels"].ToString();
                info.TotleOfUndergraduate = Basic.Utils.StrToFloat(dt.Rows[0]["TotleOfUndergraduate"].ToString(), 0);
                info.TotleOfInternational = Basic.Utils.StrToFloat(dt.Rows[0]["TotleOfInternational"].ToString(), 0);
                info.RatioOfGirl = Basic.Utils.StrToFloat(dt.Rows[0]["RatioOfGirl"].ToString(), 0);
                info.RatioOfStudentAndTeacher = dt.Rows[0]["RatioOfStudentAndTeacher"].ToString();
                info.DemandOfSAT = Basic.Utils.StrToBool(dt.Rows[0]["DemandOfSAT"].ToString(), false);
                info.MinScoreOfSAT = Basic.Utils.StrToFloat(dt.Rows[0]["MinScoreOfSAT"].ToString(), 0);
                info.ReadOfSAT = Basic.Utils.StrToFloat(dt.Rows[0]["ReadOfSAT"].ToString(), 0);
                info.WriteOfSAT = Basic.Utils.StrToFloat(dt.Rows[0]["WriteOfSAT"].ToString(), 0);
                info.MathOfSAT = Basic.Utils.StrToFloat(dt.Rows[0]["MathOfSAT"].ToString(), 0);
                info.GPAOfNewStudent = Basic.Utils.StrToFloat(dt.Rows[0]["GPAOfNewStudent"].ToString(), 0);
                info.RangeOfSAT = dt.Rows[0]["RangeOfSAT"].ToString();
                info.Scholarship = Basic.Utils.StrToBool(dt.Rows[0]["Scholarship"].ToString(), false);
                info.OfficialWebSite = dt.Rows[0]["OfficialWebSite"].ToString();
                info.DemandOfToefl = Basic.Utils.StrToBool(dt.Rows[0]["DemandOfToefl"].ToString(), false);
                info.MinScoreOfTOEFL = Basic.Utils.StrToFloat(dt.Rows[0]["MinScoreOfTOEFL"].ToString(), 0);
                info.DemandOfIELTS = Basic.Utils.StrToBool(dt.Rows[0]["DemandOfIELTS"].ToString(), false);
                info.MinScoreOfIELTS = Basic.Utils.StrToFloat(dt.Rows[0]["MinScoreOfIELTS"].ToString(), 0);
                info.HaveBranchSchool = Basic.Utils.StrToBool(dt.Rows[0]["HaveBranchSchool"].ToString(), false);
                info.Religion = dt.Rows[0]["Religion"].ToString();
                info.InLandOrCoastal = dt.Rows[0]["InLandOrCoastal"].ToString();
                info.GraduateSchool = Basic.Utils.StrToBool(dt.Rows[0]["GraduateSchool"].ToString(), false);
                info.HotMajor = dt.Rows[0]["HotMajor"].ToString();
                info.CooperationPerson = dt.Rows[0]["CooperationPerson"].ToString();
                info.Department = dt.Rows[0]["Department"].ToString();
                info.CUM = dt.Rows[0]["CUM"].ToString();
                info.Email = dt.Rows[0]["Email"].ToString();
                info.Mobile = dt.Rows[0]["Mobile"].ToString();
                info.OtherCollege = dt.Rows[0]["OtherCollege"].ToString();
                info.WeatcherType = dt.Rows[0]["WeatcherType"].ToString();
                info.PlaneLine = dt.Rows[0]["PlaneLine"].ToString();
                info.MapWebSite = dt.Rows[0]["MapWebSite"].ToString();
                info.OblastIntro = dt.Rows[0]["OblastIntro"].ToString();
                info.Certific = Basic.Utils.StrToBool(dt.Rows[0]["Certific"].ToString(), false);
                info.Bachelor = Basic.Utils.StrToBool(dt.Rows[0]["Bachelor"].ToString(), false);
                info.PostBaccalaureateCertificate = Basic.Utils.StrToBool(dt.Rows[0]["PostBaccalaureateCertificate"].ToString(), false);
                info.Mastes = Basic.Utils.StrToBool(dt.Rows[0]["Mastes"].ToString(), false);
                info.PostMasterCertificate = Basic.Utils.StrToBool(dt.Rows[0]["PostMasterCertificate"].ToString(), false);
                info.ReserachSchoolarship = Basic.Utils.StrToBool(dt.Rows[0]["ReserachSchoolarship"].ToString(), false);
                info.ProfessionalPractice = Basic.Utils.StrToBool(dt.Rows[0]["ProfessionalPractice"].ToString(), false);
                info.ProfessionalOther = Basic.Utils.StrToBool(dt.Rows[0]["ProfessionalOther"].ToString(), false);
                info.LanguageCourseName = dt.Rows[0]["LanguageCourseName"].ToString();
                info.LanguageCourseCycle = dt.Rows[0]["LanguageCourseCycle"].ToString();
                info.LanguageCourseFee = Basic.Utils.StrToFloat(dt.Rows[0]["LanguageCourseFee"].ToString(), 0);
                info.YuKe = Basic.Utils.StrToBool(dt.Rows[0]["YuKe"].ToString(), false);
                info.YuKeFee = Basic.Utils.StrToFloat(dt.Rows[0]["YuKeFee"].ToString(), 0);
                info.YuKeCycle = dt.Rows[0]["YuKeCycle"].ToString();
                info.ZtPingJia = Basic.Utils.StrToFloat(dt.Rows[0]["ZtPingJia"].ToString(), 0);
                info.QualityOfTeach = Basic.Utils.StrToFloat(dt.Rows[0]["QualityOfTeach"].ToString(), 0);
                info.ResearchAbility = Basic.Utils.StrToFloat(dt.Rows[0]["ResearchAbility"].ToString(), 0);
                info.ZongHeEnvironment = Basic.Utils.StrToFloat(dt.Rows[0]["ZongHeEnvironment"].ToString(), 0);
                info.QualityOfStudent = Basic.Utils.StrToFloat(dt.Rows[0]["QualityOfStudent"].ToString(), 0);
                info.BrandValue = Basic.Utils.StrToFloat(dt.Rows[0]["BrandValue"].ToString(), 0);
                info.NewBaoYouLv = Basic.Utils.StrToFloat(dt.Rows[0]["NewBaoYouLv"].ToString(), 0);
                info.GraduationRate = Basic.Utils.StrToFloat(dt.Rows[0]["GraduationRate"].ToString(), 0);
                info.NewRate = Basic.Utils.StrToFloat(dt.Rows[0]["NewRate"].ToString(), 0);
                info.BusinessRankings = Basic.Utils.StrToFloat(dt.Rows[0]["BusinessRankings"].ToString(), 0);
                info.FinancialRankings = Basic.Utils.StrToFloat(dt.Rows[0]["FinancialRankings"].ToString(), 0);
                info.ProOpeManageRankings = Basic.Utils.StrToFloat(dt.Rows[0]["ProOpeManageRankings"].ToString(), 0);
                info.QiyeManageRankings = Basic.Utils.StrToFloat(dt.Rows[0]["QiyeManageRankings"].ToString(), 0);
                info.ManageInfoRankings = Basic.Utils.StrToFloat(dt.Rows[0]["ManageInfoRankings"].ToString(), 0);
                info.KuaiJiRankings = Basic.Utils.StrToFloat(dt.Rows[0]["KuaiJiRankings"].ToString(), 0);
                info.InternalBusinessRankings = Basic.Utils.StrToFloat(dt.Rows[0]["InternalBusinessRankings"].ToString(), 0);
                info.DlfxRankings = Basic.Utils.StrToFloat(dt.Rows[0]["DlfxRankings"].ToString(), 0);
                info.ManageRankings = Basic.Utils.StrToFloat(dt.Rows[0]["ManageRankings"].ToString(), 0);
                info.MarketingRankings = Basic.Utils.StrToFloat(dt.Rows[0]["MarketingRankings"].ToString(), 0);
                info.SupplyAndWuLiuRankings = Basic.Utils.StrToFloat(dt.Rows[0]["SupplyAndWuLiuRankings"].ToString(), 0);
                info.HouseRankings = Basic.Utils.StrToFloat(dt.Rows[0]["HouseRankings"].ToString(), 0);
                info.InsureRankings = Basic.Utils.StrToFloat(dt.Rows[0]["InsureRankings"].ToString(), 0);
                info.ProjectRankings = Basic.Utils.StrToFloat(dt.Rows[0]["ProjectRankings"].ToString(), 0);
                info.ProjectScienceRankings = Basic.Utils.StrToFloat(dt.Rows[0]["ProjectScienceRankings"].ToString(), 0);
                info.MaterialsRankings = Basic.Utils.StrToFloat(dt.Rows[0]["MaterialsRankings"].ToString(), 0);
                info.CommunicateRankings = Basic.Utils.StrToFloat(dt.Rows[0]["CommunicateRankings"].ToString(), 0);
                info.IndustryRankings = Basic.Utils.StrToFloat(dt.Rows[0]["IndustryRankings"].ToString(), 0);
                info.EnvironmentRankings = Basic.Utils.StrToFloat(dt.Rows[0]["EnvironmentRankings"].ToString(), 0);
                info.MachineRankings = Basic.Utils.StrToFloat(dt.Rows[0]["MachineRankings"].ToString(), 0);
                info.ComputerRankings = Basic.Utils.StrToFloat(dt.Rows[0]["ComputerRankings"].ToString(), 0);
                info.BiomedicineRankings = Basic.Utils.StrToFloat(dt.Rows[0]["BiomedicineRankings"].ToString(), 0);
                info.LifeAndFarmRankings = Basic.Utils.StrToFloat(dt.Rows[0]["LifeAndFarmRankings"].ToString(), 0);
                info.CivilEngRankings = Basic.Utils.StrToFloat(dt.Rows[0]["CivilEngRankings"].ToString(), 0);
                info.AviationRankings = Basic.Utils.StrToFloat(dt.Rows[0]["AviationRankings"].ToString(), 0);
                info.ChemistryRankings = Basic.Utils.StrToFloat(dt.Rows[0]["ChemistryRankings"].ToString(), 0);
                info.USACollegeRankings = Basic.Utils.StrToFloat(dt.Rows[0]["USACollegeRankings"].ToString(), 0);
                info.WLCollegeRankings = Basic.Utils.StrToFloat(dt.Rows[0]["WLCollegeRankings"].ToString(), 0);
                info.PublicCollegeRankings = Basic.Utils.StrToFloat(dt.Rows[0]["PublicCollegeRankings"].ToString(), 0);
                info.PublicWLCollegeRankings = Basic.Utils.StrToFloat(dt.Rows[0]["PublicWLCollegeRankings"].ToString(), 0);
                info.UndergraduateRandings = Basic.Utils.StrToFloat(dt.Rows[0]["UndergraduateRandings"].ToString(), 0);
                info.WLCollegeUndergraduateRandings = Basic.Utils.StrToFloat(dt.Rows[0]["WLCollegeUndergraduateRandings"].ToString(), 0);
                info.AdviceUSACollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["AdviceUSACollegeRandings"].ToString(), 0);
                info.AdviceWLCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["AdviceWLCollegeRandings"].ToString(), 0);
                info.BlackCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["BlackCollegeRandings"].ToString(), 0);
                info.UpstateCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["UpstateCollegeRandings"].ToString(), 0);
                info.UpstateCollegeTeachRandings = Basic.Utils.StrToFloat(dt.Rows[0]["UpstateCollegeTeachRandings"].ToString(), 0);
                info.UpstatePublicRandings = Basic.Utils.StrToFloat(dt.Rows[0]["UpstatePublicRandings"].ToString(), 0);
                info.UpstateprivateRandings = Basic.Utils.StrToFloat(dt.Rows[0]["UpstateprivateRandings"].ToString(), 0);
                info.UpstateWLCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["UpstateWLCollegeRandings"].ToString(), 0);
                info.SouthCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["SouthCollegeRandings"].ToString(), 0);
                info.SouthCollegeTeachRandings = Basic.Utils.StrToFloat(dt.Rows[0]["SouthCollegeTeachRandings"].ToString(), 0);
                info.SouthPublicRandings = Basic.Utils.StrToFloat(dt.Rows[0]["SouthPublicRandings"].ToString(), 0);
                info.SouthPrivateRandings = Basic.Utils.StrToFloat(dt.Rows[0]["SouthPrivateRandings"].ToString(), 0);
                info.SouthWLCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["SouthWLCollegeRandings"].ToString(), 0);
                info.WestCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["WestCollegeRandings"].ToString(), 0);
                info.WestPublicRandings = Basic.Utils.StrToFloat(dt.Rows[0]["WestPublicRandings"].ToString(), 0);
                info.WestPrivateRandings = Basic.Utils.StrToFloat(dt.Rows[0]["WestPrivateRandings"].ToString(), 0);
                info.WestWLCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["WestWLCollegeRandings"].ToString(), 0);
                info.MidWestCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["MidWestCollegeRandings"].ToString(), 0);
                info.MidWestCollegeTeachRandings = Basic.Utils.StrToFloat(dt.Rows[0]["MidWestCollegeTeachRandings"].ToString(), 0);
                info.MidWestPublicRandings = Basic.Utils.StrToFloat(dt.Rows[0]["MidWestPublicRandings"].ToString(), 0);
                info.MidWestPrivateRandings = Basic.Utils.StrToFloat(dt.Rows[0]["MidWestPrivateRandings"].ToString(), 0);
                info.MidWestWLCollegeRandings = Basic.Utils.StrToFloat(dt.Rows[0]["MidWestWLCollegeRandings"].ToString(), 0);
                info.Major1 = dt.Rows[0]["Major1"].ToString();
                info.Major1XueZhi = dt.Rows[0]["Major1XueZhi"].ToString();
                info.Major1Fee = Basic.Utils.StrToFloat(dt.Rows[0]["Major1Fee"].ToString(), 0);
                info.Major1Level = dt.Rows[0]["Major1Level"].ToString();
                info.Major2 = dt.Rows[0]["Major2"].ToString();
                info.Major2Level = dt.Rows[0]["Major2Level"].ToString();
                info.Major3 = dt.Rows[0]["Major3"].ToString();
                info.Major3Level = dt.Rows[0]["Major3Level"].ToString();
                info.Major4 = dt.Rows[0]["Major4"].ToString();
                info.Major4Level = dt.Rows[0]["Major4Level"].ToString();
                info.Major5 = dt.Rows[0]["Major5"].ToString();
                info.Major5Level = dt.Rows[0]["Major5Level"].ToString();
                info.Major6 = dt.Rows[0]["Major6"].ToString();
                info.Major6Level = dt.Rows[0]["Major6Level"].ToString();
                info.Major7 = dt.Rows[0]["Major7"].ToString();
                info.Major7Level = dt.Rows[0]["Major7Level"].ToString();
                info.Major8 = dt.Rows[0]["Major8"].ToString();
                info.Major8Level = dt.Rows[0]["Major8Level"].ToString();
                info.Major9 = dt.Rows[0]["Major9"].ToString();
                info.Major9Level = dt.Rows[0]["Major9Level"].ToString();
                info.Major10 = dt.Rows[0]["Major10"].ToString();
                info.Major10Level = dt.Rows[0]["Major10Level"].ToString();
                info.Major11 = dt.Rows[0]["Major11"].ToString();
                info.Major11Level = dt.Rows[0]["Major11Level"].ToString();
                info.Major12 = dt.Rows[0]["Major12"].ToString();
                info.Major12Level = dt.Rows[0]["Major12Level"].ToString();
                info.Major13 = dt.Rows[0]["Major13"].ToString();
                info.Major13Xuezhi = dt.Rows[0]["Major13Xuezhi"].ToString();
                info.Major13Fee = Basic.Utils.StrToFloat(dt.Rows[0]["Major13Fee"].ToString(), 0);
                info.Major13Level = dt.Rows[0]["Major13Level"].ToString();
                info.Major14 = dt.Rows[0]["Major14"].ToString();
                info.Major14Level = dt.Rows[0]["Major14Level"].ToString();
                info.Major15 = dt.Rows[0]["Major15"].ToString();
                info.Major15Level = dt.Rows[0]["Major15Level"].ToString();
                info.Major16 = dt.Rows[0]["Major16"].ToString();
                info.Major16Level = dt.Rows[0]["Major16Level"].ToString();
                info.Major17 = dt.Rows[0]["Major17"].ToString();
                info.Major17Level = dt.Rows[0]["Major17Level"].ToString();
                info.Id = Basic.Utils.StrToInt(dt.Rows[0]["Id"].ToString(), 0);
            }
            return info;
        }

        /// <summary>
        /// 删除一个值
        /// </summary>
        /// <param name="Num">自增id的值</param>
        /// <returns>删除成功返回ture，否则返回false</returns>
        public static bool MeiGuoBenKeDel(int Id)
        {
            int intReturnValue = 0;
            intReturnValue = SqlDB.ExecuteNonQuery(CommandType.Text, "DELETE [MeiGuoBenKe]  WHERE Id =  " + Id);
            if (intReturnValue == 1)
                return true;
            return false;
        }

        /// <summary>
        /// 获取前多少的值
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <param name="TopNumber">数量</param>
        /// <returns>返回DataTable</returns>
        public static DataTable MeiGuoBenKeTopGet(string strWhere, int TopNumber)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MeiGuoBenKe] WHERE " + strWhere + ";";
            else
                strSql = "SELECT TOP " + TopNumber.ToString() + " * FROM [MeiGuoBenKe] ;";
            return SqlDB.ExecuteDataset(CommandType.Text, strSql).Tables[0];
        }

        ///
        /// <summary>
        /// 获取前多少的值
        /// </summary>
        /// <param name="TopNumber">数量</param>
        /// <param name="PageSize">每页显示多少个</param>
        /// <param name="PageIndex">当前页码，最少为1</param>
        /// <returns>返回DataTable</returns>
        public static DataTable MeiGuoBenKePageList(string strWhere, string strOrder, int PageSize, int PageIndex)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("SELECT * FROM MeiGuoBenKe");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                sbSql.Append(" WHERE " + strWhere);
            }
            sbSql.Append(strOrder);

            DataSet ds = new DataSet();
            ds = SqlDB.ExecuteDataset((PageIndex - 1) * PageSize, PageSize, CommandType.Text, sbSql.ToString());
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return new DataTable();
        }

        /// <summary>
        /// 获取该条件下的总的数量
        /// </summary>
        /// <param name="strWhere">条件，可以为空</param>
        /// <returns>如果没有就返回0</returns>
        public static int MeiGuoBenKeCount(string strWhere)
        {
            string strSql;
            if (!string.IsNullOrEmpty(strWhere.Trim()))
                strSql = "SELECT COUNT(*) FROM [MeiGuoBenKe] WHERE " + strWhere + ";";
            else
                strSql = "SELECT COUNT(*)  FROM [MeiGuoBenKe] ;";
            return Basic.Utils.StrToInt(SqlDB.ExecuteScalar(CommandType.Text, strSql).ToString(), 0);
        }
        #endregion
    }
}