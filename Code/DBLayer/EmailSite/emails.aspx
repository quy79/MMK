<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emails.aspx.cs" Inherits="EmailSite.emails" %>
<%@ Register src="logo.ascx" tagname="logo" tagprefix="uc1" %>
<%@ Register src="navigation.ascx" tagname="navigation" tagprefix="uc2" %>
<%@ Register src="headerHTML.ascx" tagname="headerHTML" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<uc3:headerHTML ID="headerHTML1" Title="Email" runat="server" />
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form  runat="server">
    <div id="main">
	    <div class="page-container">
             <uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="emails" runat="server" />
            
            <div id="content-main">
            
            	
                <div id="emails-common-panel">
                	<div id="emails-panel-left">
                    	<div id="emails-box-left">
                        	<div class="emails-box-left-header">
		                        <div class="emails-box-left-title">
                                My Messages
                                </div>
                                <div class="emails-box-left-note">
                                
                                </div>
                            </div>
                            <div class="emails-box-left-body">
                            	 <div id="box-explain">Create a new message or work from a saved draft.</div>
                            	 <div id="emails-navcontainer">
                                    <ul id="emails-navlist">
                                        <li>
                                        	<a href="createMsg.aspx" class=""><div class="create-message">Create message</div></a>
                                        </li>
                                        <li>
                                        	<a href="" class=""><div class="reuse-message">Reuse a sent message</div></a>
                                        </li>
                                        <li>
                                        	<a href="" class=""><div class="draft-message">Draft messages</div></a>
                                        </li>
                                        <li>
                                        	<a href="emails-pending-messages.html" class=""><div class="pending-message">Pending messages</div></a>
                                        </li>

                                    </ul>
                                </div>
                            </div>
                            <div class="emails-box-left-bottom">
                            </div>
                        </div>
                    </div>
                	<div id="emails-panel-right">
                    	<div id="emails-box-right">
                        	<div class="emails-box-right-header">
		                        <div class="emails-box-left-title">
                                AutoResponders
                                </div>
                                <div class="emails-box-left-note">
                                
                                </div>
                            </div>
                            <div class="emails-box-left-body">
                            	 <div id="box-explain">Automatically send a series of messages on scheduled days.</div>
                            	 <div id="emails-navcontainer">
                                    <ul id="emails-navlist">
                                        <li>
                                        	<a href="createAutoresponder.aspx" class=""><div class="create-autoresponders">Create an Autoresponder</div></a>
                                        </li>
                                        <li>
                                        	<a href="myAutoresponders.aspx" class=""><div class="my-autoresponders">My Autoresponders</div></a>
                                        </li>


                                    </ul>
                                </div>
                            </div>
                            <div class="emails-box-left-bottom">
                            </div>
                        </div>
                    </div>                    
                </div>

                
                
                <div id="emails-common-panel">
                	<br/><br/>
                    <div class="message-list-bottom">
                        	<div class="messages-filter">
                            	
                                
                        	</div>
                            <div class="messages-stat">
                            	Total <asp:Label ID="lblTotalMsgs" runat="server" Text="0"></asp:Label> messages
                            </div>
                        </div>
                	 <asp:Panel ID="pnlGrid" runat="server">
                        <div class="message-list" id="message-list">
                            <asp:GridView ID="grvList" 
                                CssClass="contact-grid" BackColor="White" Width="100%" CellPadding="1" 
                                CellSpacing="1" BorderWidth="0px" GridLines="None"
                                   HeaderStyle-BackColor="#95949B" AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"   
                                runat="server"  AutoGenerateColumns ="False" 
                                onrowcommand="grvList_RowCommand" onrowdatabound="grvList_RowDataBound" AllowPaging="True" 
                                 PageSize="20" 
                               >
                                
                                <AlternatingRowStyle BackColor="#D5D6D9" />
                                
                                <Columns>                               
                                   <asp:TemplateField HeaderText="Message ID">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "ID")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%"  />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Message Name">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "MESSAGENAME")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="30%"  />
                                    </asp:TemplateField>



                                     <asp:TemplateField HeaderText="Target List">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "LISTNAME")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="25%"  />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Create Date">
                                        <ItemTemplate>
                                            &nbsp;<%#DataBinder.Eval(Container.DataItem, "MODIFIEDDATE")%>
                                        </ItemTemplate>
                                        <HeaderStyle Width="10%"  />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                           <table class="message-action">
                                            	<tr>
                                                	<td width="50%"><a href=editMessage.aspx?id=<%#DataBinder.Eval(Container.DataItem, "ID")%>>Edit</a></td>
                                                    <td width="50%"><asp:LinkButton  ID="LinkDelete" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "ID")%>' CommandName='DelItem' >Delete</asp:LinkButton ></td>
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
            <!-- BEGIN: Footer -->
			<div id="footer">
            
            </div>
            
            <div class="copyright">Copyright © 2012 Optlynx, Inc.</div>
            
            
    	</div>
	</div>
    </form>
	</body>
</html>
