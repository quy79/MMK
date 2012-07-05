<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mylists.aspx.cs" Inherits="EmailSite.mylists" %>
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


	    function confirm_delete(listId) {
	        if (confirm('Do you really want to delete this contact list ?')) {
	            window.location.href = "deleteList.aspx?id=" + listId;
	            //return true;
	        } else {
	            //return false;	
	        }
	    }
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
		
		
		

        .gvhspadding
        {
            padding:10px;
            line-height: 150%;
        }



	</style>	
    




    <title>OptMailMarketing : Home</title>	
	</head>
	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <form runat=server>
    <div id="main">
	    <div class="page-container">
              <uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="contacts" runat="server" />
            
            <div id="content-main">
            
            	<div id="emails-common-panel">

                	<div class="my-lists-title">
                    <h2>My Lists</h2>
                    </div>
                    <div id="infoDiv" runat="server" class="create-message-step1-container3"></div>
                        <div class="message-list" id="message-list">
                            <asp:GridView ID="grvList"  CssClass="contact-grid" BackColor="#ffffff" Width="100%" CellPadding="1" CellSpacing="1" BorderWidth="0" 
                                   HeaderStyle-BackColor="#95949B" AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"  GridLines="None"
                                runat="server"  AutoGenerateColumns ="False" onrowcommand="grvList_RowCommand" onrowdatabound="grvList_RowDataBound" AllowPaging="True" 
                                onpageindexchanging="grvList_PageIndexChanging" PageSize="20">
                                
<AlternatingRowStyle BackColor="#D5D6D9"></AlternatingRowStyle>
                                
                                <Columns>
                                    
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                           &nbsp;<a href='listdetail.aspx?id=<%# DataBinder.Eval(Container.DataItem, "ID")%>'><%# DataBinder.Eval(Container.DataItem, "LISTNAME")%></a>
                                        </ItemTemplate>
                                        <HeaderStyle Width="65%"  />                                            
                                    </asp:TemplateField>


                                    <asp:TemplateField HeaderText="Subscribers">
                                        <ItemStyle CssClass="gvhspadding" />
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "TOTALSUBSCRIBES") %>'></asp:Label><br/>
                                            <asp:LinkButton  ID="lnkAdd" runat="server"  PostBackUrl='<%#"addContacts.aspx?listid="+DataBinder.Eval(Container.DataItem, "ID")%>'>Add new contact</asp:LinkButton >

                                        </ItemTemplate>
                                        <HeaderStyle Width="15%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <table class="message-action">
                                            	<tr>                                                	
                                                    <td><asp:LinkButton  ID="LinkDelete"  runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "ID")%>' CommandName='DelItem'>Delete</asp:LinkButton ></td>
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
                       
                       

						                        
                  </div>
                   <div class="message-list-bottom">
                        	<div style="float: right; width: 100px">
                            <a href="createList.aspx" class="common-button">Create List</a>
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
	

</form>
	</body>
</html>
