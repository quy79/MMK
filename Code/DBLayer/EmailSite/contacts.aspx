<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contacts.aspx.cs" Inherits="EmailSite.contacts" %>
<%@ Register src="logo.ascx" tagname="logo" tagprefix="uc1" %>
<%@ Register src="navigation.ascx" tagname="navigation" tagprefix="uc2" %>
<%@ Register src="headerHTML.ascx" tagname="headerHTML" tagprefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<uc3:headerHTML ID="headerHTML1" Title="Email" runat="server" />

	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
  <form runat="server">
    
    <div id="main">
	    <div class="page-container">
            <uc1:logo ID="logo" runat="server" />
			 <uc2:navigation ID="navigation" MenuType="contacts" runat="server" />
          
            <div id="content-main">
            
            	<div id="emails-common-panel">
                	<div id="emails-panel-left">
                    	<div id="emails-box-left">
                        	<div class="list-box-left-header">
		                        <div class="emails-box-left-title">
                                My Lists
                                </div>
                                <div class="emails-box-left-note">
                                
                                </div>
                            </div>
                            <div class="my-lists-body">
                            	 <div id="box-explain">List helps you organize your contacts. For example, you can create one for each of your newsletter.</div>
                            	 <div id="emails-navcontainer">
                                    <ul id="emails-navlist">
                                        <li>
                                        	<a href="createlist.aspx" class=""><div class="create-list">Create a List</div></a>
                                        </li>
                                        <li>
                                        	<a href="mylists.aspx" class=""><div class="my-lists">My Lists</div></a>
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
                        	<div class="list-box-right-header">
		                        <div class="emails-box-left-title">
                                Add Contacts
                                </div>
                                <div class="emails-box-left-note">
                                
                                </div>
                            </div>
                            <div class="add-contacts-body">
                            	 <div id="box-explain">It's easy to add contacts. Import using a CSV file, copy and paste, or add them one at a time. You can also create a sign-up form to post on your website.</div>
                            	 <div id="emails-navcontainer">
                                    <ul id="emails-navlist">
                                        <li>
                                        	<a href="uploadContacts.aspx" class=""><div class="upload-contacts">Upload from file</div></a>
                                        </li>
                                        <li>
                                        	<a href="addcontacts.aspx" class=""><div class="add-contact">Add a new contact</div></a>
                                        </li>
                                        <li>
                                        	<a href="copy-contact.html" class=""><div class="copy-contact">Copy & pate</div></a>
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
                	<div id="emails-panel-left">
                    	<div id="emails-box-left">
                        	<div class="search-box-left-header">
		                        <div class="emails-box-left-title">
                                Search My Contacts
                                </div>
                                <div class="emails-box-left-note">
                                
                                </div>
                            </div>
                            <div class="search-contacts-body">
                            	 <div id="box-explain">If you want to review your new subscribers, search for a specific contact, or edit contacts manually, this is the place to go.</div>
                            	 <div id="emails-navcontainer">
                                    <ul id="emails-navlist">
                                        <li>
                                        	<a href="searchContacts.aspx" class=""><div class="search-contacts">Search / Browse Contacts</div></a>
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
                        	<div class="segments-box-right-header">
		                        <div class="emails-box-left-title">
                                My Segments
                                </div>
                                <div class="emails-box-left-note">
                                
                                </div>
                            </div>
                            <div class="segments-body">
                            	 <div id="box-explain">Segments are a powerful tool for targeting specific subscribers. Use segments to create targeted lists based on subscriber data.</div>
                            	 <div id="emails-navcontainer">
                                    <ul id="emails-navlist">
                                        <li>
                                        	<a href="createSegment.aspx" class=""><div class="create-segment">Create a Segment</div></a>
                                        </li>
                                        <li>
                                        	<a href="mysegments.aspx" class=""><div class="my-segments">My Segments</div></a>
                                        </li>

                                    </ul>
                                </div>
                            </div>
                            <div class="emails-box-left-bottom">
                            </div>
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
	

	        
</form>  	
	</body>
</html>
