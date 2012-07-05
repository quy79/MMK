<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uploadContacts.aspx.cs" Inherits="EmailSite.uploadContacts" %>
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
    




    <title>OptMailMarketing : Home</title>	
	</head>
	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form id="Form1" name="form" runat="server">
    <div id="main">
	    <div class="page-container">
        	
             <uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="contacts" runat="server" />
            
            <div id="content-main">
            
            	<div id="emails-common-panel">
                   
                	<div class="common-title">
                    <div id="infoDiv" runat="server" class="create-message-step1-container3"></div>
                    <span><asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label></span>
                    <h2>Upload Contacts from file</h2><br/>
                    <span>Easily upload and import contacts from CSV file into your Lists</span>
                    </div>
                    <div class="common-form">
                    <!--<form id="formID" name="form" class="formular" method="post" action="CreateList.aspx">-->
                        <div id="listsDiv" runat="server">
                    	Chooses a list to add or invite your contacts to :<br/>    
                       <asp:Repeater ID="rptList" runat="server">                                    
                            <ItemTemplate>
                                <input class="validate[minCheckbox[1]] checkbox" type="checkbox" name="listContact" id="listContact" value="<%#Eval("ID")%>" />
                                <span class="checkbox"><%#Eval("LISTNAME")%></span><br/>                                        
                            </ItemTemplate>
                        </asp:Repeater>
                        </div>
                        <div class="upload-form">

                            <span>Please select a file:</span><br/>
                            <span>Currently supported formats: Excel, CSV</span><br/>
                            &nbsp;<asp:FileUpload  ID="file" runat="server" class="validate[required] file-input" size="50" />
                        </div>
                        <!--
                        <asp:CheckBox ID="chkAgree" Checked=true runat="server" />
                        <span class="checkbox">Require confirmation<br/>If checked, contacts are not added until you compose and send the confirmation-request email (steps follow). To confirm their subscription, contacts must click the link the confirmation-request email contains.</span>
                        -->
                        <!--
                        <a class="button" id="sm" href="#"><span>Save</span></a>
                        <a class="button" href="#"><span>Cancel</span></a>
                        -->
                        <br/><asp:Button ID="btnUpload" runat="server" Text="Upload Contacts" 
                            onclick="btnUpload_Click" />
							
						
                        <!--
                        <div class="buttonwrapper">
<a class="boldbuttons" href="http://www.dynamicdrive.com/style/"><span>Spam Check</span></a>
<span>&nbsp;&nbsp;&nbsp;</span><a class="boldbuttons" href="http://www.dynamicdrive.com/style/"><span>Send Test Message</span></a>
</div>-->
                        
					<!--</form>-->
                    </div>
                    <!--
                    <div class="upload-history-title">
                    <h2>Upload History</h2><br/>
                    
                    </div>
                    <div class="message-list" id="message-list">
                          <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td>
                                  <table class="contact-grid" bgcolor="#ffffff" width="100%" border="0" cellspacing="1" cellpadding="1">
                                    <tr>
                                      <th bgcolor="#95949b" width="25%" align="center">Date</td>
                                      <th bgcolor="#95949b" width="15%" align="center">Status</td>
                                      <th bgcolor="#95949b" width="60%" align="center">Progress</td>

                                    </tr>
                                    <tr>
                                      <td class="r1"></td>
                                      <td class="r1"></td>
                                      <td class="r1"></td>                                      
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      
                                    </tr>
                                    <tr>
                                      <td class="r1"></td>
                                      <td class="r1"></td>
                                      <td class="r1"></td>                                      
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      
                                    </tr>
                                    <tr>
                                      <td class="r1"></td>
                                      <td class="r1"></td>
                                      <td class="r1"></td>                                      
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      
                                    </tr>
                                    <tr>
                                      <td class="r1"></td>
                                      <td class="r1"></td>
                                      <td class="r1"></td>                                      
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      <td class="r1" bgcolor="#d5d6d9"></td>
                                      
                                    </tr>                                                                                                            

                                  </table>
                              </td>
                            </tr>
                          </table>
                          
                        </div>
                        
                         <div class="message-list-bottom">
                        	<div class="list-display-setting">
                            	
                                Display&nbsp;
                                <select name="rowspage">
                                	<option value="20" selected>20</option>
                                    <option value="50">50</option>
                                    <option value="100">100</option>                                    
                                </select> uploads / page
                                
                        	</div>
                            <div class="pagination">
                            	<div class="PgCounter">Page 1/12  <span class="paging">1</span> <a title="201 - 400" href="javascript:{}" onclick="load_pg(24780,200,2)">2</a>  <a title="401 - 600" href="javascript:{}" onclick="load_pg(24780,200,3)">3</a>  <a title="601 - 800" href="javascript:{}" onclick="load_pg(24780,200,4)">4</a>  <a title="601 - 800" href="javascript:{}" onclick="load_pg(24780,200,11)">11</a>  <a title="201 - 400" href="javascript:{}" onclick="load_pg(24780,200,2)">»</a> <a title="24600 - 24780" href="javascript:{}" onclick="load_pg(24780,200,124)">».</a></div>
                            </div>
                        </div>

                        -->
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
