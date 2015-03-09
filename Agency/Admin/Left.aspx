<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="Agency.Left" %>

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

	<div class="subNav currentDd currentDt">信息管理</div>
	<ul class="navContent " style="display:block">
			<li><a href="http://www.baidu.com/" target="right">内容管理</a></li>
			<li><a href="#">栏目管理</a></li>
			<li><a href="#">内容管理</a></li>
			<li><a href="#">栏目管理</a></li>
            <li><a href="#">栏目管理</a></li>
	</ul>
	<div class="subNav">信息管理</div>
	<ul class="navContent">
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
	</ul>
	<div class="subNav">信息管理</div>
	<ul class="navContent">
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
	</ul>
	<div class="subNav">信息管理</div>
	<ul class="navContent">
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
	</ul>
    <div class="subNav">信息管理</div>
	<ul class="navContent">
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
	</ul>
    <div class="subNav">信息管理</div>
	<ul class="navContent">
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
	</ul>
    <div class="subNav">信息管理</div>
	<ul class="navContent">
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
	</ul>
    <div class="subNav">信息管理</div>
	<ul class="navContent">
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
			<li><a href="#">添加新闻</a></li>
			<li><a href="#">新闻管理</a></li>
	</ul>
</div>

</div>
</body>
</html>