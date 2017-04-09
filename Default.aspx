<%-- Arbitrary Change --%>


<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="twitterUser" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="hashTag" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnHashToSpeech" runat="server" Text="Read off Hashtags" OnClick="btnVoice_Click" />
        </div>
    </form>
</body>
</html>
