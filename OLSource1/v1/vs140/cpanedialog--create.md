---
title: "CPaneDialog::Create"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - Create
  - CPaneDialog::Create
  - CPaneDialog.Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: bd7499e3-4273-4705-8bca-719b512c668a
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPaneDialog::Create
Creates a docking dialog box and attaches it to a `CPaneDialog` object.  
  
## Syntax  
  
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
  
#### Parameters  
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
 The style of the tabbed window that results when the user drags another control pane onto the caption of this control pane. The default value is `AFX_CBRS_REGULAR_TABS`. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane--createex.md) method.  
  
 [in] `dwControlBarStyle`  
 Additional style attributes. The default value is `AFX_DEFAULT_DOCKING_PANE_STYLE`. For more information, see the Remarks section of the [CBasePane::CreateEx](../vs140/cbasepane--createex.md) method.  
  
## Return Value  
 `TRUE` if this method succeeds; otherwise, `FALSE`.  
  
## Remarks  
  
## Example  
 The following example demonstrates how to use the `Create` method in the `CPaneDialog` class. This example is part of the [Set Pane Size sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_SetPaneSize#2](../vs140/codesnippet/CPP/cpanedialog--create_1.h)]
  
[!code[NVC_MFC_SetPaneSize#3](../vs140/codesnippet/CPP/cpanedialog--create_2.cpp)]
  
  
## Requirements  
 **Header:** afxpanedialog.h  
  
## See Also  
 [CPaneDialog Class](../vs140/cpanedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)