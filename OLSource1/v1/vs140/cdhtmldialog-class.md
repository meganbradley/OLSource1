---
title: "CDHtmlDialog Class"
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
  - "CDHtmlDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDHtmlDialog class"
ms.assetid: 3f941c85-87e1-4f0f-9cc5-ffee8498b312
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDHtmlDialog Class
Is used to create dialog boxes that use HTML rather than dialog resources to implement their user interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDHtmlDialog::CDHtmlDialog](#cdhtmldialog__cdhtmldialog)|Constructs a CDHtmlDialog object.|  
|[CDHtmlDialog::~CDHtmlDialog](#cdhtmldialog__~cdhtmldialog)|Destroys a CDHtmlDialog object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDHtmlDialog::CanAccessExternal](#cdhtmldialog__canaccessexternal)|Overridable that is called as an access check to see whether scripting objects on the loaded page can access the external dispatch of the control site. Checks to make sure the dispatch is either safe for scripting or the current zone allows for objects that are not safe for scripting.|  
|[CDHtmlDialog::CreateControlSite](#cdhtmldialog__createcontrolsite)|Overridable used to create a control site instance to host the WebBrowser control on the dialog.|  
|[CDHtmlDialog::DDX_DHtml_AxControl](#cdhtmldialog__ddx_dhtml_axcontrol)|Exchanges data between a member variable and the property value of an ActiveX control on an HTML page.|  
|[CDHtmlDialog::DDX_DHtml_CheckBox](#cdhtmldialog__ddx_dhtml_checkbox)|Exchanges data between a member variable and a check box on an HTML page.|  
|[CDHtmlDialog::DDX_DHtml_ElementText](#cdhtmldialog__ddx_dhtml_elementtext)|Exchanges data between a member variable and any HTML element property on an HTML page.|  
|[CDHtmlDialog::DDX_DHtml_Radio](#cdhtmldialog__ddx_dhtml_radio)|Exchanges data between a member variable and a radio button on an HTML page.|  
|[CDHtmlDialog::DDX_DHtml_SelectIndex](#cdhtmldialog__ddx_dhtml_selectindex)|Gets or sets the index of a list box on an HTML page.|  
|[CDHtmlDialog::DDX_DHtml_SelectString](#cdhtmldialog__ddx_dhtml_selectstring)|Gets or sets the display text of a list box entry (based on the current index) on an HTML page.|  
|[CDHtmlDialog::DDX_DHtml_SelectValue](#cdhtmldialog__ddx_dhtml_selectvalue)|Gets or sets the value of a list box entry (based on the current index) on an HTML page.|  
|[CDHtmlDialog::DestroyModeless](#cdhtmldialog__destroymodeless)|Destroys a modeless dialog box.|  
|[CDHtmlDialog::EnableModeless](#cdhtmldialog__enablemodeless)|Enables modeless dialog boxes.|  
|[CDHtmlDialog::FilterDataObject](#cdhtmldialog__filterdataobject)|Allows the dialog to filter clipboard data objects created by the hosted browser.|  
|[CDHtmlDialog::GetControlDispatch](#cdhtmldialog__getcontroldispatch)|Retrieves the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> interface on an ActiveX control embedded in the HTML document.|  
|[CDHtmlDialog::GetControlProperty](#cdhtmldialog__getcontrolproperty)|Retrieves the requested property of the specified ActiveX control.|  
|[CDHtmlDialog::GetCurrentUrl](#cdhtmldialog__getcurrenturl)|Retrieves the Uniform Resource Locator (URL) associated with the current document.|  
|[CDHtmlDialog::GetDHtmlDocument](#cdhtmldialog__getdhtmldocument)|Retrieves the IHTMLDocument2 interface on the currently loaded HTML document.|  
|[CDHtmlDialog::GetDropTarget](#cdhtmldialog__getdroptarget)|Called by the contained WebBrowser control when it is being used as a drop target to allow the dialog to supply an alternative                                         [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679).|  
|[CDHtmlDialog::GetElement](#cdhtmldialog__getelement)|Gets an interface on an HTML element.|  
|[CDHtmlDialog::GetElementHtml](#cdhtmldialog__getelementhtml)|Retrieves the **innerHTML** property of an HTML element.|  
|[CDHtmlDialog::GetElementInterface](#cdhtmldialog__getelementinterface)|Retrieves the requested interface pointer from an HTML element.|  
|[CDHtmlDialog::GetElementProperty](#cdhtmldialog__getelementproperty)|Retrieves the value of an HTML element's property.|  
|[CDHtmlDialog::GetElementText](#cdhtmldialog__getelementtext)|Retrieves the **innerText** property of an HTML element.|  
|[CDHtmlDialog::GetEvent](#cdhtmldialog__getevent)|Gets the **IHTMLEventObj** pointer to the current event object.|  
|[CDHtmlDialog::GetExternal](#cdhtmldialog__getexternal)|Gets the host's <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> interface.|  
|[CDHtmlDialog::GetHostInfo](#cdhtmldialog__gethostinfo)|Retrieves the host's UI capabilities.|  
|[CDHtmlDialog::GetOptionKeyPath](#cdhtmldialog__getoptionkeypath)|Retrieves the registry key under which user preferences are stored.|  
|[CDHtmlDialog::HideUI](#cdhtmldialog__hideui)|Hides the host's UI.|  
|[CDHtmlDialog::IsExternalDispatchSafe](#cdhtmldialog__isexternaldispatchsafe)|Indicates whether the host's <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> interface is safe for scripting.|  
|[CDHtmlDialog::LoadFromResource](#cdhtmldialog__loadfromresource)|Loads the specified resource into the WebBrowser control.|  
|[CDHtmlDialog::Navigate](#cdhtmldialog__navigate)|Navigates to the specified URL.|  
|[CDHtmlDialog::OnBeforeNavigate](#cdhtmldialog__onbeforenavigate)|Called by the framework before a navigation event is fired.|  
|[CDHtmlDialog::OnDocumentComplete](#cdhtmldialog__ondocumentcomplete)|Called by the framework to notify an application when a document has reached the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> state.|  
|[CDHtmlDialog::OnDocWindowActivate](#cdhtmldialog__ondocwindowactivate)|Called by the framework when the document window is activated or deactivated.|  
|[CDHtmlDialog::OnFrameWindowActivate](#cdhtmldialog__onframewindowactivate)|Called by the framework when the frame window is activated or deactivated.|  
|[CDHtmlDialog::OnInitDialog](#cdhtmldialog__oninitdialog)|Called in response to the **WM_INITDIALOG** message.|  
|[CDHtmlDialog::OnNavigateComplete](#cdhtmldialog__onnavigatecomplete)|Called by the framework after a navigation event is completed.|  
|[CDHtmlDialog::ResizeBorder](#cdhtmldialog__resizeborder)|Alerts the object that it needs to resize its border space.|  
|[CDHtmlDialog::SetControlProperty](#cdhtmldialog__setcontrolproperty)|Sets the property of an ActiveX control to a new value.|  
|[CDHtmlDialog::SetElementHtml](#cdhtmldialog__setelementhtml)|Sets the **innerHTML** property of an HTML element.|  
|[CDHtmlDialog::SetElementProperty](#cdhtmldialog__setelementproperty)|Sets a property of an HTML element.|  
|[CDHtmlDialog::SetElementText](#cdhtmldialog__setelementtext)|Sets the **innerText** property of an HTML element.|  
|[CDHtmlDialog::SetExternalDispatch](#cdhtmldialog__setexternaldispatch)|Sets the host's <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> interface.|  
|[CDHtmlDialog::SetHostFlags](#cdhtmldialog__sethostflags)|Sets the host's UI flags.|  
|[CDHtmlDialog::ShowContextMenu](#cdhtmldialog__showcontextmenu)|Called when a context menu is about to be displayed.|  
|[CDHtmlDialog::ShowUI](#cdhtmldialog__showui)|Shows the host's UI.|  
|[CDHtmlDialog::TranslateAccelerator](#cdhtmldialog__translateaccelerator)|Called to process menu accelerator-key messages.|  
|[CDHtmlDialog::TranslateUrl](#cdhtmldialog__translateurl)|Called to modify the URL to be loaded.|  
|[CDHtmlDialog::UpdateUI](#cdhtmldialog__updateui)|Called to notify the host that the command state has changed.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDHtmlDialog::m_bUseHtmlTitle](#cdhtmldialog__m_busehtmltitle)|Indicates whether to use the HTML document's title as the dialog caption.|  
|[CDHtmlDialog::m_nHtmlResID](#cdhtmldialog__m_nhtmlresid)|Resource ID of HTML resource to be displayed.|  
|[CDHtmlDialog::m_pBrowserApp](#cdhtmldialog__m_pbrowserapp)|A pointer to a Web browser application.|  
|[CDHtmlDialog::m_spHtmlDoc](#cdhtmldialog__m_sphtmldoc)|A pointer to an HTML document.|  
|[CDHtmlDialog::m_strCurrentUrl](#cdhtmldialog__m_strcurrenturl)|The current URL.|  
|[CDHtmlDialog::m_szHtmlResID](#cdhtmldialog__m_szhtmlresid)|String version of the HTML resource ID.|  
  
## Remarks  
 **CDHtmlDialog** can load the HTML to be displayed from either an HTML resource or a URL.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> can also do data exchange with HTML controls and handle events from HTML controls, such as button clicks.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdhtml.h  
  
##  \<a name="ddx_dhtml_helper_macros">\</a>  DDX_DHtml Helper Macros  
 The DDX_DHtml helper macros allow easy access to the commonly used properties of controls on an HTML page.  
  
### Data Exchange Macros  
  
|||  
|-|-|  
|[DDX_DHtml_ElementValue](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_elementvalue)|Sets or retrieves the Value property from the selected control.|  
|[DDX_DHtml_ElementInnerText](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_elementinnertext)|Sets or retrieves the text between the start and end tags of the current element.|  
|[DDX_DHtml_ElementInnerHtml](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_elementinnerhtml)|Sets or retrieves the HTML between the start and end tags of the current element.|  
|[DDX_DHtml_Anchor_Href](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_anchor_href)|Sets or retrieves the destination URL or anchor point.|  
|[DDX_DHtml_Anchor_Target](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_anchor_target)|Sets or retrieves the target window or frame.|  
|[DDX_DHtml_Img_Src](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_img_src)|Sets or retrieves the name of an image or a video clip in the document.|  
|[DDX_DHtml_Frame_Src](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_frame_src)|Sets or retrieves the URL of the associated frame.|  
|[DDX_DHtml_IFrame_Src](../vs140/ddx_dhtml-helper-macros.md#ddx_dhtml_iframe_src)|Sets or retrieves the URL of the associated frame.|  
  
##  \<a name="cdhtmldialog__canaccessexternal">\</a>  CDHtmlDialog::CanAccessExternal  
 Overridable that is called as an access check to see whether scripting objects on the loaded page can access the external dispatch of the control site. Checks to make sure the dispatch is either safe for scripting or the current zone allows for objects that are not safe for scripting.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="cdhtmldialog__cdhtmldialog">\</a>  CDHtmlDialog::CDHtmlDialog  
 Constructs a resource-based dynamic HTML dialog box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The null-terminated string that is the name of a dialog-box template resource.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The null-terminated string that is the name of an HTML resource.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 A pointer to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog-box template resource.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Contains the ID number of an HTML resource.  
  
### Remarks  
 The second form of the constructor provides access to the dialog resource through the template name. The third form of the constructor provides access to the dialog resource through the ID of the resource template. Usually, the ID begins with the **IDD_** prefix.  
  
##  \<a name="cdhtmldialog___dtorcdhtmldialog">\</a>  CDHtmlDialog::~CDHtmlDialog  
 Destroys a CDHtmlDialog object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The [CWnd::DestroyWindow](../vs140/cwnd-class.md#cwnd__destroywindow) member function must be used to destroy modeless dialog boxes that are created by [CDialog::Create](../vs140/cdialog-class.md#cdialog__create).  
  
##  \<a name="cdhtmldialog__createcontrolsite">\</a>  CDHtmlDialog::CreateControlSite  
 Overridable used to create a control site instance to host the WebBrowser control on the dialog.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A pointer to the [COleControlContainer](../vs140/colecontrolcontainer-class.md) object  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A pointer to a pointer to a [COleControlSite](../vs140/colecontrolsite-class.md).  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 You can override this member function to return an instance of your own control site class.  
  
##  \<a name="cdhtmldialog__ddx_dhtml_axcontrol">\</a>  CDHtmlDialog::DDX_DHtml_AxControl  
 Exchanges data between a member variable and the property value of an ActiveX control on an HTML page.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The value of the object tag's ID parameter in the HTML source for the ActiveX control.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The dispatch ID of the property with which you want to exchange data.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The name of the property.  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The data member, of type <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, [COleVariant](../vs140/colevariant-class.md), or [CComVariant](../vs140/ccomvariant-class.md), that holds the value exchanged with the ActiveX control property.  
  
### Example  
 [!code[NVC_MFCHtmlHttp#1](../vs140/codesnippet/CPP/cdhtmldialog-class_1.cpp)]  
  
##  \<a name="cdhtmldialog__ddx_dhtml_checkbox">\</a>  CDHtmlDialog::DDX_DHtml_CheckBox  
 Exchanges data between a member variable and a check box on an HTML page.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The value that you specified for the HTML control's ID parameter.  
  
 *value*  
 The value being exchanged.  
  
### Example  
 [!code[NVC_MFCHtmlHttp#2](../vs140/codesnippet/CPP/cdhtmldialog-class_2.cpp)]  
  
##  \<a name="cdhtmldialog__ddx_dhtml_elementtext">\</a>  CDHtmlDialog::DDX_DHtml_ElementText  
 Exchanges data between a member variable and any HTML element property on an HTML page.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The value that you specified for the HTML control's ID parameter.  
  
 *dispid*  
 The dispatch ID of the HTML element with which you want to exchange data.  
  
 *value*  
 The value being exchanged.  
  
##  \<a name="cdhtmldialog__ddx_dhtml_radio">\</a>  CDHtmlDialog::DDX_DHtml_Radio  
 Exchanges data between a member variable and a radio button on an HTML page.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The value that you specified for the HTML control's ID parameter.  
  
 *value*  
 The value being exchanged.  
  
##  \<a name="cdhtmldialog__ddx_dhtml_selectindex">\</a>  CDHtmlDialog::DDX_DHtml_SelectIndex  
 Gets or sets the index of a list box on an HTML page.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The value that you specified for the HTML control's id parameter.  
  
 *value*  
 The value being exchanged.  
  
##  \<a name="cdhtmldialog__ddx_dhtml_selectstring">\</a>  CDHtmlDialog::DDX_DHtml_SelectString  
 Gets or sets the display text of a list box entry (based on the current index) on an HTML page.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The value that you specified for the HTML control's ID parameter.  
  
 *value*  
 The value being exchanged.  
  
##  \<a name="cdhtmldialog__ddx_dhtml_selectvalue">\</a>  CDHtmlDialog::DDX_DHtml_SelectValue  
 Gets or sets the value of a list box entry (based on the current index) on an HTML page.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The value that you specified for the HTML control's ID parameter.  
  
 *value*  
 The value being exchanged.  
  
### Example  
 [!code[NVC_MFCHtmlHttp#3](../vs140/codesnippet/CPP/cdhtmldialog-class_3.cpp)]  
  
##  \<a name="cdhtmldialog__destroymodeless">\</a>  CDHtmlDialog::DestroyModeless  
 Detaches a modeless dialog box from the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object and destroys the object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="cdhtmldialog__enablemodeless">\</a>  CDHtmlDialog::EnableModeless  
 Enables modeless dialog boxes.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::EnableModeless](https://msdn.microsoft.com/en-us/library/aa753253.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::EnableModeless](https://msdn.microsoft.com/en-us/library/aa753253.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__filterdataobject">\</a>  CDHtmlDialog::FilterDataObject  
 Allows the dialog to filter clipboard data objects created by the hosted browser.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::FilterDataObject](https://msdn.microsoft.com/en-us/library/aa753254.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> in **IDocHostUIHandler::FilterDataObject** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **S_FALSE**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::FilterDataObject](https://msdn.microsoft.com/en-us/library/aa753254.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__getcontroldispatch">\</a>  CDHtmlDialog::GetControlDispatch  
 Retrieves the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> interface on an ActiveX control embedded in the HTML document returned by [GetDHtmlDocument](#cdhtmldialog__getdhtmldocument).  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 The HTML ID of an ActiveX control.  
  
 *ppdisp*  
 The <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> interface of the control if found in the Web page.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> value.  
  
##  \<a name="cdhtmldialog__getcontrolproperty">\</a>  CDHtmlDialog::GetControlProperty  
 Retrieves the requested property of the specified ActiveX control.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The HTML ID of an ActiveX control.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The name of a property in the default locale of the current user.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> pointer of an ActiveX control.  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The dispatch ID of a property.  
  
### Return Value  
 A variant containing the requested property or an empty variant if the control or property could not be found.  
  
### Remarks  
 The overloads are listed from least efficient at the top to most efficient at the bottom.  
  
##  \<a name="cdhtmldialog__getcurrenturl">\</a>  CDHtmlDialog::GetCurrentUrl  
 Retrieves the Uniform Resource Locator (URL) associated with the current document.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object containing the URL to retrieve.  
  
##  \<a name="cdhtmldialog__getdhtmldocument">\</a>  CDHtmlDialog::GetDHtmlDocument  
 Retrieves the                 [IHTMLDocument2](https://msdn.microsoft.com/en-us/library/aa752574.aspx) interface on the currently loaded HTML document.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 *\*\*pphtmlDoc*  
 A pointer to a pointer to an HTML document.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> if successful.  
  
##  \<a name="cdhtmldialog__getdroptarget">\</a>  CDHtmlDialog::GetDropTarget  
 Called by the contained WebBrowser control when it is being used as a drop target to allow the dialog to supply an alternative                 [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679).  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::GetDropTarget](https://msdn.microsoft.com/en-us/library/aa753255.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> in **IDocHostUIHandler::GetDropTarget** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::GetDropTarget](https://msdn.microsoft.com/en-us/library/aa753255.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__getelement">\</a>  CDHtmlDialog::GetElement  
 Returns an interface on the HTML element specified by <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
 *ppdisp*  
 An <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> pointer to the requested element or collection of elements.  
  
 *pbCollection*  
 A **BOOL** indicating whether the object represented by                                 *ppdisp* is a single element or a collection of elements.  
  
 *pphtmlElement*  
 An **IHTMLElement** pointer to the requested element.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Use the first overload if you need to handle conditions in which there may be more than one element with the specified ID. You can use the last parameter to find out whether the returned interface pointer is to a collection or a single item. If the interface pointer is on a collection, you can query for the **IHTMLElementCollection** and use its **item** property to refer to the elements by ordinal position.  
  
 The second overload will fail if there is more than one element with the same ID in the page.  
  
##  \<a name="cdhtmldialog__getelementhtml">\</a>  CDHtmlDialog::GetElementHtml  
 Retrieves the **innerHTML** property of the HTML element identified by <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
### Return Value  
 The **innerHTML** property of the HTML element identified by <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> or **NULL** if the element could not be found.  
  
##  \<a name="cdhtmldialog__getelementinterface">\</a>  CDHtmlDialog::GetElementInterface  
 Retrieves the requested interface pointer from the HTML element identified by <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 Address of a pointer that will be filled with the requested interface pointer if the element is found and the query succeeds.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The interface ID (IID) of the requested interface.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> value.  
  
### Example  
 [!code[NVC_MFCHtmlHttp#4](../vs140/codesnippet/CPP/cdhtmldialog-class_4.cpp)]  
  
##  \<a name="cdhtmldialog__getelementproperty">\</a>  CDHtmlDialog::GetElementProperty  
 Retrieves the value of the property identified by <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> from the HTML element identified by <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The dispatch ID of a property.  
  
### Return Value  
 The value of the property or an empty variant if the property or element could not be found.  
  
##  \<a name="cdhtmldialog__getelementtext">\</a>  CDHtmlDialog::GetElementText  
 Retrieves the **innerText** property of the HTML element identified by <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
### Return Value  
 The **innerText** property of the HTML element identified by <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> or **NULL** if the property or element could not be found.  
  
##  \<a name="cdhtmldialog__getevent">\</a>  CDHtmlDialog::GetEvent  
 Returns the **IHTMLEventObj** pointer to the current event object.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Address of a pointer that will be filled with the **IHTMLEventObj** interface pointer.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> value.  
  
### Remarks  
 This function should only be called from within a DHTML event handler.  
  
##  \<a name="cdhtmldialog__getexternal">\</a>  CDHtmlDialog::GetExternal  
 Gets the host's <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *ppDispatch*  
 See                                 *ppDispatch* in                                 [IDocHostUIHandler::GetExternal](https://msdn.microsoft.com/en-us/library/aa753256.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> on success or **E_NOTIMPL** on failure.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::GetExternal](https://msdn.microsoft.com/en-us/library/aa753256.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__gethostinfo">\</a>  CDHtmlDialog::GetHostInfo  
 Retrieves the host's UI capabilities.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::GetHostInfo](https://msdn.microsoft.com/en-us/library/aa753257.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__getoptionkeypath">\</a>  CDHtmlDialog::GetOptionKeyPath  
 Retrieves the registry key under which user preferences are stored.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::GetOptionKeyPath](https://msdn.microsoft.com/en-us/library/aa753258.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> in **IDocHostUIHandler::GetOptionKeyPath** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::GetOptionKeyPath](https://msdn.microsoft.com/en-us/library/aa753258.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__hideui">\</a>  CDHtmlDialog::HideUI  
 Hides the host's UI.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::HideUI](https://msdn.microsoft.com/en-us/library/aa753259.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__isexternaldispatchsafe">\</a>  CDHtmlDialog::IsExternalDispatchSafe  
 Indicates whether the host's <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> interface is safe for scripting.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 Returns **FALSE**.  
  
##  \<a name="cdhtmldialog__loadfromresource">\</a>  CDHtmlDialog::LoadFromResource  
 Loads the specified resource into the WebBrowser control in the DHTML dialog.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the resource to load.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The ID of the resource to load.  
  
### Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
##  \<a name="cdhtmldialog__m_busehtmltitle">\</a>  CDHtmlDialog::m_bUseHtmlTitle  
 Indicates whether to use the HTML document's title as the dialog caption.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 If **m**_ **bUseHtmlTitle** is **true**, the dialog caption is set equal to the title of the HTML document; otherwise, the caption in the dialog resource is used.  
  
##  \<a name="cdhtmldialog__m_nhtmlresid">\</a>  CDHtmlDialog::m_nHtmlResID  
 Resource ID of HTML resource to be displayed.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFCHtmlHttp#5](../vs140/codesnippet/CPP/cdhtmldialog-class_5.cpp)]  
  
##  \<a name="cdhtmldialog__m_pbrowserapp">\</a>  CDHtmlDialog::m_pBrowserApp  
 A pointer to a Web browser application.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
##  \<a name="cdhtmldialog__m_sphtmldoc">\</a>  CDHtmlDialog::m_spHtmlDoc  
 A pointer to an HTML document.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="cdhtmldialog__m_strcurrenturl">\</a>  CDHtmlDialog::m_strCurrentUrl  
 The current URL.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
##  \<a name="cdhtmldialog__m_szhtmlresid">\</a>  CDHtmlDialog::m_szHtmlResID  
 String version of the HTML resource ID.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFCHtmlHttp#6](../vs140/codesnippet/CPP/cdhtmldialog-class_6.cpp)]  
  
##  \<a name="cdhtmldialog__navigate">\</a>  CDHtmlDialog::Navigate  
 Navigates to the resource identified by the URL that is specified by <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL to be targeted.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 The flags of a variable that specifies whether to add the resource to the history list, whether to read to the cache or write from the cache, and whether to display the resource in a new window. The variable can be a combination of the values defined by the                                 [BrowserNavConstants](https://msdn.microsoft.com/en-us/library/aa768360.aspx) enumeration.  
  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A pointer to a string that contains the name of the frame in which to display the resource.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 A pointer to a value that specifies the HTTP headers to send to the server. These headers are added to the default Internet Explorer headers. The headers can specify such information as the action required of the server, the type of data being passed to the server, or a status code. This parameter is ignored if the URL is not an HTTP URL.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 A pointer to the data to send with the HTTP POST transaction. For example, the POST transaction is used to send data gathered by an HTML form. If this parameter does not specify any post data, **Navigate** issues an HTTP GET transaction. This parameter is ignored if the URL is not an HTTP URL.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Data to send with the HTTP POST transaction. For example, the POST transaction is used to send data gathered by an HTML form. If this parameter does not specify any post data, **Navigate** issues an HTTP GET transaction. This parameter is ignored if URL is not an HTTP URL.  
  
##  \<a name="cdhtmldialog__onbeforenavigate">\</a>  CDHtmlDialog::OnBeforeNavigate  
 Called by the framework to cause an event to fire before a navigation occurs.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL to navigate to.  
  
##  \<a name="cdhtmldialog__ondocumentcomplete">\</a>  CDHtmlDialog::OnDocumentComplete  
 Called by the framework to notify an application when a document has achieved the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> state.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL that was navigated to.  
  
##  \<a name="cdhtmldialog__ondocwindowactivate">\</a>  CDHtmlDialog::OnDocWindowActivate  
 Called by the framework when the document window is activated or deactivated.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::OnDocWindowActivate](https://msdn.microsoft.com/en-us/library/aa753261.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 This member function is CDHtmlDialog's implemention of                         [IDocHostUIHandler::OnDocWindowActivate](https://msdn.microsoft.com/en-us/library/aa753261.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__onframewindowactivate">\</a>  CDHtmlDialog::OnFrameWindowActivate  
 Called by the framework when the frame window is activated or deactivated.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::OnFrameWindowActivate](https://msdn.microsoft.com/en-us/library/aa753262.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::OnFrameWindowActivate](https://msdn.microsoft.com/en-us/library/aa753262.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__oninitdialog">\</a>  CDHtmlDialog::OnInitDialog  
 Called in response to the **WM_INITDIALOG** message.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 The default implementation returns **TRUE**.  
  
### Remarks  
 This message is sent to the dialog box during the **Create**, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> calls, which occur immediately before the dialog box is displayed.  
  
 Override this member function if you need to perform special processing when the dialog box is initialized. In the overridden version, first call the base class <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> but disregard its return value. You will normally return **TRUE** from your overridden member function.  
  
 Windows calls the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> function through the standard global dialog-box procedure common to all Microsoft Foundation Class Library dialog boxes, rather than through your message map, so you do not need a message-map entry for this member function.  
  
##  \<a name="cdhtmldialog__onnavigatecomplete">\</a>  CDHtmlDialog::OnNavigateComplete  
 Called by the framework after navigation to the specified URL is completed.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 A pointer to a string containing the URL that was navigated to.  
  
##  \<a name="cdhtmldialog__resizeborder">\</a>  CDHtmlDialog::ResizeBorder  
 Alerts the object that it needs to resize its border space.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::ResizeBorder](https://msdn.microsoft.com/en-us/library/aa753263.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> in **IDocHostUIHandler::ResizeBorder** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 See                                 *fFrameWindow* in **IDocHostUIHandler::ResizeBorder** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **E_NOTIMPL**.  
  
##  \<a name="cdhtmldialog__setcontrolproperty">\</a>  CDHtmlDialog::SetControlProperty  
 Sets the property of an ActiveX control to a new value.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The HTML ID of an ActiveX control.  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 The dispatch ID of the property to set.  
  
 *pVar*  
 Pointer to a **VARIANT** containing the new property value.  
  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 Pointer to an ActiveX control's <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> interface.  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 String containing the name of the property to set.  
  
##  \<a name="cdhtmldialog__setelementhtml">\</a>  CDHtmlDialog::SetElementHtml  
 Sets the **innerHTML** property of an HTML element.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 The new value of the **innerHTML** property.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 The **IUnknown** pointer of an HTML element.  
  
##  \<a name="cdhtmldialog__setelementproperty">\</a>  CDHtmlDialog::SetElementProperty  
 Sets a property of an HTML element.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 The dispatch ID of the property to set.  
  
 *pVar*  
 The new value of the property.  
  
##  \<a name="cdhtmldialog__setelementtext">\</a>  CDHtmlDialog::SetElementText  
 Sets the **innerText** property of an HTML element.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The ID of an HTML element.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The new value of the **innerText** property.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The **IUnknown** pointer of an HTML element.  
  
##  \<a name="cdhtmldialog__setexternaldispatch">\</a>  CDHtmlDialog::SetExternalDispatch  
 Sets the host's <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 *pdispExternal*  
 The new <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> interface.  
  
##  \<a name="cdhtmldialog__sethostflags">\</a>  CDHtmlDialog::SetHostFlags  
 Sets the host UI flags.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 For possible values, see                                 [DOCHOSTUIFLAG](https://msdn.microsoft.com/en-us/library/aa753277.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__showcontextmenu">\</a>  CDHtmlDialog::ShowContextMenu  
 Called when a context menu is about to be displayed.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> in **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> in **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> in **IDocHostUIHandler::ShowContextMenu** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **S_FALSE**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::ShowContextMenu](https://msdn.microsoft.com/en-us/library/aa753264.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__showui">\</a>  CDHtmlDialog::ShowUI  
 Shows the host's UI.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::ShowUI](https://msdn.microsoft.com/en-us/library/aa753265.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 See                                 *d pActiveObject* in **IDocHostUIHandler::ShowUI** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> in **IDocHostUIHandler::ShowUI** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> in **IDocHostUIHandler::ShowUI** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> in **IDocHostUIHandler::ShowUI** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **S_FALSE**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::ShowUI](https://msdn.microsoft.com/en-us/library/aa753265.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__translateaccelerator">\</a>  CDHtmlDialog::TranslateAccelerator  
 Called to process menu accelerator-key messages.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::TranslateAccelerator](https://msdn.microsoft.com/en-us/library/aa753266.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> in **IDocHostUIHandler::TranslateAccelerator** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> in **IDocHostUIHandler::TranslateAccelerator** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **S_FALSE**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::TranslateAccelerator](https://msdn.microsoft.com/en-us/library/aa753266.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__translateurl">\</a>  CDHtmlDialog::TranslateUrl  
 Called to modify the URL to be loaded.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> in                                 [IDocHostUIHandler::TranslateUrl](https://msdn.microsoft.com/en-us/library/aa753267.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> in **IDocHostUIHandler::TranslateUrl** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 See <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> in **IDocHostUIHandler::TranslateUrl** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Returns **S_FALSE**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::TranslateUrl](https://msdn.microsoft.com/en-us/library/aa753267.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdhtmldialog__updateui">\</a>  CDHtmlDialog::UpdateUI  
 Called to notify the host that the command state has changed.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 Returns **E_NOTIMPL**.  
  
### Remarks  
 This member function is CDHtmlDialog's implementation of                         [IDocHostUIHandler::UpdateUI](https://msdn.microsoft.com/en-us/library/aa753268.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [MFC Sample DHtmlExplore](../vs140/visual-c---samples.md)   
 [DDX_DHtml Helper Macros](#ddx_dhtml_helper_macros)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)