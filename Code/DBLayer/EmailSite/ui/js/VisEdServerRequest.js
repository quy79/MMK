// JavaScript Document
//var serverURL = "/vised";
var serverURL = "/xhr/visualEditor";

function VisEdServerRequest()
{
    var myConn = new XHConn();
    var httpMethod = 'POST';

    this.updateBlockContentNoSave = function (documentId, panelName, blockName, html, execWhenDone)
    {
	    myConn.connect(serverURL+"/UpdateBlockContents", httpMethod,
//	                   "cmd=UpdateBlockContents" +
	                   "documentId=" + documentId +
	                   "&panelName=" + panelName +
	                   "&blockName=" + blockName +
	                   "&html=" + encodeURIComponent(html) +
                       "&noupdate=true",
	                   execWhenDone, true);
    }

    this.updateBlockContentByEmailType = function (documentId, panelName, blockName, html, emailType, linkFormat, execWhenDone)
    {
        var commandVars = "documentId=" + documentId +
                       "&panelName=" + panelName +
                       "&blockName=" + blockName +
                       "&html=" + encodeURIComponent(html) +
                       "&emailType=" + emailType;

        if (linkFormat.isModified) {
            commandVars += "&linkFormat=true" +
                    "&linkFormatColor=" + encodeURIComponent(linkFormat.color) +
                    "&linkFormatBold=" + linkFormat.isBold +
                    "&linkFormatItalic=" + linkFormat.isItalic +
                    "&linkFormatUnderline=" + linkFormat.isUnderline;
        }

        myConn.connect(serverURL+"/UpdateBlockContents", httpMethod, commandVars, execWhenDone, true);
    }

	this.addBlock = function(documentId, panelName, blockName, execWhenDone)
	{
	    myConn.connect(serverURL+"/AddBlock", httpMethod,
//	                   "/AddBlock" +
	                   "documentId=" + documentId +
	                   "&panelName=" + panelName +
	                   "&blockName=" + blockName,
	                   execWhenDone, true);
	}
	
	this.oneTimePasteHelp = function(bFlag, execWhenDone)
	{
	    myConn.connect(serverURL+"/OneTimePasteHelp", httpMethod,
                     "pasteFormatting=" + bFlag,
	                   execWhenDone, true);
	}
	
    this.restoreBlock = function(documentId, panelName, blockName, execWhenDone) {
        myConn.connect(serverURL+"/AddBlock", httpMethod,
//                       "cmd=AddBlock" +
                       "documentId=" + documentId +
                       "&panelName=" + panelName +
                       "&restore=true"+
                       "&blockName=" + blockName,
                       execWhenDone, true);
    }

	this.deleteBlock = function(documentId, panelName, blockName, execWhenDone)
	{
	    myConn.connect(serverURL+"/DeleteBlock", httpMethod,
//	                   "cmd=DeleteBlock" +
	                   "documentId=" + documentId +
	                   "&panelName=" + panelName +
	                   "&blockName=" + blockName,
	                   execWhenDone, true);
	}

	this.copyBlock = function(documentId, panelName, blockName, execWhenDone)
	{
	    myConn.connect(serverURL+"/CopyBlock", httpMethod,
	                   "documentId=" + documentId +
	                   "&panelName=" + panelName +
	                   "&blockName=" + blockName,
	                   execWhenDone, true);
	}

	this.moveBlock = function(documentId, fromPanelName, movedBlockName, toPanelName, beforeBlockName, execWhenDone)
	{
        myConn.connect(serverURL+"/MoveBlock", httpMethod,
//	                   "cmd=MoveBlock" +
	                   "documentId=" + documentId +
	                   "&fromPanelName=" + fromPanelName +
	                   "&movedBlockName=" + movedBlockName +
	                   "&toPanelName=" + toPanelName +
	                   "&beforeBlockName=" + beforeBlockName,
	                   execWhenDone, true);
	}

    this.moveBlockToEnd = function(documentId, fromPanelName, movedBlockName, toPanelName, execWhenDone)
    {
        myConn.connect(serverURL+"/MoveBlock", httpMethod,
//                       "cmd=MoveBlock" +
                       "documentId=" + documentId +
                       "&fromPanelName=" + fromPanelName +
                       "&movedBlockName=" + movedBlockName +
                       "&toPanelName=" + toPanelName,
                       execWhenDone, true);
    }

    this.addBlockGroup = function(documentId, panelName, blockName, execWhenDone)
    {
        myConn.connect(serverURL+"/AddBlockGroup", httpMethod,
//                       "cmd=AddBlockGroup" +
                       "documentId=" + documentId +
                       "&panelName=" + panelName +
                       "&blockName=" + blockName,
                       execWhenDone, true);
    }

    // Note the server function update more than one style class at a time,
    // but we only deal with one here. If necessary we could create another
    // javascript function to update several style classes with one XmlHttpRequest

    this.updateStyleClass = function(documentId, styleClassName, stylePropName, stylePropValue, execWhenDone)
    {
        myConn.connect(serverURL+"/UpdateStyleClasses", httpMethod,
//                       "cmd=UpdateStyleClasses" +
                       "documentId=" + documentId +
                       "&styleClassName=" + styleClassName +
                       "&stylePropName=" + stylePropName +
                       "&stylePropValue=" + stylePropValue,
                       execWhenDone, true);
    }

    this.updateBGThumbnail = function(documentId, bgImage, styleClassName, stylePropName, stylePropValue, execWhenDone)
    {
        myConn.connect(serverURL+"/UpdateStyleClasses", httpMethod,
//                       "cmd=UpdateStyleClasses" +
                       "documentId=" + documentId +
                       "&styleClassName=" + styleClassName +
                       "&stylePropName=" + stylePropName +
                       "&stylePropValue=" + stylePropValue +
                       "&bgImage="+bgImage,
                       execWhenDone, true);
    }

    this.restoreTemplateStyleClasses = function(documentId, execWhenDone)
    {
        myConn.connect(serverURL+"/RestoreTemplateStyleClasses", httpMethod,
//                       "cmd=RestoreTemplateStyleClasses" +
                       "documentId=" + documentId,
                       execWhenDone, true);
    }
    this.togglePromotionBlock = function (documentId, panelName, blockName, partner, execWhenDone, enable)
    {
        myConn.connect(serverURL+"/UpdateBlockContents", httpMethod,
//                       "cmd=UpdateBlockContents" +
                       "documentId=" + documentId +
                       "&panelName=" + panelName +
                       "&blockName=" + blockName +
                       "&partner=" + partner +
                       "&enable=" + enable +
                       "&html=",
                       execWhenDone, true);
    }

    this.dropDownData = function (htmlType,execWhenDone,agentUID)
    {
        myConn.connect(serverURL+"/VeDropdown", httpMethod,
//                       "cmd=VeDropdown" +
                       "htmlType="+htmlType +
                       "agent.uid="+agentUID,
                       execWhenDone, true);
    }
    this.updateTOCBlockContent = function (documentId, panelName, blockName, blockNames, html, heading, execWhenDone)
    {
        var params =   "documentId=" + documentId +
                       "&panelName=" + panelName +
                       "&blockName=" + blockName +
                       "&blockNames=" + blockNames +
                       "&html=" + html;
        if(heading != null) params = params + "&tocHeading="+encodeURIComponent(heading);

        myConn.connect(serverURL+"/UpdateBlockContents", httpMethod,
                       params,
                       execWhenDone, true);
    }

    this.sendPreview = function (documentId, email, note, format, both, execWhenDone)
    {
        var params =   "documentId=" + documentId +
                       "&email=" + email +
                       "&note=" + encodeURIComponent(note) +
                       "&format=" + format +
                       "&both=" + both;
        myConn.connect(serverURL+"/SendPreview", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.saveStyleSheet = function (documentId, styleText, saveStyles, execWhenDone, action)
    {
        var params =   "documentId=" + documentId +
                       "&saveStyles=" + saveStyles +
                       "&styleText=" +  encodeURIComponent(styleText);
        if(action)  params = params+ "&action="+action;
        myConn.connect(serverURL+"/SaveStylesheet", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.handleTextLetter = function (documentId, action, changed, textLetter, execWhenDone)
    {
        var params =   "documentId=" + documentId +
                       "&action=" + action +
                       "&changed=" + changed +
                       "&textLetter=" + encodeURIComponent(textLetter);
        myConn.connect(serverURL+"/TextLetterActions", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.saveCampaign = function (documentId, execWhenDone) {
        var params = "documentId=" + documentId;
        myConn.connect(serverURL+"/SaveCampaign", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.hasValidSession = function (execWhenDone)
    {
        var params = '';
        myConn.connect("/xhr/common/HasValidSession", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.updateArchiveTitle = function (siteownerUID, agentUID, title, action, execWhenDone) {
        var params =   "siteownerUID=" + siteownerUID +
                       "&agentUID=" + agentUID +
                       "&action=" + action +
                       "&title=" + encodeURIComponent(title);
        myConn.connect("/xhr/archive/UpdateTitle", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.deleteArchiveHomepage = function (agentUID, unpublish, execWhenDone) {
    	var params = "agentUID="+agentUID;
    	if(unpublish) params+="&unpublish=true";
    	myConn.connect("/xhr/archive/DeleteHomePage", httpMethod,
                        params,
                        execWhenDone, true);
    }
    this.getAmazonData = function (asin, assocId, execWhenDone) {
        myConn.connect(serverURL+"/GetAmazonData", httpMethod,
	                   "asin=" + asin +
	                   "&assocId=" + assocId,
	                   execWhenDone, true);
    }
    this.setSystemMesssageFlag = function (execWhenDone) {
        var params = '';
        myConn.connect("/xhr/common/SetSystemMessageFlag", httpMethod,
                       params,
                       execWhenDone, false);
    }
    this.getOriginalImgURL = function (proxyURL, execWhenDone) {
        var params = "proxyImgUrl="+proxyURL;
        myConn.connect(serverURL+"/GetOriginalImageUrl", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.getNewImageProxyURL = function (imageURL, execWhenDone) {
        var params = "origImgUrl="+imageURL;
        myConn.connect(serverURL+"/GetProxyUrlForImage", httpMethod,
                       params,
                       execWhenDone, true);
    }
    this.getProxyImageList = function (execWhenDone) {
        var params = "";
        myConn.connect(serverURL+"/GetProxyImageList", httpMethod,
                       params,
                       execWhenDone, true);
    }

}


