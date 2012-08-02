<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editSegment.aspx.cs" Inherits="EmailSite.editSegment" %>
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
<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>

<link rel="stylesheet" href="./ui/css/ui.all.css" type="text/css" media="screen" />




<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script src="./ui/js/jquery.ValidationEngine-en.js" type="text/javascript" charset="utf-8"></script>
<script src="./ui/js/jquery.ValidationEngine.js" type="text/javascript" charset="utf-8"></script>

<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"></script>
    
    
        
    
<script>
    jQuery(document).ready(function () {

        $("#tabs").tabs();

        // binds form submission and fields to the validation engine
        jQuery("#formID").validationEngine();

        jQuery("#sm").click(function () {
            document.forms["form"].submit();
        });



        $("div.criteria").hide();
        $("input[name$='criteria']").click(function () {
            var test = $(this).val();
            $("div.criteria").hide();
            $("#" + test).show();
        });

        $("div.dt").hide();
        $("#dtdiv1").show();
        $("#date_range").change(function () {
            var dt = $(this).find(":selected").val();
            $("div.dt").hide();
            $("#" + dt).show();

        });


        $("#subscriber_fields").change(function () {
            var sf = $(this).find(":selected").val();
            $("#f").html(sf);

        });

        $("#date").datepicker({ showOn: 'button', buttonImageOnly: true, buttonImage: './img/icon_cal.png' });
        $("#date1").datepicker({ showOn: 'button', buttonImageOnly: true, buttonImage: './img/icon_cal.png' });
        $("#date2").datepicker({ showOn: 'button', buttonImageOnly: true, buttonImage: './img/icon_cal.png' });
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
		.criteria {position: relative; display: none;}
		.dt {position: relative; display: none;}
		


	</style>	
    




    <title>OptMailMarketing : Home</title>	
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
                    <h2>Edit a Segment</h2>
                        <div id="common-explain">
                        A segment is a list that can be used for sending targeted emails. You create the segment by supplying criterias, which are characteristics of your subscribers.
                        </div>
                        
                    </div>
                    <div class="create-message-step1-container1">
	                    <div class="segment-criteria1">
                    <!--<form id="formID" name="form" class="formular" method="post" action="CreateContact.aspx">-->
                    	<fieldset>
                            <legend>
                                Segment's Information
                            </legend>
                            
                            <table>
                            	<tr>
                                	<td width="300" align="left" valign="top" style="line-height: 200%">
                                		<span>Segment Name : </span><br/>
		                                
                                        <asp:TextBox ID="txtName" runat="server" CssClass="text-segment-name" ></asp:TextBox><br/>
		                                <span>Source List : </span><br/>
                                        <asp:DropDownList ID="ddlList" runat="server" Width="150px" 
                                            DataTextField="LISTNAME" DataValueField="ID">
                                        </asp:DropDownList>
                                        <br/>
                                        <span style="font-size: 11px;">
                                        Once saved, the source list cannot be changed.
                                        </span>
                                    </td>
                                    <td width="310">
                                    	<span>Segment description : </span>   
                                        <asp:TextBox ID="txtDesc" runat="server" Height="200px" TextMode="MultiLine" 
                                            Width="300px"></asp:TextBox>                  
										
                                    </td>
                                </tr>
                            </table>
                            
                                
                            
                         </fieldset> 
                         <!--
                         <div style="display: inline-block; margin: 10px 0px; padding: 2px 2px;  float: left; width: 130px;">
                                <a href="mysegments.html" class="common-button">My Segments</a>
                            </div>-->
                         <br/>
                            <asp:Button ID="btnSave" runat="server" Text="Save and add criterias" 
                                CssClass="submit3" onclick="btnSave_Click" />  
                            <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#CC3300"></asp:Label>
						    <asp:HiddenField ID="hdSegmentID" runat="server" />
						</div>  
						</div>
                        
                        <!--start add criteria here-->
                        
                        
                        <!--end add criteria here-->
                        
                        
                        
                        
                        
						
						
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
            
            <div class="copyright">Copyright © 2012 Optlynx, Inc.12 Optlynx, Inc.</div>
            




       
    

    
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

