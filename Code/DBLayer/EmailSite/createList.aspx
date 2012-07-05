<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createList.aspx.cs" Inherits="EmailSite.createList" %>
<%@ Register src="logo.ascx" tagname="logo" tagprefix="uc1" %>
<%@ Register src="navigation.ascx" tagname="navigation" tagprefix="uc2" %>
<%@ Register src="headerHTML.ascx" tagname="headerHTML" tagprefix="uc3" %>
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


	<script src="./ui/js/jquery-1.7.2.js" type="text/javascript" charset="utf-8"></script>
	<script src="./ui/js/jquery.ValidationEngine-en.js" type="text/javascript" charset="utf-8"></script>
	<script src="./ui/js/jquery.ValidationEngine.js" type="text/javascript" charset="utf-8"></script>
    
    
        
    
	<script>
	    jQuery(document).ready(function () {
	        // binds form submission and fields to the validation engine
	        jQuery("#formID").validationEngine();

	        jQuery("#sm").click(function () {
	            document.forms["form"].submit();
	        });


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
    




    <title>OptMailMarketing : Create List</title>	
	</head>

	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form id="formID" name="form" class="formular" runat="server">
    <div id="main">
	    <div class="page-container">
        	<uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="contacts" runat="server" />

            <div id="content-main">
            
            	<div id="emails-common-panel">

                	<div class="common-title">
                    <h2>Create a new List</h2>
                    </div>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <div class="create-message-step1-container1">
                    <br/>
                        
                        
           	 		<!--<form id="formID" name="form" class="formular" method="post" action="CreateList.aspx">-->
                        <span>List name : </span><br/>
                        <asp:TextBox ID="txtName" CssClass="validate[required] text-input" runat="server"></asp:TextBox>
                        <br/>
						<span>List description : </span><br/>
                        <asp:TextBox ID="txtDesc" CssClass="validate[required] text-input" 
                            runat="server" TextMode="MultiLine"></asp:TextBox>

						<br/>
                        <label>                        
                      <!--  <asp:CheckBox ID="chkAgree" Checked="true" runat="server" />
                        <span class="checkbox">Send me email notifications when contacts are added to or removed from this list.</span> -->
                        

                        </label>
						<br/>
                        <!--
                        <a class="button" id="sm" href="#"><span>Save</span></a>
                        <a class="button" href="#"><span>Cancel</span></a>
                        -->
                        
                        <asp:Button ID="btnSave" CssClass="submit1" runat="server" Text="Save" 
                            onclick="btnSave_Click" />
                        <!--<input type="button" value="Cancel"/>&nbsp;&nbsp;-->
                      

						
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
</div>
            
          
            
    	</div>
	</div>
	

	        
		<!--
		<ul id="menu">
			<li>
		    <a href="">Home</a></li> 
		    <li><a href=""><img src="img/emails.gif"/>&nbsp;&nbsp;Emails</a> 
		      <ul>

		      	<li><a href="">Create new message</a></li>
		        <li><a href="">Sent mssages</a></li> 
		        <li><a href="">Pending messages</a></li> 
		      </ul> 
		    </li> 
		    <li><a href=""><img src="img/contacts.gif"/>&nbsp;&nbsp;Contacts List</a> 
		      <ul> 
		        <li><a href="">Create new list</a></li> 
		        <li><a href="">Browse contacts</a></li> 
		      </ul> 
		    </li>

		    <li><a href="">Tracking & Report</a> 
		      <ul> 
		        <li><a href="">Tracking last message</a></li> 
		        <li><a href="">Autoresponders</a></li> 
		      </ul> 
		    </li> 
		</ul>	
		-->
	</form>
	</body>
</html>
