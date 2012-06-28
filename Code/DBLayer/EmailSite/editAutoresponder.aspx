<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editAutoresponder.aspx.cs" Inherits="EmailSite.editAutoresponder" %>
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
			 <uc2:navigation ID="navigation" MenuType="contacts" runat="server" />
            
            <div id="content-main">
                  
            	<div id="emails-common-panel">

                	<div class="common-title">
                    <h2>Create an Autoresponder</h2><br/>
                    <span>Use autoresponders to schedule a series of emails to be sent to new contacts. Schedule each email on the basis of the contact's subscription date.</span>
                    </div>                    
                    <div class="create-message-step1-container1">
                    <br/>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>                    
           	 		<!--<form id="formID" class="formular" method="post" action="">-->
                        <span>Autoresponder Name<br/></span>
                        <span style="font-size: 11px;">(not viewable by yours contacts)</span><br/>
                        <asp:TextBox ID="txtName" runat="server" CssClass="validate[required] text-input"></asp:TextBox>
                        <br/>
                        <span>Autoresponder Description<br/></span>
                        <span style="font-size: 11px;">(not viewable by yours contacts)</span><br/>
                        <asp:TextBox ID="txtDesc" runat="server" 
                            CssClass="validate[required] text-input" Height="120px" TextMode="MultiLine"></asp:TextBox><br/>
                        <span>Source List<br/>
                            <asp:DropDownList ID="ddlList" runat="server" Width="400px" 
                            DataTextField="LISTNAME" DataValueField="ID">
                            </asp:DropDownList>
                        <br/>
						<span>Autoresponder From Name<br/></span>
                        <span style="font-size: 11px;">The person's name that this message will come from.</span><br/>
                        <asp:TextBox ID="txtFromName" runat="server" CssClass="validate[required] text-input"></asp:TextBox><br/>
                        <span>Autoresponder From Email<br/></span>
                        <span style="font-size: 11px;">The person's Email Address that this message will come from.</span><br/>
                        <asp:TextBox ID="txtFromEmail" runat="server" CssClass="validate[required] text-input"></asp:TextBox><br/>
                         <span>Please specify Interval of Autoresponder<br/></span>
                        <span style="font-size: 11px;">(Number of days after that each messages in Autoresponder will be re-sent, minimum is 1 day.)</span><br/>
                        <asp:TextBox ID="txtDuration" runat="server" CssClass="validate[required] text-input"></asp:TextBox><br/>
                       
                       
                    </div>
                    <div class="autoresponder-bottom">
                        <asp:Button ID="btnSave" runat="server" Text="Save Autoresponder" 
                            CssClass="submit3" onclick="btnSave_Click" />
                        <div style="display: inline-block; margin: 0 0; padding: 2px 50px;  float: right; width: 130px;">
                            <a href="myAutoresponders.aspx" class="common-button">Cancel</a>
                        </div>
                    </div> 
					<!--</form>-->
                    <asp:Panel ID="pnlGrid" runat="server" Visible="false">
                        <br/><br/><br/><br/>
                        <div class="message-list-title">
                        My Autoresponder Messages
                        </div>
                        <div class="message-list" id="message-list">
                              
                              <asp:GridView ID="grvList" CssClass="contact-grid" BackColor="White" 
                                  Width="100%" CellPadding="1"  onrowcommand="grvList_RowCommand" onrowdatabound="grvList_RowDataBound" 
                                CellSpacing="1" BorderWidth="0px" GridLines="None"  
                                  HeaderStyle-BackColor="#95949B" AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"   
                                runat="server"  AutoGenerateColumns ="False" ondatabound="grvList_DataBound" 
                                    >
                                
                                <AlternatingRowStyle BackColor="#D5D6D9" />
                                
                                <Columns>                               
                                     <asp:TemplateField HeaderText="Message Name">
                                        <ItemTemplate>
                                            &nbsp;<a href='editMessage.aspx?id=<%#DataBinder.Eval(Container.DataItem, "ID")%>' ><%#DataBinder.Eval(Container.DataItem, "MESSAGENAME")%></a>
                                        </ItemTemplate>
                                        <HeaderStyle Width="25%"  />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="Created date">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "MODIFIEDDATE")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%"  />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                             <table class="message-action">
                                                    <tr>
                                                        <td width="50%"><a href='editMessage.aspx?id=<%#DataBinder.Eval(Container.DataItem, "ID")%>'>Edit</a></td>                                                        
                                                        <td width="50%"><asp:LinkButton  ID="LinkDelete" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "ID")%>' CommandName='DelItem' >Delete</asp:LinkButton ></td>
                                                    </tr>
                                                </table>
                                        </ItemTemplate>
                                        <HeaderStyle Width="20%"  />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="Start / Stop sending">
                                        <ItemTemplate>
                                            &nbsp;<asp:Button ID="btnStartStop" runat="server" Text="Start" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "ID")%>' CommandName='StartStop'  />
                                        </ItemTemplate>
                                        <HeaderStyle Width="25%"  />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            &nbsp;<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%"  />
                                        <ItemStyle HorizontalAlign="Center" />
                                    </asp:TemplateField> 
                                    
                                </Columns>
                                
                                <HeaderStyle BackColor="#95949B"></HeaderStyle>

                                <PagerSettings Visible="False" />

                                <RowStyle CssClass="r1"></RowStyle>
                                
                            </asp:GridView>
                              
						</div>

                    </asp:Panel>						                        
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
		--><asp:HiddenField ID="hdAutoID" runat="server" />
	</form>
        
    
   
	</body>
</html>
