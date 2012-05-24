// JavaScript Document
/**
 * This library performs window specific functions, ie. open a new popup window
 */
 
var WindowControl = {
    /**
     * Opens the default help window.
     * 
     * @param url The help URL. 
     */
    openHelpWin : function(url) {
        var params = "toolbar=1";
        params += ",location=1";
        params += ",directories=1";
        params += ",status=1";
        params += ",menubar=1";
        params += ",scrollbars=1";
        params += ",resizable=1";
        params += ",width=800";
        params += ",height=600";
        params += ",left=20";
        params += ",top=20";
        
        return this.popup(url, "HelpWin", params);
    },
    
    /**
     * Opens a new popup window with the given width and height.
     * 
     * @param width The popup window width.
     * @param height The popup window height.
     * @param left The popup window x coord.
     * @param top The popup window y coord.
     */
    openWindow : function(winName, url, width, height, left, top) {
    	if ( !left ) left = 20;
    	if ( !top ) top = 20;
        var params = "toolbar=0";
        params += ",location=0";
        params += ",directories=0";
        params += ",status=0";
        params += ",menubar=0";
        params += ",scrollbars=1";
        params += ",resizable=1";
        params += ",left="+left;
        params += ",top="+top;
        params += ",width="+width;
        params += ",height="+height;
        
        return this.popup(url, winName, params);
        
    },
    
    /**
     * Opens a new popup window with the given parameters.  Once the window is
     * opened, set the focus on the new window.
     * 
     * @param winName The popup window name.
     * @param url The URL.
     * @param params The popup window attributes (menubar, toolbar, location bar, width, height, etc.).
     */
    popup : function(url, winName, params) {
        var w = window.open(url, winName, params);

        if (w) {
            if (w.focus) w.focus();                
        }
        return w;
    }
};