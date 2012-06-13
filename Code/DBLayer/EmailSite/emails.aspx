<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emails.aspx.cs" Inherits="EmailSite.emails" %>
<%@ Register src="logo.ascx" tagname="logo" tagprefix="uc1" %>
<%@ Register src="navigation.ascx" tagname="navigation" tagprefix="uc2" %>
<%@ Register src="headerHTML.ascx" tagname="headerHTML" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<uc3:headerHTML ID="headerHTML1" Title="Email" runat="server" />
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    
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
                                        	<a href="" class=""><div class="create-autoresponders">Create an Autoresponder</div></a>
                                        </li>
                                        <li>
                                        	<a href="" class=""><div class="my-autoresponders">My Autoresponders</div></a>
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
                            	<form name="messages_filter_frm" id="messages_filter_frm">
                                Show : &nbsp;
                                <select name="rowspage">
                                	<option value="0" selected>All</option>
                                    <option value="1">Successful sent</option>
                                    <option value="2">Failed</option>
                                    <option value="3">Pending</option>                                    
                                </select> Messages
                                </form>
                        	</div>
                            <div class="messages-stat">
                            	Total 150 messages :&nbsp;&nbsp;200 successful sent&nbsp;&nbsp;|&nbsp;&nbsp;50 failed&nbsp;&nbsp;|&nbsp;&nbsp;150 pending
                            </div>
                        </div>
                	<div class="message-list" id="message-list">
                          <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td>
                                  <table class="contact-grid" bgcolor="#ffffff" width="100%" border="0" cellspacing="1" cellpadding="1">
                                    <tr>
                                      <th bgcolor="#95949b" width="10%" align="center">Message ID</th>
                                      <th bgcolor="#95949b" width="25%" align="center">Message Name</th>
                                      <th bgcolor="#95949b" width="15%" align="center">Status</th>
                                      <th bgcolor="#95949b" width="20%" align="center">Target List</th>
                                      <th bgcolor="#95949b" width="10%" align="center">Created date</th>
                                      <th bgcolor="#95949b" width="20%" align="center">Action</th>

                                    </tr>
                                    <tr>
                                      <td class="r1">msg0001</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-failed-text">failed</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-pending-text">pending...</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1" bgcolor="#d5d6d9">msg0002</td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >text text text text text text</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1" bgcolor="#d5d6d9"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" bgcolor="#d5d6d9" align="center">2012-05-22</td>
                                      <td class="r1" bgcolor="#d5d6d9">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="r1">msg0003</td>
                                      <td class="r1"><a href="" >text text text text text text</a></td>
                                      <td class="r1" align="center"><span class="status-success-text">successful sent</span></td>
                                      <td class="r1"><a href="" >Contacts list #1</a></td>
                                      <td class="r1" align="center">2012-05-22</td>
                                      <td class="r1">
											<table class="message-action">
                                            	<tr>
                                                	<td width="33%"><a href="">Edit</a></td>
                                                    <td width="34%"><a href="">Re-use</a></td>
                                                    <td width="33%"><a href="">Delete</a></td>
                                                </tr>
                                            </table>
                                      </td>
                                    </tr>

                                  </table>
                              </td>
                            </tr>
                          </table>
                          
                        </div>
                        <div class="message-list-bottom">
                        	<div class="list-display-setting">
                            	<form name="list_setting_frm" id="list_setting_frm">
                                Display&nbsp;
                                <select name="rowspage">
                                	<option value="20" selected>20</option>
                                    <option value="50">50</option>
                                    <option value="100">100</option>                                    
                                </select> messages / page
                                </form>
                        	</div>
                            <div class="pagination">
                            	<div class="PgCounter">Page 1/12  <span class="paging">1</span> <a title="201 - 400" href="javascript:{}" onclick="load_pg(24780,200,2)">2</a>  <a title="401 - 600" href="javascript:{}" onclick="load_pg(24780,200,3)">3</a>  <a title="601 - 800" href="javascript:{}" onclick="load_pg(24780,200,4)">4</a>  <a title="601 - 800" href="javascript:{}" onclick="load_pg(24780,200,11)">11</a>  <a title="201 - 400" href="javascript:{}" onclick="load_pg(24780,200,2)">»</a> <a title="24600 - 24780" href="javascript:{}" onclick="load_pg(24780,200,124)">».</a></div>
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
	</body>
</html>
