﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createAutoTextEmail.aspx.cs" Inherits="EmailSite.createAutoTextEmail" %>
<%@ Register src="headerHTML.ascx" tagname="headerHTML" tagprefix="uc3" %>
<%@ Register src="logo.ascx" tagname="logo" tagprefix="uc1" %>
<%@ Register src="navigation.ascx" tagname="navigation" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta HTTP-EQUIV="X-Roving-Page-Generated" CONTENT="Fri May 11 00:40:11 EDT 2012">
<meta name="Generator" content="CCTiles">
<meta HTTP-EQUIV="Cache-Control" Content="no-cache">
<meta HTTP-EQUIV="Pragma" Content="no-cache">
<meta HTTP-EQUIV="Expires" Content="-1">
<meta HTTP-EQUIV="no-cache">
<meta NAME="robots" CONTENT="noindex,nofollow">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
        
<link href="./ui/css/main.css" media="all" rel="stylesheet" type="text/css"/>
<link href="./ui/css/layout.css" media="all" rel="stylesheet" type="text/css"/>


<link rel="stylesheet" href="./ui/css/globalFormStyle.css" type="text/css"/>
<link rel="stylesheet" href="./ui/css/template.css" type="text/css"/>
<link rel="stylesheet" href="./ui/css/dlg.css" type="text/css"/>
<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>
<link rel="stylesheet" href="./ui/css/ui.all.css" type="text/css" media="screen" />



<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script src="./ui/js/jquery.ValidationEngine-en.js" type="text/javascript" charset="utf-8"></script>
<script src="./ui/js/jquery.ValidationEngine.js" type="text/javascript" charset="utf-8"></script>

<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"></script>
<script src="./ui/js/dlg.js" type="text/javascript" charset="utf-8"></script>
    
    
        
    
	<script>
	    jQuery(document).ready(function () {
	        // binds form submission and fields to the validation engine
	        jQuery("#formID").validationEngine();

	    });

	</script>
    
    
<!--navigation dropdown menu-->

<link rel="stylesheet" href="./ui/css/menu.css" type="text/css" />
 	<!--[if lt IE 8]>
		<script src ="http://ie7-js.googlecode.com/svn/version/2.1(beta2)/IE8.js"></script>
	<![endif]-->	

       
       
 

        
	<style type="text/css">

		ul {
			font-family: Arial, Verdana;
			font-size: 14px;
			margin: 0;
			padding: 0;
			list-style: none;
		}
		ul li {
			display: block;
			position: relative;
			float: left;
			width: auto;
			height: auto;
			
		}
		li ul { display: none; }
		ul li a {
			display: block;
			text-decoration: none;
			color: #000000;
			border-top: 1px solid #ffffff;			
			padding: 0px 5px 0px 5px;			
			background:url(img/navbg_off.gif) top left;
			margin-left: 1px;
			white-space: nowrap;
		}
		
		ul li a:hover { background:url(img/navbg_on.gif) top left; }
		li:hover ul { 
			display: block; 
			position: absolute;
		}
		li:hover li { 
			float: none;
			font-size: 11px;
		}
		


	</style>	
    




    <title>OptMailMarketing : Home</title>	
	</head>
	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form id="formID" class="formular" runat="server">
    <div id="main">
	    <div class="page-container">
        	  <uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="emails" runat="server" />
            
            <div id="content-main">
            
            	<div id="emails-common-panel">

                	<div class="common-title">
                    <h2>Create an Autoresonder Message for "<%=strListName%>"</h2>
                    </div>  
                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                     
                    <div class="create-message-step1-container1">
                    <br/>
           	 		<!--<form id="formID" class="formular" method="post" action="">-->
                        <span>From Email Address : </span><br/>
                        <asp:TextBox ID="txtFromEmail" CssClass="validate[required,custom[email]] text-input" runat="server"></asp:TextBox>
                        <br/>
                        <span>Email Subject : </span><br/>
                        <asp:TextBox ID="txtSubject" CssClass="validate[required] text-input" runat="server"></asp:TextBox>
                        <br/>
						<span>Message Name : <br/>
                        (not displayed to yours contacts)                 
                        </span><br/>
                        <asp:TextBox ID="txtMsgName" CssClass="validate[required] text-input" runat="server"></asp:TextBox><br/>
		                <asp:TextBox ID="txtMsgBody" CssClass="validate[required] text-input" 
                            runat="server" TextMode="MultiLine"></asp:TextBox>
						

						<div style="position: relative; float: left; margin-top: 20px; width: 400px;">                        	
                            <asp:Button ID="btnSpam" CssClass="button" runat="server" Text="Spam Check" 
                                onclick="btnSpam_Click" />                                                        

                            <asp:HiddenField ID="hdAutoID" runat="server" />

                            <asp:HiddenField ID="hdMsgID" runat="server" />

                            </div>                       
                        
                        <asp:Button ID="btnSubmit" CssClass="submit1" runat="server" 
                            Text="Save and Preview" onclick="btnSubmit_Click" />
                        <!--
                        <div class="buttonwrapper">
<a class="boldbuttons" href="http://www.dynamicdrive.com/style/"><span>Spam Check</span></a>
<span>&nbsp;&nbsp;&nbsp;</span><a class="boldbuttons" href="http://www.dynamicdrive.com/style/"><span>Send Test Message</span></a>
</div>-->
                    </div>
					<!--</form>-->
                    
                    


                        

						                        
                  </div>

                	              
                </div>
                
                
                
                

            
            </div>     
            <!-- BEGIN: Footer -->
			<div id="footer">
            
            </div>
            
            <div class="copyright">Copyright © 2012 Optlynx, Inc.</div>
            




        
        


    
    </div>

    
</form>
	</body>
</html>