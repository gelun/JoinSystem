<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Join.Agency.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html;charset=utf-8" />
    <title>格伦咨询中心管理系统</title>
    <meta http-equiv="x-ua-compatible" content="ie=7" />
    <script type="text/javascript" src="http://libs.baidu.com/jquery/1.4.2/jquery.js"></script>
    <script type="text/javascript">
        function changeDisplayMode() {
            if (document.getElementById("bottomframes").cols == "175,7,*") {
                document.getElementById("bottomframes").cols = "0,7,*";
                document.getElementById("separator").contentWindow.document.getElementById('ImgArrow').src = "/images/separator2.gif"
            } else {
                document.getElementById("bottomframes").cols = "175,7,*"
                document.getElementById("separator").contentWindow.document.getElementById('ImgArrow').src = "/images/separator1.gif"
            }
        }
    </script>
</head>
<frameset id="mainframes" framespacing="0" border="false" rows="45,*" frameborder="0"
    scrolling="yes">
    <frame name="top" scrolling="no" src="Top.aspx">
    <frameset id="bottomframes" framespacing="0" border="false" cols="175,7,*" frameborder="0"
        scrolling="yes">
        <frame name="left" id="left" scrolling="auto" runat="server" marginwidth="0" marginheight="0" src="left.aspx"
            noresize />
        <frame id="separator" name="separator" src="separator.html" noresize scrolling="no" />
        <frame name="right" id="right" scrolling="auto" src="main.aspx">
    </frameset>
</frameset>
</html>
