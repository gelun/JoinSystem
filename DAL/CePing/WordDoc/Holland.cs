using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Imaging;
using Svg;
using System.Text;
using System.Data;
using Word = Microsoft.Office.Interop.Word;

namespace DAL.CePing.WordDoc
{
    public static class Holland
    {
        private static int intArt = 0, intBusiness = 0, intReality = 0, intSociety = 0, intStudy = 0, intTradition = 0;

        //最强兴趣特点
        private static string strTeDian = "";

        //可能感兴趣专业
        private static string[] arrTuiJianZhuanYe;
        //不推荐专业
        private static string[] arrBuTuiJianZhuanYe;

        private static int[] list;
        private static int intMax = 0;//最大值
        private static int intMin = 0;//最小值
        
        //生成word文档
        public static void ExpWordByWord(int intStudentId)
        {
            Entity.Join_Student infoStudent = DAL.Join_Student.Join_StudentEntityGet(intStudentId);
            if (infoStudent == null)
            {
                return;
            }

            Entity.GaoKaoCard infoGaoKaoCard = DAL.GaoKaoCard.GaoKaoCardEntityGetByStudentId(intStudentId);
            if (infoGaoKaoCard == null)
            {
                return;
            }
            //文件路径和名称
            object fileName = System.Web.HttpContext.Current.Server.MapPath("~/") + "CePing/WordOfResult/Holland/" + infoGaoKaoCard.KaHao + "(" + infoStudent.StudentName + "_" + intStudentId + ")" + "_职业兴趣测评.doc";//获取服务器路径
            //判定文件是否已经存在了
            if (Basic.Utils.FileExists(fileName.ToString()))
                return;
            //读取模板文件
            object temp = System.Web.HttpContext.Current.Server.MapPath("~/CePing/WordTemplet/TempletOfHolland.doc");//读取模板文件



            #region 基本信息处理

            DataTable dt = DAL.Join_HollandResults.Join_HollandResultsList("[UserId]=" + intStudentId);
            if (dt != null && dt.Rows.Count > 0)
            {
                intArt = Basic.TypeConverter.StrToInt(dt.Rows[0]["Art"].ToString(), 0);
                intBusiness = Basic.TypeConverter.StrToInt(dt.Rows[0]["Business"].ToString(), 0);
                intReality = Basic.TypeConverter.StrToInt(dt.Rows[0]["Reality"].ToString(), 0);
                intSociety = Basic.TypeConverter.StrToInt(dt.Rows[0]["Society"].ToString(), 0);
                intStudy = Basic.TypeConverter.StrToInt(dt.Rows[0]["Study"].ToString(), 0);
                intTradition = Basic.TypeConverter.StrToInt(dt.Rows[0]["Tradition"].ToString(), 0);
            }
            else
            {
                return;
            }

            //创建数组，通过冒泡排序得到最大值和最小值
            list = new int[] { intArt, intBusiness, intReality, intSociety, intStudy, intTradition };
            DAL.Comm.BubbleSortUp(list);
            intMax = list[5];//最大值
            intMin = list[0];//最小值

            #endregion

            #region MyRegion


            Word._Application app = new Word.Application();
            //表示System.Type信息中的缺少值
            object nothing = Type.Missing;
            try
            {
                //建立一个基于摸版的文档
                Word._Document doc = app.Documents.Add(ref temp, ref nothing, ref nothing, ref nothing);
                //学生基本信息
                Word.Table tb1 = doc.Tables[1];
                if (tb1.Rows.Count == 4)
                {
                    GenerateWordDocument.BaseInfo(tb1, infoGaoKaoCard, infoStudent, Basic.TypeConverter.StrToDateStr(dt.Rows[0]["AddTime"].ToString()));
                }

                //插入图片
                Word.Table tb2 = doc.Tables[2];
                string path = System.Web.HttpContext.Current.Server.MapPath("~/") + ("CePing/ImgOfResult/Holland/") + intStudentId + "_holland.jpg";
                string FileName = path.Replace("\\\\","\\").Replace("/","\\");//@"C:\chart.jpeg";//图片所在路径
                object LinkToFile = false;
                object SaveWithDocument = true;
                object Anchor = tb2.Range;
                doc.Application.ActiveDocument.InlineShapes.AddPicture(FileName, ref LinkToFile, ref SaveWithDocument, ref Anchor);
                //doc.Application.ActiveDocument.InlineShapes[1].Width = 300f;//图片宽度
                //doc.Application.ActiveDocument.InlineShapes[1].Height = 200f;//图片高度

                //object readOnly = false;
                //object isVisible = false;

                //职业兴趣测评分类说明
                Word.Table tb3 = doc.Tables[3];
                if (tb3.Rows.Count == 7)
                {
                    //在指定单元格填值
                    //第2行 现实
                    tb3.Cell(2, 2).Range.Text = intReality.ToString();
                    tb3.Cell(2, 3).Range.Text = GenerateWordDocument.HallondLevel(intReality);
                    //第3行 研究
                    tb3.Cell(3, 2).Range.Text = intStudy.ToString();
                    tb3.Cell(3, 3).Range.Text = GenerateWordDocument.HallondLevel(intStudy);
                    //第4行 艺术
                    tb3.Cell(4, 2).Range.Text = intArt.ToString();
                    tb3.Cell(4, 3).Range.Text = GenerateWordDocument.HallondLevel(intArt);
                    //第5行 社会
                    tb3.Cell(5, 2).Range.Text = intSociety.ToString();
                    tb3.Cell(5, 3).Range.Text = GenerateWordDocument.HallondLevel(intSociety);
                    //第6行 企业
                    tb3.Cell(6, 2).Range.Text = intBusiness.ToString();
                    tb3.Cell(6, 3).Range.Text = GenerateWordDocument.HallondLevel(intBusiness);
                    //第7行 常规
                    tb3.Cell(7, 2).Range.Text = intTradition.ToString();
                    tb3.Cell(7, 3).Range.Text = GenerateWordDocument.HallondLevel(intTradition);
                }


                //模板中 占位符的替换
                Microsoft.Office.Interop.Word.Document oDoc = (Microsoft.Office.Interop.Word.Document)doc;
                JieGuoJieXi();

                //学生姓名
                GenerateWordDocument.ReplaceZF(oDoc, "@studentname", infoStudent.StudentName, Type.Missing);

                //根据你最强的兴趣，可见你的特点是
                GenerateWordDocument.ReplaceZF(oDoc, "@xqlx", strTeDian, Type.Missing);
                //你可能喜欢的专业
                for (int i = 0; i < arrTuiJianZhuanYe.Length; i++)
                {
                    GenerateWordDocument.ReplaceZF(oDoc, "@xihuanzhuanye" + i, arrTuiJianZhuanYe[i], Type.Missing);
                }
                if (arrTuiJianZhuanYe.Length < 6)
                {
                    for (int i = arrTuiJianZhuanYe.Length; i < 6; i++)
                    {
                        GenerateWordDocument.ReplaceZF(oDoc, "@xihuanzhuanye" + i, "", Type.Missing);
                    }
                }

                //不建议选择的专业范围
                for (int i = 0; i < arrBuTuiJianZhuanYe.Length; i++)
                {
                    GenerateWordDocument.ReplaceZF(oDoc, "@buxihuanzhuanye" + i, arrBuTuiJianZhuanYe[i], Type.Missing);
                }
                if (arrBuTuiJianZhuanYe.Length < 6)
                {
                    for (int i = arrBuTuiJianZhuanYe.Length; i < 6; i++)
                    {
                        GenerateWordDocument.ReplaceZF(oDoc, "@buxihuanzhuanye" + i, "", Type.Missing);
                    }
                }

                //保存到服务器
                //保存doc文档
                oDoc.SaveAs(ref fileName, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing,
                ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing,
                ref nothing, ref nothing, ref nothing);
                oDoc.Close(ref nothing, ref nothing, ref nothing);
                app.Quit(ref nothing, ref nothing, ref nothing);

            }
            catch (Exception ex)
            {
                //  resultMsg = "导出错误：" + ex.Message;
                app.Quit(ref nothing, ref nothing, ref nothing);
            }

            #endregion
        }

        //结果解析
        private static void JieGuoJieXi()
        {
            if (intMax == intMin)
            {
                //所有类型得分一样
                strTeDian = "现实型-研究型-艺术型-社会型-企业型-常规型";
                arrTuiJianZhuanYe = new string[] { GenerateWordDocument.HallondZhuanYe(0), GenerateWordDocument.HallondZhuanYe(1), GenerateWordDocument.HallondZhuanYe(2), GenerateWordDocument.HallondZhuanYe(3), GenerateWordDocument.HallondZhuanYe(4), GenerateWordDocument.HallondZhuanYe(5) };
                //最强兴趣特点
                //strTeDian arrTuiJianZhuanYe  arrBuTuiJianZhuanYe = "";
            }
            else
            {
                CountArr();
                int max = -1;
                int min = -1;
              
                if (intArt == intMax)
                {
                    max++;
                    strTeDian = "艺术型";
                    arrTuiJianZhuanYe[max] = GenerateWordDocument.HallondZhuanYe(2);
                }
                else if (intArt == intMin)
                {
                    min++;
                    arrBuTuiJianZhuanYe[min] = GenerateWordDocument.HallondZhuanYe(2);
                }
                if (intBusiness == intMax)
                {
                    max++;
                    strTeDian += "-企业型";
                    arrTuiJianZhuanYe[max] = GenerateWordDocument.HallondZhuanYe(4);
                }
                else if (intBusiness == intMin)
                {
                    min++;
                    arrBuTuiJianZhuanYe[min] = GenerateWordDocument.HallondZhuanYe(4);
                }
                if (intReality == intMax)
                {
                    max++;
                    strTeDian += "-现实型";
                    arrTuiJianZhuanYe[max] = GenerateWordDocument.HallondZhuanYe(0);
                }
                else if (intReality == intMin)
                {
                    min++;
                    arrBuTuiJianZhuanYe[min] = GenerateWordDocument.HallondZhuanYe(0);
                }
                if (intSociety == intMax)
                {
                    max++;
                    strTeDian += "-社会型";
                    arrTuiJianZhuanYe[max] = GenerateWordDocument.HallondZhuanYe(3);
                }
                else if (intSociety == intMin)
                {
                    min++;
                    arrBuTuiJianZhuanYe[min] = GenerateWordDocument.HallondZhuanYe(3);
                }
                if (intStudy == intMax)
                {
                    max++;
                    strTeDian += "-研究型";
                    arrTuiJianZhuanYe[max] = GenerateWordDocument.HallondZhuanYe(1);
                }
                else if (intStudy == intMin)
                {
                    min++;
                    arrBuTuiJianZhuanYe[min] = GenerateWordDocument.HallondZhuanYe(1);
                }
                if (intTradition == intMax)
                {
                    max++;
                    strTeDian += "-常规型";
                    arrTuiJianZhuanYe[max] = GenerateWordDocument.HallondZhuanYe(5);
                }
                else if (intTradition == intMin)
                {
                    min++;
                    arrBuTuiJianZhuanYe[min] = GenerateWordDocument.HallondZhuanYe(5);
                }

                if (strTeDian.StartsWith("-"))
                {
                    strTeDian = strTeDian.Substring(1);
                }
            }
        }

        //结果解析1
        private static void CountArr()
        {
            int max = 0;
            int min = 0;
            if (intArt == intMax)
            {
                max++;
            }
            else if (intArt == intMin)
            {
                min++;
            }
            if (intBusiness == intMax)
            {
                max++;
            }
            else if (intBusiness == intMin)
            {
                min++;
            }
            if (intReality == intMax)
            {
                max++;
            }
            else if (intReality == intMin)
            {
                min++;
            }
            if (intSociety == intMax)
            {
                max++;
            }
            else if (intSociety == intMin)
            {
                min++;
            }
            if (intStudy == intMax)
            {
                max++;
            }
            else if (intStudy == intMin)
            {
                min++;
            }
            if (intTradition == intMax)
            {
                max++;
            }
            else if (intTradition == intMin)
            {
                min++;
            }

            arrTuiJianZhuanYe = new string[max];
            arrBuTuiJianZhuanYe = new string[min];
        }
    }
}
