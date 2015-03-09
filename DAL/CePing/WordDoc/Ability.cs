using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Svg;
using System.Data;
using Word = Microsoft.Office.Interop.Word;

namespace DAL.CePing.WordDoc
{
    public static class Ability
    {
        private static int intYanYu = 0, intShuLi = 0, intKongJianPanDuan = 0, intChaJueXiJie = 0, intShuXie = 0,
            intYunDongXieTiao = 0, intDongShou = 0, intSheHuiJiaoWang = 0, intZuZhiGuanLi = 0;

        private static int[] list;
        private static int intMax = 0;//最大值
        private static int intMin = 0;//最小值
        //可能感兴趣专业
        private static string[] arrTuiJianZhuanYe;
        //不推荐专业
        private static string[] arrBuTuiJianZhuanYe;


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
            object fileName = System.Web.HttpContext.Current.Server.MapPath("~/") + "CePing/WordOfResult/Ability/" + infoGaoKaoCard.KaHao + "(" + infoStudent.StudentName + "_" + intStudentId + ")" + "_职业能力测评.doc";//获取服务器路径
            //判定文件是否已经存在了
            if (Basic.Utils.FileExists(fileName.ToString()))
                return;


            //读取模板文件
            object temp = System.Web.HttpContext.Current.Server.MapPath("~/CePing/WordTemplet/TempletOfAbility.doc");//读取模板文件


            #region 基本信息处理
            DataTable dt = DAL.Join_AbilityResults.Join_AbilityResultsList("UserId=" + intStudentId); //获取该学生的测试结果
            if (dt != null && dt.Rows.Count > 0)
            {

                string Language = dt.Rows[0]["Language"].ToString();
                string Tissue = dt.Rows[0]["Tissue"].ToString();
                string Among = dt.Rows[0]["Among"].ToString();
                string Mathematics = dt.Rows[0]["Mathematics"].ToString();
                string Motion = dt.Rows[0]["Motion"].ToString();
                string Writing = dt.Rows[0]["Writing"].ToString();
                string Watch = dt.Rows[0]["Watch"].ToString();
                string Space = dt.Rows[0]["Space"].ToString();
                string Art = dt.Rows[0]["Art"].ToString();
                //各能力得分
                intYanYu = Basic.TypeConverter.StrToInt(Language);
                intShuLi = Basic.TypeConverter.StrToInt(Tissue);
                intKongJianPanDuan = Basic.TypeConverter.StrToInt(Among);
                intChaJueXiJie = Basic.TypeConverter.StrToInt(Mathematics);
                intShuXie = Basic.TypeConverter.StrToInt(Motion);
                intYunDongXieTiao = Basic.TypeConverter.StrToInt(Writing);
                intDongShou = Basic.TypeConverter.StrToInt(Watch);
                intSheHuiJiaoWang = Basic.TypeConverter.StrToInt(Space);
                intZuZhiGuanLi = Basic.TypeConverter.StrToInt(Art);
            }
            else
            {
                return;
            }

            //创建数组，通过冒泡排序得到最大值和最小值
            list = new int[] { intYanYu, intShuLi, intKongJianPanDuan, intChaJueXiJie, intShuXie, intYunDongXieTiao, intDongShou, intSheHuiJiaoWang, intZuZhiGuanLi };
            DAL.Comm.BubbleSortUp(list);
            intMax = list[8];//最大值
            intMin = list[0];//最小值

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
                if (tb2.Rows.Count == 10)
                {
                    //在指定单元格填值
                    //第2行 言语能力
                    tb2.Cell(2, 2).Range.Text = intYanYu.ToString();
                    tb2.Cell(2, 3).Range.Text = GenerateWordDocument.AbilityLevel(intYanYu);
                    //第3行 数理能力
                    tb2.Cell(3, 2).Range.Text = intShuLi.ToString();
                    tb2.Cell(3, 3).Range.Text = GenerateWordDocument.AbilityLevel(intShuLi);
                    //第4行 空间判断能力
                    tb2.Cell(4, 2).Range.Text = intKongJianPanDuan.ToString();
                    tb2.Cell(4, 3).Range.Text = GenerateWordDocument.AbilityLevel(intKongJianPanDuan);
                    //第5行 察觉细节能力
                    tb2.Cell(5, 2).Range.Text = intChaJueXiJie.ToString();
                    tb2.Cell(5, 3).Range.Text = GenerateWordDocument.AbilityLevel(intChaJueXiJie);
                    //第6行 书写能力
                    tb2.Cell(6, 2).Range.Text = intShuXie.ToString();
                    tb2.Cell(6, 3).Range.Text = GenerateWordDocument.AbilityLevel(intShuXie);
                    //第7行 运动协调能力
                    tb2.Cell(7, 2).Range.Text = intYunDongXieTiao.ToString();
                    tb2.Cell(7, 3).Range.Text = GenerateWordDocument.AbilityLevel(intYunDongXieTiao);
                    //第8行 动手能力
                    tb2.Cell(8, 2).Range.Text = intDongShou.ToString();
                    tb2.Cell(8, 3).Range.Text = GenerateWordDocument.AbilityLevel(intDongShou);
                    //第9行 社会交往能力
                    tb2.Cell(9, 2).Range.Text = intSheHuiJiaoWang.ToString();
                    tb2.Cell(9, 3).Range.Text = GenerateWordDocument.AbilityLevel(intSheHuiJiaoWang);
                    //第10行 组织管理能力
                    tb2.Cell(10, 2).Range.Text = intZuZhiGuanLi.ToString();
                    tb2.Cell(10, 3).Range.Text = GenerateWordDocument.AbilityLevel(intZuZhiGuanLi);
                }
                #endregion


                //
                #region 模板中 占位符的替换

                Microsoft.Office.Interop.Word.Document oDoc = (Microsoft.Office.Interop.Word.Document)doc;
                JieGuoJieXi();

                //学生姓名
                GenerateWordDocument.ReplaceZF(oDoc, "@studentname", infoStudent.StudentName, Type.Missing);

                //你可能喜欢的专业
                for (int i = 0; i < arrTuiJianZhuanYe.Length; i++)
                {
                    GenerateWordDocument.ReplaceZF(oDoc, "@xihuanzhuanye" + i, arrTuiJianZhuanYe[i], Type.Missing);
                }
                if (arrTuiJianZhuanYe.Length < 9)
                {
                    for (int i = arrTuiJianZhuanYe.Length; i < 9; i++)
                    {
                        GenerateWordDocument.ReplaceZF(oDoc, "@xihuanzhuanye" + i, "", Type.Missing);
                    }
                }

                //不建议选择的专业范围
                for (int i = 0; i < arrBuTuiJianZhuanYe.Length; i++)
                {
                    GenerateWordDocument.ReplaceZF(oDoc, "@buxihuanzhuanye" + i, arrBuTuiJianZhuanYe[i], Type.Missing);
                }
                if (arrBuTuiJianZhuanYe.Length < 9)
                {
                    for (int i = arrBuTuiJianZhuanYe.Length; i < 9; i++)
                    {
                        GenerateWordDocument.ReplaceZF(oDoc, "@buxihuanzhuanye" + i, "", Type.Missing);
                    }
                }

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

        //结果解析
        private static void JieGuoJieXi()
        {
            if (intMax == intMin)
            {
                //所有能力得分一样
                arrTuiJianZhuanYe = new string[9];
                for (int i = 0; i < 9; i++)
                {
                    arrTuiJianZhuanYe[i] = GenerateWordDocument.AbilityZhuanYe(i);
                }
            }
            else
            {
                CountArr();
                int max = -1;
                int min = -1;
                if (intYanYu == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(0);
                }
                else if (intYanYu == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(0);
                }
                if (intShuLi == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(1);
                }
                else if (intShuLi == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(1);
                }
                if (intKongJianPanDuan == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(2);
                }
                else if (intKongJianPanDuan == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(2);
                }
                if (intChaJueXiJie == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(3);
                }
                else if (intChaJueXiJie == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(3);
                }
                if (intShuXie == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(4);
                }
                else if (intShuXie == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(4);
                }
                if (intYunDongXieTiao == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(5);
                }
                else if (intYunDongXieTiao == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(5);
                }
                if (intDongShou == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(6);
                }
                else if (intDongShou == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(6);
                }
                if (intSheHuiJiaoWang == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(7);
                }
                else if (intSheHuiJiaoWang == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(7);
                }
                if (intZuZhiGuanLi == intMax)
                {
                    max++;
                    arrBuTuiJianZhuanYe[max] = GenerateWordDocument.AbilityZhuanYe(8);
                }
                else if (intZuZhiGuanLi == intMin)
                {
                    min++;
                    arrTuiJianZhuanYe[min] = GenerateWordDocument.AbilityZhuanYe(8);
                }
            }
        }
        //结果解析1
        private static void CountArr()
        {
            int max = 0;
            int min = 0;
            if (intYanYu == intMax)
            {
                max++;
            }
            else if (intYanYu == intMin)
            {
                min++;
            }
            if (intShuLi == intMax)
            {
                max++;
            }
            else if (intShuLi == intMin)
            {
                min++;
            }
            if (intKongJianPanDuan == intMax)
            {
                max++;
            }
            else if (intKongJianPanDuan == intMin)
            {
                min++;
            }
            if (intChaJueXiJie == intMax)
            {
                max++;
            }
            else if (intChaJueXiJie == intMin)
            {
                min++;
            }
            if (intShuXie == intMax)
            {
                max++;
            }
            else if (intShuXie == intMin)
            {
                min++;
            }
            if (intYunDongXieTiao == intMax)
            {
                max++;
            }
            else if (intYunDongXieTiao == intMin)
            {
                min++;
            }
            if (intDongShou == intMax)
            {
                max++;
            }
            else if (intDongShou == intMin)
            {
                min++;
            }
            if (intSheHuiJiaoWang == intMax)
            {
                max++;
            }
            else if (intSheHuiJiaoWang == intMin)
            {
                min++;
            }
            if (intZuZhiGuanLi == intMax)
            {
                max++;
            }
            else if (intZuZhiGuanLi == intMin)
            {
                min++;
            }

            arrTuiJianZhuanYe = new string[min];
            arrBuTuiJianZhuanYe = new string[max];
        }
    }
}
