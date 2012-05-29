<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="navigation.ascx.cs" Inherits="EmailSite.navigation" %>
  <!-- BEGIN: Primary Navigation -->
<div class="nav-list-wrap">
	<ul class="main-nav" id="navi">
        <li class="mn-nav-prdcts <%=strHomeSelected%>">
        	<a href="home.aspx" class="" id="mainNavHome">Home</a>
		</li>

      	<li class="mn-nav-prdcts <%=strEmailSelected%>">
        	<a href="emails.aspx" class="" id="mainNavEmailMarketing" >
				<span class="ic-emails"></span>Email
            </a>
                        
            <ul>
                <li><a href="createMsg.aspx">Messages</a></li>
                <li><a href="#">Pending messages</a></li>
                <li><a href="#">Autoresponder</a></li>						
			</ul>
          
				
		</li>
        <li class="mn-nav-prdcts <%=strContactSelected%>">
        	<a href="/rnavmap/evaluate.rnav/pidbbGa4P2Yc4B007A81QUR7?activepage=ecampaign.view" class="" id="mainNavEmailMarketing">
				<span class="ic-contacts"></span>Contacts
            </a>
                        
            <ul>
                <li><a href="#">List</a></li>
                <li><a href="#">Add contacts</a></li>
                <li><a href="#">Browse / Search contacts</a></li>
                <li><a href="#">Segments</a></li>		
                           				
			</ul>
          
				
		</li>
        <li class="mn-nav-prdcts <%=strReportSelected%>">
        	<a href="/rnavmap/evaluate.rnav/pidbbGa4P2Yc4B007A81QUR7?activepage=ecampaign.view" class="" id="mainNavEmailMarketing">
				<span class="ic-tracking"></span>Tracking & Reports
            </a>
            <ul>
                <li><a href="#">Last Message</a></li>
                <li><a href="#">Sent Messages</a></li>
                <li><a href="#">Autoresponders</a></li>
				
			</ul>
				
		</li>
                 
                
    </ul>
                
                	
	
<script src="http://jquery-ui.googlecode.com/svn/tags/latest/ui/jquery.effects.core.js" type="text/javascript"></script>

<script type="text/javascript" src="./ui/js/menu.js"></script>
</div>