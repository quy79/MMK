<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="EmailSite.home" %>
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
		<script src="./ui/js/WindowControl.js"></script>
        
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
    
    <div id="main">
	    <div class="page-container">
        	<div id="header">  
				<div id="logo">
					<a href="">
                    	<img src="./img/logo.jpg" border="0"/>
					</a>
				</div>
                <div class="header-right">
					<div class="topbar">
						<a href="./MyAccount.aspx?id=aaa">My Account</a>&nbsp;&nbsp;|&nbsp;&nbsp;
						<a href="javascript:showHelp();">Help</a>&nbsp;&nbsp;|&nbsp;&nbsp;
                        <a id="header_logout" href="logout.aspx">Log Out</a>
					</div>
				</div>
                <div class="welcome">Welcome to OptMailMarketting,&nbsp;<span id="header_contact_firstname">quy</span>!</div>
			</div>
            
            
            <!-- BEGIN: Primary Navigation -->
            <div class="nav-list-wrap">
				<ul class="main-nav" id="navi">
                	<li class="mn-nav-prdcts selected">
        				<a href="/rnavmap/evaluate.rnav/pidbbGa4P2Yc4B007A81QUR6?activepage=site.home" class="" id="mainNavHome">Home</a>
					</li>

      				<li class="mn-nav-prdcts">
        				<a href="emails.html" class="" id="mainNavEmailMarketing" >
						   <span class="ic-emails"></span>Email
                   		</a>
                        
                        <ul>
                            <li><a href="#">Messages</a></li>
                            <li><a href="#">Pending messages</a></li>
                            <li><a href="#">Autoresponder</a>
                            <!--
                                <ul>
                                    <li><a href="#">More About Us</a></li>
                
                                    <li><a href="#">More About Them</a></li>
                                    <li><a href="#">More About You</a></li>						
                                </ul>
                            -->    
							</li>						
						</ul>
          
				
					</li>
                    <li class="mn-nav-prdcts">
        				<a href="/rnavmap/evaluate.rnav/pidbbGa4P2Yc4B007A81QUR7?activepage=ecampaign.view" class="" id="mainNavEmailMarketing">
						   <span class="ic-contacts"></span>Contacts
                   		</a>
                        
                        <ul>
                            <li><a href="#">List</a></li>
                            <li><a href="#">Add contacts</a></li>
                            <li><a href="#">Browse / Search contacts</a></li>
                            <li><a href="#">Segments</a></li>		
                           				
						</ul>
          
				
					</li>
                    <li class="mn-nav-prdcts">
        				<a href="/rnavmap/evaluate.rnav/pidbbGa4P2Yc4B007A81QUR7?activepage=ecampaign.view" class="" id="mainNavEmailMarketing">
						   <span class="ic-tracking"></span>Tracking & Reports
                   		</a>
                        <ul>
                            <li><a href="#">Last Message</a></li>
                            <li><a href="#">Sent Messages</a></li>
                            <li><a href="#">Autoresponders</a></li>
				
						</ul>
				
					</li>
                    <!--
                    <li class="mn-nav-tools">
        <a href="/rnavmap/evaluate.rnav/pidTCfpJfi7NV2bucdNig3w9?activepage=ecampaign.imglib" 
		       class="nav-images" 
		       id="mainNavLibrary" 
                   >

					
						<span class="ic-library"></span>
					
				   Library
				</a>
				
      </li>-->
                
            	</ul>
                
                
	
<script src="http://jquery-ui.googlecode.com/svn/tags/latest/ui/jquery.effects.core.js" type="text/javascript"></script>

<script type="text/javascript" src="./ui/js/menu.js"></script>
      		</div> 
            
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
	</body>
</html>
