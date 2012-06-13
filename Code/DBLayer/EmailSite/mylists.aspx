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
           	 		
                        <div class="message-list" id="message-list">
                            <asp:GridView ID="grvList"  CssClass="contact-grid" BackColor="#ffffff" Width="100%" CellPadding="1" CellSpacing="1" BorderWidth="0" BorderStyle="NotSet"
                                   HeaderStyle-BackColor="#95949B" AlternatingRowStyle-BackColor="#d5d6d9" RowStyle-CssClass="r1"  
                                runat="server"  AutoGenerateColumns ="False" onrowcommand="grvList_RowCommand" onrowdatabound="grvList_RowDataBound" AllowPaging="True" 
                                onpageindexchanging="grvList_PageIndexChanging" PageSize="20">
                                
                                <Columns>
                                    <asp:BoundField HeaderText="List Name" DataField="LISTNAME"  >
                                         <HeaderStyle Width="15%" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="Welcome Message">
                                        <ItemTemplate>
                                            <asp:LinkButton  ID="lnkWelcome" runat="server">&nbsp;<%#DataBinder.Eval(Container.DataItem, "DESCRIPTION")%></asp:LinkButton >
                                        </ItemTemplate>
                                        <HeaderStyle Width="50%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Subscribers">
                                        <ItemTemplate>
                                            <asp:LinkButton  ID="lnkSubcrbes" runat="server">&nbsp;<%#DataBinder.Eval(Container.DataItem, "TOTALSUBSCRIBES")%> Subscribers</asp:LinkButton ><br/>
                                            &nbsp;<asp:LinkButton  ID="lnkAdd" runat="server">Add</asp:LinkButton >
                                        </ItemTemplate>
                                        <HeaderStyle Width="15%"  />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action">
                                        <ItemTemplate>
                                            <table class="message-action">
                                            	<tr>
                                                	<td width="50%"><asp:LinkButton  ID="linkListHealth" runat="server">List Health</asp:LinkButton ></td>
                                                    <td width="50%"><asp:LinkButton  ID="LinkDelete" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "ID")%>' CommandName='DelItem' >Delete</asp:LinkButton ></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                        <HeaderStyle Width="20%"  />                                            
                                    </asp:TemplateField>
                                </Columns>
                                
<HeaderStyle BackColor="#95949B"></HeaderStyle>

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
                            	<div class="PgCounter"><!--Page 1/12  <span class="paging">1</span> <a title="201 - 400" href="javascript:{}" onclick="load_pg(24780,200,2)">2</a>  <a title="401 - 600" href="javascript:{}" onclick="load_pg(24780,200,3)">3</a>  <a title="601 - 800" href="javascript:{}" onclick="load_pg(24780,200,4)">4</a>  <a title="601 - 800" href="javascript:{}" onclick="load_pg(24780,200,11)">11</a>  <a title="201 - 400" href="javascript:{}" onclick="load_pg(24780,200,2)">»</a> <a title="24600 - 24780" href="javascript:{}" onclick="load_pg(24780,200,124)">».</a> --></div>
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
