<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoticeList.aspx.cs" Inherits="Agency.Agency.Notice.NoticeList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://cdn.bootcss.com/jquery/1.9.0/jquery.js"></script>
    <link href="http://cdn.bootcss.com/bootstrap/2.0.4/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid" style="padding-top: 5px;">
        <ul class="breadcrumb">
            <li>高校管理<span class="divider">/</span>高校列表</li>
        </ul>
        <div class="form-search">
            <div class=" pull-left">
                <div class="controls" style="margin-bottom: 5px;">
                    <input name="txtSchoolName" type="text" id="txtSchoolName" class="span2" placeholder="请输入高校名称..." />
                    <select name="ddlProvince" id="ddlProvince" class="span2">
                        <option value="请选择所在省份">请选择所在省份</option>
                        <option value="1">北京</option>
                        <option value="2">天津</option>
                        <option value="3">河北</option>
                        <option value="4">山西</option>
                        <option value="5">内蒙古</option>
                        <option value="6">辽宁</option>
                        <option value="7">吉林</option>
                        <option value="8">黑龙江</option>
                        <option value="9">上海</option>
                        <option value="10">江苏</option>
                        <option value="11">浙江</option>
                        <option value="12">安徽</option>
                        <option value="13">福建</option>
                        <option value="14">江西</option>
                        <option value="15">山东</option>
                        <option value="16">河南</option>
                        <option value="17">湖北</option>
                        <option value="18">湖南</option>
                        <option value="19">广东</option>
                        <option value="20">广西</option>
                        <option value="21">海南</option>
                        <option value="22">重庆</option>
                        <option value="23">四川</option>
                        <option value="24">贵州</option>
                        <option value="25">云南</option>
                        <option value="26">西藏</option>
                        <option value="27">陕西</option>
                        <option value="28">甘肃</option>
                        <option value="29">青海</option>
                        <option value="30">宁夏</option>
                        <option value="31">新疆</option>
                        <option value="32">港澳台</option>
                    </select>
                    <select name="ddlYuanXiaoLeiXing" id="ddlYuanXiaoLeiXing" class="span2">
                        <option value="请选择院校类型">请选择院校类型</option>
                        <option value="1">综合类</option>
                        <option value="2">理工类</option>
                        <option value="3">农林类</option>
                        <option value="4">医药类</option>
                        <option value="5">师范类</option>
                        <option value="6">语言类</option>
                        <option value="7">财经类</option>
                        <option value="8">政法类</option>
                        <option value="9">体育类</option>
                        <option value="10">艺术类</option>
                        <option value="11">民族类</option>
                        <option value="12">军事类</option>
                        <option value="13">其他</option>
                    </select>
                    <input type="submit" name="btnSearch" value="搜索" id="btnSearch" class="btn" />
                </div>
            </div>
        </div>
        <div class=" clearfix">
        </div>
        <div class=" panel panel-default">
            <div class="panel-heading">
                高考院校列表
            </div>
            <table class="table table-bordered table-hover">
                <thead>
                    <tr>
                        <th>
                            编号
                        </th>
                        <th>
                            学校名称
                        </th>
                        <th>
                            所在地
                        </th>
                        <th>
                            点击次数
                        </th>
                        <th colspan="3" style="text-align: center;">
                            操作
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            1
                        </td>
                        <td>
                            <a href="http://gaokao.gelunjiaoyu.com/daxue-jianjie-1.shtml" target="_blank">北京大学</a>
                        </td>
                        <td>
                            北京
                        </td>
                        <td>
                            <a id="rpt_List_LinkButton2_0" href="javascript:__doPostBack(&#39;rpt_List$ctl00$LinkButton2&#39;,&#39;&#39;)">
                                12382</a>
                        </td>
                        <td>
                            <a onclick="return confirm(&#39;确定删除吗？&#39;);" id="rpt_List_LinkButton1_0" href="javascript:__doPostBack(&#39;rpt_List$ctl00$LinkButton1&#39;,&#39;&#39;)">
                                删除 </a>
                        </td>
                        <td>
                            <a onclick="return confirm(&#39;确定更改状态吗？&#39;);" id="rpt_List_lkbtnPause_0" href="javascript:__doPostBack(&#39;rpt_List$ctl00$lkbtnPause&#39;,&#39;&#39;)">
                                <font style="color: Green;">正常</font></a>
                        </td>
                        <td>
                            <a href="../MainSchool.aspx?schoolid=1">编辑</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            2
                        </td>
                        <td>
                            <a href="http://gaokao.gelunjiaoyu.com/daxue-jianjie-2.shtml" target="_blank">中国人民大学</a>
                        </td>
                        <td>
                            北京
                        </td>
                        <td>
                            <a id="rpt_List_LinkButton2_1" href="javascript:__doPostBack(&#39;rpt_List$ctl01$LinkButton2&#39;,&#39;&#39;)">
                                11532</a>
                        </td>
                        <td>
                            <a onclick="return confirm(&#39;确定删除吗？&#39;);" id="rpt_List_LinkButton1_1" href="javascript:__doPostBack(&#39;rpt_List$ctl01$LinkButton1&#39;,&#39;&#39;)">
                                删除 </a>
                        </td>
                        <td>
                            <a onclick="return confirm(&#39;确定更改状态吗？&#39;);" id="rpt_List_lkbtnPause_1" href="javascript:__doPostBack(&#39;rpt_List$ctl01$lkbtnPause&#39;,&#39;&#39;)">
                                <font style="color: Green;">正常</font></a>
                        </td>
                        <td>
                            <a href="../MainSchool.aspx?schoolid=2">编辑</a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=" pagination-centered pagination">
            <ul>
                <li class="disabled"><a href="School_List.aspx?schoolname=&provinceid=0&yuanxiaoleixing=0&p=1">
                    首页</a></li>
                <li class="cur_page"><a href="School_List.aspx?schoolname=&provinceid=0&yuanxiaoleixing=0&p=1">
                    1</a></li>
                <li><a href="School_List.aspx?schoolname=&provinceid=0&yuanxiaoleixing=0&p=2">2</a></li>
                <li><a href="School_List.aspx?schoolname=&provinceid=0&yuanxiaoleixing=0&p=3">3</a></li>
                <li><a href="School_List.aspx?schoolname=&provinceid=0&yuanxiaoleixing=0&p=4">4</a></li>
                <li class="active"><a href="#">…</a></li>
                <li><a href="School_List.aspx?schoolname=&provinceid=0&yuanxiaoleixing=0&p=130">130</a></li>
                <li><a href="School_List.aspx?schoolname=&provinceid=0&yuanxiaoleixing=0&p=130">尾页</a><li>
            </ul>
        </div>
    </div>
    </form>
</body>
</html>
