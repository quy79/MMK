<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createTextEmail.aspx.cs" Inherits="EmailSite.createTextEmail" %>
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



	<script src="./ui/js/jquery-1.7.2.js" type="text/javascript" charset="utf-8"></script>
	<script src="./ui/js/jquery.ValidationEngine-en.js" type="text/javascript" charset="utf-8"></script>
	<script src="./ui/js/jquery.ValidationEngine.js" type="text/javascript" charset="utf-8"></script>
    
	<script src="./ui/js/dlg.js" type="text/javascript" charset="utf-8"></script>
    
    
        
    
	<script>
	    jQuery(document).ready(function () {
	        // binds form submission and fields to the validation engine
	        jQuery("#formID").validationEngine();

	    });

	    /**
	    *
	    * @param {jqObject} the field where the validation applies
	    * @param {Array[String]} validation rules for this field
	    * @param {int} rule index
	    * @param {Map} form options
	    * @return an error string if validation failed
	    */
	    function checkHELLO(field, rules, i, options) {
	        if (field.val() != "HELLO") {
	            // this allows to use i18 for the error msgs
	            return options.allrules.validate2fields.alertText;
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
		


	</style>	
    




    <title>OptMailMarketing : Home</title>	
	</head>
	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    
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
                            <li><a href="emails-create-messages-step1.html">Messages</a></li>
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
  
	


            <script type="text/javascript" src="./ui/js/menu.js"></script>
      		</div>
            
            <div id="content-main">
            
            	<div id="emails-common-panel">

                	<div class="create-message-step1-container">
                    <h2>CREATE AN EMAIL MESSAGE</h2>
                    </div>
           	 		<form id="formID" class="formular" method="post" action="">
                        <span>From Email Address : </span>
                        <input value="" class="validate[required,custom[email]] text-input" type="text" name="email_from" id="email_from" />
                        <span>Email Subject : </span>
                        <input value="" class="validate[required] text-input" type="text" name="email_subject" id="email_subject" />
						<span>Message Name : <br/>
                        (not displayed to yours contacts)                 
                        </span>
                        <input value="" class="validate[required] text-input" type="text" name="message_name" id="message_name" />
		
						<textarea class="validate[required] text-input" rows="30" cols="50" name="message_body" id="message_body" ></textarea>

						<div style="position: relative; float: left; margin-top: 20px; width: 400px;">
                        	<a class="button" href="#"><span>Spam Check</span></a>
                            <a class="login-window" href="#test-message"><span>Test message</span></a>
                            
							

                        </div>
                        

                        <input class="submit" type="submit" value="Proceed Send"/>
                     
                        <hr/>
					</form>
                    
                    


                        

						                        
                  </div>

                	              
                </div>
                
                
                
                

            
            </div>     
            <!-- BEGIN: Footer -->
			<div id="footer">
            
            </div>
            




        
        <div id="test-message" class="test-message-popup">
        <h2><font color="#FFFFFF">Send test message</font></h2>
        <a href="#" class="close"><img src="img/close_pop.png" class="btn_close" title="Close Window" alt="Close" /></a>
          <form method="post" class="test_message" action="#">
                <fieldset class="textbox">
            	
                <input id="toemail" name="toemail" value="" type="text" autocomplete="on" placeholder="Email address">
                </label>
                
                
                <button class="submit button" type="button">Send</button>
                
               
                </fieldset>
          </form>
		</div>


    
    </div>
</div>
            
          
            
    	</div>
	</div>
	


	</body>
</html>
