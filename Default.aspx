<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tweeter</title>
    <link href="css/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:scriptmanager runat="server"></asp:scriptmanager>
    <asp:timer ID="tmrLiveUpdate" runat="server" interval="10000" OnTick="btnVoice_Click"></asp:timer>
    <asp:updatepanel runat="server">
        <ContentTemplate>
            <div id="content">
                <h1 class="bigHeader">Tweeter</h1>
                <asp:TextBox ID="txtHashTag" runat="server" text="#"></asp:TextBox><br />
                <div id="buttons">
                    <asp:button class="button" ID="btnLogin" runat="server" text="Login" OnClick="btnLogin_Click"/><!--
                    --><asp:Button class="button" ID="btnHashToSpeech" runat="server" Text="Chirp" OnClick="btnVoice_Click" />
                </div>
            </div>
            <asp:label ID="lblTest" runat="server" text=""></asp:label>
        </ContentTemplate>
    </asp:updatepanel>
    </form>
</body>
</html>
