<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chooseEmailList.aspx.cs" Inherits="EmailSite.chooseEmailList" %>
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
                    <h2>Create an Email Message</h2>
                    </div>  
                   <div class="my-lists-title">
                    <br/>Select a target List or Segment to send
                    </div>                  
                    <div class="message-list" id="message-list">
                    		
                            <asp:GridView ID="grvList"  CssClass="contact-grid" BackColor="#ffffff" Width="100%" CellPadding="1" CellSpacing="1" BorderWidth="0" BorderStyle="NotSet" GridLines="None"
                                   HeaderStyle-BackColor="#95949B" AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"   
                                runat="server"  AutoGenerateColumns ="False"  
                                AllowPaging="True" onpageindexchanged="grvList_PageIndexChanged" 
                                onpageindexchanging="grvList_PageIndexChanging" PageSize="20">
                                
<AlternatingRowStyle BackColor="#D5D6D9"></AlternatingRowStyle>
                                
                                            <Columns>                                                
                                                 <asp:TemplateField HeaderText="List Name">
                                                    <ItemTemplate>
                                                         &nbsp;<%#DataBinder.Eval(Container.DataItem, "LISTNAME")%>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="70%"  />                                            
                                                </asp:TemplateField>                                               
                                               <asp:TemplateField HeaderText="Subscribers">
                                                    <ItemTemplate>
                                                         &nbsp;<%#DataBinder.Eval(Container.DataItem, "NUMSUBSCRIBES")%>
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="10%"  />                                            
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Select this list to send">
                                                    <ItemTemplate>
                                                         <input type="radio" name="target_list" value="<%#DataBinder.Eval(Container.DataItem, "ID")%>" />
                                                    </ItemTemplate>
                                                    <HeaderStyle Width="20%"  />                                            
                                                </asp:TemplateField>
                                            </Columns>
                                
                                                <HeaderStyle BackColor="#95949B"></HeaderStyle>

                                                <PagerSettings Visible="False" />

                                                <RowStyle CssClass="r1"></RowStyle>
                                
                                        </asp:GridView>
                          
                        </div>
						<div class="message-list-bottom">
                        	<div class="list-display-setting">
                            	
                                Display&nbsp;
                               <asp:DropDownList ID="ddlRowPage" runat="server" AutoPostBack=true 
                                    onselectedindexchanged="ddlRowPage_SelectedIndexChanged">
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem Selected="True">20</asp:ListItem>
                                    <asp:ListItem>50</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                </asp:DropDownList> lists / page
                                
                        	</div>
                            <div class="pagination">
                                 <div class="PgCounter">
                                   Page <asp:Label ID="lblCurrentPage" runat="server" Text="Label"></asp:Label>/<asp:Label ID="lblTotalPages" runat="server" Text="Label"></asp:Label> 
                                   <asp:LinkButton ID="first" runat="server" Text="<<"  CausesValidation="false" 
                                        onclick="first_Click"></asp:LinkButton>
                                   <asp:LinkButton ID="prev" runat="server" Text="<"  CausesValidation="false" 
                                        onclick="prev_Click"></asp:LinkButton>
                                   <asp:Label ID="lblPaging" runat="server"></asp:Label>

                                   <asp:LinkButton ID="next" runat="server" Text=">" CausesValidation="false" 
                                        onclick="next_Click" ></asp:LinkButton>  
                                   <asp:LinkButton ID="last" runat="server" Text=">>"  CausesValidation="false" 
                                        onclick="last_Click"></asp:LinkButton>

                                    <input type="hidden" value="1" id="CurrentPage" runat="server"/>
                                    <input type="hidden" id="TotalSize" runat="server"/>
                                    <input type="hidden" id="TotalPages" runat="server"/>
                                </div>   
                            </div>
                        </div>
                        
                        <div class="segment-bottom">
                            <div style="display: inline-block; margin: 0 0; padding: 2px 2px;  float: left; width: 160px;">
                             
                            <asp:LinkButton ID="lnkBack" runat="server" CssClass="common-button" 
                                    onclick="lnkBack_Click">Back to edit message</asp:LinkButton>
                            <!--
                            <a href="emails-create-message-html.html" class="common-button">Back to edit message</a>
                            <a href="emails-create-message-template2.html" class="common-button">Back to edit message</a>
                            <a href="emails-create-message-template3.html" class="common-button">Back to edit message</a>
                            -->
                            </div> 
                            <asp:Button ID="btnPreview" runat="server"  CssClass="submit6" 
                                Text="Preview and proceed send" onclick="btnPreview_Click" />
                        
                           
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
    
    <div id="test-message" class="test-message-popup">
        <h2><font color="#FFFFFF">Send test message</font></h2>
        <a href="#" class="closebtn"><img src="img/close_pop.png" class="btn_close" title="Close Window" alt="Close" /></a>
          <form method="post" name="testform" class="test_message" action="#">
                <fieldset class="textbox">
            	<label>
                <input id="toemail" name="toemail" value="" type="text" autocomplete="on" placeholder="Email address">
                </label>
                
                
                <button class="submit button" type="button">Send</button>
                
               
                </fieldset>
          </form>
		</div>
	</body>
</html>
