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
    public static class MBTI
    {
        private static int E = 0, I = 0, S = 0, N = 0, T = 0, F = 0, J = 0, P = 0;//

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
            object fileName = System.Web.HttpContext.Current.Server.MapPath("~/") + "CePing/WordOfResult/MBTI/" + infoGaoKaoCard.KaHao + "(" + infoStudent.StudentName + "_" + intStudentId + ")" + "_职业性格测评.doc";//获取服务器路径
            //判定文件是否已经存在了
            if (Basic.Utils.FileExists(fileName.ToString()))
                return;
            //读取模板文件
            object temp = System.Web.HttpContext.Current.Server.MapPath("~/CePing/WordTemplet/TempletOfMBTI.doc");//读取模板文件



            #region 基本信息处理

            DataTable dt = DAL.Join_MbtiResults.Join_MbtiResultsList("StudentId = " + intStudentId);
            if (dt != null && dt.Rows.Count > 0)
            {
                E = Basic.TypeConverter.StrToInt(dt.Rows[0]["E"].ToString(), 0);
                I = Basic.TypeConverter.StrToInt(dt.Rows[0]["I"].ToString(), 0);
                S = Basic.TypeConverter.StrToInt(dt.Rows[0]["S"].ToString(), 0);
                N = Basic.TypeConverter.StrToInt(dt.Rows[0]["N"].ToString(), 0);
                T = Basic.TypeConverter.StrToInt(dt.Rows[0]["T"].ToString(), 0);
                F = Basic.TypeConverter.StrToInt(dt.Rows[0]["F"].ToString(), 0);
                J = Basic.TypeConverter.StrToInt(dt.Rows[0]["J"].ToString(), 0);
                P = Basic.TypeConverter.StrToInt(dt.Rows[0]["P"].ToString(), 0);
            }
            else
            {
                return;
            }

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
                string path = System.Web.HttpContext.Current.Server.MapPath("~/") + ("CePing/ImgOfResult/MBTI/") + intStudentId + "_mbti.jpg";
                string FileName = path.Replace("\\\\", "\\").Replace("/", "\\");//@"C:\chart.jpeg";//图片所在路径
                object LinkToFile = false;
                object SaveWithDocument = true;
                object Anchor = tb2.Range;
                doc.Application.ActiveDocument.InlineShapes.AddPicture(FileName, ref LinkToFile, ref SaveWithDocument, ref Anchor);

                //模板中 占位符的替换
                Microsoft.Office.Interop.Word.Document oDoc = (Microsoft.Office.Interop.Word.Document)doc;
                //学生姓名
                GenerateWordDocument.ReplaceZF(oDoc, "@studentname", infoStudent.StudentName, Type.Missing);

                //特征解析
                GenerateWordDocument.ReplaceZF(oDoc, "@xgtzjx", GenerateWordDocument.MBTILeiXingJieXi(reGeLeiXing().ToUpper()), Type.Missing);
                
                //根据你最强的兴趣，可见你的特点是
                GenerateWordDocument.ReplaceZF(oDoc, "@xgtz", GenerateWordDocument.MBTILeiXing(reGeLeiXing().ToUpper()), Type.Missing);

                //你可能喜欢的专业
                GenerateWordDocument.ReplaceZF(oDoc, "@xihuanzhuanye", GenerateWordDocument.MBTIZhuanYe(reGeLeiXing().ToUpper()), Type.Missing);

                //你可能喜欢的职业
                GenerateWordDocument.ReplaceZF(oDoc, "@xihuanzhiye", GenerateWordDocument.MBTIZhiYe(reGeLeiXing().ToUpper()), Type.Missing);

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
        private static string reGeLeiXing()
        {
            //创建人格类型
            string[] renge = new string[4];
            if (E > I)
            {
                renge[0] = "E";
            }
            else
            {
                renge[0] = "I";
            }

            if (S > N)
            {
                renge[1] = "S";
            }
            else
            {
                renge[1] = "N";
            }

            if (T > F)
            {
                renge[2] = "T";
            }
            else
            {
                renge[2] = "F";
            }

            if (J > P)
            {
                renge[3] = "J";
            }
            else
            {
                renge[3] = "P";
            }

            //人格类型
            string reGeLeiXing = "";
            foreach (string st in renge)
            {
                reGeLeiXing += st;

            }

            return reGeLeiXing;
        }
    }
}
