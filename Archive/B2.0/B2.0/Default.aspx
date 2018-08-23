<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="B2._0.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=ArchitectsDaughter"/>
	    <link href="./CSS/BasemENT2dot0.css" type="text/css" rel="stylesheet"/>
	    <title> BasemENT 2dot0</title>
    </head>
    <body>
        <div id="container">
        <form id="form1" runat="server">
            <div id="logo">
		    <center><img src="./Images/B20NeuHiraleonNewFont.png"/></center>
		    </div>
            <div id="navi">	
               <center>
			            <li><asp:LinkButton ID="homeBtn" runat="server" OnClick ="homeBtn_Click">Home</asp:LinkButton></li>
			            <li><asp:LinkButton ID="aboutBtn" runat="server" OnClick="aboutBtn_Click">About Us</asp:LinkButton></li>
			            <li><asp:LinkButton ID="projectsBtn" runat="server" OnClick="projectsBtn_Click">Games</asp:LinkButton></li>
			            <li><asp:LinkButton ID="faqBtn" runat="server" OnClick="faqBtn_Click">FAQs</asp:LinkButton></li>
			            <li><asp:LinkButton ID="contactBtn" runat="server" OnClick="contactBtn_Click">Contact Us</asp:LinkButton></li>
                   <li><asp:LinkButton ID="donateBtn" runat="server" OnClick="donateBtn_Click">Donate</asp:LinkButton></li>
	          </center> 
            </div>
            <center>
                <div class="content">
		                    <p>
			                <asp:Label ID="contentLabel" runat="server" OnLoad="Page_Load" Font-Underline="False"></asp:Label>
                            </p>
                </div>
            </center>
                <footer>
                <p> FB Icon</p>
            </footer>
        </form>
            </div>
    </body>
</html>
