<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delAutoresponder.aspx.cs" Inherits="EmailSite.delAutoresponder" %>
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
        <link href="./ui/css/jqueryui.css" media="all" rel="stylesheet" type="text/css"/>
        
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>            
        <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.17/jquery-ui.min.js"></script>
        
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
    <form name="messages_filter_frm" id="messages_filter_frm" runat="server">
    <div id="main">
	    <div class="page-container">
        	 <uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="emails" runat="server" />
            <div id="content-main">
            
            	<div id="emails-common-panel">
                 
                   <div class="common-title">
                    <h2>Delete Autoresponder</h2><br/>
                    <span>Use autoresponders to schedule a series of emails to be sent to new contacts. Schedule each email on the basis of the contact's subscription date.</span>
                    </div>
                	     
                         
                        <div class="create-message-step1-container1">
                        
                        <div class="infobox1">
                            <span class="segment-title">Autoresponder Name : </span><br/>                       
                            <span class="segment-content">
                                <asp:Label ID="lblName" runat="server" Text=""></asp:Label></span><br/><br/>
                            
                            <span class="segment-title">Autoresponder Description : </span><br/>                       
                            <span class="segment-content"><asp:Label ID="lblDescription" runat="server" Text=""></asp:Label> </span><br/><br/>
                            
                            <span class="segment-title">Source List : </span><br/>                       
                            <span class="segment-content"><asp:Label ID="lblSourceList" runat="server" Text=""></asp:Label></span><br/><br/>
                            
    
                            <span class="segment-title">Autoresponder From Name : </span><br/>                       
                            <span class="segment-content"><asp:Label ID="lblFromName" runat="server" Text=""></asp:Label></span><br/><br/>
                            
                            <span class="segment-title">Autoresponder From Email : </span><br/>                       
                            <span class="segment-content"><asp:Label ID="lblFromEmail" runat="server" Text=""></asp:Label></span><br/><br/>
    
                            <span class="segment-title">Autoresponder Interval</span><br/>                       
                            <span class="segment-content"><asp:Label ID="lblInterval" runat="server" Text=""></asp:Label></span><br/><br/>
                        </div>


                    </div>
                    <div class="autoresponder-bottom">
                        <asp:Button ID="btnDel" runat="server" Text="Delete this Autoresponder"  
                            CssClass="submit3" onclick="btnDel_Click" />
                        <div style="display: inline-block; margin: 0 0; padding: 2px 0px;  float: right; width: 130px;">
                            <a href="myAutoresponders.aspx" class="common-button">Cancel</a>
                        </div>
                    </div>           
			    </div>
                
                
                
                <div id="emails-common-panel1">
                	
                         <asp:Panel ID="pnlGrid" runat="server" Visible="false">
                        <br/><br/>
                        <div class="message-list-title">
                        My Autoresponder Messages
                        </div>
                        <div class="message-list" id="message-list">
                              
                              <asp:GridView ID="grvList" CssClass="contact-grid" BackColor="White" 
                                  Width="100%" CellPadding="1"  onrowcommand="grvList_RowCommand" onrowdatabound="grvList_RowDataBound" 
                                CellSpacing="1" BorderWidth="0px" GridLines="None"  
                                  HeaderStyle-BackColor="#95949B" AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"   
                                runat="server"  AutoGenerateColumns ="False"  
                                    >
                                
                                <AlternatingRowStyle BackColor="#D5D6D9" />
                                
                                <Columns>                               
                                     <asp:TemplateField HeaderText="Message Name">
                                        <ItemTemplate>
                                            &nbsp;<a href='editMessage.aspx?id=<%#DataBinder.Eval(Container.DataItem, "ID")%>' ><%#DataBinder.Eval(Container.DataItem, "MESSAGENAME")%></a>
                                        </ItemTemplate>
                                        <HeaderStyle Width="60%"  />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="Created date">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "MODIFIEDDATE", "{0:M/d/yyyy}")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="20%"  />
                                    </asp:TemplateField>
                                    
                                 
                                    
                                    
                                    
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            &nbsp;<asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
                                        </ItemTemplate>
                                        <HeaderStyle Width="20%"  />
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
	

	        
		
    <asp:HiddenField ID="hdAutoID" runat="server" />
        </form>
	</body>
</html>
