---
title: "CWnd::SubclassDlgItem"
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
  - "CWnd.SubclassDlgItem"
  - "CWnd::SubclassDlgItem"
  - "SubclassDlgItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "subclassing dialog items"
  - "subclassing"
  - "SubclassDlgItem method"
  - "subclassing dialog box controls"
  - "dialog box functions"
  - "dialog box controls, subclassing"
  - "subclassing, dialog box controls"
ms.assetid: 5a7564b9-310e-472a-8b6e-4e2f22d49b22
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::SubclassDlgItem
Call this member function to "dynamically subclass" a control created from a dialog template and attach it to this `CWnd` object.  
  
## Syntax  
  
```  
  
      BOOL SubclassDlgItem(  
   UINT nID,  
   CWnd* pParent   
);  
```  
  
#### Parameters  
 `nID`  
 The control's ID.  
  
 `pParent`  
 The control's parent (usually a dialog box).  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 When a control is dynamically subclassed, windows messages will route through the `CWnd`'s message map and call message handlers in the `CWnd`'s class first. Messages that are passed to the base class will be passed to the default message handler in the control.  
  
 This member function attaches the Windows control to a `CWnd` object and replaces the control's **WndProc** and **AfxWndProc** functions. The function stores the old **WndProc** in the location returned by the `GetSuperWndProcAddr` member function.  
  
## Example  
 [!code[NVC_MFCWindowing#122](../vs140/codesnippet/CPP/cwnd--subclassdlgitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md)   
 [CWnd::SubclassWindow](../vs140/cwnd--subclasswindow.md)   
 [CWnd::Attach](../vs140/cwnd--attach.md)