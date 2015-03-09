<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="Join.Admin.Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>格伦教育</title>
    <link href="/css/frameleft.css" type="text/css" rel="stylesheet">
    <script type="text/javascript" src="http://libs.baidu.com/jquery/1.4.2/jquery.js"></script>
    <script type="text/javascript">
        $(function () {
            $(".subNav").click(function () {
                $(this).toggleClass("currentDd").siblings(".subNav").removeClass("currentDd")
                $(this).toggleClass("currentDt").siblings(".subNav").removeClass("currentDt")

                // 修改数字控制速度， slideUp(500)控制卷起速度
                $(this).next(".navContent").slideToggle(500).siblings(".navContent").slideUp(500);
            })
        })
    </script>
</head>
<body>
    <!-- 代码 开始 -->
    <div class="subNavBox">
        <div class="loginname">
            <span style="display: block;">信息管理</span>
        </div>
        <div class="subNav currentDd currentDt">
            总部通知</div>
        <ul class="navContent " style="display: block">
            <li><a href="http://www.baidu.com/" target="right">总部通知</a></li>
        </ul>
        <div class="subNav">
            项目介绍</div>
        <ul class="navContent">
            <li><a href="#" target="right">高考报考</a></li>
            <li><a href="#" target="right">作文培训</a></li>
            <li><a href="#" target="right">建工培训</a></li>
            <li><a href="#" target="right">在职研究生</a></li>
        </ul>
        <div class="subNav">
            营销管理</div>
        <ul class="navContent">
            <li><a href="#" target="right">项目营销工具</a></li>
            <li><a href="#" target="right">客户管理</a></li>
            <li><a href="#" target="right">代理商管理</a></li>
            <li><a href="#" target="right">会员管理</a></li>
            <li><a href="#" target="right">电子营销工具</a></li>
        </ul>
        <div class="subNav">
            员工管理</div>
        <ul class="navContent">
            <li><a href="#" target="right">店员管理</a></li>
            <li><a href="#" target="right">日报管理</a></li>
            <li><a href="#" target="right">周报管理</a></li>
        </ul>
        <div class="subNav">
            培训管理</div>
        <ul class="navContent">
            <li><a href="#" target="right">培训管理</a></li>
        </ul>
        <div class="subNav">
            订货管理</div>
        <ul class="navContent">
            <li><a href="/Admin/DingHuo/OrdersList.aspx" target="right">订货管理</a></li>
        </ul>
    </div>
</body>
</html>
