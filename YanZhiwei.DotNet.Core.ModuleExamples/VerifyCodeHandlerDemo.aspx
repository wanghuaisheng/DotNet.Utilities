﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerifyCodeHandlerDemo.aspx.cs" Inherits="YanZhiwei.DotNet.Core.ModuleExamples.VerifyCodeHandlerDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type1" onclick="this.src='BuilderVerifyCode.aspx?style=type1&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type2" onclick="this.src='BuilderVerifyCode.aspx?style=type2&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type3" onclick="this.src='BuilderVerifyCode.aspx?style=type3&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type4" onclick="this.src='BuilderVerifyCode.aspx?style=type4&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type5" onclick="this.src='BuilderVerifyCode.aspx?style=type5&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type6" onclick="this.src='BuilderVerifyCode.aspx?style=type6&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type7" onclick="this.src='BuilderVerifyCode.aspx?style=type7&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type8" onclick="this.src='BuilderVerifyCode.aspx?style=type8&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type9" onclick="this.src='BuilderVerifyCode.aspx?style=type9&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type10" onclick="this.src='BuilderVerifyCode.aspx?style=type10&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type11" onclick="this.src='BuilderVerifyCode.aspx?style=type11&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type12" onclick="this.src='BuilderVerifyCode.aspx?style=type12&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type13" onclick="this.src='BuilderVerifyCode.aspx?style=type13&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx?style=type14" onclick="this.src='BuilderVerifyCode.aspx?style=type14&ver='+Math.random()" /><br />
            <img alt="看不清，换一张" src="BuilderVerifyCode.aspx" onclick="this.src='BuilderVerifyCode.aspx?ver='+Math.random()" /><br />
            <%--托管管道模式设置经典--%>
        </div>
    </form>
</body>
</html>
