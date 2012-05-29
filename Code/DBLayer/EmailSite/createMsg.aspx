<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createMsg.aspx.cs" Inherits="EmailSite.createMsg" %>
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
			 <uc2:navigation ID="navigation" MenuType="home" runat="server" />
            
            <div id="content-main">
            
            	<div id="emails-common-panel">

                	<div class="create-message-step1-container">
                    <h2>CREATE AN EMAIL MESSAGE</h2>
                    </div>
           	  <div class="create-message-step1-container">
                    	<div id="message-template-container">
                           
                                    <a href="createTemplateEmail.aspx">
                                    	<div id="message-template-box">
                                        	<div class="message-template-box-left">
                                            </div>
                                        	<div class="message-template-box-right">
                                            	<div class="message-template-box-right-title"> 
		                                            Create Message from template
                                                </div>    
                                                <div class="message-template-box-right-note">
                                                Use pre-designed template with WYSIWYG HTML tool to create Email Message in just a few minutes !
                                                </div>
                                            </div>                                            
                                        </div>S
                                    </a>
                              
                        </div>
                    
                        <div id="message-plaintext-container">
                                    <a href="createTextEmail.aspx">
                                        <div id="message-plaintext-box">
                                        Create Text-Only Email
                                                                                
                                        </div>
                                    </a>
                  </div>
                        
<div id="message-plaintext-container">
                                    <a href="createHTMLEmail.aspx">
                                        <div id="message-plaintext-box">
                                        Create Message with WYSIWYG HTML EDITOR
                                                                                
                                        </div>
                                    </a>
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
                                      <td bgcolor="#95949b" width="10%" align="center">Message ID</td>
                                      <td bgcolor="#95949b" width="25%" align="center">Message Name</td>
                                      <td bgcolor="#95949b" width="15%" align="center">Status</td>
                                      <td bgcolor="#95949b" width="20%" align="center">Target List</td>
                                      <td bgcolor="#95949b" width="10%" align="center">Created date</td>
                                      <td bgcolor="#95949b" width="20%" align="center">Action</td>

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
            
            
    	</div>
	</div>
	
	</body>
</html>
