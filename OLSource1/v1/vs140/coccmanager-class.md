---
title: "COccManager Class"
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
  - "COccManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "custom controls [MFC], sites"
  - "COccManager class"
  - "CNoTrackObject class"
  - "ActiveX control containers [C++], control site"
ms.assetid: 7d47aeed-d1ab-48e3-b4cf-d429718e370a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager Class
Manages various custom control sites; implemented by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COccManager::CreateContainer](#coccmanager__createcontainer)|Creates a **COleContainer** object.|  
|[COccManager::CreateDlgControls](#coccmanager__createdlgcontrols)|Creates ActiveX controls, hosted by the associated <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[COccManager::CreateSite](#coccmanager__createsite)|Creates a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[COccManager::GetDefBtnCode](#coccmanager__getdefbtncode)|Retrieves the code of the default button.|  
|[COccManager::IsDialogMessage](#coccmanager__isdialogmessage)|Determines the target of a dialog message.|  
|[COccManager::IsLabelControl](#coccmanager__islabelcontrol)|Determines if the specified control is a label control.|  
|[COccManager::IsMatchingMnemonic](#coccmanager__ismatchingmnemonic)|Determines if the current mnemonic matches the mnemonic of the specified control.|  
|[COccManager::OnEvent](#coccmanager__onevent)|Attempts to handle the specified event.|  
|[COccManager::PostCreateDialog](#coccmanager__postcreatedialog)|Frees resources allocated during dialog creation.|  
|[COccManager::PreCreateDialog](#coccmanager__precreatedialog)|Processes a dialog template for ActiveX controls.|  
|[COccManager::SetDefaultButton](#coccmanager__setdefaultbutton)|Toggles the default state of the specified control.|  
|[COccManager::SplitDialogTemplate](#coccmanager__splitdialogtemplate)|Separates any existing ActiveX controls from common controls in the specified dialog template.|  
  
## Remarks  
 The base class, **CNoTrackObject**, is an undocumented base class (located in AFXTLS.H). Designed for use by the MFC framework, classes derived from the **CNoTrackObject** class are exempt from memory leak detection. It is not recommended that you derive directly from **CNoTrackObject**.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxocc.h  
  
##  \<a name="coccmanager__createcontainer">\</a>  COccManager::CreateContainer  
 Called by the framework to create a control container.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A pointer to the window object associated with the custom site container.  
  
### Return Value  
 A pointer to the newly created container; otherwise **NULL**.  
  
### Remarks  
 For more information on creating custom sites, see [COleControlContainer::AttachControlSite](../vs140/colecontrolcontainer-class.md#colecontrolcontainer__attachcontrolsite).  
  
##  \<a name="coccmanager__createdlgcontrols">\</a>  COccManager::CreateDlgControls  
 Call this function to create ActiveX controls specified by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *pWndParent*  
 A pointer to the parent of the dialog object.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The name of the resource being created.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to the dialog template used to create the dialog object.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to a resource.  
  
### Return Value  
 Nonzero if the control was created successfully; otherwise zero.  
  
##  \<a name="coccmanager__createsite">\</a>  COccManager::CreateSite  
 Called by the framework to create a control site, hosted by the container pointed to by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A pointer to the control container hosting the new control site.  
  
### Return Value  
 A pointer to the newly created control site.  
  
### Remarks  
 Override this function to create a custom control site, using your [COleControlSite](../vs140/colecontrolsite-class.md)-derived class.  
  
 Each control container can host multiple sites. Create additional sites with multiple calls to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="coccmanager__getdefbtncode">\</a>  COccManager::GetDefBtnCode  
 Call this function to determine if the control is a default push button.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The window object containing the button control.  
  
### Return Value  
 One of the following values:  
  
-   **DLGC_DEFPUSHBUTTON** Control is the default button in the dialog.  
  
-   **DLGC_UNDEFPUSHBUTTON** Control is not the default button in the dialog.  
  
-   **0** Control is not a button.  
  
##  \<a name="coccmanager__isdialogmessage">\</a>  COccManager::IsDialogMessage  
 Called by the framework to determine whether a message is intended for the specified dialog box and, if it is, processes the message.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *pWndDlg*  
 A pointer to the intended target dialog of the message.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> structure that contains the message to be checked.  
  
### Return Value  
 Nonzero if the message is processed; otherwise zero.  
  
### Remarks  
 The default behavior of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is to check for keyboard messages and convert them into selections for the corresponding dialog box. For example, the TAB key, when pressed, selects the next control or group of controls.  
  
 Override this function to provide custom behavior for messages sent to the specified dialog.  
  
##  \<a name="coccmanager__islabelcontrol">\</a>  COccManager::IsLabelControl  
 Call this function to determine if the specified control is a label control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A pointer to the window containing the control.  
  
### Return Value  
 Nonzero if the control is a label; otherwise zero  
  
### Remarks  
 A label control is one that acts like a label for whatever control is next in the ordering.  
  
##  \<a name="coccmanager__ismatchingmnemonic">\</a>  COccManager::IsMatchingMnemonic  
 Call this function to determine if the current mnemonic matches that represented by the control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to the window containing the control.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A pointer to the message containing the mnemonic to match.  
  
### Return Value  
 Nonzero if the mnemonic matches the control; otherwise zero  
  
### Remarks  
  
##  \<a name="coccmanager__onevent">\</a>  COccManager::OnEvent  
 Called by the framework to handle the specified event.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *pCmdTarget*  
 A pointer to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object attempting to handle the event  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The resource ID of the control.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The event being handled.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 If not **NULL**, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> fills in the **pTarget** and **pmf** members of the **AFX_CMDHANDLERINFO** structure instead of dispatching the command. Typically, this parameter should be **NULL**.  
  
### Return Value  
 Nonzero if the event was handled, otherwise zero.  
  
### Remarks  
 Override this function to customize the default event-handling process.  
  
##  \<a name="coccmanager__precreatedialog">\</a>  COccManager::PreCreateDialog  
 Called by the framework to process a dialog template for ActiveX controls before creating the actual dialog box.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 An **_AFX_OCC_DIALOG_INFO** structure containing information on the dialog template and any ActiveX controls hosted by the dialog.  
  
 *pOrigTemplate*  
 A pointer to the dialog template to be used in creating the dialog box.  
  
### Return Value  
 A pointer to a dialog template structure used to create the dialog box.  
  
### Remarks  
 The default behavior makes a call to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, determining if there are any ActiveX controls present and then returns the resultant dialog template.  
  
 Override this function to customize the process of creating a dialog box hosting ActiveX controls.  
  
##  \<a name="coccmanager__postcreatedialog">\</a>  COccManager::PostCreateDialog  
 Called by the framework to free memory allocated for the dialog template.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 An **_AFX_OCC_DIALOG_INFO** structure containing information on the dialog template and any ActiveX controls hosted by the dialog.  
  
### Remarks  
 This memory was allocated by a call to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, and was used for any hosted ActiveX controls in the dialog box.  
  
 Override this function to customize the process of cleaning up any resources used by the dialog box object.  
  
##  \<a name="coccmanager__setdefaultbutton">\</a>  COccManager::SetDefaultButton  
 Call this function to set the control as the default button.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A pointer to the window containing the control.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Nonzero if the control should become the default button; otherwise zero.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
  
> [!NOTE]
>  The control must have the **OLEMISC_ACTSLIKEBUTTON** status bit set. For more information on **OLEMISC** flags, see the                             [OLEMISC](http://msdn.microsoft.com/library/windows/desktop/ms678497) topic in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coccmanager__splitdialogtemplate">\</a>  COccManager::SplitDialogTemplate  
 Called by the framework to split the ActiveX controls from common dialog controls.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to the dialog template to be examined.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A list of pointers to dialog box items that are ActiveX controls.  
  
### Return Value  
 A pointer to a dialog template structure containing only non-ActiveX controls. If no ActiveX controls are present, **NULL** is returned.  
  
### Remarks  
 If any ActiveX controls are found, the template is analyzed and a new template, containing only non-ActiveX controls, is created. Any ActiveX controls found during this process are added to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 If there are no ActiveX controls in the template, **NULL** is returned                        *.*  
  
> [!NOTE]
>  Memory allocated for the new template is freed in the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> function.  
  
 Override this function to customize this process.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite](../vs140/colecontrolsite-class.md)   
 [COleControlContainer](../vs140/colecontrolcontainer-class.md)