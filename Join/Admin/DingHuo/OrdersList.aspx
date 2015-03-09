<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdersList.aspx.cs" Inherits="Join.Admin.DingHuo.OrdersList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>订单列表</title>
    <script src="/js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script type="text/javascript" src="http://cdn.bootcss.com/jquery/1.9.0/jquery.js"></script>
    <script src="/js/layer-v1.8.5/layer/layer.min.js" type="text/javascript"></script>
    <link href="http://cdn.bootcss.com/bootstrap/2.0.4/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/css/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $('#addhuowuorder').click(function () {
                $.layer({
                    type: 2,
                    shade: [0.5, '#b3b3b3'],
                    shadeClose: true,
                    fix: false,
                    title: 'iframe子父操作',
                    maxmin: true,
                    iframe: { src: 'OrdersList.aspx' },
                    area: ['800px', '440px'],
//                    close: function (index) {
//                        layer.msg('您获得了子窗口标记：' + layer.getChildFrame('#name', index).val(), 3, 1);
//                    }
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid" style="padding-top: 5px;">
        <ul class="breadcrumb" style="margin: 0 0 10px;">
            <li>订货管理<span class="divider">/</span>订单列表</li>
        </ul>
        <div style="background-color: #f5f5f5; float: left; width: 100%; padding: 10px 0;">
            <input type="button" value="增加货物订单" id="addhuowuorder" class="btn " />
            <input type="button" value="增加服务类订单" id="addfuwuorder" class="btn " />
            <input type="button" value="修改" id="edit" class="btn " />
            <input type="button" value="取消订单" id="cancel" class="btn " />
        </div>
        <div class=" clearfix">
        </div>
        <div style="float: left; width: 100%; padding: 5px 0;">
            <asp:DropDownList ID="ddlMaterialType" runat="server" class="span2">
                <asp:ListItem Value="0">订单种类</asp:ListItem>
                <asp:ListItem Value="1">货物类</asp:ListItem>
                <asp:ListItem Value="2">服务类</asp:ListItem>
            </asp:DropDownList>
            <input type="text" id="txtOrderMonth" class="span2" placeholder="订单月份..." onclick="WdatePicker({dateFmt:'yyyy-MM'})" />
            <asp:DropDownList ID="ddlOrderState" runat="server" class="span2">
                <asp:ListItem Value="0">订单状态</asp:ListItem>
                <asp:ListItem Value="1">未确认</asp:ListItem>
                <asp:ListItem Value="2">已确认</asp:ListItem>
                <asp:ListItem Value="3">有欠款</asp:ListItem>
                <asp:ListItem Value="4">已付全款</asp:ListItem>
                <asp:ListItem Value="5">已完结</asp:ListItem>
                <asp:ListItem Value="6">已取消</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class=" clearfix">
        </div>
        <div class=" panel panel-default">
            <%--  <div class="panel-heading">
                高考院校列表
            </div>--%>
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
