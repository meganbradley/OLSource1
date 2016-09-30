---
title: "CHtmlView Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CHtmlView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "browsers, MFC support for"
  - "CHtmlView class"
  - "WebBrowser control"
  - "WebBrowser control, MFC support"
ms.assetid: 904976af-73de-4aba-84ac-cfae8e2be09a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView Class
Provides the functionality of the WebBrowser control within the context of MFC's document/view architecture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHtmlView::Create](#chtmlview__create)|Creates the WebBrowser control.|  
|[CHtmlView::CreateControlSite](#chtmlview__createcontrolsite)|Overridable used to create a control site instance to host a control on the form.|  
|[CHtmlView::ExecFormsCommand](#chtmlview__execformscommand)|Executes the specified command using the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> method.|  
|[CHtmlView::ExecWB](#chtmlview__execwb)|Executes a command.|  
|[CHtmlView::GetAddressBar](#chtmlview__getaddressbar)|Determines if the Internet Explorer object's address bar is visible. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::GetApplication](#chtmlview__getapplication)|Retrieves an application object representing the application that contains the current instance of the Internet Explorer application.|  
|[CHtmlView::GetBusy](#chtmlview__getbusy)|Retrieves a value indicating whether a download or other activity is still in progress.|  
|[CHtmlView::GetContainer](#chtmlview__getcontainer)|Retrieves the container of the WebBrowser control.|  
|[CHtmlView::GetFullName](#chtmlview__getfullname)|Retrieves the full name, including the path, of the resource displayed in the web browser. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::GetFullScreen](#chtmlview__getfullscreen)|Indicates whether the WebBrowser control is operating in full-screen mode or in normal window mode.|  
|[CHtmlView::GetHeight](#chtmlview__getheight)|Retrieves the height of the Internet Explorer main window.|  
|[CHtmlView::GetHtmlDocument](#chtmlview__gethtmldocument)|Retrieves the active HTML document.|  
|[CHtmlView::GetLeft](#chtmlview__getleft)|Retrieves the screen coordinate of the left edge of the Internet Explorer main window.|  
|[CHtmlView::GetLocationName](#chtmlview__getlocationname)|Retrieves the name of the resource that WebBrowser is currently displaying|  
|[CHtmlView::GetLocationURL](#chtmlview__getlocationurl)|Retrieves the URL of the resource that WebBrowser is currently displaying.|  
|[CHtmlView::GetMenuBar](#chtmlview__getmenubar)|Retrieves a value that determines whether the menu bar is visible.|  
|[CHtmlView::GetOffline](#chtmlview__getoffline)|Retrieves a value that determines whether the control is offline.|  
|[CHtmlView::GetParentBrowser](#chtmlview__getparentbrowser)|Retrieves a pointer to the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> interface. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).|  
|[CHtmlView::GetProperty](#chtmlview__getproperty)|Retrieves the current value of a property associated with the given object.|  
|[CHtmlView::GetReadyState](#chtmlview__getreadystate)|Retrieves the ready state of the web browser object.|  
|[CHtmlView::GetRegisterAsBrowser](#chtmlview__getregisterasbrowser)|Indicates whether the WebBrowser control is registered as a top-level browser for target name resolution.|  
|[CHtmlView::GetRegisterAsDropTarget](#chtmlview__getregisterasdroptarget)|Indicates whether the WebBrowser control is registered as a drop target for navigation.|  
|[CHtmlView::GetSilent](#chtmlview__getsilent)|Indicates whether any dialog boxes can be shown.|  
|[CHtmlView::GetSource](#chtmlview__getsource)|The HTML source code of the web page.|  
|[CHtmlView::GetStatusBar](#chtmlview__getstatusbar)|Indicates whether the Internet Explorer's status bar is visible. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::GetTheaterMode](#chtmlview__gettheatermode)|Indicates whether the WebBrowser control is in theater mode.|  
|[CHtmlView::GetToolBar](#chtmlview__gettoolbar)|Retrieves a value that determines whether the toolbar is visible.|  
|[CHtmlView::GetTop](#chtmlview__gettop)|Retrieves the screen coordinate of the top edge of the Internet Explorer main window.|  
|[CHtmlView::GetTopLevelContainer](#chtmlview__gettoplevelcontainer)|Retrieves a value indicating whether the current object is the top-level container of the WebBrowser control.|  
|[CHtmlView::GetType](#chtmlview__gettype)|Retrieves the type name of the document object.|  
|[CHtmlView::GetVisible](#chtmlview__getvisible)|Retrieves a value indicating whether the object is visible or hidden.|  
|[CHtmlView::GetWidth](#chtmlview__getwidth)|Retrieves the width of the Internet Explorer main window.|  
|[CHtmlView::GoBack](#chtmlview__goback)|Navigates to the previous item in the history list.|  
|[CHtmlView::GoForward](#chtmlview__goforward)|Navigates to the next item in the history list.|  
|[CHtmlView::GoHome](#chtmlview__gohome)|Navigates to the current home or start page.|  
|[CHtmlView::GoSearch](#chtmlview__gosearch)|Navigates to the current search page.|  
|[CHtmlView::LoadFromResource](#chtmlview__loadfromresource)|Loads a resource in the WebBrowser control.|  
|[CHtmlView::Navigate](#chtmlview__navigate)|Navigates to the resource identified by a URL.|  
|[CHtmlView::Navigate2](#chtmlview__navigate2)|Navigates to the resource identified by a URL, or to the file identified by a full path.|  
|[CHtmlView::OnBeforeNavigate2](#chtmlview__onbeforenavigate2)|Called before a navigation occurs in the given WebBrowser (on either a window or frameset element).|  
|[CHtmlView::OnCommandStateChange](#chtmlview__oncommandstatechange)|Called to notify an application that the enabled state of a web browser command has changed.|  
|[CHtmlView::OnDocumentComplete](#chtmlview__ondocumentcomplete)|Called to notify an application that a document has reached the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> state.|  
|[CHtmlView::OnDocWindowActivate](#chtmlview__ondocwindowactivate)|Called from the Internet Explorer or MSHTML implementation of                                         [IOleInPlaceActiveObject::OnDocWindowActivate](http://msdn.microsoft.com/library/windows/desktop/ms687281), which notifies the active in-place object when the container's document window is activated or deactivated.|  
|[CHtmlView::OnDownloadBegin](#chtmlview__ondownloadbegin)|Called to notify an application that a navigation operation is beginning.|  
|[CHtmlView::OnDownloadComplete](#chtmlview__ondownloadcomplete)|Called when a navigation operation finished, was halted, or failed.|  
|[CHtmlView::OnEnableModeless](#chtmlview__onenablemodeless)|Called to enable or disable modeless dialog boxes when the container creates or destroys a modal dialog box.|  
|[CHtmlView::OnFilterDataObject](#chtmlview__onfilterdataobject)|Called on the host by Internet Explorer or MSHTML to allow the host to replace Internet Explorer or MSHTML's data object.|  
|[CHtmlView::OnFrameWindowActivate](#chtmlview__onframewindowactivate)|Called from                                         [IOleInPlaceActiveObject::OnFrameWindowActivate](http://msdn.microsoft.com/library/windows/desktop/ms683969) to notify the object when the container's top-level frame window is activated or deactivated.|  
|[CHtmlView::OnFullScreen](#chtmlview__onfullscreen)|Called when the FullScreen property has changed.|  
|[CHtmlView::OnGetDropTarget](#chtmlview__ongetdroptarget)|Called by Internet Explorer or MSHTML when it is being used as a drop target to allow the host to supply an alternative                                         [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679).|  
|[CHtmlView::OnGetExternal](#chtmlview__ongetexternal)|Called by Internet Explorer or MSHTML to obtain the host's <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> interface.|  
|[CHtmlView::OnGetHostInfo](#chtmlview__ongethostinfo)|Retrieves the UI capabilities of the Internet Explorer or MSHTML host.|  
|[CHtmlView::OnGetOptionKeyPath](#chtmlview__ongetoptionkeypath)|Returns the registry key under which Internet Explorer or MSHTML stores user preferences.|  
|[CHtmlView::OnHideUI](#chtmlview__onhideui)|Called when Internet Explorer or MSHTML removes its menus and toolbars.|  
|[CHtmlView::OnMenuBar](#chtmlview__onmenubar)|Called when the MenuBar property has changed.|  
|[CHtmlView::OnNavigateComplete2](#chtmlview__onnavigatecomplete2)|Called after a navigation to a hyperlink completes (on either a window or frameset element).|  
|[CHtmlView::OnNavigateError](#chtmlview__onnavigateerror)|Called by the framework if navigation to a hyperlink fails.|  
|[CHtmlView::OnNewWindow2](#chtmlview__onnewwindow2)|Called when a new window is to be created for displaying a resource.|  
|[CHtmlView::OnProgressChange](#chtmlview__onprogresschange)|Called to notify an application that the progress of a download operation has been updated.|  
|[CHtmlView::OnPropertyChange](#chtmlview__onpropertychange)|Called to notify an application that the [PutProperty](#chtmlview__putproperty) method has changed the value of a property.|  
|[CHtmlView::OnQuit](#chtmlview__onquit)|Called to notify an application that the Internet Explorer application is ready to quit. (Applies to Internet Explorer only)|  
|[CHtmlView::OnResizeBorder](#chtmlview__onresizeborder)|Called from the Internet Explorer or MSHTML implementation of                                         [IOleInPlaceActiveObject::ResizeBorder](http://msdn.microsoft.com/library/windows/desktop/ms680053), which alerts the object that it needs to resize its border space.|  
|[CHtmlView::OnShowContextMenu](#chtmlview__onshowcontextmenu)|Called from Internet Explorer or MSHTML when it is about to show its context menu.|  
|[CHtmlView::OnShowUI](#chtmlview__onshowui)|Called before Internet Explorer or MSHTML displays its menus and toolbars.|  
|[CHtmlView::OnStatusBar](#chtmlview__onstatusbar)|Called when the StatusBar property has changed.|  
|[CHtmlView::OnStatusTextChange](#chtmlview__onstatustextchange)|Called to notify an application that the text of the status bar associated with the WebBrowser control has changed.|  
|[CHtmlView::OnTheaterMode](#chtmlview__ontheatermode)|Called when the TheaterMode property has changed.|  
|[CHtmlView::OnTitleChange](#chtmlview__ontitlechange)|Called to notify an application if the title of a document in the WebBrowser control becomes available or changes.|  
|[CHtmlView::OnToolBar](#chtmlview__ontoolbar)|Called when the ToolBar property has changed.|  
|[CHtmlView::OnTranslateAccelerator](#chtmlview__ontranslateaccelerator)|Called by Internet Explorer or MSHTML when                                         [IOleInPlaceActiveObject::TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms693360) or                                         [IOleControlSite::TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms693756) is called to process menu accelerator-key messages from the container's message queue.|  
|[CHtmlView::OnTranslateUrl](#chtmlview__ontranslateurl)|Called by Internet Explorer or MSHTML to allow the host an opportunity to modify the URL to be loaded.|  
|[CHtmlView::OnUpdateUI](#chtmlview__onupdateui)|Notifies the host that the command state has changed.|  
|[CHtmlView::OnVisible](#chtmlview__onvisible)|Called when the window for the WebBrowser control should be shown/hidden.|  
|[CHtmlView::PutProperty](#chtmlview__putproperty)|Sets the value of a property associated with the given object.|  
|[CHtmlView::QueryFormsCommand](#chtmlview__queryformscommand)|Queries for the status of one or more commands generated by user interface events.|  
|[CHtmlView::QueryStatusWB](#chtmlview__querystatuswb)|Queries the status of a command being processed by the WebBrowser control.|  
|[CHtmlView::Refresh](#chtmlview__refresh)|Reloads the current file.|  
|[CHtmlView::Refresh2](#chtmlview__refresh2)|Reloads the current file and optionally prevents the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> header from being sent.|  
|[CHtmlView::SetAddressBar](#chtmlview__setaddressbar)|Shows or hides the Internet Explorer object's address bar. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::SetFullScreen](#chtmlview__setfullscreen)|Sets a value to determine whether the control is operating in full-screen mode or in normal window mode. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::SetHeight](#chtmlview__setheight)|Sets the height of the Internet Explorer main window.|  
|[CHtmlView::SetLeft](#chtmlview__setleft)|Sets the horizontal position of the Internet Explorer main window.|  
|[CHtmlView::SetMenuBar](#chtmlview__setmenubar)|Sets a value to determine whether the control's menu bar is visible. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::SetOffline](#chtmlview__setoffline)|Sets a value to determine whether the control is offline.|  
|[CHtmlView::SetRegisterAsBrowser](#chtmlview__setregisterasbrowser)|Sets a value indicating whether the WebBrowser control is registered as a top-level browser for target name resolution.|  
|[CHtmlView::SetRegisterAsDropTarget](#chtmlview__setregisterasdroptarget)|Sets a value indicating whether the WebBrowser control is registered as a drop target for navigation.|  
|[CHtmlView::SetSilent](#chtmlview__setsilent)|Sets a value to determine whether the control will display dialog boxes.|  
|[CHtmlView::SetStatusBar](#chtmlview__setstatusbar)|Sets a value to determine whether the Internet Explorer's status bar is visible. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::SetTheaterMode](#chtmlview__settheatermode)|Sets a value indicating whether the WebBrowser control is in theater mode.|  
|[CHtmlView::SetToolBar](#chtmlview__settoolbar)|Sets a value to determine whether the control's toolbar is visible. (WebBrowser control ignores; Internet Explorer only.)|  
|[CHtmlView::SetTop](#chtmlview__settop)|Sets the vertical position of the Internet Explorer main window.|  
|[CHtmlView::SetVisible](#chtmlview__setvisible)|Sets a value indicating whether the object is visible or hidden.|  
|[CHtmlView::SetWidth](#chtmlview__setwidth)|Sets the width of the Internet Explorer main window.|  
|[CHtmlView::Stop](#chtmlview__stop)|Stops opening a file.|  
  
## Remarks  
 The WebBrowser control is a window in which the user can browse sites on the World Wide Web, as well as folders in the local file system and on a network. The WebBrowser control supports hyperlinking, Uniform Resource Locator (URL) navigation, and maintains a history list.  
  
## Using the CHtmlView Class in an MFC Application  
 In the standard MFC framework application (either SDI or MDI based), the view object is commonly derived from a specialized set of classes. These classes, all derived from <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, provide specialized functionality beyond that provided by <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
 Basing the application's view class on <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> provides the view with the WebBrowser control. This effectively makes the application a web browser. The preferred method of creating a web browser-style application is to use the MFC Application Wizard, and specify <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> as the view class. For more information on implementing and using the WebBrowser control within MFC applications, see [Creating a Web Browser-Style Application](../vs140/creating-a-web-browser-style-mfc-application.md).  
  
> [!NOTE]
>  The WebBrowser ActiveX control (and therefore <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>) is available only to programs running under Windows NT versions 4.0 or later, in which Internet Explorer 4.0 or later has been installed.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is designed for applications that access the Web (and/or HTML documents). The following <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> member functions apply to the Internet Explorer application only. These functions will succeed on the WebBrowser control, but they will have no visible effect.  
  
-   [GetAddressBar](#chtmlview__getaddressbar)  
  
-   [GetFullName](#chtmlview__getfullname)  
  
-   [GetStatusBar](#chtmlview__getstatusbar)  
  
-   [SetAddressBar](#chtmlview__setaddressbar)  
  
-   [SetFullScreen](#chtmlview__setfullscreen)  
  
-   [SetMenuBar](#chtmlview__setmenubar)  
  
-   [SetStatusBar](#chtmlview__setstatusbar)  
  
-   [SetToolBar](#chtmlview__settoolbar)  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CScrollView](../vs140/cscrollview-class.md)  
  
 [CFormView](../vs140/cformview-class.md)  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxhtml.h  
  
##  \<a name="chtmlview__create">\</a>  CHtmlView::Create  
 Call this member function to create a WebBrowser control or container for the Internet Explorer executable.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that names the Windows class. The class name can be any name registered with the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) global function or the **RegisterClass** Windows function. If **NULL**, uses the predefined default [CFrameWnd](../vs140/cframewnd-class.md) attributes.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that represents the window name.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Specifies the window style attributes. By default, the **WS_VISIBLE** and **WS_CHILD** Windows styles are set.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the size and position of the window. The <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> value allows Windows to specify the size and position of the new window.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A pointer to the parent window of the control.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The ID number of the view. By default, set to **AFX_IDW_PANE_FIRST**.  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 A pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md). **NULL** by default.  
  
##  \<a name="chtmlview__createcontrolsite">\</a>  CHtmlView::CreateControlSite  
 Overridable used to create a control site instance to host a control on the form.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 A pointer to a [COleControlContainer](../vs140/colecontrolcontainer-class.md) object containing the control.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 A pointer to a pointer to a [COleControlSite](../vs140/colecontrolsite-class.md) object, providing the site for the control.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The identifier of the control to be hosted.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The CLSID of the control to be hosted  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
### Remarks  
 You can override this member function to return an instance of your own control site class.  
  
##  \<a name="chtmlview__execformscommand">\</a>  CHtmlView::ExecFormsCommand  
 Executes the specified command using the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The command to be executed. This command must belong to the **CMDSETID3_Forms3** group.  
  
 *pVarIn*  
 Pointer to a **VARIANT** structure containing input arguments. Can be **NULL**.  
  
 *pVarOut*  
 Pointer to a **VARIANT** structure to receive command output. Can be **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> value. For a complete listing of possible values, see                         [IOleCommandTarget::Exec](http://msdn.microsoft.com/library/windows/desktop/ms690300) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 **ExecFormsCommand** implements the behavior of the                         [IOleCommandTarget::Exec](http://msdn.microsoft.com/library/windows/desktop/ms690300) method.  
  
##  \<a name="chtmlview__execwb">\</a>  CHtmlView::ExecWB  
 Call this member function to execute a command in the WebBrowser or Internet Explorer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The command to execute.  
  
 *cmdexecopt*  
 The options set for executing the command.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 A variant used for specifying command input arguments.  
  
 *pvaOut*  
 A variant used for specifying command output arguments.  
  
### Remarks  
 See                         [IWebBrowser2::ExecWB](https://msdn.microsoft.com/en-us/library/aa752117.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="chtmlview__getaddressbar">\</a>  CHtmlView::GetAddressBar  
 Call this member function to retrieve Internet Explorer's address bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the address bar is visible; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__getapplication">\</a>  CHtmlView::GetApplication  
 Call this member function to retrieve the automation object supported by the application that contains the WebBrowser control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> interface of the active document object. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getbusy">\</a>  CHtmlView::GetBusy  
 Call this member function to determine whether the WebBrowser control is engaged in a navigation or downloading operation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the web browser is busy; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getcontainer">\</a>  CHtmlView::GetContainer  
 Call this member function to retrieve an object that evaluates to the container of the web browser.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> interface of the active document object.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getfullname">\</a>  CHtmlView::GetFullName  
 Call this member function to retrieve the full path of the file that Internet Explorer is currently displaying.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the path and name of the currently displayed file. If no path and filename exist, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> returns an empty <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
### Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__getfullscreen">\</a>  CHtmlView::GetFullScreen  
 Call this member function to determine whether the WebBrowser control is operating in full-screen mode or in normal window mode.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the WebBrowser is operating in full-screen mode; otherwise zero.  
  
### Remarks  
 In full-screen mode, the Internet Explorer main window is maximized and the status bar, toolbar, menu bar, and title bar are hidden.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getheight">\</a>  CHtmlView::GetHeight  
 Call this member function to retrieve the height, in pixels, of the WebBrowser control's frame window.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The control's frame window height, in pixels.  
  
##  \<a name="chtmlview__gethtmldocument">\</a>  CHtmlView::GetHtmlDocument  
 Call this member function to retrieve the HTML document for the active document.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> interface of the active document object.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getleft">\</a>  CHtmlView::GetLeft  
 Call this member function to retrieve the distance between the internal left edge of the WebBrowser control and the left edge of its container.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The left-edge distance, in pixels.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getlocationname">\</a>  CHtmlView::GetLocationName  
 Call this member function to get the name of the resource being displayed in the WebBrowser.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the name of the resource currently displayed in the WebBrowser.  
  
### Remarks  
 If the resource is an HTML page on the World Wide Web, the name is the title of that page. If the resource is a folder or file on the network or local computer, the name is the UNC or full path of the folder or file.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getlocationurl">\</a>  CHtmlView::GetLocationURL  
 Call this member function to retrieve the URL of the resource that the WebBrowser control is currently displaying.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the URL of the resource currently displayed in the WebBrowser.  
  
### Remarks  
 If the resource is a folder or file on the network or local computer, the name is the UNC or full path of the folder or file.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getmenubar">\</a>  CHtmlView::GetMenuBar  
 Call this member function to determine whether the menu bar is visible.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the menu bar is visible; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getoffline">\</a>  CHtmlView::GetOffline  
 Call this member function to determine whether the web browser is operating offline.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the web browser is currently offline; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getparentbrowser">\</a>  CHtmlView::GetParentBrowser  
 Call this member function to retrieve a pointer to the parent object of the WebBrowser control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> interface of the object that is the parent of the WebBrowser control.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getproperty">\</a>  CHtmlView::GetProperty  
 Call this member function to get the value of the property currently associated with the control.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A pointer to a string containing the property to retrieve.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object that receives the current value of the property.  
  
### Return Value  
 In the first version, nonzero if completed successfully; otherwise zero. In the second version, a [COleVariant](../vs140/colevariant-class.md) object.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getreadystate">\</a>  CHtmlView::GetReadyState  
 Call this member function to retrieve the ready state of the WebBrowser object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A                         [READYSTATE](https://msdn.microsoft.com/en-us/library/aa768362.aspx) value, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getregisterasbrowser">\</a>  CHtmlView::GetRegisterAsBrowser  
 Call this member function to determine whether the WebBrowser object is registered as a top-level browser for target name resolution.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the browser is registered as a top-level browser; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getregisterasdroptarget">\</a>  CHtmlView::GetRegisterAsDropTarget  
 Call this member function to determine whether the WebBrowser control is registered as a drop target for navigation.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the browser is registered as a drop target; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getsilent">\</a>  CHtmlView::GetSilent  
 Call this member function to determine whether any dialog boxes can be shown in the WebBrowser control.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if dialog boxes cannot be displayed from the WebBrowser control; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getsource">\</a>  CHtmlView::GetSource  
 Call this member function to retrieve the HTML source code for the web page.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) that will hold the source code.  
  
### Remarks  
 This function is equivalent to the "View Source" command in Internet Explorer, except that the source code is returned in a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>.  
  
##  \<a name="chtmlview__getstatusbar">\</a>  CHtmlView::GetStatusBar  
 Call this member function to determine whether the WebBrowser control displays a status bar.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the status bar can be displayed; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__gettheatermode">\</a>  CHtmlView::GetTheaterMode  
 Call this member function to determine whether the web browser is in theater mode.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the web browser is in theater mode; otherwise zero.  
  
### Remarks  
 When the web browser is in theater mode, the browser main window fills the entire screen, a toolbar with a minimal set of navigational tools appears, and the status bar appears in the upper right-hand corner of the screen.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__gettoolbar">\</a>  CHtmlView::GetToolBar  
 Call this member function to determine whether the toolbar is visible.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
 A value indicating whether the toolbar is visible. Nonzero if toolbar is visible; otherwise zero.  
  
##  \<a name="chtmlview__gettop">\</a>  CHtmlView::GetTop  
 Call this member function to retrieve the screen coordinate of the top edge of the WebBrowser control's main window.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 Address of a variable that receives the screen coordinate of the main window's top edge.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__gettoplevelcontainer">\</a>  CHtmlView::GetTopLevelContainer  
 Call this member function to determine whether Internet Explorer is the top-level container of the WebBrowser control.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero the container is the top-level container; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__gettype">\</a>  CHtmlView::GetType  
 Call this member function to retrieve the type name of the contained active document.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the type name of the contained active document.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getvisible">\</a>  CHtmlView::GetVisible  
 Call this member function to determine if the contained object is visible.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the object is visible; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__getwidth">\</a>  CHtmlView::GetWidth  
 Retrieves the width of the Internet Explorer main window.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 The current width of the window, in pixels.  
  
##  \<a name="chtmlview__goback">\</a>  CHtmlView::GoBack  
 Navigates backward one item in the history list.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__goforward">\</a>  CHtmlView::GoForward  
 Navigates forward one item in the history list.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
##  \<a name="chtmlview__gohome">\</a>  CHtmlView::GoHome  
 Navigates to the current home or start page specified in the Internet Explorer Internet Options dialog box or the Internet Properties dialog box, accessed from the Control Panel.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__gosearch">\</a>  CHtmlView::GoSearch  
 Navigates to the current search page, as specified in the Internet Explorer Internet Options dialog box or the Internet Properties dialog box, accessed from the Control Panel.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__loadfromresource">\</a>  CHtmlView::LoadFromResource  
 Call this member function to load the specified resource into the WebBrowser control.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the resource to load.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The ID of the buffer containing the name of the resource to load.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__navigate">\</a>  CHtmlView::Navigate  
 Call this member function to navigate to the resource identified by a URL.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 *URL*  
 A caller-allocated string that contains the URL to navigate to, or the full path of the file to display.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The flags of a variable that specifies whether to add the resource to the history list, whether to read to or write from the cache, and whether to display the resource in a new window. The variable can be a combination of the values defined by the                                 [BrowserNavConstants](https://msdn.microsoft.com/en-us/library/aa768360.aspx) enumeration.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 A pointer to a string that contains the name of the frame in which to display the resource.  
  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 A pointer to a value that specifies the HTTP headers to send to the server. These headers are added to the default Internet Explorer headers. The headers can specify such things as the action required of the server, the type of data being passed to the server, or a status code. This parameter is ignored if                                 *URL* is not an HTTP URL.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 A pointer to the data to send with the HTTP POST transaction. For example, the POST transaction is used to send data gathered by an HTML form. If this parameter does not specify any post data, **Navigate** issues an HTTP GET transaction. This parameter is ignored if                                 *URL* is not an HTTP URL.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Data to send with the HTTP POST transaction. For example, the POST transaction is used to send data gathered by an HTML form. If this parameter does not specify any post data, **Navigate** issues an HTTP GET transaction. This parameter is ignored if                                 *URL* is not an HTTP URL.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__navigate2">\</a>  CHtmlView::Navigate2  
 Call this member function to navigate to the resource identified by a URL, or to the file identified by a full path.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 *pIDL*  
 A pointer to an                                 [ITEMIDLIST](http://msdn.microsoft.com/library/windows/desktop/bb773321) structure.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The flags of a variable that specifies whether to add the resource to the history list, whether to read to or write from the cache, and whether to display the resource in a new window. The variable can be a combination of the values defined by the                                 [BrowserNavConstants](https://msdn.microsoft.com/en-us/library/aa768360.aspx) enumeration.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 A pointer to a string that contains the name of the frame in which to display the resource.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Data to send with the HTTP POST transaction. For example, the POST transaction is used to send data gathered by an HTML form. If this parameter does not specify any post data, <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> issues an HTTP GET transaction. This parameter is ignored if                                 *URL* is not an HTTP or HTTPS URL.  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Length in bytes of the data pointed to by the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 A pointer to a value that specifies the HTTP or HTTPS headers to send to the server. These headers are added to the default Internet Explorer headers. The headers can specify such things as the action required of the server, the type of data being passed to the server, or a status code. This parameter is ignored if                                 *URL* is not an HTTP or HTTPS URL.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 A reference to a [CByteArray](../vs140/cbytearray-class.md) object.  
  
### Remarks  
 This member function extends the **Navigate** member function by supporting browsing on special folders, such as Desktop and My Computer, that are represented by the parameter                         *pIDL*.  
  
 Applies to Internet Explorer and WebBrowser.  
  
### Example  
 [!code[NVC_MFCHtmlHttp#7](../vs140/codesnippet/CPP/chtmlview-class_1.cpp)]  
  
##  \<a name="chtmlview__onbeforenavigate2">\</a>  CHtmlView::OnBeforeNavigate2  
 This member function is called by the framework to cause an event to fire before a navigation occurs in the web browser.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Pointer to a string containing the URL to navigate to.  
  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 A string that contains the name of the frame in which to display the resource, or **NULL** if no named frame is targeted for the resource.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> object containing the data to send to the server if the HTTP POST transaction is being used.  
  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 A pointer to a string containing additional HTTP headers to send to the server (HTTP URLs only). The headers can specify such things as the action required of the server, the type of data being passed to the server, or a status code.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 A pointer to a cancel flag. An application can set this parameter to nonzero to cancel the navigation operation, or to zero to allow it to proceed.  
  
##  \<a name="chtmlview__oncommandstatechange">\</a>  CHtmlView::OnCommandStateChange  
 This member function is called by the framework to notify an application that the enabled state of a web browser command has changed.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 *nCommand*  
 Identifier of the command whose enabled state has changed.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Enabled state. This parameter is nonzero if the command is enabled, or zero if it is disabled.  
  
##  \<a name="chtmlview__ondocumentcomplete">\</a>  CHtmlView::OnDocumentComplete  
 This member function is called by the framework to notify an application that a document has reached the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> state.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 A pointer to a string that evaluates to the URL, UNC file name, or a PIDL (a pointer to an item identifier list) that was navigated to.  
  
### Remarks  
 Not every frame will fire this event, but each frame that fires an [OnDownloadBegin](#chtmlview__ondownloadbegin) event will fire a corresponding <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> event.  
  
 The URL indicated by <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> can be different from the URL that the browser was told to navigate to, because this URL is the canonicalized and qualified URL. For example, if an application specifies a URL of "www.microsoft.com" in a call to [Navigate](#chtmlview__navigate) or [Navigate2](#chtmlview__navigate2), the URL passed by <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> will be "http://www.microsoft.com/". Also, if the server has redirected the browser to a different URL, the redirected URL will be reflected here.  
  
##  \<a name="chtmlview__ondocwindowactivate">\</a>  CHtmlView::OnDocWindowActivate  
 Called from the Internet Explorer or MSHTML implementation of **IOleInPlaceActiveObject::OnDocWindowActivate**, which notifies the active in-place object when the container's document window is activated or deactivated.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 Indicates the state of the document window. If this value is nonzero, the window is being activated. If this value is zero, the window is being deactivated.  
  
### Return Value  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 Override <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::OnDocWindowActivate](https://msdn.microsoft.com/en-us/library/aa753261.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__ondownloadbegin">\</a>  CHtmlView::OnDownloadBegin  
 This member function is called by the framework to begin downloading a document.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 This event is fired shortly after the [OnBeforeNavigate2](#chtmlview__onbeforenavigate2) event, unless the navigation is canceled. Any animation or "busy" indication that the container needs to display should be connected to this event.  
  
##  \<a name="chtmlview__ondownloadcomplete">\</a>  CHtmlView::OnDownloadComplete  
 This member function is called by the framework to indicate that a navigation operation finished, was halted, or failed.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
##  \<a name="chtmlview__onenablemodeless">\</a>  CHtmlView::OnEnableModeless  
 Called when Internet Explorer or MSHTML displays modal UI.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 Indicates if the host's modeless dialog boxes are enabled or disabled. If this value is nonzero, modeless dialog boxes are enabled. If this value is zero, modeless dialog boxes are disabled.  
  
### Return Value  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 Enables or disables modeless dialog boxes when the container creates or destroys a modal dialog box. Override <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::EnableModeless](https://msdn.microsoft.com/en-us/library/aa753253.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onfilterdataobject">\</a>  CHtmlView::OnFilterDataObject  
 Called on the host by Internet Explorer or MSHTML to allow the host to replace Internet Explorer or MSHTML's data object.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Address of the                                 [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) interface supplied by Internet Explorer or MSHTML.  
  
 *ppDataObject*  
 Address that receives the <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> interface pointer supplied by the host. The contents of this parameter should always be initialized to **NULL**, even if the method fails.  
  
### Return Value  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> if the data object is replaced, **S_FALSE** if the data object is not replaced, or an OLE-defined error code if an error occurs.  
  
### Remarks  
 Override <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::FilterDataObject](https://msdn.microsoft.com/en-us/library/aa753254.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onframewindowactivate">\</a>  CHtmlView::OnFrameWindowActivate  
 Called from                 [IOleInPlaceActiveObject::OnFrameWindowActivate](http://msdn.microsoft.com/library/windows/desktop/ms683969) to notify the object when the container's top-level frame window is activated or deactivated.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 Indicates the state of the container's top-level frame window. If this value is nonzero, the window is being activated. If this value is zero, the window is being deactivated.  
  
### Return Value  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 Override <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::OnFrameWindowActivate](https://msdn.microsoft.com/en-us/library/aa753262.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onfullscreen">\</a>  CHtmlView::OnFullScreen  
 This member function is called by the framework when the                 [FullScreen](https://msdn.microsoft.com/en-us/library/aa752119.aspx) property has changed.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 *bFullScreen*  
 Nonzero if Internet Explorer is in full screen mode; zero otherwise.  
  
##  \<a name="chtmlview__ongetdroptarget">\</a>  CHtmlView::OnGetDropTarget  
 Called by Internet Explorer or MSHTML when it is being used as a drop target to allow the host to supply an alternative <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) Internet Explorer or MSHTML proposes to use.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 Address of the <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> that receives the <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> interface pointer the host wants to provide.  
  
### Return Value  
 See                         [IDocHostUIHandler::GetDropTarget](https://msdn.microsoft.com/en-us/library/aa753255.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of return codes.  
  
### Remarks  
 Override <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::GetDropTarget](https://msdn.microsoft.com/en-us/library/aa753255.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__ongetexternal">\</a>  CHtmlView::OnGetExternal  
 Called by Internet Explorer or MSHTML to obtain the host's <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 *lppDispatch*  
 A pointer to the address that receives the <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> interface pointer of the host application. If the host exposes an Automation interface, it can provide a reference to Internet Explorer or MSHTML through this parameter. The contents of this parameter should always be initialized to **NULL**, even if the method fails.  
  
### Return Value  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 Override <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::GetExternal](https://msdn.microsoft.com/en-us/library/aa753256.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__ongethostinfo">\</a>  CHtmlView::OnGetHostInfo  
 Retrieves the UI capabilities of the Internet Explorer or MSHTML host.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Address of a                                 [DOCHOSTUIINFO](https://msdn.microsoft.com/en-us/library/aa770044.aspx) structure that receives the host's UI capabilities.  
  
### Return Value  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 Override <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__ongetoptionkeypath">\</a>  CHtmlView::OnGetOptionKeyPath  
 Call this member function to get the registry key under which Internet Explorer or MSHTML stores user preferences.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 Address of an <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> that receives the registry subkey string where the host stores its default options. This subkey will be under the HKEY_CURRENT_USER key. Allocate this memory using                                 [CoTaskMemAlloc](http://msdn.microsoft.com/library/windows/desktop/ms692727). The calling application is responsible for freeing this memory using                                 [CoTaskMemFree](http://msdn.microsoft.com/library/windows/desktop/ms680722). This parameter should always be initialized to **NULL**, even if the method fails.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 Reserved for future use. Not currently used.  
  
### Return Value  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> if successful, or **S_FALSE** otherwise. If **S_FALSE**, Internet Explorer or MSHTML will default to its own user options.  
  
### Remarks  
 Override <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::GetOptionKeyPath](https://msdn.microsoft.com/en-us/library/aa753258.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onhideui">\</a>  CHtmlView::OnHideUI  
 This member function is called by the framework when Internet Explorer or MSHTML removes its menus and toolbars.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 Override <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::HideUI](https://msdn.microsoft.com/en-us/library/aa753259.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onmenubar">\</a>  CHtmlView::OnMenuBar  
 This member function is called by the framework when the                 [MenuBar](https://msdn.microsoft.com/en-us/library/aa752131.aspx) property has changed.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 *bMenuBar*  
 Nonzero if the Internet Explorer menu bar is visible; zero otherwise.  
  
##  \<a name="chtmlview__onnavigatecomplete2">\</a>  CHtmlView::OnNavigateComplete2  
 This member function is called by the framework after a navigation to a hyperlink completes (on either a window or frameset element).  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 *strURL*  
 A string expression that evaluates to the URL, UNC file name, or PIDL (a pointer to an item identifier list) that was navigated to.  
  
### Remarks  
 The URL parameter can be a PIDL in the case of a shell name space entity for which there is no URL representation.  
  
 Note that the URL contained in                         *strURL* can be different from the URL that the browser was told to navigate to, because this URL is the canonicalized and qualified URL. For example, if an application specifies a URL of "www.microsoft.com" in a call to [Navigate](#chtmlview__navigate) or [Navigate2](#chtmlview__navigate2), the URL passed by <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> will be "http://www.microsoft.com/". Also, if the server has redirected the browser to a different URL, the redirected URL will be reflected here.  
  
##  \<a name="chtmlview__onnavigateerror">\</a>  CHtmlView::OnNavigateError  
 Called by the framework if navigation to a hyperlink fails.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 The URL for which navigation failed.  
  
 *lpszFrame*  
 The name of the frame in which the resource is to be displayed, or NULL if no named frame was targeted for the resource.  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 An error status code, if available. For a list of the possible HRESULT and HTTP status codes, see                                 [NavigateError Event Status Codes.](https://msdn.microsoft.com/en-us/library/aa768365.aspx)  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 Specifies whether to cancel the navigation to an error page or any further autosearch. If **TRUE** (the default), continue with navigation to an error page or autosearch; if **FALSE**, cancel navigation to an error page or autosearch.  
  
### Remarks  
 Override this method to provide custom navigation error handling.  
  
 For more information, see                         [DWebBrowserEvents2::NavigateError](https://msdn.microsoft.com/en-us/library/aa768286.aspx)  
  
##  \<a name="chtmlview__onnewwindow2">\</a>  CHtmlView::OnNewWindow2  
 This member function is called by the framework when a new window is to be created for displaying a resource.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 A pointer to an interface pointer that, optionally, receives the <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> interface pointer of a new WebBrowser or Internet Explorer object.  
  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 A pointer to a cancel flag. An application can set this parameter to nonzero to cancel the navigation operation, or to zero to allow it to proceed.  
  
### Remarks  
 This event precedes the creation of a new window from within the WebBrowser.  
  
##  \<a name="chtmlview__onprogresschange">\</a>  CHtmlView::OnProgressChange  
 This member function is called by the framework to notify an application that the progress of a download operation has been updated.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 *nProgress*  
 Amount of total progress to show, or -1 when progress is complete.  
  
 *nProgressMax*  
 Maximum progress value.  
  
### Remarks  
 The container can use the information provided by this event to display the number of bytes downloaded so far or to update a progress indicator.  
  
##  \<a name="chtmlview__onpropertychange">\</a>  CHtmlView::OnPropertyChange  
 This member function is called by the framework to notify an application that [PutProperty](#chtmlview__putproperty) has changed the value of a property.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the property.  
  
##  \<a name="chtmlview__onquit">\</a>  CHtmlView::OnQuit  
 This member function is called by the framework to notify an application that the Internet Explorer application is ready to quit.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
##  \<a name="chtmlview__onresizeborder">\</a>  CHtmlView::OnResizeBorder  
 Called from the Internet Explorer or MSHTML implementation of                 [IOleInPlaceActiveObject::ResizeBorder](http://msdn.microsoft.com/library/windows/desktop/ms680053), which alerts the object that it needs to resize its border space.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 New outer rectangle for border space.  
  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 A pointer to the interface for the frame or document window object whose border has changed.  
  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 **TRUE** if the frame window is calling                                 [IOleInPlaceActiveObject::ResizeBorder](http://msdn.microsoft.com/library/windows/desktop/ms680053), otherwise **FALSE**.  
  
### Return Value  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 Override <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::ResizeBorder](https://msdn.microsoft.com/en-us/library/aa753263.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onshowcontextmenu">\</a>  CHtmlView::OnShowContextMenu  
 Called from Internet Explorer or MSHTML when it is about to show its context menu.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 Identifier of the context menu to be displayed. See **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 Screen coordinates for the menu.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 [IOleCommandTarget](http://msdn.microsoft.com/library/windows/desktop/ms683797) interface used to query command status and execute commands on this object.  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 IDispatch interface of the object at the screen coordinates. This allows a host to differentiate particular objects to provide more specific context.  
  
### Return Value  
 See                         [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
### Remarks  
 Override <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onshowui">\</a>  CHtmlView::OnShowUI  
 Called before Internet Explorer or MSHTML displays its menus and toolbars.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 [IOleInPlaceActiveObject](http://msdn.microsoft.com/library/windows/desktop/ms691299) interface of the currently active object.  
  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
 [IOleCommandTarget](http://msdn.microsoft.com/library/windows/desktop/ms683797) interface of the object.  
  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 [IOleInPlaceFrame](http://msdn.microsoft.com/library/windows/desktop/ms692770) interface of the object. This is needed for menus and toolbars.  
  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 [IOleInPlaceUIWindow](http://msdn.microsoft.com/library/windows/desktop/ms680716) interface for the object. This is needed for toolbars.  
  
### Return Value  
 See                         [IDocHostUIHandler::ShowUI](https://msdn.microsoft.com/en-us/library/aa753265.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
### Remarks  
 Override <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::ShowUI](https://msdn.microsoft.com/en-us/library/aa753265.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onstatusbar">\</a>  CHtmlView::OnStatusBar  
 This member function is called by the framework when the                 [StatusBar](https://msdn.microsoft.com/en-us/library/aa768270.aspx) property has changed.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 *bStatusBar*  
 Nonzero if Internet Explorer's status bar is visible or zero otherwise.  
  
##  \<a name="chtmlview__onstatustextchange">\</a>  CHtmlView::OnStatusTextChange  
 This member function is called by the framework to notify an application that the text of the status bar associated with the WebBrowser control has changed.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 A string that contains the new status bar text.  
  
##  \<a name="chtmlview__ontheatermode">\</a>  CHtmlView::OnTheaterMode  
 This member function is called by the framework when the                 [TheaterMode](https://msdn.microsoft.com/en-us/library/aa768273.aspx) property has changed.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 *bTheaterMode*  
 Nonzero if Internet Explorer is in theater mode; zero otherwise.  
  
##  \<a name="chtmlview__ontitlechange">\</a>  CHtmlView::OnTitleChange  
 This member function is called by the framework to notify an application if the title of a document in the WebBrowser control becomes available or changes.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
 The new document title.  
  
### Remarks  
 For HTML, the title might change; while HTML is still downloading, the URL of the document is set as the title. After the real title (if there is one) is parsed from the HTML, the title is changed to reflect the actual title.  
  
##  \<a name="chtmlview__ontoolbar">\</a>  CHtmlView::OnToolBar  
 This member function is called by the framework when the                 [ToolBar](https://msdn.microsoft.com/en-us/library/aa768274.aspx) property has changed.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Parameters  
 *bToolBar*  
 Nonzero if Internet Explorer's toolbar is visible or zero otherwise.  
  
##  \<a name="chtmlview__ontranslateaccelerator">\</a>  CHtmlView::OnTranslateAccelerator  
 Called by Internet Explorer or MSHTML when                 [IOleInPlaceActiveObject::TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms693360) or                 [IOleControlSite::TranslateAccelerator](http://msdn.microsoft.com/library/windows/desktop/ms693756) is called to process menu accelerator-key messages from the container's message queue.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
 Points to the message that might need to be translated.  
  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 Command group identifier.  
  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 Command identifier.  
  
### Return Value  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> if successful, or **S_FALSE** otherwise.  
  
### Remarks  
 Override <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::TranslateAccelerator](https://msdn.microsoft.com/en-us/library/aa753266.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__ontranslateurl">\</a>  CHtmlView::OnTranslateUrl  
 Called by Internet Explorer or MSHTML to allow the host an opportunity to modify the URL to be loaded.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 Reserved for future use.  
  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 Address of a string supplied by Internet Explorer or MSHTML that represents the URL to be translated.  
  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 Address of a string pointer that receives the address of the translated URL. The host allocates the buffer using the task memory allocator. The contents of this parameter should always be initialized to **NULL**, even if the URL is not translated or the method fails.  
  
### Return Value  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> if the URL was translated, **S_FALSE** if the URL was not translated, or an OLE-defined error code if an error occurred.  
  
### Remarks  
 Override <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control. See                         [IDocHostUIHandler::TranslateUrl](https://msdn.microsoft.com/en-us/library/aa753267.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="chtmlview__onupdateui">\</a>  CHtmlView::OnUpdateUI  
 Notifies the host that the command state has changed.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> if successful, or an OLE-defined error code otherwise.  
  
### Remarks  
 The host should update the state of toolbar buttons. This method is called regardless of the return value from <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>. Override <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> to react to the <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> notification from the Microsoft Web Browser control.  
  
##  \<a name="chtmlview__onvisible">\</a>  CHtmlView::OnVisible  
 This member function is called by the framework when the window for the WebBrowser should be shown or hidden.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 Nonzero if the object is visible or zero otherwise.  
  
### Remarks  
 This allows the object control host window to behave the same way the Internet Explorer window would behave.  
  
##  \<a name="chtmlview__putproperty">\</a>  CHtmlView::PutProperty  
 Call this member function to set the property associated with a given object.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 A string containing the property to set.  
  
 *vtValue*  
 The new value of the property indicated by <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
 *lpszPropertyName*  
 A pointer to a string containing the name of the property to set.  
  
 *dValue*  
 The new value of the property.  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 The new value of the property.  
  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 A pointer to a string containing the new value of the property.  
  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 The new value of the property.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__queryformscommand">\</a>  CHtmlView::QueryFormsCommand  
 Queries for the status of one or more commands generated by user interface events.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 The identifier of the command being queried for.  
  
 *pbSupported*  
 A pointer to a **BOOL** specifying if the command (identified by <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>) is supported. If TRUE, the command is supported; otherwise FALSE.  
  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 A pointer to a **BOOL** specifying if the command (identified by <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>) is enabled. If TRUE, the command is supported; otherwise FALSE.  
  
 *pbChecked*  
 A pointer to a **BOOL** specifying if the command (identified by <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>) is checked. If TRUE, the command is supported; otherwise FALSE.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> value. For a complete listing of possible values, see                         [IOleCommandTarget::QueryStatus](http://msdn.microsoft.com/library/windows/desktop/ms688491) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> implements the behavior of the                         [IOleCommandTarget::QueryStatus](http://msdn.microsoft.com/library/windows/desktop/ms688491) method.  
  
##  \<a name="chtmlview__querystatuswb">\</a>  CHtmlView::QueryStatusWB  
 Call this member function to query a command status.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
 The                                 [OLECMDID](http://msdn.microsoft.com/library/windows/desktop/ms691264) value of the command for which the caller needs status information.  
  
### Return Value  
 The address of the                         [OLECMDF](http://msdn.microsoft.com/library/windows/desktop/ms695237) value that receives the status of the command.  
  
### Remarks  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> implements the behavior of the                         [IOleCommandTarget::QueryStatus](http://msdn.microsoft.com/library/windows/desktop/ms688491) method.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__refresh">\</a>  CHtmlView::Refresh  
 Reloads the URL or file that the web browser is currently displaying.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Remarks  
 **Refresh** contains no parameters for setting the refresh level.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__refresh2">\</a>  CHtmlView::Refresh2  
 Reloads the file that Internet Explorer is currently displaying.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
 The address of the variable specifying the refresh level. The possible variables are defined in                                 [RefreshConstants](https://msdn.microsoft.com/en-us/library/aa768363.aspx), in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 Unlike [Refresh](#chtmlview__refresh), <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> contains a parameter that specifies the refresh level.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setaddressbar">\</a>  CHtmlView::SetAddressBar  
 Call this member function to show or hide the Internet Explorer object's address bar.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 Nonzero to show address bar; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__setfullscreen">\</a>  CHtmlView::SetFullScreen  
 Call this member function to set Internet Explorer to either full-screen or normal window mode.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 Nonzero for full-screen mode; otherwise zero.  
  
### Remarks  
 In full-screen mode, the Internet Explorer main window is maximized and the status bar, toolbar, menu bar, and title bar are hidden.  
  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__setheight">\</a>  CHtmlView::SetHeight  
 Call this member function to set the height of the Internet Explorer main window.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 The height, in pixels, of the main window.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setleft">\</a>  CHtmlView::SetLeft  
 Sets the horizontal position of the Internet Explorer main window.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 The screen coordinate of the left edge of the main window.  
  
##  \<a name="chtmlview__setmenubar">\</a>  CHtmlView::SetMenuBar  
 Call this member function to show or hide the Internet Explorer menu bar.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 Nonzero to show menu bar; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__setoffline">\</a>  CHtmlView::SetOffline  
 Call this member function to set a value indicating whether the WebBrowser control is currently operating in offline mode.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 Nonzero to read from the local cache; otherwise zero.  
  
### Remarks  
 In offline mode, the browser reads HTML pages from the local cache rather than from the source document.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setregisterasbrowser">\</a>  CHtmlView::SetRegisterAsBrowser  
 Call this member function to set a value indicating whether the WebBrowser control is registered as a top-level browser for target name resolution.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 Determines whether Internet Explorer is registered as a top-level browser. If nonzero, the web browser is registered as a top-level browser; if zero, it is not a top-level browser. The default value is zero.  
  
### Remarks  
 A top-level browser is the browser set in the registry as the default browser.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setregisterasdroptarget">\</a>  CHtmlView::SetRegisterAsDropTarget  
 Call this member function to set a value indicating whether the WebBrowser control is registered as a drop target for navigation.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
 Determines if the WebBrowser control is registered as a drop target for navigation. If nonzero, the object is registered as a drop target; if zero, it is not a drop target.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setsilent">\</a>  CHtmlView::SetSilent  
 Call this member function to set a value indicating whether any dialog boxes can be shown.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 If nonzero, dialog boxes will not be displayed; if zero, dialog boxes will be displayed. The default value is zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setstatusbar">\</a>  CHtmlView::SetStatusBar  
 Call this member function to display the status bar.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 Nonzero if the status bar is visible; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__settheatermode">\</a>  CHtmlView::SetTheaterMode  
 Call this member function to set a value indicating whether the WebBrowser control is in theater mode.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 Nonzero to set the WebBrowser control to theater mode; otherwise zero. The default value is zero.  
  
### Remarks  
 When the web browser is in theater mode, the browser main window fills the entire screen, a toolbar with a minimal set of navigational tools appears, and the status bar appears in the upper right-hand corner of the screen.  
  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__settoolbar">\</a>  CHtmlView::SetToolBar  
 Call this member function to show or hide the Internet Explorer toolbar.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 Indicates whether to display the toolbar. Nonzero if the toolbar is to be displayed; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer. If you use this call with a WebBrowser control, it will return no error, but it will ignore this call.  
  
##  \<a name="chtmlview__settop">\</a>  CHtmlView::SetTop  
 Call this member function to set the distance between the internal top edge of the WebBrowser control and the top edge of its container  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 The screen coordinate of the top edge of the main window.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setvisible">\</a>  CHtmlView::SetVisible  
 Call this member function to set the visibility state of the WebBrowser control.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 Nonzero if the control is visible; otherwise zero.  
  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
##  \<a name="chtmlview__setwidth">\</a>  CHtmlView::SetWidth  
 Sets the width of the Internet Explorer main window.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 The width, in pixels, of the Internet Explorer main window.  
  
##  \<a name="chtmlview__stop">\</a>  CHtmlView::Stop  
 Call this member function to cancel any pending navigation or download operation and stop any dynamic page elements, such as background sounds and animations.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Remarks  
 Applies to Internet Explorer and WebBrowser.  
  
## See Also  
 [MFC Sample MFCIE](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cformview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IWebBrowser2](https://msdn.microsoft.com/en-us/library/aa752127.aspx)