<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="EmailSite.register" %>
<!DOCTYPE html>
<html dir="ltr">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>OPTMailMarketting Register</title>
    <!-- EXTERNAL CSS -->
    <link href="./ui/css/login.css" rel="stylesheet" type="text/css" />
    <script>
        window.DOM = { get: function (id) { return document.getElementById(id) } };
    </script>
</head>
<body>
<form runat=server>

<div id="login-wrapper" class="login-whisp">
    <div id="notify">
    <!--
        <noscript>
            <div class="error-notice">
                <img src="./img/notice-error.png" alt="Error" align="left"/>
                JavaScript is disabled in your browser.
                For cPanel to function properly, you must enable JavaScript.
                If you do not enable JavaScript, certain features in cPanel will not function correctly.
            </div>
			</noscript>
		
        <div id='login-status' class="error-notice" style="visibility: visible">
            <span class='login-status-icon'></span>
            <div id="login-status-message">Your session cookie is invalid. Please log in again.</div>
        </div>
        -->
    </div>
    

    
    <div id="content-container">
        <div id="register-container">

            <div id="register-sub-container">
                <div id="login-sub-header">

                    <img src="./img/logo_login.png" alt="logo" /><br/><br/><span class="box-title">CREATE AN ACCOUNT</span>
                </div>
                
                
                
                <div id="register-sub">
                    <div id="forms">                   	
                    
                    	<div class="formContent">
                        
                        
 							<div class="col01">
                            
                            	
                                
                                    <div class="input-req-login"><label for="user">First name</label></div>
        
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtFirstname" runat="server" autofocus="autofocus" placeholder="Enter your first name." CssClass="std_textbox" TabIndex="1"></asp:TextBox>                                        
                                    </div>
									<div class="input-req-login-error"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ErrorMessage=""  ControlToValidate="txtFirstname">Please input First name !</asp:RequiredFieldValidator></div>

                                    <div style="margin-top:5px;" class="input-req-login"><label for="pass">Phone number</label></div>
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtPhone" runat="server" autofocus="autofocus" placeholder="Enter your phone number." CssClass="std_textbox" TabIndex="3"></asp:TextBox>                                        
                                    </div>                                    
                                    <div class="input-req-login-error"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ErrorMessage=""  ControlToValidate="txtPhone">Please input Phone number !</asp:RequiredFieldValidator></div>

                                    <div style="margin-top:5px;" class="input-req-login"><label for="pass">Username</label></div>
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtUsername" runat="server" autofocus="autofocus" placeholder="Enter your username." CssClass="std_textbox" TabIndex="5"></asp:TextBox>
                                    </div>
                                    <div class="input-req-login-error"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ErrorMessage=""  ControlToValidate="txtUsername">Please input Username !</asp:RequiredFieldValidator></div>
                                    
                                    <div style="margin-top:5px;" class="input-req-login"><label for="pass">Password</label></div>
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" autofocus="autofocus" placeholder="Enter your password." CssClass="std_textbox" TabIndex="7"></asp:TextBox>
                                    </div>
                                    <div class="input-req-login-error">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ErrorMessage=""  ControlToValidate="txtPassword">Please input Password !</asp:RequiredFieldValidator>
                                     </div>
                                    
                                    <div style="width: 400px;">        
                                        <div class="login-btn">
                                            <asp:Button ID="btnRegister" runat="server" Text="Register" TabIndex="9" 
                                                onclick="btnRegister_Click" />                                            
                                        </div>        
                                        <div class="input-req-login-error">
                                             &nbsp;&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server"  ControlToCompare="txtPassword" ControlToValidate="txtPassword2">The passwords you entered do not match.</asp:CompareValidator><br />
                                             &nbsp;&nbsp;<asp:Label ID="lblErrMsg" Text="" runat=server></asp:Label>
                                         </div>    
                                    </div>

                                    
                                    <div class="clear" id="push"></div>
                            	
                            </div>
							<div class="col02">
                            
                            	
                                    <div class="input-req-login"><label for="user">Last name</label></div>
        
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtLastname" runat="server" autofocus="autofocus" placeholder="Enter your last name." CssClass="std_textbox" TabIndex="2"></asp:TextBox>
                                    </div>                                    
                                    <div class="input-req-login-error"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ErrorMessage=""  ControlToValidate="txtLastname">Please input Last name !</asp:RequiredFieldValidator></div>

                                    <div style="margin-top:5px;" class="input-req-login"><label for="pass">Email address</label></div>
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtEmail" runat="server" autofocus="autofocus" placeholder="Enter your email address." CssClass="std_textbox" TabIndex="4"></asp:TextBox>
                                    </div>
                                    <div class="input-req-login-error"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"  ErrorMessage=""  ControlToValidate="txtEmail">Please input Email address !</asp:RequiredFieldValidator></div>

                                    <div style="margin-top:5px;" class="input-req-login"><label for="pass">Company name(optional)</label></div>
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtCompany" runat="server" autofocus="autofocus" placeholder="Enter your Company name." CssClass="std_textbox" TabIndex="6"></asp:TextBox>

                                    </div>
                                    <div class="input-req-login-error">&nbsp;</div>
                                    
                                   
                                
									<div style="margin-top:5px;" class="input-req-login"><label for="pass">Confirm Password</label></div>
                                    <div class="input-field-login icon">
                                        <asp:TextBox ID="txtPassword2" TextMode="Password" runat="server" autofocus="autofocus" placeholder="Enter your confirm password." CssClass="std_textbox" TabIndex="8"></asp:TextBox>
                                    </div>
                                    <div class="input-req-login-error"><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"  ErrorMessage=""  ControlToValidate="txtPassword2">Please input confirm Password !</asp:RequiredFieldValidator></div>
                            </div>          

                                       
                        </div>


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

                <ul id="locales_list">
                    
                        
                        <li><a href="/?locale=en">English</a></li>
                    
                        
                        <li><a href="/?locale=ar">Japanese</a></li>
                    
                        
                        <li><a href="login.aspx">Login</a></li>
                 </ul>       
              
            </div>
        </div>
         <div class="copyright">Copyright © 2012 Optlynx, Inc.</div>
<script>
    // Homerolled.   We're not logged in and don't have access to cjt and yui.

    var MESSAGES = {
        "ajax_timeout": "The connection timed out. Please try again.",
        "authenticating": "Authenticating …",
        "changed_ip": "Your IP address has changed. Please log in again.",
        "expired_session": "Your session has expired. Please log in again.",
        "invalid_login": "The login is invalid.",
        "invalid_session": "Your session cookie is invalid. Please log in again.",
        "invalid_username": "The submitted username is invalid.",
        "network_error": "A network error occurred while sending your login request. Please try again. If this condition persists, contact your network service provider.",
        "no_username": "You must specify a username to login.",
        "prevented_xfer": "The session could not be transferred because you were not accessing this service over a secure connection. Please login now to continue.",
        "session_locale": "The locale selected here will be in effect for the current browser session, regardless of your account's saved locale preference.",
        "success": "Login successful. Redirecting …",
        "token_incorrect": "The security token in your request is invalid.",
        "token_missing": "The security token is missing from your request.",
        "": 0
    };
    delete MESSAGES[""];

    window.IS_LOGOUT = false;

    "use strict"; var FADE_DURATION = 0.45; var FADE_DELAY = 20; var AJAX_TIMEOUT = 30000; var LOCALE_FADES = []; var HAS_CSS_OPACITY = "opacity" in document.body.style; var login_form = DOM.get("login_form"); var login_username_el = DOM.get("user"); var login_password_el = DOM.get("pass"); var login_submit_el = DOM.get("login_submit"); var div_cache = { "login-page": DOM.get("login-page") || false, "locale-container": DOM.get("locale-container") || false, "login-container": DOM.get("login-container") || false, "locale-footer": DOM.get("locale-footer") || false, "content-cell": DOM.get("content-container") || false, invalid: DOM.get("invalid") || false }; var content_cell = div_cache["content-cell"]; if (div_cache["locale-footer"]) { div_cache["locale-footer"].style.display = "block" } var reset_form = DOM.get("reset_form"); var reset_username_el = DOM.get("reset_pass_username"); var RESET_FADES = []; var show_reset = function () { if (!reset_username_el.value) { reset_username_el.value = login_username_el.value } while (RESET_FADES.length) { clearInterval(RESET_FADES.shift()) } RESET_FADES.push(fade_in(reset_form)); RESET_FADES.push(fade_out(login_form)); reset_username_el.focus() }; var hide_reset = function () { while (RESET_FADES.length) { clearInterval(RESET_FADES.shift()) } RESET_FADES.push(fade_in(login_form)); RESET_FADES.push(fade_out(reset_form)); login_username_el.focus() }; function toggle_locales(a) { while (LOCALE_FADES.length) { clearInterval(LOCALE_FADES.shift()) } var c = div_cache[a ? "locale-container" : "login-container"]; set_opacity(c, 0); if (HAS_CSS_OPACITY) { content_cell.replaceChild(c, content_cell.children[0]) } else { var b = content_cell.children[0]; content_cell.insertBefore(c, b); c.style.display = ""; b.style.display = "none" } LOCALE_FADES.push(fade_in(c)); LOCALE_FADES.push((a ? fade_out : fade_in)("locale-footer")) } if (HAS_CSS_OPACITY) { var set_opacity = function set_opacity(b, a) { b.style.opacity = a } } else { var filter_regex = /(DXImageTransform\.Microsoft\.Alpha\()[^)]*\)/; var set_opacity = function set_opacity(c, a) { var b = c.currentStyle.filter; if (!b) { c.style.filter = "progid:DXImageTransform.Microsoft.Alpha(enabled=true)" } else { if (!filter_regex.test(b)) { c.style.filter += " progid:DXImageTransform.Microsoft.Alpha(enabled=true)" } else { var f = b.replace(filter_regex, "$1enabled=true)"); if (f !== b) { c.style.filter = f } } } try { c.filters.item("DXImageTransform.Microsoft.Alpha").opacity = a * 100 } catch (d) { try { c.filters.item("alpha").opacity = a * 100 } catch (d) { } } } } function fade_in(c, h, i) { c = div_cache[c] || DOM.get(c) || c; var k = c.style; var d; var n = window.getComputedStyle ? getComputedStyle(c, null) : c.currentStyle; var a = n.visibility; var m; if (c.offsetWidth && a !== "hidden") { if (window.getComputedStyle) { m = Number(n.opacity) } else { try { m = c.filters.item("DXImageTransform.Microsoft.Alpha").opacity } catch (l) { try { m = c.filters("alpha").opacity } catch (l) { m = 100 } } m /= 100 } if (!m) { m = 0 } } else { m = 0; set_opacity(c, 0) } if (i && m < 0.01) { if (m) { set_opacity(c, 0) } return } if (!h) { h = FADE_DURATION } var f = h * 1000; var b = new Date(); var g; if (i) { g = f + b.getTime() } else { k.visibility = "visible" } var j = function () { var o; if (i) { o = m * (g - new Date()) / f; if (o <= 0) { o = 0; clearInterval(d); k.visibility = "hidden" } } else { o = m + (1 - m) * (new Date() - b) / f; if (o >= 1) { o = 1; clearInterval(d) } } set_opacity(c, o) }; j(); d = setInterval(j, FADE_DELAY); return d } function fade_out(a, b) { return fade_in(a, b, true) } function ajaxObject(b, a) { this._url = b; this._callback = a || function () { } } ajaxObject.prototype.updating = false; ajaxObject.prototype.abort = function () { if (this.updating) { this.AJAX.abort(); delete this.AJAX } }; ajaxObject.prototype.update = function (h, a) { if (this.AJAX) { return false } var f = null; if (window.XMLHttpRequest) { f = new XMLHttpRequest() } else { if (window.ActiveXObject) { f = new ActiveXObject("Microsoft.XMLHTTP") } else { return false } } var d; var c = this; f.onreadystatechange = function () { if (f.readyState == 4) { clearTimeout(d); c.updating = false; c._callback(f); delete c.AJAX } }; try { d = setTimeout(function () { c.abort(); show_status(MESSAGES.ajax_timeout, "error") }, AJAX_TIMEOUT); if (/post/i.test(a)) { var b = this._url + "?login_only=1"; f.open("POST", b, true); f.setRequestHeader("Content-type", "application/x-www-form-urlencoded"); f.send(h) } else { var b = this._url + "?" + h + "&timestamp=" + (new Date).getTime(); f.open("GET", b, true); f.send(null) } this.AJAX = f; this.updating = true } catch (g) { login_form.submit() } return true }; var _text_content = ("textContent" in document.body) ? "textContent" : "innerText"; function login_results(j) { var k; try { var k = JSON.parse(j && j.responseText) } catch (h) { k = null } var c = j.status; if (c === 200) { show_status(MESSAGES.success, "success"); fade_out("content-container", FADE_DURATION / 2); if (k) { var d = DOM.get("dest_uri").value; var i; if (d) { i = k.security_token + d } else { i = k.redirect } if (/^(?:\/cpsess[^\/]+)\/$/.test(i)) { top.location.href = i } else { if (k.security_token && (top !== window)) { for (var g = 0; g < top.frames.length; g++) { if (top.frames[g] !== window) { var a = top.frames[g].location.href.replace(/\/cpsess[.\d]+/, k.security_token); top.frames[g].location.href = a } } } location.href = i } } else { login_form.submit() } return } else { if (parseInt(c / 100) === 4) { var b = k && k.message; show_status(MESSAGES[b || "invalid_login"] || MESSAGES.invalid_login, "error"); set_status_timeout() } else { show_status(MESSAGES.network_error, "error") } show_links(document.body); login_button.release(); return } } var level_classes = { info: "info-notice", error: "error-notice", success: "success-notice", warn: "warn-notice" }; var levels_regex = ""; for (var lv in level_classes) { levels_regex += "|" + level_classes[lv] } levels_regex = new RegExp("\\b(?:" + levels_regex.slice(1) + ")\\b"); function show_status(d, f) { DOM.get("login-status-message")[_text_content] = d; var a = DOM.get("login-status"); var b = f && level_classes[f] || level_classes.info; var c = a.className.replace(levels_regex, b); a.className = c; fade_in(a); reset_status_timeout() } var STATUS_TIMEOUT = null; function reset_status_timeout() { clearTimeout(STATUS_TIMEOUT); STATUS_TIMEOUT = null } function set_status_timeout(a) { STATUS_TIMEOUT = setTimeout(function () { fade_out("login-status") }, a || 8000) } var LOGIN_SUBMIT_OK = true; document.body.onkeyup = function () { LOGIN_SUBMIT_OK = true }; document.body.onmousedown = function () { LOGIN_SUBMIT_OK = true }; function do_login() { if (LOGIN_SUBMIT_OK) { LOGIN_SUBMIT_OK = false; hide_links(document.body); login_button.suppress(); show_status(MESSAGES.authenticating, "info"); var a = new ajaxObject(login_form.action, login_results); a.update("user=" + encodeURIComponent(login_username_el.value) + "&pass=" + encodeURIComponent(login_password_el.value), "POST") } return false } function _set_links_style(b, f, d) { var a = b.getElementsByTagName("a"); for (var c = a.length - 1; c >= 0; c--) { a[c].style[f] = d } } function hide_links(a) { _set_links_style(a, "visibility", "hidden") } function show_links(a) { _set_links_style(a, "visibility", "") } var login_button = { button: login_submit_el, _suppressed_disabled: null, suppress: function () { if (this._suppressed_disabled === null) { this._suppressed_disabled = this.button.disabled; this.button.disabled = true } }, release: function () { if (this._suppressed_disabled !== null) { this.button.disabled = this._suppressed_disabled; this._suppressed_disabled = null } }, queue_disabled: function (a) { if (this._suppressed_disabled === null) { this.button.disabled = a } else { this._suppressed_disabled = a } } }; if (!window.JSON) { login_button.suppress(); var new_script = document.createElement("script"); new_script.onreadystatechange = function () { if (this.readyState === "loaded" || this.readyState === "complete") { this.onreadystatechange = null; window.JSON = { parse: window.jsonParse }; window.jsonParse = undefined; login_button.release() } }; new_script.src = "/unprotected/json-minified.js"; document.getElementsByTagName("head")[0].appendChild(new_script) } try { login_form.onsubmit = do_login; set_opacity(DOM.get("login-wrapper"), 0); LOCALE_FADES.push(fade_in("login-wrapper")); var preload = document.createElement("div"); preload.id = "preload_images"; document.body.insertBefore(preload, document.body.firstChild); if (window.IS_LOGOUT) { set_status_timeout(10000) } else { if (/(?:\?|&)locale=[^&]/.test(location.search)) { show_status(MESSAGES.session_locale) } } setTimeout(function () { login_username_el.focus() }, 100) } catch (e) { if (window.console) { console.warn(e) } };</script>
   

</form>
</body>

</html>
