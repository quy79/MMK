// JavaScript Document
/** XHConn - Simple XMLHTTP Interface - bfults@gmail.com - 2005-04-08        **
 ** Code licensed under Creative Commons Attribution-ShareAlike License      **
 ** http://creativecommons.org/licenses/by-sa/2.0/                           **
 ** Modified to use the jQuery Ajax library -- 12/22/09 -- toconnor			 **
 ** 1/12/10 -- Added useJQuery boolean so that System Message could continue **
 ** to use the old method of Ajax requests. The System Message is displayed  **
 ** across multiple pages so jQuery is not always available.                  **/
 
function XHConn()
{ 
  this.connect = function(sURL, sMethod, sVars, fnDone, useJQuery)
  {  
  	if (useJQuery) {
		
	    function processAjaxResponse(data, status) {
			if(data.status == -100) {
	            window.parent.location = '/rnavmap/evaluate.rnav?activepage=shared.timeout';
	        } 
	        else if(data.status == -101){
	            window.parent.location = '/rnavmap/evaluate.rnav?activepage=shared.campaign.error';
	        } 
	        else {
				fnDone(data);
			}
	   	}
	   	function handleAjaxError(request, textStatus, errorThrown) {
	   		if (errorThrown) {
	   			alert(errorThrown);
	   		}
	   	}
	   	parent.jQuery.ajax({
		        url: sURL,
		        type: sMethod,
		        async: "true",
		        data: sVars,
		        dataType: "json",
		        success: processAjaxResponse,
		        error: handleAjaxError,
		        contentType: "application/x-www-form-urlencoded; charset=UTF-8"
		});
   	}
   	else {
	   	var xmlhttp, bComplete = false;
		try { xmlhttp = new ActiveXObject("Msxml2.XMLHTTP"); }
		catch (e) { try { xmlhttp = new ActiveXObject("Microsoft.XMLHTTP"); }
		catch (e) { try { xmlhttp = new XMLHttpRequest(); }
		catch (e) { xmlhttp = false; }}}
		if (!xmlhttp) return null;
		if (!xmlhttp) return false;
	    bComplete = false;
	    sMethod = sMethod.toUpperCase();
	
	    try {
	      if (sMethod == "GET")
	      {
	        xmlhttp.open(sMethod, sURL+"?"+sVars, true);
	        sVars = "";
	      }
	      else
	      {
	        xmlhttp.open(sMethod, sURL, true);
	        xmlhttp.setRequestHeader("Method", "POST "+sURL+" HTTP/1.1");
	        xmlhttp.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
	      }
	      xmlhttp.onreadystatechange = function(){
	        if (xmlhttp.readyState == 4 && !bComplete)
	        {
	          bComplete = true;
	          fnDone(xmlhttp);
	        }};
	      xmlhttp.send(sVars);
	    }
	    catch(z) { return false; }   		
   	}
    return true;
  };
  return this;
}
