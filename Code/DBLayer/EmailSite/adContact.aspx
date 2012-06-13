<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adContact.aspx.cs" Inherits="EmailSite.adContact" %>
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
    




    <title>OptMailMarketing : Add Contact</title>	
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
                    <h2>Add One Contact</h2><br/>

                    </div>
                    <div class="create-message-step1-container1">
                    <!--<form id="formID" name="form" class="formular" method="post" action="CreateContact.aspx">-->
                        <span><asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label></span>
                    	<fieldset>
                            <legend>
                                Required fields(*)
                            </legend>
                            <label>
                            	<span>Email : </span>
                                <asp:TextBox ID="txtEmail" CssClass="validate[required] text-input" runat="server"></asp:TextBox>                                
                                Chooses a list to add or invite your contacts to :<br/>    
                                <asp:Repeater ID="rptList" runat="server">                                    
                                    <ItemTemplate>
                                        <input class="validate[minCheckbox[1]] checkbox" type="checkbox" name="listContact" id="listContact" value="<%#Eval("ID")%>" />
                                        <span class="checkbox"><%#Eval("LISTNAME")%></span><br/>                                        
                                    </ItemTemplate>
                                </asp:Repeater>

                            </label>
                         </fieldset>   
	                    
                        
                        
                        <fieldset>
                            <legend>
                                Optional fields
                            </legend>
                            
                            
                                <table width="400" cellpadding="0">
                                	<tr>
                                    	<td><span>Prefix</span><asp:TextBox ID="txtPrefix" CssClass="text-prefix" runat="server"></asp:TextBox></td>
                                    	<td><span>Last Name</span><asp:TextBox ID="txtLastname" CssClass="text-lastname" runat="server"></asp:TextBox></td>
                                    	<td><span>First Name</span><asp:TextBox ID="txtFirstname" CssClass="text-firstname" runat="server"></asp:TextBox></td>
                                    	<td><span>Suffix</span><asp:TextBox ID="txtSuffix" CssClass="text-suffix" runat="server"></asp:TextBox></td>
                                    </tr>
                                </table>
                                <span>Address 1 : </span>
                                <asp:TextBox ID="txtAddr1" CssClass="text-input" runat="server"></asp:TextBox>                                
                                <span>Address 2 : </span>
                                <asp:TextBox ID="txtAddr2" CssClass="text-input" runat="server"></asp:TextBox>
                                <table width="300">
                                	<tr>
                                    	<td width="40%"><span>City</span><asp:TextBox ID="txtCity" CssClass="text-city" runat="server"></asp:TextBox></td>
                                    	<td width="40%"><span>State or Province</span><asp:TextBox ID="txtState" CssClass="text-state" runat="server"></asp:TextBox></td>
                                    	<td width="20%"><span>Zip</span><asp:TextBox ID="txtZip" CssClass="text-zip" runat="server"></asp:TextBox></td>
                                    	                                                                                                                      
                                    </tr>
                                </table>
                                <table width="300">
                                	<tr>
                                    	<td><span>Business Name</span><asp:TextBox ID="txtBusinessname" CssClass="text-businessname" runat="server"></asp:TextBox></td>
                                    	<td><span>Phone</span><asp:TextBox ID="txtPhone" CssClass="text-phone" runat="server"></asp:TextBox></td>
                                    	<td><span>Fax</span><asp:TextBox ID="txtFax" CssClass="text-fax" runat="server"></asp:TextBox></td>
                                    	                                                                                                                      
                                    </tr>
                                </table>
                                 <asp:CheckBox ID="chkAgree" runat="server" CssClass="checkbox" 
                                Checked="True" />                                
                                 <span class="checkbox">Require confirmation<br/>If checked, contacts are not added until you compose and send the confirmation-request email (steps follow). To confirm their subscription, contacts must click the link the confirmation-request email contains.</span>
                                
                                <asp:Button ID="btnAdd" CssClass="submit" runat="server" Text="Add Contact" 
                                onclick="btnAdd_Click" /> 	
								
                        </fieldset>
                                        
                        
                        
                        
						
						
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
	
    	
	</form>
	</body>
</html>
