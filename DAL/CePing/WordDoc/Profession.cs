using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Svg;
using System.Data;
using Word = Microsoft.Office.Interop.Word;

namespace DAL.CePing.WordDoc
{
    public static class Profession
    {
        private static int intGroup1 = 0, intGroup2 = 0, intGroup3 = 0, intGroup4 = 0, intGroup5 = 0, intGroup6 = 0, intGroup7 = 0,
            intGroup8 = 0, intGroup9 = 0, intGroup10 = 0, intGroup11 = 0, intGroup12 = 0, intGroup13 = 0;

        private static int[] list;

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
            object fileName = System.Web.HttpContext.Current.Server.MapPath("~/") + "CePing/WordOfResult/Profession/" + infoGaoKaoCard.KaHao + "(" + infoStudent.StudentName + "_" + intStudentId + ")" + "_职业价值观测评.doc";//获取服务器路径
            //判定文件是否已经存在了
            if (Basic.Utils.FileExists(fileName.ToString()))
                return;


            //读取模板文件
            object temp = System.Web.HttpContext.Current.Server.MapPath("~/CePing/WordTemplet/TempletOfProfession.doc");//读取模板文件


            #region 基本信息处理
            DataTable dt = DAL.Join_ProfessionResults.Join_ProfessionResultsList("UserId=" + intStudentId); //获取该学生的测试结果
            if (dt != null && dt.Rows.Count > 0)
            {
                intGroup1 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group1"].ToString());
                intGroup2 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group2"].ToString());
                intGroup3 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group3"].ToString());
                intGroup4 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group4"].ToString());
                intGroup5 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group5"].ToString());
                intGroup6 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group6"].ToString());
                intGroup7 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group7"].ToString());
                intGroup8 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group8"].ToString());
                intGroup9 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group9"].ToString());
                intGroup10 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group10"].ToString());
                intGroup11 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group11"].ToString());
                intGroup12 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group12"].ToString());
                intGroup13 = Basic.TypeConverter.StrToInt(dt.Rows[0]["Group13"].ToString());
            }
            else
            {
                return;
            }

            //创建数组，通过冒泡排序得到最大值和最小值
            list = new int[] { intGroup1, intGroup2, intGroup3, intGroup4, intGroup5, intGroup6, intGroup7, intGroup8, intGroup9, intGroup10, intGroup11, intGroup12, intGroup13 };

            int[] list2 = new int[] { intGroup1, intGroup2, intGroup3, intGroup4, intGroup5, intGroup6, intGroup7, intGroup8, intGroup9, intGroup10, intGroup11, intGroup12, intGroup13 };

            DAL.Comm.BubbleSortUp(list);

            #endregion


            Word._Application app = new Word.Application();
            //表示System.Type信息中的缺少值
            object nothing = Type.Missing;
            try
            {

                //建立一个基于摸版的文档
                Word._Document doc = app.Documents.Add(ref temp, ref nothing, ref nothing, ref nothing);
                //
                #region 填充学生基本信息

                Word.Table tb1 = doc.Tables[1];
                if (tb1.Rows.Count == 4)
                {
                    GenerateWordDocument.BaseInfo(tb1, infoGaoKaoCard, infoStudent, Basic.TypeConverter.StrToDateStr(dt.Rows[0]["AddTime"].ToString()));
                }

                #endregion

                //
                #region 职业兴趣测评结果:各能力得分、评级
                Word.Table tb2 = doc.Tables[2];
                if (tb2.Rows.Count == 14)
                {
                    //在指定单元格填值
                    //第2行
                    tb2.Cell(2, 2).Range.Text = intGroup1.ToString();
                    //第3行
                    tb2.Cell(3, 2).Range.Text = intGroup2.ToString();
                    //第4行
                    tb2.Cell(4, 2).Range.Text = intGroup3.ToString();
                    //第5行 
                    tb2.Cell(5, 2).Range.Text = intGroup4.ToString();
                    //第6行 
                    tb2.Cell(6, 2).Range.Text = intGroup5.ToString();
                    //第7行 
                    tb2.Cell(7, 2).Range.Text = intGroup6.ToString();
                    //第8行 
                    tb2.Cell(8, 2).Range.Text = intGroup7.ToString();
                    //第9行 
                    tb2.Cell(9, 2).Range.Text = intGroup8.ToString();
                    //第10行 
                    tb2.Cell(10, 2).Range.Text = intGroup9.ToString();
                    //第11行 
                    tb2.Cell(11, 2).Range.Text = intGroup10.ToString();
                    //第12行 
                    tb2.Cell(12, 2).Range.Text = intGroup11.ToString();
                    //第13行 
                    tb2.Cell(13, 2).Range.Text = intGroup12.ToString();
                    //第14行 
                    tb2.Cell(14, 2).Range.Text = intGroup13.ToString();
                }
                #endregion


                //
                #region 模板中 占位符的替换

                Microsoft.Office.Interop.Word.Document oDoc = (Microsoft.Office.Interop.Word.Document)doc;

                // //学生姓名
                // GenerateWordDocument.ReplaceZF(oDoc, "@studentname", infoStudent.StudentName, Type.Missing);

                //你可能喜欢的专业
                string strKZJZ = "";
                GenerateWordDocument.ReplaceZF(oDoc, "@kzjz", GenerateWordDocument.ProfessionName(list, list2, true), Type.Missing);

                //不建议选择的专业范围
                GenerateWordDocument.ReplaceZF(oDoc, "@bkzjz", GenerateWordDocument.ProfessionName(list, list2, false), Type.Missing);

                #endregion

                //
                #region 保存到服务器

                //保存doc文档
                oDoc.SaveAs(ref fileName, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing,
                ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing,
                ref nothing, ref nothing, ref nothing);
                oDoc.Close(ref nothing, ref nothing, ref nothing);
                app.Quit(ref nothing, ref nothing, ref nothing);

                //输出word 到客户端
                //   GenerateWordDocument.ExtWord(fileName.ToString(), "ts.doc");

                #endregion
            }
            catch (Exception ex)
            {
                //  resultMsg = "导出错误：" + ex.Message;
                app.Quit(ref nothing, ref nothing, ref nothing);
            }
        }
    }
}
