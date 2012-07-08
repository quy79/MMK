<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unsubscribe.aspx.cs" Inherits="EmailSite.unsubscribe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html dir="ltr">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>OPTMailMarketting Login</title>
    <!-- EXTERNAL CSS -->
    <link href="./ui/css/login.css" rel="stylesheet" type="text/css" />
   
</head>
<body>
<form id="Form1" runat=server>
<div id="login-wrapper" class="login-whisp">
    <div id="notify">
    </div>
    
    <div id="content-container">
        <div id="login-container">

            <div id="login-sub-container">
                <div id="login-sub-header">

                    <img src="./img/logo_login.png" alt="logo" /><br/><br/><span class="box-title">UNSUBSCRIBE</span>
                </div>
                <div id="login-sub">
                    <div id="forms">
                            <div class="input-req-login"><label for="user">Email</label></div>
                            <div class="input-field-login icon username-container">
                                <asp:TextBox ID="txtUsername" runat="server" CssClass="std_textbox" 
                                    placeholder="Your Email." TabIndex="1" Enabled="False" Width="272px"></asp:TextBox>
                            </div>
                            <div class="input-req-login-error"><asp:Literal ID="errorMessage" runat="server"  ></asp:Literal></div>
                            
                           
                            <div style="width: 285px;">

                                <div class="login-btn">                                    
                                    <asp:Button  ID="btnLogin" runat="server" Text="OK" TabIndex="3" 
                                        onclick="btnLogin_Click" />                                    
                                </div>
                            </div>
                            <div class="clear" id="push"></div>
                    <!--CLOSE forms -->

                    </div>

                <!--CLOSE login-sub -->
                </div>
            <!--CLOSE login-sub-container -->
            </div>
        <!--CLOSE login-container -->
        </div>

        <div id="locale-footer">

            <div class="locale-container">

                   
              
            </div>
        </div>
    </div>
<!--Close login-wrapper -->
</div>


    <div class="copyright">Copyright © 2012 Optlynx, Inc.</div>
</form>
</body>

</html>

