---
title: "COleControlContainer Class"
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
  - "COleControlContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "custom controls [MFC], sites"
  - "COleControlContainer class"
  - "ActiveX control containers [C++], control site"
ms.assetid: f7ce9246-0fb7-4f07-a83a-6c2390d0fdf8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer Class
Acts as a control container for ActiveX controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleControlContainer::COleControlContainer](#colecontrolcontainer__colecontrolcontainer)|Constructs a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleControlContainer::AttachControlSite](#colecontrolcontainer__attachcontrolsite)|Creates a control site, hosted by the container.|  
|[COleControlContainer::BroadcastAmbientPropertyChange](#colecontrolcontainer__broadcastambientpropertychange)|Informs all hosted controls that an ambient property has changed.|  
|[COleControlContainer::CheckDlgButton](#colecontrolcontainer__checkdlgbutton)|Modifies the specified button control.|  
|[COleControlContainer::CheckRadioButton](#colecontrolcontainer__checkradiobutton)|Selects the specified radio button of a group.|  
|[COleControlContainer::CreateControl](#colecontrolcontainer__createcontrol)|Creates a hosted ActiveX control.|  
|[COleControlContainer::CreateOleFont](#colecontrolcontainer__createolefont)|Creates an OLE font.|  
|[COleControlContainer::FindItem](#colecontrolcontainer__finditem)|Returns the custom site of the specified control.|  
|[COleControlContainer::FreezeAllEvents](#colecontrolcontainer__freezeallevents)|Determines if the control site is accepting events.|  
|[COleControlContainer::GetAmbientProp](#colecontrolcontainer__getambientprop)|Retrieves the specified ambient property.|  
|[COleControlContainer::GetDlgItem](#colecontrolcontainer__getdlgitem)|Retrieves the specified dialog control.|  
|[COleControlContainer::GetDlgItemInt](#colecontrolcontainer__getdlgitemint)|Retrieves the value of the specified dialog control.|  
|[COleControlContainer::GetDlgItemText](#colecontrolcontainer__getdlgitemtext)|Retrieves the caption of the specified dialog control.|  
|[COleControlContainer::HandleSetFocus](#colecontrolcontainer__handlesetfocus)|Determines if the container handles <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> messages.|  
|[COleControlContainer::HandleWindowlessMessage](#colecontrolcontainer__handlewindowlessmessage)|Handles messages sent to a windowless control.|  
|[COleControlContainer::IsDlgButtonChecked](#colecontrolcontainer__isdlgbuttonchecked)|Determines the state of the specified button.|  
|[COleControlContainer::OnPaint](#colecontrolcontainer__onpaint)|Called to repaint a portion of the container.|  
|[COleControlContainer::OnUIActivate](#colecontrolcontainer__onuiactivate)|Called when a control is about to be in-place activated.|  
|[COleControlContainer::OnUIDeactivate](#colecontrolcontainer__onuideactivate)|Called when a control is about to be deactivated.|  
|[COleControlContainer::ScrollChildren](#colecontrolcontainer__scrollchildren)|Called by the framework when scroll messages are received from a child window.|  
|[COleControlContainer::SendDlgItemMessage](#colecontrolcontainer__senddlgitemmessage)|Sends a message to the specified control.|  
|[COleControlContainer::SetDlgItemInt](#colecontrolcontainer__setdlgitemint)|Sets the value of the specified control.|  
|[COleControlContainer::SetDlgItemText](#colecontrolcontainer__setdlgitemtext)|Sets the text of the specified control.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleControlContainer::m_crBack](#colecontrolcontainer__m_crback)|The background color of the container.|  
|[COleControlContainer::m_crFore](#colecontrolcontainer__m_crfore)|The foreground color of the container.|  
|[COleControlContainer::m_listSitesOrWnds](#colecontrolcontainer__m_listsitesorwnds)|A list of the supported control sites.|  
|[COleControlContainer::m_nWindowlessControls](#colecontrolcontainer__m_nwindowlesscontrols)|The number of hosted windowless controls.|  
|[COleControlContainer::m_pOleFont](#colecontrolcontainer__m_polefont)|A pointer to the OLE font of the custom control site.|  
|[COleControlContainer::m_pSiteCapture](#colecontrolcontainer__m_psitecapture)|Pointer to the capture control site.|  
|[COleControlContainer::m_pSiteFocus](#colecontrolcontainer__m_psitefocus)|Pointer to the control that currently has input focus.|  
|[COleControlContainer::m_pSiteUIActive](#colecontrolcontainer__m_psiteuiactive)|Pointer to the control that is currently in-place activated.|  
|[COleControlContainer::m_pWnd](#colecontrolcontainer__m_pwnd)|Pointer to the window implementing the control container.|  
|[COleControlContainer::m_siteMap](#colecontrolcontainer__m_sitemap)|The site map.|  
  
## Remarks  
 This is done by providing support for one or more ActiveX control sites (implemented by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>). <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> fully implements the                 [IOleInPlaceFrame](http://msdn.microsoft.com/library/windows/desktop/ms692770) and                 [IOleContainer](http://msdn.microsoft.com/library/windows/desktop/ms690103) interfaces, allowing the contained ActiveX controls to fulfill their qualifications as in-place items.  
  
 Commonly, this class is used in conjunction with <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to implement a custom ActiveX control container, with custom sites for one or more ActiveX controls.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxocc.h  
  
##  \<a name="colecontrolcontainer__attachcontrolsite">\</a>  COleControlContainer::AttachControlSite  
 Called by the framework to create and attach a control site.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The ID of the control to be attached.  
  
### Remarks  
 Override this function if you want to customize this process.  
  
> [!NOTE]
>  Use the first form of this function if you are statically linking to the MFC library. Use the second form if you are dynamically linking to the MFC library.  
  
##  \<a name="colecontrolcontainer__broadcastambientpropertychange">\</a>  COleControlContainer::BroadcastAmbientPropertyChange  
 Informs all hosted controls that an ambient property has changed.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The dispatch ID of the ambient property being changed.  
  
### Remarks  
 This function is called by the framework when an ambient property has changed value. Override this function to customize this behavior.  
  
##  \<a name="colecontrolcontainer__checkdlgbutton">\</a>  COleControlContainer::CheckDlgButton  
 Modifies the current state of the button.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The ID of the button to be modified.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the state of the button. Can be one of the following:  
  
-   **BST_CHECKED** Sets the button state to checked.  
  
-   **BST_INDETERMINATE** Sets the button state to grayed, indicating an indeterminate state. Use this value only if the button has the **BS_3STATE** or **BS_AUTO3STATE** style.  
  
-   **BST_UNCHECKED** Sets the button state to cleared.  
  
##  \<a name="colecontrolcontainer__checkradiobutton">\</a>  COleControlContainer::CheckRadioButton  
 Selects a specified radio button in a group and clears the remaining buttons in the group.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies the identifier of the first radio button in the group.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Specifies the identifier of the last radio button in the group.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies the identifier of the radio button to be checked.  
  
##  \<a name="colecontrolcontainer__colecontrolcontainer">\</a>  COleControlContainer::COleControlContainer  
 Constructs a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A pointer to the parent window of the control container.  
  
### Remarks  
 Once the object has been successfully created, add a custom control site with a call to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="colecontrolcontainer__createcontrol">\</a>  COleControlContainer::CreateControl  
 Creates an ActiveX control, hosted by the specified <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A pointer to the window object representing the control.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The unique class ID of the control.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A pointer to the text to be displayed in the control. Sets the value of the control's Caption or Text property (if any). If **NULL**, the control's Caption or Text property is not changed.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Windows styles. The available styles are listed under the **Remarks** section.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies the control's size and position. It can be either a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object or a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Specifies the control's child window ID.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> containing the persistent state for the control. The default value is **NULL**, indicating that the control initializes itself without restoring its state from any persistent storage. If not **NULL**, it should be a pointer to a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>-derived object that contains the control's persistent data, in the form of either a stream or a storage. This data could have been saved in a previous activation of the client. The <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> can contain other data, but must have its read-write pointer set to the first byte of persistent data at the time of the call to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Indicates whether the data in <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> should be interpreted as <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> data. If the data in <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is a storage, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> should be **TRUE**. If the data in <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is a stream, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> should be **FALSE**. The default value is **FALSE**.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Optional license key data. This data is needed only for creating controls that require a run-time license key. If the control supports licensing, you must provide a license key for the creation of the control to succeed. The default value is **NULL**.  
  
 *ppNewSite*  
 A pointer to the existing control site that will host the control being created. The default value is **NULL**, indicating that a new control site will be automatically created and attached to the new control.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A pointer to a **POINT** structure that contains the upper-left corner of the control. The size of the control is determined by the value of                                 *psize*. The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and                                 *psize* values are an optional method of specifying the size and position of the control.  
  
 *psize*  
 A pointer to a **SIZE** structure that contains the size of the control. The upper-left corner is determined by the value of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> and                                 *psize* values are an optional method of specifying the size and position of the control.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Only a subset of the Windows <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> flags are supported by <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>:  
  
-   **WS_VISIBLE** Creates a window that is initially visible. Required if you want the control to be visible immediately, like ordinary windows.  
  
-   **WS_DISABLED** Creates a window that is initially disabled. A disabled window cannot receive input from the user. Can be set if the control has an Enabled property.  
  
-   <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> Creates a window with a thin-line border. Can be set if control has a BorderStyle property.  
  
-   **WS_GROUP** Specifies the first control of a group of controls. The user can change the keyboard focus from one control in the group to the next by using the direction keys. All controls defined with the **WS_GROUP** style after the first control belong to the same group. The next control with the **WS_GROUP** style ends the group and starts the next group.  
  
-   **WS_TABSTOP** Specifies a control that can receive the keyboard focus when the user presses the TAB key. Pressing the TAB key changes the keyboard focus to the next control of the **WS_TABSTOP** style.  
  
 Use the second overload to create default-sized controls.  
  
##  \<a name="colecontrolcontainer__createolefont">\</a>  COleControlContainer::CreateOleFont  
 Creates an OLE font.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A pointer to the font to be used by the control container.  
  
##  \<a name="colecontrolcontainer__finditem">\</a>  COleControlContainer::FindItem  
 Finds the custom site that hosts the specified item.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The identifier of the item to be found.  
  
### Return Value  
 A pointer to the custom site of the specified item.  
  
##  \<a name="colecontrolcontainer__freezeallevents">\</a>  COleControlContainer::FreezeAllEvents  
 Determines if the container will ignore events from the attached control sites or accept them.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Nonzero if events will be processed; otherwise 0.  
  
### Remarks  
  
> [!NOTE]
>  The control is not required to stop firing events if requested by the control container. It can continue firing but all subsequent events will be ignored by the control container.  
  
##  \<a name="colecontrolcontainer__getambientprop">\</a>  COleControlContainer::GetAmbientProp  
 Retrieves the value of a specified ambient property.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A pointer to a control site from which the ambient property will be retrieved.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The dispatch ID of the desired ambient property.  
  
 *pVarResult*  
 A pointer to the value of the ambient property.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="colecontrolcontainer__getdlgitem">\</a>  COleControlContainer::GetDlgItem  
 Retrieves a pointer to the specified control or child window in a dialog box or other window.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Identifier of the dialog item to retrieve.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A pointer to the handle of the specified dialog item's window object.  
  
### Return Value  
 A pointer to the dialog item's window.  
  
##  \<a name="colecontrolcontainer__getdlgitemint">\</a>  COleControlContainer::GetDlgItemInt  
 Retrieves the value of the translated text of the given control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The identifier of the control.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 Pointer to a Boolean variable that receives a function success/failure value ( **TRUE** indicates success, **FALSE** indicates failure).  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Specifies whether the function should examine the text for a minus sign at the beginning and return a signed integer value if it finds one. If the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> parameter is **TRUE**, specifying that the value to be retrieved is a signed integer value, cast the return value to an <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> type. To get extended error information, call                                 [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Return Value  
 If successful, the variable pointed to by <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is set to **TRUE**, and the return value is the translated value of the control text.  
  
 If the function fails, the variable pointed to by <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is set to **FALSE**, and the return value is zero. Note that, since zero is a possible translated value, a return value of zero does not by itself indicate failure.  
  
 If <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is **NULL**, the function returns no information about success or failure.  
  
### Remarks  
 The function translates the retrieved text by stripping any extra spaces at the beginning of the text and then converting the decimal digits. The function stops translating when it reaches the end of the text or encounters a nonnumeric character.  
  
 This function returns zero if the translated value is greater than **INT_MAX** (for signed numbers) or **UINT_MAX** (for unsigned numbers).  
  
##  \<a name="colecontrolcontainer__getdlgitemtext">\</a>  COleControlContainer::GetDlgItemText  
 Retrieves the text of the given control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The identifier of the control.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Pointer to the text of the control.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 Specifies the maximum length, in characters, of the string to be copied to the buffer pointed to by <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>. If the length of the string exceeds the limit, the string is truncated.  
  
### Return Value  
 If the function succeeds, the return value specifies the number of characters copied to the buffer, not including the terminating null character.  
  
 If the function fails, the return value is zero. To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
##  \<a name="colecontrolcontainer__handlesetfocus">\</a>  COleControlContainer::HandleSetFocus  
 Determines if the container handles <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> messages.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the container handles <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> messages; otherwise zero.  
  
##  \<a name="colecontrolcontainer__handlewindowlessmessage">\</a>  COleControlContainer::HandleWindowlessMessage  
 Processes window messages for windowless controls.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The identifier for the window message, provided by Windows.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 Parameter of the message; provided by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 Parameter of the message; provided by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> parameter.  
  
 *plResult*  
 Windows result code. Specifies the result of the message processing and depends on the message sent.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 Override this function to customize the handling of windowless control messages.  
  
##  \<a name="colecontrolcontainer__isdlgbuttonchecked">\</a>  COleControlContainer::IsDlgButtonChecked  
 Determines the state of the specified button.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The identifier of the button control.  
  
### Return Value  
 The return value, from a button created with the **BS_AUTOCHECKBOX**, **BS_AUTORADIOBUTTON**, **BS_AUTO3STATE**, **BS_CHECKBOX**, **BS_RADIOBUTTON**, or **BS_3STATE** style. Can be one of the following:  
  
-   **BST_CHECKED** Button is checked.  
  
-   **BST_INDETERMINATE** Button is grayed, indicating an indeterminate state (applies only if the button has the **BS_3STATE** or **BS_AUTO3STATE** style).  
  
-   **BST_UNCHECKED** Button is cleared.  
  
### Remarks  
 If the button is a three-state control, the member function determines whether it is dimmed, checked, or neither.  
  
##  \<a name="colecontrolcontainer__m_crback">\</a>  COleControlContainer::m_crBack  
 The background color of the container.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_crfore">\</a>  COleControlContainer::m_crFore  
 The foreground color of the container.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_listsitesorwnds">\</a>  COleControlContainer::m_listSitesOrWnds  
 A list of the control sites hosted by the container.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_nwindowlesscontrols">\</a>  COleControlContainer::m_nWindowlessControls  
 The number of windowless controls hosted by the control container.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_polefont">\</a>  COleControlContainer::m_pOleFont  
 A pointer to the OLE font of the custom control site.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_psitecapture">\</a>  COleControlContainer::m_pSiteCapture  
 Pointer to the capture control site.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_psitefocus">\</a>  COleControlContainer::m_pSiteFocus  
 A pointer to the control site that currently has input focus.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_psiteuiactive">\</a>  COleControlContainer::m_pSiteUIActive  
 A pointer to the control site that is in-place activated.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_pwnd">\</a>  COleControlContainer::m_pWnd  
 A pointer to the window object associated with the container.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__m_sitemap">\</a>  COleControlContainer::m_siteMap  
 The site map.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="colecontrolcontainer__onpaint">\</a>  COleControlContainer::OnPaint  
 Called by the framework to handle <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> requests.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 A pointer to the device context used by the container.  
  
### Return Value  
 Nonzero if the message was handled; otherwise zero.  
  
### Remarks  
 Override this function to customize the painting process.  
  
##  \<a name="colecontrolcontainer__onuiactivate">\</a>  COleControlContainer::OnUIActivate  
 Called by the framework when the control site, pointed to by <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, is about to be activated in-place.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A pointer to the control site about to be in-place activated.  
  
### Remarks  
 In-place activation means that the container's main menu is replaced with an in-place composite menu.  
  
##  \<a name="colecontrolcontainer__onuideactivate">\</a>  COleControlContainer::OnUIDeactivate  
 Called by the framework when the control site, pointed to by <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, is about to be deactivated.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 A pointer to the control site about to be deactivated.  
  
### Remarks  
 When this notification is received, the container should reinstall its user interface and take focus.  
  
##  \<a name="colecontrolcontainer__scrollchildren">\</a>  COleControlContainer::ScrollChildren  
 Called by the framework when scroll messages are received from a child window.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The amount, in pixels, of scrolling along the x-axis.  
  
 *dy*  
 The amount, in pixels, of scrolling along the y-axis.  
  
##  \<a name="colecontrolcontainer__senddlgitemmessage">\</a>  COleControlContainer::SendDlgItemMessage  
 Sends a message to the specified control.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 Specifies the identifier of the control that receives the message.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Specifies the message to be sent.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 Specifies additional message-specific information.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 Specifies additional message-specific information.  
  
##  \<a name="colecontrolcontainer__setdlgitemint">\</a>  COleControlContainer::SetDlgItemInt  
 Sets the text of a control in a dialog box to the string representation of a specified integer value.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The identifier of the control.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The integer value to be displayed.  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 Specifies whether the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> parameter is signed or unsigned. If this parameter is **TRUE**, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> is signed. If this parameter is **TRUE** and <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> is less than zero, a minus sign is placed before the first digit in the string. If this parameter is **FALSE**, <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> is unsigned.  
  
##  \<a name="colecontrolcontainer__setdlgitemtext">\</a>  COleControlContainer::SetDlgItemText  
 Sets the text of the specified control, using the text contained in <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The identifier of the control.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Pointer to the text of the control.  
  
## See Also  
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite](../vs140/colecontrolsite-class.md)   
 [COccManager](../vs140/coccmanager-class.md)