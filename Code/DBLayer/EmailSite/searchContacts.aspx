<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchContacts.aspx.cs" Inherits="EmailSite.searchContacts" %>
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
<link rel="stylesheet" type="text/css" href="./ui/css/tabcontent.css" />

<link rel="stylesheet" href="./ui/css/globalFormStyle.css" type="text/css"/>
<link rel="stylesheet" href="./ui/css/template.css" type="text/css"/>
<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>

<link rel="stylesheet" href="./ui/css/ui.all.css" type="text/css" media="screen" />




<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script src="./ui/js/jquery.ValidationEngine-en.js" type="text/javascript" charset="utf-8"></script>
<script src="./ui/js/jquery.ValidationEngine.js" type="text/javascript" charset="utf-8"></script>

<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"></script>
<script>
    function CheckAllDataGridCheckBoxes(aspCheckBoxID) {
        var checkVal = false;
        re = new RegExp(aspCheckBoxID + '$');
        re1 = new RegExp('selectall' + '$');
        for (i = 0; i < document.forms[0].elements.length; i++) {
            elm1 = document.forms[0].elements[i]
            if (elm1.type == 'checkbox') {
                if (re1.test(elm1.name)) {
                    checkVal = elm1.checked;
                }
            }
        }
        for (i = 0; i < document.forms[0].elements.length; i++) {
            elm = document.forms[0].elements[i]
            if (elm.type == 'checkbox') {
                if (re.test(elm.name)) {
                    elm.checked = checkVal
                }
            }
        }
    }
    function UnCheckDataGridCheckBoxes(aspCheckBoxID, aspCheckBoxID2) {
        var checkVal = false;
        re1 = new RegExp('chk_SelectAll' + '$');
        re2 = new RegExp(aspCheckBoxID2 + '$');
        for (i = 0; i < document.forms[0].elements.length; i++) {
            elm = document.forms[0].elements[i]
            if (elm.type == 'checkbox') {
                if (re2.test(elm.name)) {
                    if (elm.checked == false) {
                        for (i = 0; i < document.forms[0].elements.length; i++) {
                            elm2 = document.forms[0].elements[i]
                            if (elm2.type == 'checkbox') {
                                if (re1.test(elm2.name)) {
                                    elm2.checked = false;

                                }
                            }
                        }
                    }

                }
            }
        }
    }
</script>
<script>
    jQuery(document).ready(function () {

        $("#tabs").tabs();

        // binds form submission and fields to the validation engine
        jQuery("#formID").validationEngine();

        jQuery("#sm").click(function () {
            document.forms["form"].submit();
        });



        $("div.desc").hide();
        $("input[name$='actions']").click(function () {
            var test = $(this).val();
            $("div.desc").hide();
            $("#" + test).show();
        });


        //var total = $('input[type=checkbox]').length - 1;
        var checkedAmount = ($("#selectContactContainer :checked").size());
        if ($("input[name$='selectall']").is(':checked')) {
            checkedAmount = checkedAmount - 1;
        }

        $("input[name$='selectContact']").click(function () {
            var checkedAmount = ($("#selectContactContainer :checked").size());
            var total = $('input[type=checkbox]').length - 1;
            if ($("input[name$='selectall']").is(':checked')) {
                checkedAmount = checkedAmount - 1;
            }
            
            total = ($("#selectContactContainer :not(:checked)").size());	
            
            if (checkedAmount == 0) {
                var option1 = $('<option></option>').attr("value", '-').text('Please select contacts');
                //var option2 = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                var option1a = $('<option></option>').attr("value", '-').text('Please select contacts');
                //var option2a = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                var option1b = $('<option></option>').attr("value", '-').text('Please select contacts');
                //var option2b = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                var option1c = $('<option></option>').attr("value", '-').text('Please select contacts');
                //var option2c = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                $("#c1").empty().append(option1);
               // $("#c1").append(option2);
                $("#c2").empty().append(option1a);
                //$("#c2").append(option2a);
                $("#c3").empty().append(option1b);
               // $("#c3").append(option2b);
                $("#c4").empty().append(option1c);
               // $("#c4").append(option2c);
                $("#donotcontact_txt").text('Select contacts to mark as "Do Not Contact" for your account.');
            } else {

                var option3 = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
                //var option4 = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                var option3a = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
               // var option4a = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                var option3b = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
               // var option4b = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                var option3c = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
               // var option4c = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                $("#c1").empty().append(option3);
                //$("#c1").append(option4);
                $("#c2").empty().append(option3a);
                //$("#c2").append(option4a);
                $("#c3").empty().append(option3b);
                //$("#c3").append(option4b);
                $("#c4").empty().append(option3c);
                //$("#c4").append(option4c);
                $("#donotcontact_txt").text('Mark ' + checkedAmount + ' selected contact as "Do Not Contact" for your account.');

            }



        });

        $("input[name$='selectall']").click(function () {



            var total = $('input[type=checkbox]').length - 1;
            if ($("input[name$='selectall']").is(':checked')) {

                $("form#formID INPUT[@name='selectContact'][type='checkbox']").attr('checked', true);

                var checkedAmount = ($("#selectContactContainer :checked").size()) - 1;

                var option3 = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
                var option4 = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                var option3a = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
                var option4a = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                var option3b = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
                var option4b = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                var option3c = $('<option></option>').attr("value", checkedAmount).text(checkedAmount + ' selected contacts');
                var option4c = $('<option></option>').attr("value", '-').text('all ' + total + ' contacts');
                $("#c1").empty().append(option3);
                $("#c1").append(option4);
                $("#c2").empty().append(option3a);
                $("#c2").append(option4a);
                $("#c3").empty().append(option3b);
                $("#c3").append(option4b);
                $("#c4").empty().append(option3c);
                $("#c4").append(option4c);
                $("#donotcontact_txt").text('Mark ' + checkedAmount + ' selected contact as "Do Not Contact" for your account.');

            } else {
                $("form#formID INPUT[@name='selectContact'][type='checkbox']").attr('checked', false);

                var option1 = $('<option></option>').attr("value", '-').text('Please select contacts');
                var option2 = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                var option1a = $('<option></option>').attr("value", '-').text('Please select contacts');
                var option2a = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                var option1b = $('<option></option>').attr("value", '-').text('Please select contacts');
                var option2b = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                var option1c = $('<option></option>').attr("value", '-').text('Please select contacts');
                var option2c = $('<option></option>').attr("value", total).text('all ' + total + ' contacts');
                $("#c1").empty().append(option1);
                $("#c1").append(option2);
                $("#c2").empty().append(option1a);
                $("#c2").append(option2a);
                $("#c3").empty().append(option1b);
                $("#c3").append(option2b);
                $("#c4").empty().append(option1c);
                $("#c4").append(option2c);
                $("#donotcontact_txt").text('Select contacts to mark as "Do Not Contact" for your account.');

            }

        });



        $("input[name$='chkUnsub1']").click(function () {
            
            if ($("input[name$='chkUnsub1']").is(':checked')) {
                $("#subunsub-title").text("Subscribe");
                $("#subunsub-action").text("Subscribe");
                $("#subunsub-submit").prop('value', 'Subscribe Contacts back to their Lists');
            } else {
                $("#subunsub-title").text("Unsubscribe");
                $("#subunsub-action").text("Unsubscribe");
                $("#subunsub-submit").prop('value', 'Unsubscribe Contacts from their Lists');
            }
        });
        //<input type="radio" name="actions" value="unsubscribe" />Unsubscribe

        $("a[title='browse_all']").live('click', function () {
            //alert("Link klicked ...");
            var $tabs = $('#tabs').tabs(); // first tab selected
            $tabs.tabs('select', 1);
            return false;
        });


        $("#date1").datepicker({ showOn: 'button', buttonImageOnly: true, buttonImage: './img/icon_cal.png' });
        $("#date2").datepicker({ showOn: 'button', buttonImageOnly: true, buttonImage: './img/icon_cal.png' });


    });

</script>


<script type="text/javascript" src="./ui/js/tabcontent.js"></script>    
    
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
		
		.desc {position: relative; display: none; line-height: 200%}


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
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            	<div id="emails-common-panel">
                 <asp:Panel ID="pnlSearch" runat="server">
					<div id="contacts-search-container">
                        <!--
                        <div id="total-contacts-info">
                        sfsafsdf
                        </div>
                      -->
                        <div id="tabs">
                            <ul>
                                <li><a href="#fragment-1"><span>Browse Contacts</span></a></li>
                                <li><a href="#fragment-2"><span>Search Contacts</span></a></li>
                            
                            </ul>
                            <div id="fragment-1" style="position:relative; float: none; margin: 0 auto; width: 400px">
                                
								<table border="0" width="100%">
                                	<tr>
                                        <td align="left" valign="top" width="20%">
                                        	<div style="position: relative; width: 100%; height: 30px; margin: 0 0">
                                            	<span class="search-form-text">Browse by list or segment: <br/></span>
                                            </div>
                                            <div style="position: relative; width: 100%; min-height: 50px; margin: 0 0">
                                            
                                                <asp:DropDownList ID="lstContactLists" runat="server" Width="400px" DataTextField="NAME" DataValueField="ID">
                                                </asp:DropDownList>
                                            
                                                <asp:HiddenField ID="hdModeSearch" runat="server" Value="0" />
                                            <br/>
                                              <div style="position: relative; width: 100%;  margin: 0 0; padding: 0; background: #fffeee; border-top: 1px dashed #000; border: 1px dashed #000;">
                                        	<div style="margin: 10px; height: auto; line-height: 200%">
                                                <asp:Label ID="lblTotalContacts" runat="server" Text="Label"></asp:Label> contacts in your account<br/>
                                                <asp:Label ID="lblTotalSub" runat="server" Text="Label"></asp:Label> contacts subscribed to lists
                                            </div>
                                          </div><br/><br/>
                                                <asp:CheckBox ID="chkUnSub1" runat="server" />Browse unsubscribed contacts only.
                                            <p align="left">
                                            <asp:Button ID="btnBrowse" runat="server" Text="Browse" Width="120px" 
                                                    onclick="btnBrowse_Click" />
                                            </p>
                                            </div>
                                        </td>
                                       
                                    </tr>
                                </table>
                                    
                         		
         

                            </div>
                            <div id="fragment-2">
                               
                            <!--aaaaaaaaaaaaaaaaaaaaaaaaaaaaa-->
                            	
                           <div class="create-message-step1-container1">
                                        	<fieldset>
                            <legend>
                                Quick Contact Search
                            </legend>
                            <label>
                                <asp:TextBox ID="txtQSearch" runat="server" CssClass="text-input1"></asp:TextBox>     
                                <asp:Button ID="btnQSearch" runat="server" Text="Quick Search" CssClass="submit2" 
                                                    onclick="btnQSearch_Click" />                           
                                
                                 <div style="float: right; display: inline-block; padding: 0; margin: 5px 0">
                                     <asp:LinkButton ID="lnkBrowseAll" runat="server" CssClass="common-button" 
                                         onclick="lnkBrowseAll_Click">Browse all my contacts</asp:LinkButton>
                                </div>
                                <br/>
                                <asp:CheckBox ID="chkUnsub2" runat="server" />Browse unsubscribed contacts only.
                            </label>
                         </fieldset>   
	                    
                        <br/>
                        
                        <fieldset>
                            <legend>
                                Advanced Contacts Search
                            </legend>
                            
                            
                                <table width="400" cellpadding="0">
                                	<tr>
                                    	<td><span>Prefix</span><asp:TextBox ID="txtPrefix" runat="server" CssClass="text-prefix"></asp:TextBox></td>
                                    	<td><span>Last Name</span><asp:TextBox ID="txtLName" runat="server" CssClass="text-lastname"></asp:TextBox></td>
                                    	<td><span>First Name</span><asp:TextBox ID="txtFName" runat="server" CssClass="text-firstname"></asp:TextBox></td>
                                    	<td><span>Suffix</span><asp:TextBox ID="txtSuffix" runat="server" CssClass="text-suffix"></asp:TextBox></td>                                                                                                                        
                                    </tr>
                                </table>
                                <span>Address 1 : </span>
                                <asp:TextBox ID="txtAddress1" runat="server" CssClass="text-input"></asp:TextBox>
                                <span>Address 2 : </span>
                                <asp:TextBox ID="txtAddress2" runat="server" CssClass="text-input"></asp:TextBox>
                                <table width="300">
                                	<tr>
                                    	<td width="40%"><span>City</span><asp:TextBox ID="txtCity" runat="server" CssClass="text-city"></asp:TextBox></td>
                                    	<td width="40%"><span>State or Province</span><asp:TextBox ID="txtProvince" runat="server" CssClass="text-state"></asp:TextBox></td>
                                    	<td width="20%"><span>Zip</span><asp:TextBox ID="txtZip" runat="server" CssClass="text-zip"></asp:TextBox></td>
                                    	                                                                                                                      
                                    </tr>
                                </table>
                                <table width="300">
                                	<tr>
                                    	<td><span>Business Name</span><asp:TextBox ID="txtBusiness" runat="server" CssClass="text-businessname"></asp:TextBox></td>
                                    	<td><span>Phone</span><asp:TextBox ID="txtPhone" runat="server" CssClass="text-phone"></asp:TextBox></td>
                                    	<td><span>Fax</span><asp:TextBox ID="txtFax" runat="server" CssClass="text-fax"></asp:TextBox></td>
                                    	                                                                                                                      
                                    </tr>
                                </table>
                                
                                <span style="font-size: 13px; font-weight: bold;">Date Range </span><br/>
                                <span style="font-size: 10px;">(Search for Contacts added during a specific date range)</span><br/>
                                <span>Beginning Date : </span>
                                <asp:TextBox ID="date1" runat="server"></asp:TextBox>&nbsp;&nbsp;
                                <span>Ending Date : </span>
                                <asp:TextBox ID="date2" runat="server"></asp:TextBox>                                
                             <asp:Button ID="btnSearch" runat="server" CssClass="submit" 
                                Text="Search Contacts" onclick="btnSearch_Click" />  	
								
                        </fieldset>
                                        
                        
                        
                        
						
						
                       
                    </div> 
                            
                            
                            
                            <!--aaaaaaaaaaaaaaaaaaaaaaaaaaaaa-->
                            
                            
                           
                            </div>
                                                
                        </div>

                                               
                    </div>
                </asp:Panel>
                    <asp:Panel ID="pnlSearchResutls" runat="server" Visible="false">
                    <div id="contacts-search-container">
                    	
                         <asp:GridView ID="selectContactContainer"  CssClass="contact-grid" 
                             BackColor="White" Width="100%" CellPadding="2" 
                                CellSpacing="1" BorderWidth="0px" GridLines="None"
                                   HeaderStyle-BackColor="#bcc1c4" RowStyle-CssClass="r1"   
                                runat="server"  AutoGenerateColumns ="False"      
                             AllowPaging="True"                                  PageSize="20" 
                             ondatabound="selectContactContainer_DataBound" 
                             onrowdatabound="selectContactContainer_RowDataBound" >

                             <Columns>
                                 <asp:BoundField DataField="ID" Visible="False" />
                                 <asp:TemplateField>
                                         <ItemTemplate>
                                                    <asp:CheckBox ID="selectContact" runat="server"  onclick="UnCheckDataGridCheckBoxes('chk_SelectAll','Chk_select')"  />
                                                  <asp:HiddenField ID="hdContactID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem, "ID")%>'/>
                                          </ItemTemplate>
                                        <HeaderTemplate>
                                            <asp:CheckBox ID="selectall" runat="server" name="selectall" 
                                                onclick="CheckAllDataGridCheckBoxes('Chk_select')" />
                                        </HeaderTemplate>
                                        <HeaderStyle HorizontalAlign="Center" Width="5%" />
                                        <ItemStyle HorizontalAlign="Center" />
                                 </asp:TemplateField>
                                 <asp:BoundField DataField="Email" HeaderText="Email" >
                                 <HeaderStyle Width="20%" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="FirstName" HeaderText="First Name" >
                                 <HeaderStyle Width="15%" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="LastName" HeaderText="Last Name" >
                                 <HeaderStyle Width="15%" />
                                 </asp:BoundField>
                                 
                                  <asp:TemplateField HeaderText="List Name">
                                      <ItemTemplate>
                                          <asp:Label ID="lblListName" runat="server" Text=""></asp:Label>
                                      </ItemTemplate>
                                     <HeaderStyle Width="20%" />
                                 </asp:TemplateField>

                                  
                                 <asp:BoundField DataField="ModifiedDate" DataFormatString="{0:g}" 
                                     HeaderText="Added on" >
                                 <HeaderStyle Width="15%" />
                                 </asp:BoundField>
                                    <asp:TemplateField HeaderText="Actions">
                                     <ItemTemplate>
                                         <table class="message-action">
                                             <tr>
                                              
                                                 <td width="100%">
                                                    <a href='adContact.aspx?mode=Edit&contactID=<%#DataBinder.Eval(Container.DataItem, "ID")%>' > Edit</a>
                                                 </td>
                                             </tr>
                                         </table>
                                     </ItemTemplate>
                                     <HeaderStyle Width="10%" />
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
                                    <asp:ListItem Selected="True">20</asp:ListItem>
                                    <asp:ListItem>50</asp:ListItem>
                                    <asp:ListItem>100</asp:ListItem>
                                </asp:DropDownList> contacts / page
                        </div>
                        <div class="pagination">
                            <div class="PgCounter">
                                   Page <asp:Label ID="lblCurrentPage" runat="server" Text="0"></asp:Label>/<asp:Label ID="lblTotalPages" runat="server"  Text="0"></asp:Label> 
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
                                    <input type="hidden" id="TotalSize" runat="server" />
                                    <input type="hidden" id="TotalPages" runat="server" value="0"/>
                                </div>   
                        </div>
                    </div>
                    </asp:Panel>
                    <asp:Panel ID="pnlAction"  runat="server" Visible="false" >
                    <div class="message-list-bottom">
                    	<div id="myRadioGroup" style="position: relative; float: left; width: 150px; margin: 0 0; line-height: 200%">
        					
                            <fieldset>
                            <legend>
                            Actions
                            </legend>
                            <input type="radio" name="actions" value="copy" />Copy<br/>
                            <input type="radio" name="actions" value="unsubscribe" /><asp:Label ID="lblUnSubscribe" runat="server" Text="Label">Unsubscribe</asp:Label><br/>
                            <input type="radio" name="actions" value="delete" />Delete<br/>
                            <input type="radio" name="actions" value="export" />Export<br/>
                            <!--<input type="radio" name="actions" value="donotcontact" />Do not contact -->
							</fieldset>
                            
                    	</div>
                        <div style="position: relative; float: none; width: 400px; margin-left: 160px;">
                        	<div id="copy" class="desc">
                                <label>Copy</label>
                                <select type="text" name="c1" id="c1">
                                    <option value="">Please select contacts</option>
                                </select><br/><br/>
                                <label>To</label>
                                                                            
                                <asp:DropDownList ID="ddlCopyContacts" runat="server" DataTextField="LISTNAME" 
                                    DataValueField="ID">
                                </asp:DropDownList>      	
                                
                                 &nbsp; 
                                <label>(or new list)</label>
                                <asp:TextBox ID="txtCopyList" runat="server" CssClass="text-prefix"></asp:TextBox>
                                <br/><br/>
                                <asp:Button ID="btnCopyContacts" runat="server" Text="Add Contacts to List" 
                                    onclick="btnCopyContacts_Click" />
                            </div>
                            <div id="unsubscribe" class="desc">
                                <label>Unsubscribe</label>
                                <select type="text" name="c2" id="c2">
                                    <option value="">Please select contacts</option>
                                </select>&nbsp;&nbsp;
                                <label>from</label>
                                <asp:DropDownList ID="ddlUnsubContacts" runat="server" DataTextField="LISTNAME" 
                                    DataValueField="ID" /><br/><br/>
                                <asp:Button ID="btnUnsubContacts" runat="server" 
                                    Text="Unsubscribe Contacts from List" onclick="btnUnsubContacts_Click" />
                                <br/>
                                (This action cannot be undone)
                            </div>                            
                            <div id="delete" class="desc">
                                <label>Delete</label>
                                <select type="text" name="c3" id="c3">
                                    <option value="">Please select contacts</option>
                                </select>&nbsp;&nbsp;
                                <label>from your account</label><br/><br/>
                                <asp:Button ID="btnDeleteContacts" runat="server" Text="Delete Contacts" 
                                    onclick="btnDeleteContacts_Click" /><br/>
                                (This action cannot be undone)
                            </div>
                            <div id="export" class="desc">
                                <label>Export</label>
                                <select type="text" name="c4" id="c4">
                                    <option value="">Please select contacts</option>
                                </select>
                                <br/><br/>
                                <asp:Button ID="btnExportContacts" runat="server" Text="Export Contacts" 
                                    onclick="btnExportContacts_Click" /><br/>
                            </div>
                             <div id="donotcontact" class="desc">
                                <span id="donotcontact_txt">Select contacts to mark as "Do Not Contact" for your account.</span>
                                <br/>
                                <asp:Button ID="btnDonotContact" runat="server" Text='Mark as "Do not contact"' />
                                <br/>
                            </div>
                        </div>
                    
                    </div>
                   </asp:Panel>




					
                	
                
                </div>     
                  
                	              
                </div>
               
                
                
                
                

            
            </div>     
            <!-- BEGIN: Footer -->
			<div id="footer">

            </div>
            
            <div class="copyright">Copyright © 2012 Optlynx, Inc.</div>
            




       
    

    
    </div>


	
	</form>
	</body>
</html>
