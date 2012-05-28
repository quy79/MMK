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
                          			Let's increase rsfsdfevenue by joining to Rights Network !      	
                                </div>
                            	
                            </div>
                            <div id="message-content-left">
                            	<div class="message-info">
                                	<ul>
                                    	<span>Type :  Plain Text</span><br/>
                                    	<span>Forwards :  0</span><br/>
                                    	<span>Releases :  0</span><br/>
                                        <span>Conplaints :  0</span><br/>
                                        <span>Unsubscribes :  0</span><br/>
                                        <span>Sent :  2012/05/21  15:26pm</span><br/>
                                        <span>Target contact list(s) : <a href="">contact list #1</a>, <a href="">contact list #2</a>, <a href="">contact list #3</a>, <a href="">contact list #4</a></span><br/>
                                        <span>Sending Complete :  2012/05/21  15:30pm</span><br/>        

                                    </ul>
                                </div>
                            </div>
                            <div id="message-content-right">
                            	<div class="message-content-right-header">
                                	<div class="message-content-right-header-body">
                                    	<span class="message-content-delivered-num">1,000</span><br/>
                                        contacts received this message.
                                    </div>
                                	
                                </div>
                                <div class="message-content-right-wrap">
                                	<table id="message-icons">
                                    	<tr>
                                        	<td class="opens"></td>
                                            <td class="info">Opens : 5%</td>
                                        </tr>
                                        <tr>
                                        	<td class="clicks"></td>
                                            <td class="info">Clicks : 30%</td>
                                        </tr>
                                        <tr>
                                        	<td class="bounces"></td>
                                            <td class="info">Bounces : 10%</td>
                                        </tr>
                                    </table>
                                    	
								</div>
                                <div id="navcontainer">
                                    <ul id="navlist">
                                        <li id="active"><a href="#" id="current">Create Message</a></li>
                                        <li><a href="#">Tracking message</a></li>
                                        <li><a href="#">Re-use this message</a></li>

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
                        	<a href="" class="contacts-actions-nav">Create new Contact List</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a href="" class="contacts-actions-nav">Import Contacts</a>
                        </div>
                        <div class="message-content-box">
                          <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td>
                                  <table class="contact-grid" bgcolor="#ffffff" width="100%" border="0" cellspacing="1" cellpadding="1">
                                    <tr>
                                      <th bgcolor="#9b82d6" width="80%">Contact List ID</td>
                                      <th bgcolor="#9b82d6" width="20%">Total of contacts</td>
                                    </tr>
                                    <tr>
                                      <td class="r1"><a href="">My contact list #1</a></td>
                                      <td class="r1">100</td>
                                    </tr>
                                    <tr>
                                      <td class="r2"><a href="">Optlynx VIP member list</a></td>
                                      <td class="r2">15</td>
                                    </tr>
                                    <tr>
                                      <td class="r1"><a href="">sdfsf saf ssfs234sdf sf324 saf 234wds af saf  234 sdaf  sadf 日本語　中国語　英語　ベトナム語　中国語　英語　ベトナム語</a></td>
                                      <td class="r1">3,000</td>
                                    </tr>
                                    <tr>
                                      <td class="r2"><a href="">sdfsf</a></td>
                                      <td class="r2">1010</td>
                                    </tr>
                                  </table>
                              </td>
                            </tr>
                          </table>
                          
                        </div>
                    
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
                                	<li>Total <span class="impression-txt">10,000</span> contacts splitted into :</li>
                                </ul>
                                <ul class="p2">
                                	<li class="node1">12 lists</li>
                                    <li class="node2">3 segments</li>
                                </ul>
                                <ul class="p1">
                                	<li>Total <span class="impression-txt">500</span> messages were sent to  <span class="impression-txt">10,352</span> contacts within 7 days.</li>
                                </ul>
                                <div class="moredetail">
                                	<a href="/safsdaf">View more...</a>
                                </div>
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
