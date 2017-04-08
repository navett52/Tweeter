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
                        <asp:TextBox ID="txtMsg" runat="server"></asp:TextBox><br />    
                          <asp:Button ID="btVoice" runat="server"   
                            Text="convert to speech" onclick="btnVoice_Click" />    

    </div>
    </form>
</body>
</html>
