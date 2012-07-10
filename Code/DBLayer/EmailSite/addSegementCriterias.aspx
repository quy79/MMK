<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addSegementCriterias.aspx.cs" Inherits="EmailSite.addSegementCriterias" %>
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
            if (dt != "dtdiv2")dt= "dtdiv1"
            $("div.dt").hide();
            $("#" + dt).show();

        });


        $("#subscriber_fields").change(function () {
            var sf = $(this).find(":selected").text();
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
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                        ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#CC3300"></asp:Label>
                	<div class="common-title">
                    <h2>Create a Segment</h2>
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
                                		<span class="segment-title">Segment Name : </span><br/>
		                                <span class="segment-content"><asp:Label ID="lblName" runat="server"></asp:Label></span><br/><br/>
                                
		                                <span class="segment-title">Source List : </span><br/>
                                        <ul class="segment-content">
                                        	<li><asp:Label ID="lblListName" runat="server"></asp:Label></li><br/>
                                            
                                        </ul>
                                        
                                    </td>
                                    <td width="310" valign="top" align="left" style="line-height: 200%">
                                    	<span class="segment-title">Segment description : </span><br/>                      
										<span class="segment-content"> 
                                            <asp:Label ID="lblDesc" runat="server"></asp:Label></span>
                                    </td>
                                </tr>
                            </table>
                            
                                
                            
                         </fieldset> 
                         
						  
					</div>
                        
                    <!--start add criteria here-->
                    <div class="segment-criteria1">
                        <fieldset>
                            <legend>
                                Segment Criteria
                            </legend>
                             <div style="position: relative; clear: both; width: 100%; margin: 0 auto">	
                             <table>
                            	<tr>
                                	<td width="250" align="left" valign="top" >
                                    	<input type="radio" name="criteria" value="by_date" />Date Added to account<br/>
                                		<span style="font-size: 11px;">
                                        Filter Contacts based on the date when a Contact is added to your account.
                                        </span>

                                
		                               
                                    </td>
                                    <td width="110"></td>
                                    <td width="250">
                                    	<input type="radio" name="criteria" value="by_fields" />Subscriber's information<br/>
                                		<span style="font-size: 11px;">
                                        Filter Contacts based on standard Subscriber's information such as Email, Zip code, postal address,...
                                        </span>
                                    </td>
                                </tr>
                            </table>
							</div>
                            <div id="by_date" class="criteria">
                                <div style="position: relative; clear: both; width: 100%">
                                    <asp:DropDownList ID="date_range" runat="server" Width="150px" Height="22px">
                                        <asp:ListItem Value="dtdiv1">Added On</asp:ListItem>
                                        <asp:ListItem Value="dtdiv3">Added Before</asp:ListItem>
                                        <asp:ListItem Value="dtdiv4">Added After</asp:ListItem>
                                        <asp:ListItem Value="dtdiv2">Added Between</asp:ListItem>
                                    </asp:DropDownList>                                    
                                </div>
                                <div id="dtdiv1" class="dt">
                                	<asp:TextBox ID="date" runat="server"></asp:TextBox>
                                </div>
                                <div id="dtdiv2" class="dt">
                                    <span>From Date : </span>
                                    <asp:TextBox ID="date1" runat="server"></asp:TextBox>&nbsp;&nbsp;
                                    <span>To Date : </span>
                                	<asp:TextBox ID="date2" runat="server"></asp:TextBox>
                                </div>
                                <br/> <asp:Button ID="btnAddCriteria1" runat="server" Text="Add Criteria" 
                                    CssClass="submit2" onclick="btnAddCriteria1_Click"  />
                            </div>
                            
                            <div id="by_fields" class="criteria">
                                <div style="position: relative; clear: both; width: 100%; line-height: 200%">
	                                <span>Subscriber fields : </span><br/>
                                     <asp:DropDownList ID="subscriber_fields" runat="server" Width="150px" Height="22px">                                        
                                        <asp:ListItem Value="FIRSTNAME">First Name</asp:ListItem>
                                        <asp:ListItem Value="LASTNAME">Last Name</asp:ListItem>
                                        <asp:ListItem Value="BUSINESSNAME">Business</asp:ListItem>
                                        <asp:ListItem Value="EMAIL">Email</asp:ListItem>
                                        <asp:ListItem Value="PREFIX">Prefix</asp:ListItem>
                                        <asp:ListItem Value="SUFFIX">Suffix</asp:ListItem>
                                        <asp:ListItem Value="ADDRESS1">Address 1</asp:ListItem>
                                        <asp:ListItem Value="ADDRESS1">Address 2</asp:ListItem>
                                        <asp:ListItem Value="CITY">City</asp:ListItem>
                                        <asp:ListItem Value="PROVINCE">State</asp:ListItem>
                                        <asp:ListItem Value="ZIP">Zip code</asp:ListItem>
                                        <asp:ListItem Value="PHONE">Phone Number</asp:ListItem>
                                        <asp:ListItem Value="FAX">Fax Number</asp:ListItem> 

                                    </asp:DropDownList> 
                                    <br/>
                                    <span>Conditional : </span><br/>
                                    <asp:DropDownList ID="conditional" runat="server" Width="150px" Height="22px">                                        
                                        <asp:ListItem Value="equals">Equals</asp:ListItem>
                                        <asp:ListItem Value="notequals">Doesn't Equal</asp:ListItem>
                                        <asp:ListItem Value="contains">Contains</asp:ListItem>
                                        <asp:ListItem Value="notcontains">Doesn't Contain</asp:ListItem>

                                    </asp:DropDownList>
                                    
                                </div>
                                <span id="f">First Name</span><br/>
                                <asp:TextBox ID="txtFV" runat="server" CssClass="text-segment-name"></asp:TextBox>
                                
                                <br/>
                                <asp:Button ID="btnAddCriteria2" runat="server" Text="Add Criteria" 
                                    CssClass="submit2" onclick="btnAddCriteria2_Click"  />
                                
                            </div> 
                            
                        </fieldset>
                        
						</div>
                    
                    <!--end add criteria here-->
                    
                        
                        
                        
                        
						
						
                        <!--
                        <div class="buttonwrapper">
<a class="boldbuttons" href="http://www.dynamicdrive.com/style/"><span>Spam Check</span></a>
<span>&nbsp;&nbsp;&nbsp;</span><a class="boldbuttons" href="http://www.dynamicdrive.com/style/"><span>Send Test Message</span></a>
</div>-->
                    </div>
                    <br/>
                  <asp:Panel ID="pnlCriterias" runat="server">
                    <div style="position: relative; float: none; width: 95%; padding: 10px; margin: 0 auto; clear: both; height: auto">
                    Segment's Criterias<br/>
                    </div>
                    
                    <div class="message-list" id="message-list">
                    	
                         <asp:GridView ID="grvCriterion" 
                                CssClass="contact-grid" BackColor="White" Width="100%" CellPadding="2" 
                                CellSpacing="1" BorderWidth="0px" GridLines="None"
                                   HeaderStyle-BackColor="#95949B" 
                             AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"   
                                runat="server"  AutoGenerateColumns ="False" 
                                onrowcommand="grvCriterion_RowCommand" onrowdatabound="grvCriterion_RowDataBound" 
                                
                               >
                                
                                <AlternatingRowStyle BackColor="#D5D6D9" />
                                
                                <Columns>                               
                                     <asp:TemplateField HeaderText="Criterion">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "CRITERION")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="30%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Condition">
                                        <ItemTemplate>
                                             &nbsp;<%#DataBinder.Eval(Container.DataItem, "CONDITIONNAME")%>
                                            
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Value or Range">
                                        <ItemTemplate>
                                             &nbsp;<%#DataBinder.Eval(Container.DataItem, "VALUE")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="25%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <table class="message-action">
                                            	<tr>                                                	
                                                    <td width="50%"><asp:LinkButton  ID="LinkDelete" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "ID")%>' CommandName='DelItem' >Delete this criteria</asp:LinkButton ></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                        <HeaderStyle Width="20%"  />                                            
                                    </asp:TemplateField>
                                </Columns>
                                
<HeaderStyle BackColor="#95949B"></HeaderStyle>

                                <PagerSettings Visible="False" />

<RowStyle CssClass="r1"></RowStyle>
                                
                            </asp:GridView>
					</div>
                    </asp:Panel>
                    <div class="segment-bottom">
                        <asp:Button ID="btnSaveandNew" runat="server" 
                            Text="Save and create another segment" CssClass="submit3" 
                            onclick="btnSaveandNew_Click"/>
                        
                            <div style="display: inline-block; margin: 0 0; padding: 2px 2px;  float: left; width: 130px;">
                                <a href="mysegments.aspx" class="common-button">My Segments<asp:HiddenField 
                                    ID="hdSegmentID" runat="server" />
                                </a>
                            &nbsp;</div>
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
