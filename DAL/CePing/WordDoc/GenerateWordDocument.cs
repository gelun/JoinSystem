using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DAL.CePing.WordDoc
{

    public static class GenerateWordDocument
    {
        //填充学生报告的基本信息
        public static Microsoft.Office.Interop.Word.Table BaseInfo(Microsoft.Office.Interop.Word.Table tb1, Entity.GaoKaoCard infoGaoKaoCard, Entity.Join_Student infoStudent,string strCePingTime)
        {
            string strProvinceName = "";
            Entity.S_Province infoProvince = DAL.S_Province.S_ProvinceEntityGet(infoStudent.ProvinceId);
            if (infoProvince!=null)
            {
                strProvinceName = infoProvince.ProvinceName;
            }

            if (tb1.Rows.Count == 4)
            {
                //在指定单元格填值
                //第1行
                tb1.Cell(1, 2).Range.Text = infoStudent.StudentName;
                tb1.Cell(1, 4).Range.Text = (infoStudent.Sex == 1 ? "女" : "男");
                //第2行
                tb1.Cell(2, 2).Range.Text = infoStudent.SchoolName;
                tb1.Cell(2, 4).Range.Text = (infoStudent.WenLi == 1 ? "文史" : "理工");
                //第3行
                tb1.Cell(3, 2).Range.Text = strProvinceName;
                tb1.Cell(3, 4).Range.Text = infoStudent.GKYear.ToString();
                //第4行
                tb1.Cell(4, 2).Range.Text = infoGaoKaoCard.KaHao;
                tb1.Cell(4, 4).Range.Text = strCePingTime;
            }
            return tb1;
        }


        //替换字符
        public static void ReplaceZF(Microsoft.Office.Interop.Word.Document oDoc, object FindText, object ReplaceWith, object MissingValue)
        {
            //wdReplaceAll - 替换找到的所有项。 
            //wdReplaceNone - 不替换找到的任何项。 
            //wdReplaceOne - 替换找到的第一项。 
            object Replace = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
            //移除Find的搜索文本和段落格式设置 
            oDoc.Content.Find.ClearFormatting();

            oDoc.Content.Find.Execute(ref FindText, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue, ref ReplaceWith, ref Replace, ref MissingValue, ref MissingValue, ref MissingValue, ref MissingValue);
        }

        //输出word
        public static void ExtWord(string fileName, string wordname)
        {
            //输出word
            System.IO.FileInfo file = new System.IO.FileInfo(fileName);
            System.Web.HttpContext.Current.Response.Clear();
            System.Web.HttpContext.Current.Response.Charset = "utf-8";
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
            // 添加头信息，为"文件下载/另存为"对话框指定默认文件名 
            System.Web.HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(wordname, System.Text.Encoding.UTF8));
            // 添加头信息，指定文件大小，让浏览器能够显示下载进度 
            System.Web.HttpContext.Current.Response.AddHeader("Content-Length", file.Length.ToString());

            // 指定返回的是一个不能被客户端读取的流，必须被下载 
            System.Web.HttpContext.Current.Response.ContentType = "application/ms-word";

            // 把文件流发送到客户端 
            System.Web.HttpContext.Current.Response.WriteFile(file.FullName);
            // 停止页面的执行 
            //HttpContext.Current.ApplicationInstance.CompleteRequest
            System.Web.HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        #region 职业能力 Ability

        //根据分值获取职业能力测评等级
        public static string AbilityLevel(int intFenShu)
        {
            switch (intFenShu)
            {
                case 1:
                    return "弱";
                case 2:
                    return "较弱";
                case 3:
                    return "一般";
                case 4:
                    return "较强";
                case 5:
                    return "强";
                default:
                    return "";
            }
        }

        //各个职业能力对应的专业
        public static string AbilityZhuanYe(int intIndex)
        {
            switch (intIndex)
            {
                case 0://言语能力
                    return "文学（中国语言文学类，外国语言文学类，新闻传播学类）；教育学（教育学类）艺术学（戏剧与影视学类）";
                case 1://数理能力
                    return "经济学（经济学类，财政学类，金融学类，经济与贸易类）；理学（数学类，物理学类，物理学类，天文学类，地球物理学类，心理学类，统计学类）；工学（力学类、机械类，仪器类，材料类，能源动力类，电气类，电子信息类，自动化类，计算机类，土木类，水利类，测绘类，航空航天类，兵器类，核工程类，安全科学与工程类，公安技术类）；管理学（工商管理类，管理科学与工程类）";
                case 2://空间判断能力
                    return "理学（数学类、物理学类、地球物理学类）；工学（土木类，水利类，测绘类，建筑类）；艺术学（设计学类）";
                case 3://察觉细节能力
                    return "教育学（教育学类）；经济学（经济学类，财政学类，金融学类，经济与贸易类）；工学（土木类，水利类，测绘类，建筑类）；艺术学（设计学类）；管理学（工商管理类，管理科学与工程类）";
                case 4://书写能力
                    return "教育学（教育学类）；经济学（经济学类，财政学类，金融学类，经济与贸易类）；管理学（工商管理类，管理科学与工程类）";
                case 5://运动协调能力
                    return "教育学（体育学类）；医学（临床医学类，口腔医学类，护理学类）";
                case 6://动手能力
                    return "医学（临床医学类，口腔医学类，护理学类）；工学（力学类、机械类，仪器类，材料类，测绘类，化工与制药类，地质类，矿业类，纺织类，轻工类，农业工程类，林业工程类，生物医学工程类，食品医学工程类，建筑类、航空航天类，兵器类，核工程类，安全科学与工程类，生物工程类，公安技术类）";
                case 7://社会交往能力
                    return "教育学（教育学类、体育学类）；法学（社会学类，法学，政治学类）；文学（中国语言文学类，外国语言文学类，新闻传播学类）；管理学（工商管理类，管理科学与工程类，公共管理类）";
                case 8://组织管理能力
                    return "管理学（工商管理类，管理科学与工程类，公共管理类）";
                default:
                    return "";
            }
        }

        #endregion

        #region 职业兴趣  Hallond

        //根据分值获取职业能力测评等级
        public static string HallondLevel(int intFenShu)
        {
            if (intFenShu <= 5)
            {
                return "较低";
            }
            else if (intFenShu <= 10)
            {
                return "一般";
            }
            else
            {
                return "较高";
            }
        }

        //各个类型能力对应的专业
        public static string HallondZhuanYe(int intIndex)
        {
            switch (intIndex)
            {
                case 0://实际型（R）  现实
                    return "工学（机械类、仪器仪表、材料类、能源动力类、电气类、自动化类、计算机类、土木类、测绘类、地质类、矿业类、纺织类、轻工类、交通运输类、建筑类等）";//
                case 1://调研型（I）  研究
                    return "理学（数学类，物理学类，化学类，天文学类，地理科学类，大气科学类，海洋科学类，地球物理学类，地质学类，生物科学类，心理学类，统计学类）、经济学（经济学类，财政学类，金融学类，经济与贸易类）、法学（法学类）、教育学（教育学类）、医学（基础医学、中医学、药学）";//
                case 2://艺术型（A）艺术
                    return "艺术类（音乐与舞蹈学类、戏剧与影视学类、美术学类、设计学类）、工学（纺织类、建筑类、工业设计）";//
                case 3://社会型（S）社会
                    return "教育学（教育学类、体育学类）， 法学（社会学类，法学，政治学类、民族学类、马克思主义理论类、公安学类），文学（中国语言文学类，外国语言文学类，新闻传播学类），理学（心理学类）， 医学（护理学类）， 管理学（工商管理类、公共管理类、旅游管理类）， 经济学（经济学类，财政学类，金融学类，经济与贸易类）";//理科学与工程类）";
                case 4://企业型（E） 企业
                    return "管理学（工商管理类、公共管理类、物流管理与工程等） 法学（法学类、公安学类）  经济学（经济学类，财政学类，金融学类，经济与贸易类）";//
                case 5://常规型（C）  常规
                    return "管理类（工商管理类:会计学、审计学、人力资源管理，图书情报与档案管理类、物流管理与工程类、工业工程类等）  医学类（中医学类、中药学类）";//
                default:
                    return "";
            }
        }

        #endregion


        #region 职业性格  MBTI

        //各个类型能力对应的专业
        public static string MBTIZhuanYe(string strXingGeLeiXing)
        {
            switch (strXingGeLeiXing)
            {

                case "ISTJ"://ISTJ 检查员型
                    return "管理学（工商管理类、图书管理类、物流管理类、工业工程类等），法学（法学类、公安学类）";//
                case "ISFJ"://ISFJ照顾者型
                    return "教育学（教育学类、体育学类），理学（心理学类），医学（护理学类）";//
                case "INFJ"://INFJ博爱型
                    return "管理学（工商管理类、公共管理类），法学（社会学类），教育学(教育学类)，理学（心理学类），艺术学（艺术学理论类，音乐与舞蹈学类，戏剧与影视学类，美术学类，设计学类）文学（中国语言文学类，外国语言文学类，新闻传播学类）";//
                case "INTJ"://INTJ专家型
                    return "理学（数学类，物理学类，化学类，天文学类，地理科学类，大气科学类，海洋科学类，地球物理学类，地质学类，生物科学类，心理学类，统计学类）、工学（计算机类）、法学（法学类、社会学类）、管理学（工商管理类、工业工程类）、医学（基础医学类，临床医学类，口腔医学类，公共卫生与预防医学类，中医学类，中西医结合类，药学类，中药学类，法医学类，医学技术类）";//
                case "ISTP"://ISTP 冒险家型
                    return "经济学（经济学类，财政学类，金融学类，经济与贸易类）、工学（机械类，仪器类，材料类，能源动力类，电气类，电子信息类，自动化类，计算机类，交通运输类，海洋工程类，航空航天类，兵器类，核工程类，安全科学与工程类）、农学（植物生产类，自然保护与环境生态类，动物生产类，动物医学类，林学类，水产类，草学类）、法学（法学类）";//
                case "ISFP"://ISFP艺术家型
                    return "理学（心理学类），医学（护理学类），教育学（教育学类），文学（中国语言文学类，外国语言文学类，新闻传播学类），艺术学（艺术学理论类，音乐与舞蹈学类，戏剧与影视学类，美术学类，设计学类）";//
                case "INFP"://INFP哲学家型
                    return "管理学（工商管理类、公共管理类），法学（社会学类），教育学（教育学类），理学（心理学类），文学（中国语言文学类，新闻传播学类），哲学（哲学类，逻辑学类，宗教学类），艺术学（设计学类）";//
                case "INTP"://INTP学者型
                    return "理学（数学类，物理学类，化学类，天文学类，地理科学类，大气科学类，海洋科学类，地球物理学类，地质学类，生物科学类，心理学类，统计学类）、经济学（经济学类，金融学类、财政学类）、法学（法学类）";//
                case "ESTP"://ESTP挑战者型
                    return "管理学（工商管理类市场营销方向）、法学（法学类、公安学类）、工学（力学类、机械类，仪器类，材料类，能源动力类，电气类，电子信息类，自动化类，计算机类，土木类，水利类，测绘类，化工与制药类，地质类，矿业类，纺织类，轻工类，农业工程类，林业工程类，环境科学与工程，生物医学工程类，食品医学工程类，建筑类、交通运输类，海洋工程类，航空航天类，兵器类，核工程类，安全科学与工程类，生物工程类，公安技术类）";//
                case "ESFP"://•	ESFP表演者型
                    return "理学（心理学类），医学（护理学类），教育学（教育学类特别是学前教育），法学（社会学类）";//
                case "ENFP"://•	ENFP 公关型
                    return "管理学（工商管理类、公共管理类），法学（社会学类），教育学（教育学类），理学（心理学类），艺术学（艺术学理论类，音乐与舞蹈学类，戏剧与影视学类，美术学类，设计学类）";//
                case "ENTP"://•	ENTP 智多星型
                    return "经济学（经济学类，财政学类，金融学类，经济与贸易类）；管理学（工商管理类，管理科学与工程类，农业经济管理类，公共管理类，图书情报与档案管理类，电子商务类，旅游管理类）；理学（数学类，物理学类，化学类，天文学类，地理科学类，大气科学类，海洋科学类，地球物理学类，地质学类，生物科学类，心理学类，统计学类）；工学（力学类、机械类，仪器类，材料类，能源动力类，电气类，计算机类，土木类，水利类，测绘类，化工与制药类，建筑类、交通运输类，兵器类，核工程类，安全科学与工程类，生物工程类，公安技术类）";//


                case "ESTJ"://•	•	ESTJ管家型
                    return "工学（力学类、机械类，仪器类，材料类，能源动力类，电气类，电子信息类，自动化类，计算机类，土木类，水利类，测绘类，化工与制药类，地质类，矿业类，纺织类，轻工类，农业工程类，林业工程类，环境科学与工程，生物医学工程类，食品医学工程类，建筑类、交通运输类，海洋工程类，航空航天类，兵器类，核工程类，安全科学与工程类，生物工程类，公安技术类）、管理学（工商管理市场营销方向，公共管理类），法学（法学类、公安学类）";//
                case "ESFJ"://•	•	ESFJ 主人型
                    return "管理学（公共管理类）、教育学（教育学类）、理学（心理学类），医学（护理学类）、法学（社会学类）";//
                case "ENFJ"://•	•	ENFJ教导型
                    return "教育学（教育学类、体育学类），法学（政治学类、社会学类等），管理学（公共管理类、旅游管理类、工商管理类人力资源方向）";//
                case "ENTJ"://•	•	•	ENTJ统帅型
                    return "经济学（经济学类，财政学类，金融学类，经济与贸易类），管理学（工商管理类，公共管理类，管理科学与工程类），法学（政治学类）";//
                default:
                    return "";
            }
        }

        //各个类型能力对应的职业
        public static string MBTIZhiYe(string strXingGeLeiXing)
        {
            switch (strXingGeLeiXing)
            {
                case "ISTJ"://ISTJ 检查员型
                    return "管理者、行政管理、执法者、会计，或者其他可以让他们用自己的经验和对细节的注意完成任务的职业";//
                case "ISFJ"://ISFJ照顾者型
                    return "教育、健康护理（生理、心理），或者其他能够让他们运用自己的经验亲力亲为帮助别人的职业，这种帮助是协助或辅助性。";//
                case "INFJ"://INFJ博爱型
                    return "咨询服务（包括个人、社会、心理等），教学、教导，艺术，或者其他能够促进他们情感、智力或精神发展的职业";//
                case "INTJ"://INTJ专家型
                    return "科学或技术领域，计算机、法律，或者其他能够让他们运用智力创造和技术知识去构思、分析和完成任务的职业。";//
                case "ISTP"://ISTP 冒险家型
                    return "熟练工种、技术领域 、农业、执法者、军人，或者其他能够让他们动手操作、分析数据或事情的职业。";//
                case "ISFP"://ISFP艺术家型
                    return "健康护理（包括生理、心理），商业，执法者，或者其他能够让他们运用友善、专注于细节的相关服务的职业。";//
                case "INFP"://INFP哲学家型
                    return "咨询服务（个人、社会、心理），写作，艺术，或者其他能够让他们创造和集中于他们价值观的职业。";//
                case "INTP"://INTP学者型
                    return "科学或技术领域，或者其他能够让他们基于自己的专业技术知识独立客观分析问题的职业。";//
                case "ESTP"://ESTP挑战者型
                    return "市场、熟练工种、商业、执法者、应用技术，或者其他能够让他们用行动关注必要细节的职业。";//
                case "ESFP"://•	ESFP表演者型
                    return "健康护理（心理、生理），教育、教导，教练，儿童保育，熟练工种，或者其他能够让他们利用外向的天性和热情去帮助那些有实际需要的人们的职业。";//
                case "ENFP"://•	ENFP 公关型
                    return "咨询服务（个人、社会、心理），教学、教导，宗教，艺术，或者其他人能够让他们用创造和交流去帮助促进他人成长的职业。";//
                case "ENTP"://•	ENTP 智多星型
                    return "科学，管理者，技术，艺术，或者其他能够让他们有机会不断有机会承担新挑战的工作。";//


                case "ESTJ"://•	•	ESTJ管家型
                    return "管理者、行政管理、执法者，或者其他能够让他们运用对事实的逻辑和组织完成任务的职业。";//
                case "ESFJ"://•	•	ESFJ 主人型
                    return "教育、健康护理（包括生理、心理），或者其他能够让他们运用个人关怀为他人提供服务的行业。";//
                case "ENFJ"://•	•	ENFJ教导型
                    return "宗教，艺术，教学、教导，或者其他能够让他们帮助别人在情感、智力和精神上成长的职业。";//
                case "ENTJ"://•	•	•	ENTJ统帅型
                    return "领导者，管理者，或者其他能够让他们运用实际分析、战略计划和组织完成任务的职业。";//
                default:
                    return "";
            }
        }

        //性格类型
        public static string MBTILeiXing(string strXingGeLeiXing)
        {
            switch (strXingGeLeiXing)
            {
                case "ISTJ"://ISTJ 检查员型
                    return "ISTJ 检查员型";//
                case "ISFJ"://ISFJ 照顾者型
                    return "ISFJ 照顾者型";//
                case "INFJ"://INFJ 博爱型
                    return "INFJ 博爱型";//
                case "INTJ"://INTJ专家型
                    return "INTJ 专家型";//
                case "ISTP"://ISTP 冒险家型
                    return "ISTP 冒险家型";//
                case "ISFP"://ISFP 艺术家型
                    return "ISFP 艺术家型";//
                case "INFP"://INFP 哲学家型
                    return "INFP 哲学家型";//
                case "INTP"://INTP 学者型
                    return "INTP 学者型";//
                case "ESTP"://ESTP 挑战者型
                    return "ESTP 挑战者型";//
                case "ESFP"://ESFP 表演者型
                    return "ESFP 表演者型";//
                case "ENFP"://ENFP 公关型
                    return "ENFP 公关型";//
                case "ENTP"://ENTP 智多星型
                    return "ENTP 智多星型";//
                case "ESTJ"://ESTJ 管家型
                    return "ESTJ 管家型";//
                case "ESFJ"://ESFJ 主人型
                    return "ESFJ 主人型";//
                case "ENFJ"://ENFJ 教导型
                    return "ENFJ 教导型";//
                case "ENTJ"://ENTJ 统帅型
                    return "ENTJ 统帅型";//
                default:
                    return "";
            }
        }


        //性格的解释
        public static string MBTILeiXingJieXi(string strXingGeLeiXing)
        {
            switch (strXingGeLeiXing)
            {
                case "ISTJ"://ISTJ 检查员型
                    return "1.严肃、安静、藉由集中心 志与全力投入、及可被信赖获致成功。2.行事务实、有序、实际 、 逻辑、真实及可信赖3.十分留意且乐于任何事（工作、居家、生活均有良好组织及有序。4.负责任。5.照设定成效来作出决策且不畏阻挠与闲言会坚定为之。6.重视传统与忠诚。7.传统性的思考者或经理。";//
                case "ISFJ"://ISFJ 照顾者型
                    return "1.安静、和善、负责任且有良心。2.行事尽责投入。3.安定性高，常居项目工作或团体之安定力量。4.愿投入、吃苦及力求精确。5.兴趣通常不在于科技方面。对细节事务有耐心。6.忠诚、考虑周到、知性且会关切他人感受。7.致力于创构有序及和谐的工作与家庭环境。";//
                case "INFJ"://INFJ 博爱型
                    return "1.因为坚忍、创意及必须达成的意图而能成功。2.会在工作中投注最大的努力。3.默默强力的、诚挚的及用心的关切他人。4.因坚守原则而受敬重。5.提出造福大众利益的明确远景而为人所尊敬与追随。6.追求创见、关系及物质财物的意义及关联。7.想了解什么能激励别人及对他人具洞察力。8.光明正大且坚信其价值观。9.有组织且果断地履行其愿景。";//
                case "INTJ"://INTJ专家型
                    return "1.具强大动力与本意来达成目的与创意—固执顽固者。2.有宏大的愿景且能快速在众多外界事件中找出有意义的模范。3.对所承负职务，具良好能力于策划工作并完成。4.具怀疑心、挑剔性、独立性、果决，对专业水准及绩效要求高。";//
                case "ISTP"://ISTP 冒险家型
                    return "1.冷静旁观者—安静、预留余地、弹性及会以无偏见的好奇心与未预期原始的幽默观察与分析。2.有兴趣于探索原因及效果，技术事件是为何及如何运作且使用逻辑的原理组构事实、重视效能。3.擅长于掌握问题核心及找出解决方式。4.分析成事的缘由且能实时由大量资料中找出实际问题的核心。";//
                case "ISFP"://ISFP 艺术家型
                    return "1.羞怯的、安宁和善地、敏感的、亲切的、且行事谦虚。2.喜于避开争论，不对他人强加已见或价值观。3.无意于领导却常是忠诚的追随者。4.办事不急躁，安于现状无意于以过度的急切或努力破坏现况，且非成果导向。5.喜欢有自有的空间及照自订的时程办事。";//
                case "INFP"://INFP 哲学家型
                    return "1安静观察者，具理想性与对其价值观及重要之人具忠诚心。2.希外在生活形态与内在价值观相吻合。3.具好奇心且很快能看出机会所在。常担负开发创意的触媒者。4.除非价值观受侵犯，行事会具弹性、适应力高且承受力强。5.具想了解及发展他人潜能的企图。想作太多且作事全神贯注。6.对所处境遇及拥有不太在意。7.具适应力、有弹性除非价值观受到威胁。";//
                case "INTP"://INTP 学者型
                    return "1.安静、自持、弹性及具适应力。2.特别喜爱追求理论与科学事理。3.习于以逻辑及分析来解决问题—问题解决者。4.最有兴趣于创意事务及特定工作，对聚会与闲聊无大兴趣。5.追求可发挥个人强烈兴趣的生涯。6.追求发展对有兴趣事务之逻辑解释。";//
                case "ESTP"://ESTP 挑战者型
                    return "1.擅长现场实时解决问题—解决问题者。2.喜欢办事并乐于其中及过程。3.倾向于喜好技术事务及运动，交结同好友人。4.具适应性、容忍度、务实性；投注心力于会很快具成效工作。5.不喜欢冗长概念的解释及理论。6.最专精于可操作、处理、分解或组合的真实事务。";//
                case "ESFP"://ESFP 表演者型
                    return "1.外向、和善、接受性、乐于分享喜乐予他人。2.喜欢与他人一起行动且促成事件发生，在学习时亦然。3.知晓事件未来的发展并会热列参与。5.最擅长于人际相处能力及具备完备常识，很有弹性能立即适应他人与环境。6.对生命、人、物质享受的热爱者。";//
                case "ENFP"://ENFP 公关型
                    return "1.充满热忱、活力充沛、聪明的、富想象力的，视生命充满机会但期能得自他人肯定与支持。2.几乎能达成所有有兴趣的事。3.对难题很快就有对策并能对有困难的人施予援手。4.依赖能改善的能力而无须预作规划准备。5.为达目的常能找出强制自己为之的理由。6.即兴执行者。";//
                case "ENTP"://ENTP 智多星型
                    return "1.反应快、聪明、长于多样事务。2.具激励伙伴、敏捷及直言讳专长。3.会为了有趣对问题的两面加予争辩。4.对解决新及挑战性的问题富有策略，但会轻忽或厌烦经常的任务与细节。5.兴趣多元，易倾向于转移至新生的兴趣。6.对所想要的会有技巧地找出逻辑的理由。7.长于看清础他人，有智能去解决新或有挑战的问题";//
                case "ESTJ"://ESTJ 管家型
                    return "1.务实、真实、事实倾向，具企业或技术天份。2.不喜欢抽象理论；最喜欢学习可立即运用事理。3.喜好组织与管理活动且专注以最有效率方式行事以达致成效。4.具决断力、关注细节且很快作出决策—优秀行政者。5.会忽略他人感受。6.喜作领导者或企业主管。";//
                case "ESFJ"://ESFJ 主人型
                    return "1.诚挚、爱说话、合作性高、受欢迎、光明正大 的—天生的合作者及活跃的组织成员。2.重和谐且长于创造和谐。3.常作对他人有益事务。4.给予鼓励及称许会有更佳工作成效。5.最有兴趣于会直接及有形影响人们生活的事务。6.喜欢与他人共事去精确且准时地完成工作。";//
                case "ENFJ"://ENFJ 教导型
                    return "1.热忱、易感应及负责任的--具能鼓励他人的领导风格。2.对别人所想或希求会表达真正关切且切实用心去处理。3.能怡然且技巧性地带领团体讨论或演示文稿提案。4.爱交际、受欢迎极富同情心。5.对称许及批评很在意。6.喜欢带引别人且能使别人或团体发挥潜能。";//
                case "ENTJ"://ENTJ 统帅型
                    return "1.坦诚、具决策力的活动领导者。2.长于发展与实施广泛的系统以解决组织的问题。3.专精于具内涵与智能的谈话如对公众演讲。4.乐于经常吸收新知且能广开信息管道。5.易生过度自信，会强于表达自已创见。6.喜于长程策划及目标设定。";//
                default:
                    return "";
            }
        }
        #endregion



        #region 职业价值观  Profession

        //职业价值观名称
        public static string ProfessionName(int[] list, int[] list2,bool ZuiDa)
        {
            string[] arrGroup = { "利他主义", "美感", "智力刺激", "成就感", "独立性", "社会地位", "管理", "经济报酬", "社会交际"
                                , "安全感", "舒适", "人际关系", "变异性"};

            string strList = "";
            if (ZuiDa)
            {

                #region 最大值
                for (int i = 0; i < list2.Length; i++)
                {
                    if (list2[i] == list[12])
                    {
                        strList += arrGroup[i] + "-";
                    }
                }
                #endregion
            }
            else
            {
                #region 最小值
                for (int i = 0; i < list2.Length; i++)
                {
                    if (list2[i] == list[0])
                    {
                        strList += arrGroup[i] + "-";
                    }
                }
                #endregion
            }

            if (strList.EndsWith("-"))
            {
                strList = strList.Substring(0, strList.Length - 1);
            }

            return strList;
        }

        static int[] RemoveAgain(int[] nums)
        {
            //nums2为中间过渡容器，先将数据放进去
            List<int> nums2 = new List<int>();
            //比较变量
            int lastNum = 0;
            //遍历数组
            for (int i = 0; i < nums.Length; i++)
            {
                //如果数组和前面一个不重复，加入过渡容器
                if (nums[i] != lastNum)
                {
                    nums2.Add(nums[i]);
                }
                //修改比较变量
                lastNum = nums[i];
            }
            //最终返回的数组
            int[] nums3 = new int[nums2.Count];
            //将中间过渡容器中内容放回最终数组中
            for (int i = 0; i < nums2.Count; i++)
            {
                nums3[i] = nums2[i];
            }
            return nums3;
        }

        #endregion
    }
}
