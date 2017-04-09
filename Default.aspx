<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tweeter</title>
    <link href="css/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="content">
            <h1 class="bigHeader">Tweeter</h1>
            <asp:TextBox ID="txtHashTag" runat="server" text="#"></asp:TextBox><br />
            <div id="buttons">
                <asp:button class="button" runat="server" text="Login" /><!--
                --><asp:Button class="button" ID="btnHashToSpeech" runat="server" Text="Chirp" OnClick="btnVoice_Click" />
            </div>
            
        </div>
    </form>
</body>
</html>
