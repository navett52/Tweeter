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
            <asp:TextBox id="hashtags" ID="txtHashTag" runat="server"></asp:TextBox><br />
            <div id="buttons">
                <asp:button runat="server" text="Button" />
                <asp:Button ID="btnHashToSpeech" runat="server" Text="Chirp" OnClick="btnVoice_Click" />
            </div>
            
        </div>
    </form>
</body>
</html>
