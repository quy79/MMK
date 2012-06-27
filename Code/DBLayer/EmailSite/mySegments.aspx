<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mySegments.aspx.cs" Inherits="EmailSite.mySegments" %>
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

<script src="./ui/js/WindowsControl.js" type="text/javascript" charset="utf-8"></script>
    

    
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
    
	<script language="javascript">
	    function open_win(url) {
	        window.open(url, 'Matching_Contacts', 'toolbar=0, location=0, directories=0, status=0, menubar=0, scrollbars=1, resizable=1, left=250, top=200, width=700, height=500');
	    }

    </script>



    <title>OptMailMarketing : Home</title>	
	</head>
	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form id="Form1" runat="server">
    <div id="main">
	    <div class="page-container">
        	<uc1:logo ID="logo" runat="server" />
			<uc2:navigation ID="navigation" MenuType="contacts" runat="server" />  

            <div id="content-main">
            
            	<div id="emails-common-panel">

                	<div class="common-title">
                        <h2>My Segment</h2><br/>
                        <span>Segments are a powerful tool for targeting specific subscribers. Use segments to create targeted lists based on subscriber data. <br/>
                        The Subscribed column displays the total number of contacts that receive email when you send to this segment.</span>
                    </div>
						                        
				</div>
                <asp:Panel ID="pnlList" runat="server">
					<div class="message-list" id="message-list">
                                 <asp:GridView ID="grvList" 
                                CssClass="contact-grid" BackColor="White" Width="100%" CellPadding="1" 
                                CellSpacing="1" BorderWidth="0px" GridLines="None"
                                   HeaderStyle-BackColor="#95949B" AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"   
                                runat="server"  AutoGenerateColumns ="False" 
                                onrowcommand="grvList_RowCommand" onrowdatabound="grvList_RowDataBound"
                                
                               >
                                
                                <AlternatingRowStyle BackColor="#D5D6D9" />
                                
                                <Columns>                               
                                     <asp:TemplateField HeaderText="">
                                        <ItemTemplate>
                                           <a href="editSegment.aspx?id=<%#DataBinder.Eval(Container.DataItem, "ID")%>"><div class="segment-icon" title="Edit this segment"></div></a>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Segment Name">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "NAME")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="35%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Subscribed">
                                        <ItemTemplate>
                                            &nbsp;0
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%"  />
                                    </asp:TemplateField>
                                      <asp:TemplateField HeaderText="Source List">
                                        <ItemTemplate>
                                             &nbsp;<%#DataBinder.Eval(Container.DataItem, "LISTNAME")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <table class="message-action">
                                            	<tr>
                                                    <td width="33%"><a href="editSegment.aspx?id=<%#DataBinder.Eval(Container.DataItem, "ID")%>">Edit</a></td>
                                                	<td width="34%"><a href="#" id="show2" onclick="open_win('showContacts.aspx?segmentID=<%#DataBinder.Eval(Container.DataItem, "ID")%>');">Show Contacts</a></td>
                                                    <td width="33%"><asp:LinkButton  ID="LinkDelete" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "ID")%>' CommandName='DelItem' >Delete</asp:LinkButton ></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                        <HeaderStyle Width="30%"  />                                            
                                    </asp:TemplateField>
                                </Columns>
                                
<HeaderStyle BackColor="#95949B"></HeaderStyle>

                                <PagerSettings Visible="False" />

<RowStyle CssClass="r1"></RowStyle>
                                
                            </asp:GridView>
					</div> 
                    </asp:Panel>      
                    <div class="segment-bottom">
	                    <div style="display: inline-block; margin: 0 0; padding: 2px 2px;  float: right; width: 170px;">
                            <a href="createSegment.aspx" class="common-button">Create a new Segment</a>
                        </div>
                        <br/><br/> 
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

