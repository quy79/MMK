<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="EmailSite.home" %>
<%@ Register src="logo.ascx" tagname="logo" tagprefix="uc1" %>
<%@ Register src="navigation.ascx" tagname="navigation" tagprefix="uc2" %>
<%@ Register src="headerHTML.ascx" tagname="headerHTML" tagprefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<uc3:headerHTML ID="headerHTML1" Title="Home" runat="server" />
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
<form id="form1" runat="server">    
    <div id="main">
	    <div class="page-container">        	
			 
			 <uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="home" runat="server" />
            
            <!-- BEGIN: Primary Navigation -->
            
            
            <div id="content-main">
            
            	<div id="panel-left">
                	<div id="last-message-container">
                    	
                    	<div id="title-box">
                        	
                        	<ul>
                            	<li>Last message</li>
                            </ul>
                        	<!--
                            <div class="title-text">
                        	Last Message
                            </div>
                            -->
                        </div>
                        
                        
                       	<div class="message-content-box">
                        	<div class="message-title-box">
                            	<div class="message-title-text">
                                    <asp:Label ID="lblMsgName" runat="server" Text=""></asp:Label>
                          			
                                </div>
                            	
                            </div>
                            <div id="message-content-left">
                            	<div class="message-info">
                                	<ul>
                                    	<span>Type :   <asp:Label ID="lblMsgType" runat="server" Text=""></asp:Label></span><br/>                                    	
                                        <span>Target contact list(s) :  <asp:HyperLink ID="hlContactLink" runat="server"></asp:HyperLink></span><br/>
                                        

                                    </ul>
                                </div>
                            </div>
                            <div id="message-content-right">
                            	<div class="message-content-right-header">
                                	<div class="message-content-right-header-body">
                                    	<span class="message-content-delivered-num"><asp:Label ID="lblMsgTotalContacts" runat="server" Text=""></asp:Label></span><br/>
                                        contacts received this message.
                                    </div>
                                	
                                </div>
                                <div class="message-content-right-wrap">
                                	<table id="message-icons">
                                    	<tr>
                                        	<td class="opens"></td>
                                            <td class="info">Opens : <asp:Label ID="lblTotalOpen" runat="server" Text=""></asp:Label></td>
                                        </tr>
                                        <tr>
                                        	<td class="clicks"></td>
                                            <td class="info">Clicks : <asp:Label ID="lblTotalClick" runat="server" Text=""></asp:Label></td>
                                        </tr>
                                        <tr>
                                        	<td class="bounces"></td>
                                            <td class="info">Bounces : <asp:Label ID="lblTotalBounces" runat="server" Text=""></asp:Label></td>
                                        </tr>
                                    </table>
                                    	
								</div>
                                <div id="navcontainer">
                                    <ul id="navlist">
                                        <li id="active"><a href="createMsg.aspx" id="current">Create Message</a></li>
                                        

                                    </ul>
                                </div>
                                
                            </div>
						</div>                            
                        
                        
                    </div>
                    
                  <div id="contact-list-container">
						<div id="contacts-title-box">
                        	
                        	<ul>
                            	<li>Contact List</li>
                            </ul>
                        	<!--
                            <div class="title-text">
                        	Last Message
                            </div>
                            -->
                        </div>
                        <div id="contacts-actions-menu">
                        	<a href="createList.aspx" class="contacts-actions-nav">Create new Contact List</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="uploadContacts.aspx" class="contacts-actions-nav">Import Contacts</a>
                        </div>
                         <asp:Panel ID="pnlContactList" runat="server">
                        <div class="message-content-box">
                     
                     
                        <asp:GridView ID="grvList"  CssClass="contact-grid" BackColor="#ffffff" Width="100%" CellPadding="1" CellSpacing="1" BorderWidth="0" 
                                   AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"  GridLines="None"
                                runat="server"  AutoGenerateColumns ="False" onrowcommand="grvList_RowCommand" onrowdatabound="grvList_RowDataBound" AllowPaging="True" 
                                onpageindexchanging="grvList_PageIndexChanging" PageSize="20">
                                
<AlternatingRowStyle BackColor="#D5D6D9"></AlternatingRowStyle>
                                
                                <Columns>
                                    
                                    <asp:TemplateField HeaderText="Contact List ID">
                                        <ItemTemplate>
                                           &nbsp;<a href='searchContacts.aspx?listID=<%# DataBinder.Eval(Container.DataItem, "ID")%>'><%# DataBinder.Eval(Container.DataItem, "LISTNAME")%></a>
                                        </ItemTemplate>
                                        <HeaderStyle Width="80%"  />                                            
                                    </asp:TemplateField>


                                    <asp:TemplateField HeaderText="Total of contacts">
                                        <ItemStyle CssClass="gvhspadding" />
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TOTALSUBSCRIBES") %>'></asp:Label><br/>
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
                                </asp:DropDownList>
                                 lists / page
                                
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
                        </asp:Panel>
                        
                    
                    </div>
   
                </div>
                
                <div id="panel-right">
                	<div id="stat-container">
                    	<div class="stat-title">
                        	<div class="stat-title-text">
                            	SYSTEM STATISTICS                        
                            </div>
                        </div>
                        <div class="stat-content">
                        	<div id="stat-content-sub">
								<ul class="p1">
                                	<li>Total 
                                        <asp:Label ID="lblTotalContacts" runat="server" CssClass="impression-txt" Text="0"></asp:Label> contacts splitted into :</li>
                                </ul>
                                <ul class="p2">
                                	<li class="node1"><asp:Label ID="lblTotalLists" runat="server" Text="0"></asp:Label> lists</li>
                                    <li class="node2"><asp:Label ID="lblTotalSegments" runat="server" Text="0"></asp:Label> segments</li>
                                </ul>                                
                                
                            </div>
                        </div>
                        <div class="stat-bottom">
                        </div>
                    </div>
                </div>
            
            
               
            
            
            </div>     
            <!-- BEGIN: Footer -->
			<div id="footer">
            
            </div>
            
            
    	</div>
	</div>
	

	    </form>
	</body>
</html>
