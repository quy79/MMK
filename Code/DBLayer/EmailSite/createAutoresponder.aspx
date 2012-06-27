<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createAutoresponder.aspx.cs" Inherits="EmailSite.createAutoresponder" %>
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
<link rel="stylesheet" href="./ui/css/dlg.css" type="text/css"/>
<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>
<link rel="stylesheet" href="./ui/css/ui.all.css" type="text/css" media="screen" />



<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script src="./ui/js/jquery.ValidationEngine-en.js" type="text/javascript" charset="utf-8"></script>
<script src="./ui/js/jquery.ValidationEngine.js" type="text/javascript" charset="utf-8"></script>

<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"></script>
<script src="./ui/js/dlg.js" type="text/javascript" charset="utf-8"></script>
    
    
        
    
	<script>
	    jQuery(document).ready(function () {
	        // binds form submission and fields to the validation engine
	        jQuery("#formID").validationEngine();

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
    <form id="formID" class="formular" method="post" action="myautoresponders.html">
    <div id="main">
	    <div class="page-container">
        	<div id="header">  
				<div id="logo">
					<a href="index.html">
                    	<img src="./img/logo.jpg" border="0"/>
					</a>
				</div>
                <div class="header-right">
					<div class="topbar">
						<a href="/rnavmap/evaluate.rnav/account/home?activepage=account.home&ctoken=d38863c8-b16d-4022-8cd1-8e78871b3350">My Account</a>&nbsp;&nbsp;|&nbsp;&nbsp;
						<a href="javascript:showHelp();">Help</a>&nbsp;&nbsp;|&nbsp;&nbsp;
                        <a id="header_logout" href="login.html">Log Out</a>
					</div>
				</div>
                <div class="welcome">Welcome to OptMailMarketting,&nbsp;<span id="header_contact_firstname">quy</span>!</div>
			</div>
            
            
            <!-- BEGIN: Primary Navigation -->
            <div class="nav-list-wrap">
				<ul class="main-nav" id="navi">
                	<li class="mn-nav-prdcts">
        				<a href="index.html" class="" id="mainNavHome">Home</a>
					</li>

      				<li class="mn-nav-prdcts selected">
        				<a href="emails.html" class="" id="mainNavEmailMarketing" >
						   <span class="ic-emails"></span>Email
                   		</a>
                        
                        <ul>
                            <li><a href="emails.html">Messages</a></li>
                            <li><a href="#">Pending messages</a></li>
                            <li><a href="myautoresponders.html">Autoresponder</a>
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
        				<a href="contacts.html" class="" id="mainNavEmailMarketing">
						   <span class="ic-contacts"></span>Contacts
                   		</a>
                        
                        <ul>
                            <li><a href="#">List</a></li>
                            <li><a href="add-contacts.html">Add contacts</a></li>
                            <li><a href="search-contacts.html">Browse / Search contacts</a></li>
                            <li><a href="mysegments.html">Segments</a></li>		
                           				
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
            
            	<div id="emails-common-panel">

                	<div class="common-title">
                    <h2>Create an Autoresponder</h2><br/>
                    <span>Use autoresponders to schedule a series of emails to be sent to new contacts. Schedule each email on the basis of the contact's subscription date.</span>
                    </div>                    
                    <div class="create-message-step1-container1">
                    <br/>
           	 		<!--<form id="formID" class="formular" method="post" action="">-->
                        <span>Autoresponder Name<br/></span>
                        <span style="font-size: 11px;">(not viewable by yours contacts)</span><br/>
                        <input value="" class="validate[required] text-input" type="text" name="autoresponder_name" id="autoresponder_name" /><br/>
                        <span>Autoresponder Description<br/></span>
                        <span style="font-size: 11px;">(not viewable by yours contacts)</span><br/>
						<textarea class="validate[required] text-input" rows="15" cols="50" name="autoresponder_description" style="height: 120px" ></textarea><br/>
                        <span>Source List<br/>
                        <select style="width: 400px;" name="source_list" id="source_list">					
                            <option value="list001">List #001</option>
                            <option value="list002">List #002</option>
                            <option value="list003">List #003</option>
                            <option value="list004">List #004</option>
                            <option value="list005">List #005</option>
                        </select><br/>
						<span>Autoresponder From Name<br/></span>
                        <span style="font-size: 11px;">The person's name that this message will come from.</span><br/>
                        <input value="" class="validate[required] text-input" type="text" name="autoresponder_from_name" id="autoresponder_from_name"/><br/>
                        <span>Autoresponder From Email<br/></span>
                        <span style="font-size: 11px;">The person's Email Address that this message will come from.</span><br/>
                        <input value="" class="validate[required] text-input" type="text" name="autoresponder_from_email" id="autoresponder_from_email"/><br/>
                         <span>Please specify Interval of Autoresponder<br/></span>
                        <span style="font-size: 11px;">(Number of days after that each messages in Autoresponder will be re-sent, minimum is 1 day.)</span><br/>
                        <input value="" class="validate[required] text-input" type="text" name="autoresponder_frequency" id="autoresponder_frequency"/><br/>
                       
                       
                    </div>
                    <div class="autoresponder-bottom">
                    <input type="submit" value="Save Autoresponder" class="submit3" />
                        <div style="display: inline-block; margin: 0 0; padding: 2px 50px;  float: right; width: 130px;">
                            <a href="myautoresponders.html" class="common-button">Cancel</a>
                        </div>
                    </div> 
					<!--</form>-->
                    
                    


                        

						                        
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
