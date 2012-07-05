<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createAutoTemplateEmail.aspx.cs" Inherits="EmailSite.createAutoTemplateEmail" %>
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


<script src="./ui/js/thumbnailPreview.js" type="text/javascript"></script>
    
    
        
    
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
		
		
		.tip {font:10px/12px
                    Arial,Helvetica,sans-serif; border:solid 1px
                    #666666; width:50px; padding:1px;
                    position:absolute; z-index:100;
                    visibility:hidden; color:#333333; top:20px;
                    left:90px; background-color:#ffffcc;
                    layer-background-color:#ffffcc;}


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
                    <div class="create-message-step1-container3">
                    	<span><br/>Please select the template you would like to use :</span><br/><br/>
                    	<table class="email_templates">
                        	<tr>
                            	<td width="33%">
                                	<div class="template-box">
                                    <a href="createAutoTemplateEmail2.aspx?tempID=1&Aid=<%=strAutoresponderID %>" onMouseOver="doTooltip(event, 'template1/images/tpl_thumbnail')" onMouseOut="hideTip()">
                                    	<img src="./templates/template1/images/tpl_thumbnail.jpg"  alt="Template #001" border="0" width="200" height="192" />
                                        </a>
                                    </div>
                                </td>
                                <td width="34%">
                                	<div class="template-box">
                                    <a href="createAutoTemplateEmail2.aspx?tempID=2&Aid=<%=strAutoresponderID %>" onMouseOver="doTooltip(event, 'template2/images/tmpl_thumbnail')" onMouseOut="hideTip()">
                                    	<img src="./templates/template2/images/tmpl_thumbnail.jpg"  alt="Template #002" border="0" width="200" height="192" />
                                        </a>
                                    	
                                    </div>
                                </td>
                                <td width="33%">
                                	<div class="template-box">
                                    <a href="createAutoTemplateEmail2.aspx?tempID=3&Aid=<%=strAutoresponderID %>" onMouseOver="doTooltip(event, 'template3/images/tmpl_thumbnail')" onMouseOut="hideTip()">
                                    	<img src="./templates/template3/images/tmpl_thumbnail.jpg"  alt="Template #003" border="0" width="200" height="192" />
                                        </a>
                                    	
                                    </div>
                                	
                                </td>
                            </tr>
                        </table>
           	 		
                    </div>
					
                    
                    


                        

						                        
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
    <asp:HiddenField ID="hdAutoID" runat="server" />
	</form>
    
   
	</body>
</html>
