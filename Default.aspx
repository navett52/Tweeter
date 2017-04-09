<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tweeter</title>
    <link href="css/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <%--<asp:Timer ID="tmrLiveUpdate" Enabled="false" runat="server" Interval="60000" OnTick="btnVoice_Click"></asp:Timer>--%>
                <div id="content">
                    <h1 class="bigHeader">Tweeter</h1>
                    <asp:TextBox ID="txtHashTag" runat="server" Text="#"></asp:TextBox><br />
                    <div id="buttons">
                        <asp:Button class="button" ID="btnLogin" runat="server" Text="Clear" OnClick="btnLogin_Click" /><!--
                    --><asp:Button class="button" ID="btnHashToSpeech" runat="server" Text="Chirp" OnClick="btnVoice_Click" />
                        <asp:Button class="button" ID="btnLatestTweet" runat="server" Text="Latest Tweet!" OnClick="btnLatestTweet_Click" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
    <%--<script type="text/javascript">
        document.getElementById("btnHashToSpeech").onclick = refresh;
        function refresh() {
            var timer = setInterval(clickRefresh, 20000);
            function clickRefresh() {
                //document.getElementById("btnLogin").click();
                document.getElementById("btnHashToSpeech").click();
            }
        }
    </script>--%>
</body>
</html>
