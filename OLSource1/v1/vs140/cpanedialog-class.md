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
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class supports a modeless, dockable dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPaneDialog::Create](#cpanedialog__create)|Creates a dockable dialog box and attaches it to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CPaneDialog::HandleInitDialog](#cpanedialog__handleinitdialog)|Handles the                                         [WM_INITDIALOG](http://msdn.microsoft.com/library/windows/desktop/ms645428) message. (Redefines <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.)|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Handles the                                         [WM_ERASEBKGND](http://msdn.microsoft.com/library/windows/desktop/ms648055) message. (Redefines [CWnd::OnEraseBkgnd](../vs140/cwnd-class.md#cwnd__onerasebkgnd).)|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Handles the                                         [WM_LBUTTONDBLCLK](http://msdn.microsoft.com/library/windows/desktop/ms645606) message. (Redefines [CWnd::OnLButtonDblClk](../vs140/cwnd-class.md#cwnd__onlbuttondblclk).)|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Handles the                                         [WM_LBUTTONDOWN](http://msdn.microsoft.com/library/windows/desktop/ms645607) message. (Redefines [CWnd::OnLButtonDown](../vs140/cwnd-class.md#cwnd__onlbuttondown).)|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Called by the framework to update the dialog box window. (Overrides [CDockablePane::OnUpdateCmdUI](assetId:///5dd61606-1c12-40d4-b024-f3839aa5e2e0).)|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Handles the                                         [WM_WINDOWPOSCHANGING](http://msdn.microsoft.com/library/windows/desktop/ms632653) message. (Redefines [CWnd::OnWindowPosChanging](../vs140/cwnd-class.md#cwnd__onwindowposchanging).)|  
|[CPaneDialog::SetOccDialogInfo](#cpanedialog__setoccdialoginfo)|Specifies the template for a dialog box that is an OLE control container.|  
  
## Remarks  
 Construct a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object in two steps. First, construct the object in your code. Second, call [Create](#cpanedialog__create). You must specify a valid resource template name or template ID and pass a pointer to the parent window. Otherwise, the creation process fails. The dialog box must specify the WS_CHILD and WS_VISIBLE style. We recommend that you also specify the WS_CLIPCHILDREN and WS_CLIPSIBLINGS styles. For more information, see [Window Styles](../vs140/window-styles.md).  
  
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
  
##  \<a name="cpanedialog__create">\</a>  CPaneDialog::Create  
 Creates a docking dialog box and attaches it to a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The name of the docking dialog box.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Points to the parent window.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to create the docking dialog box with a caption (gripper); otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The name of the resource dialog template.  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The Windows style.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The control ID.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The resource ID of the dialog template.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The style of the tabbed window that results when the user drags another control pane onto the caption of this control pane. The default value is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex) method.  
  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Additional style attributes. The default value is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane-class.md#cbasepane__createex) method.  
  
### Return Value  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if this method succeeds; otherwise, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
### Remarks  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class. This example is part of the [Set Pane Size sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_SetPaneSize#2](../vs140/codesnippet/CPP/cpanedialog-class_1.h)]  
[!code[NVC_MFC_SetPaneSize#3](../vs140/codesnippet/CPP/cpanedialog-class_2.cpp)]  
  
##  \<a name="cpanedialog__handleinitdialog">\</a>  CPaneDialog::HandleInitDialog  
 Handles the                 [WM_INITDIALOG](http://msdn.microsoft.com/library/windows/desktop/ms645428) message.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Handle to the control that is to receive the default keyboard focus.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies additional initialization data.  
  
### Return Value  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. In addition, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> sets the keyboard focus to the control specified by the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter; <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> prevents setting the default keyboard focus.  
  
### Remarks  
 The framework uses this method to initialize controls and the appearance of a dialog box. The framework calls this method before it displays the dialog box.  
  
##  \<a name="cpanedialog__setoccdialoginfo">\</a>  CPaneDialog::SetOccDialogInfo  
 Specifies the template for a dialog box that is an OLE control container.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Pointer to a dialog box template that is used to create the dialog box object. The value of this parameter is subsequently passed into the [COccManager::CreateDlgControls](../vs140/coccmanager-class.md#coccmanager__createdlgcontrols) method.  
  
### Return Value  
 Always <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method supports the [COccManager](../vs140/coccmanager-class.md) class, which manages OLE control sites and ActiveX controls. The _AFX_OCC_DIALOG_INFO structure is defined in the afxocc.h header file.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CDockablePane](../vs140/cdockablepane-class.md)   
 [Window Styles](../vs140/window-styles.md)