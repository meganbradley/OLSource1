---
title: "CPaneDialog Class"
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
  - "CPaneDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPaneDialog::OnLButtonDblClk method"
  - "CPaneDialog::OnLButtonDown method"
  - "CPaneDialog::CreateObject method"
  - "CPaneDialog::OnUpdateCmdUI method"
  - "CPaneDialog constructor"
  - "CPaneDialog::OnEraseBkgnd method"
  - "CPaneDialog class"
  - "CPaneDialog::OnWindowPosChanging method"
ms.assetid: 48a6bb91-4b92-40f5-8907-b3270b146cf6
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneDialog Class
The `CPaneDialog` class supports a modeless, dockable dialog box.  
  
## Syntax  
  
```  
class CPaneDialog : public CDockablePane  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|`CPaneDialog::CPaneDialog`|Default constructor.|  
|`CPaneDialog::~CPaneDialog`|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneDialog::Create](#cpanedialog__create)|Creates a dockable dialog box and attaches it to a `CPaneDialog` object.|  
|`CPaneDialog::CreateObject`|Used by the framework to create a dynamic instance of this class type.|  
|`CPaneDialog::GetThisClass`|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CPaneDialog::HandleInitDialog](#cpanedialog__handleinitdialog)|Handles the                                         [WM_INITDIALOG](http://msdn.microsoft.com/library/windows/desktop/ms645428) message. (Redefines `CBasePane::HandleInitDialog`.)|  
|`CPaneDialog::OnEraseBkgnd`|Handles the                                         [WM_ERASEBKGND](http://msdn.microsoft.com/library/windows/desktop/ms648055) message. (Redefines [CWnd::OnEraseBkgnd](../vs140/cwnd-class.md#cwnd__onerasebkgnd).)|  
|`CPaneDialog::OnLButtonDblClk`|Handles the                                         [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606) message. (Redefines [CWnd::OnLButtonDblClk](../vs140/cwnd-class.md#cwnd__onlbuttondblclk).)|  
|`CPaneDialog::OnLButtonDown`|Handles the                                         [WM_LBUTTONDOWN](http://msdn.microsoft.com/library/windows/desktop/ms645607) message. (Redefines [CWnd::OnLButtonDown](../vs140/cwnd-class.md#cwnd__onlbuttondown).)|  
|`CPaneDialog::OnUpdateCmdUI`|Called by the framework to update the dialog box window. (Overrides [CDockablePane::OnUpdateCmdUI](assetId:///5dd61606-1c12-40d4-b024-f3839aa5e2e0).)|  
|`CPaneDialog::OnWindowPosChanging`|Handles the                                         [WM_WINDOWPOSCHANGING](http://msdn.microsoft.com/library/windows/desktop/ms632653) message. (Redefines [CWnd::OnWindowPosChanging](../vs140/cwnd-class.md#cwnd__onwindowposchanging).)|  
|[CPaneDialog::SetOccDialogInfo](#cpanedialog__setoccdialoginfo)|Specifies the template for a dialog box that is an OLE control container.|  
  
## Remarks  
 Construct a `CPaneDialog` object in two steps. First, construct the object in your code. Second, call [Create](#cpanedialog__create). You must specify a valid resource template name or template ID and pass a pointer to the parent window. Otherwise, the creation process fails. The dialog box must specify the WS_CHILD and WS_VISIBLE style. We recommend that you also specify the WS_CLIPCHILDREN and WS_CLIPSIBLINGS styles. For more information, see [Window Styles](../vs140/window-styles.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CPane](../vs140/cpane-class.md)  
  
 [CDockablePane](../vs140/cdockablepane-class.md)  
  
 [CPaneDialog](../vs140/cpanedialog-class.md)  
  
## Requirements  
 **Header:** afxpanedialog.h  
  
##  <a name="cpanedialog__create"></a>  CPaneDialog::Create  
 Creates a docking dialog box and attaches it to a `CPaneDialog` object.  
  
```  
BOOL Create(  
   LPCTSTR lpszWindowName,  
   CWnd* pParentWnd,  
   BOOL bHasGripper,  
   LPCTSTR lpszTemplateName,  
   UINT nStyle,  
   UINT nID,  
   DWORD dwTabbedStyle= AFX_CBRS_REGULAR_TABS,  
   DWORD dwControlBarStyle=AFX_DEFAULT_DOCKING_PANE_STYLE  
);  
BOOL Create(  
   LPCTSTR lpszWindowName,  
   CWnd* pParentWnd,  
   BOOL bHasGripper,  
   UINT nIDTemplate,  
   UINT nStyle,  
   UINT nID   
);  
BOOL Create(  
   CWnd* pParentWnd,  
   LPCTSTR lpszTemplateName,  
   UINT nStyle,  
   UINT nID   
);  
BOOL Create(  
   CWnd* pParentWnd,  
   UINT nIDTemplate,  
   UINT nStyle,  
   UINT nID   
);  
```  
  
### Parameters  
 [in] `lpszWindowName`  
 The name of the docking dialog box.  
  
 [in] `pParentWnd`  
 Points to the parent window.  
  
 [in] `bHasGripper`  
 `TRUE` to create the docking dialog box with a caption (gripper); otherwise, `FALSE`.  
  
 [in] `lpszTemplateName`  
 The name of the resource dialog template.  
  
 [in] `nStyle`  
 The Windows style.  
  
 [in] `nID`  
 The control ID.  
  
 [in] `nIDTemplate`  
 The resource ID of the dialog template.  
  
 [in] `dwTabbedStyle`  
 The style of the tabbed window that results when the user drags another control pane onto the caption of this control pane. The default value is `AFX_CBRS_REGULAR_TABS`. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex) method.  
  
 [in] `dwControlBarStyle`  
 Additional style attributes. The default value is `AFX_DEFAULT_DOCKING_PANE_STYLE`. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex) method.  
  
### Return Value  
 `TRUE` if this method succeeds; otherwise, `FALSE`.  
  
### Remarks  
  
### Example  
 The following example demonstrates how to use the `Create` method in the `CPaneDialog` class. This example is part of the [Set Pane Size sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_SetPaneSize#2](../vs140/codesnippet/CPP/cpanedialog-class_1.h)]  
[!code[NVC_MFC_SetPaneSize#3](../vs140/codesnippet/CPP/cpanedialog-class_2.cpp)]  
  
##  <a name="cpanedialog__handleinitdialog"></a>  CPaneDialog::HandleInitDialog  
 Handles the                 [WM_INITDIALOG](http://msdn.microsoft.com/library/windows/desktop/ms645428) message.  
  
```  
afx_msg LRESULT HandleInitDialog(  
    WPARAM wParam,  
    LPARAM lParam  
);  
```  
  
### Parameters  
 [in] `wParam`  
 Handle to the control that is to receive the default keyboard focus.  
  
 [in] `lParam`  
 Specifies additional initialization data.  
  
### Return Value  
 `TRUE` if this method is successful; otherwise, `FALSE`. In addition, `TRUE` sets the keyboard focus to the control specified by the `wParam` parameter; `FALSE` prevents setting the default keyboard focus.  
  
### Remarks  
 The framework uses this method to initialize controls and the appearance of a dialog box. The framework calls this method before it displays the dialog box.  
  
##  <a name="cpanedialog__setoccdialoginfo"></a>  CPaneDialog::SetOccDialogInfo  
 Specifies the template for a dialog box that is an OLE control container.  
  
```  
virtual BOOL SetOccDialogInfo(  
   _AFX_OCC_DIALOG_INFO* pOccDialogInfo  
);  
```  
  
### Parameters  
 [in] `pOccDialogInfo`  
 Pointer to a dialog box template that is used to create the dialog box object. The value of this parameter is subsequently passed into the [COccManager::CreateDlgControls](../vs140/coccmanager-class.md#coccmanager__createdlgcontrols) method.  
  
### Return Value  
 Always `TRUE`.  
  
### Remarks  
 This method supports the [COccManager](../vs140/coccmanager-class.md) class, which manages OLE control sites and ActiveX controls. The _AFX_OCC_DIALOG_INFO structure is defined in the afxocc.h header file.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CDockablePane](../vs140/cdockablepane-class.md)   
 [Window Styles](../vs140/window-styles.md)