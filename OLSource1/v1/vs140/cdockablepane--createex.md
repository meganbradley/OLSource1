---
title: "CDockablePane::CreateEx"
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
  - "CreateEx"
  - "CDockablePane::CreateEx"
  - "CDockablePane.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 2e511728-4a2f-490d-a9ac-409f7ecbe4dc
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CreateEx
Creates the Windows control and attaches it to the [CDockablePane](../vs140/cdockablepane-class.md) object.  
  
## Syntax  
  
```  
virtual BOOL CreateEx(  
    DWORD dwStyleEx,  
    LPCTSTR lpszCaption,  
    CWnd* pParentWnd,  
    const RECT& rect,  
    BOOL bHasGripper,  
    UINT nID,  
    DWORD dwStyle,  
    DWORD dwTabbedStyle = AFX_CBRS_REGULAR_TABS,  
    DWORD dwControlBarStyle = AFX_DEFAULT_DOCKING_PANE_STYLE,  
    CCreateContext* pContext = NULL  
);  
```  
  
#### Parameters  
 [in] `dwStyleEx`  
 Specifies the extended style attributes for the new window.  
  
 [in] `lpszCaption`  
 Specifies the window name.  
  
 [in] [out] `pParentWnd`  
 Specifies the parent window.  
  
 [in] `rect`  
 Specifies the size and position of the window, in client coordinates of `pParentWnd`.  
  
 [in] `bHasGripper`  
 `TRUE` to create the pane with a caption; otherwise, `FALSE`.  
  
 [in] `nID`  
 Specifies the ID of the child window. This value must be unique if you want to save the docking state for this docking pane.  
  
 [in] `dwStyle`  
 Specifies the window style attributes.  
  
 [in] `dwTabbedStyle`  
 Specifies the tabbed style of a tabbed window that is created when the user drags a pane on the caption of this pane.  
  
 [in] `dwControlBarStyle`  
 Specifies the additional style attributes.  
  
 [in] [out] `pContext`  
 Specifies the create context of the window.  
  
## Return Value  
 `TRUE` if the dockable pane is successfully created; otherwise, `FALSE`.  
  
## Remarks  
 Creates a Windows pane and attaches it to the `CDockablePane` object.  
  
 If the `dwStyle` window style has the `CBRS_FLOAT_MULTI` flag, the miniframe window can float with other panes in the miniframe window. By default, docking panes can only float individually.  
  
 If the `dwTabbedStyle` parameter has the `AFX_CBRS_OUTLOOK_TABS` flag specified, the pane creates Outlook-style tabbed panes when another pane is attached to this pane using the [CDockablePane::AttachToTabWnd](../vs140/cdockablepane--attachtotabwnd.md) method. By default, dockable panes create regular tabbed panes of type [CTabbedPane](../vs140/ctabbedpane-class.md).  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)