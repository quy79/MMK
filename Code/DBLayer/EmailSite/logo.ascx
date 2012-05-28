<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="logo.ascx.cs" Inherits="EmailSite.logo" %>
<div id="header">  
	<div id="logo">
		<a href="">
            <img src="./img/logo.jpg" border="0"/>
		</a>
	</div>
    <div class="header-right">
		<div class="topbar">
			<a href="editProfile.aspx">My Account</a>&nbsp;&nbsp;|&nbsp;&nbsp;
			<a href="javascript:showHelp();">Help</a>&nbsp;&nbsp;|&nbsp;&nbsp;
            <a id="header_logout" href="logout.aspx">Log Out</a>
		</div>
	</div>
    <div class="welcome">Welcome to OptMailMarketting,
        &nbsp;<span id="header_contact_firstname"><asp:Label ID="lblUsername" runat="server" Text="Label"></asp:Label></span>!</div>
</div>
            