---
title: "CWnd::SubclassWindow"
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
  - CWnd::SubclassWindow
  - CWnd.SubclassWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - windows [C++], subclassing
  - SubclassWindow method
  - subclassing windows
ms.assetid: f781f399-51af-4bf9-88bd-efe5cdaae344
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::SubclassWindow
Call this member function to "dynamically subclass" a window and attach it to this `CWnd` object.  
  
## Syntax  
  
```  
  
      BOOL SubclassWindow(  
   HWND hWnd   
);  
```  
  
#### Parameters  
 `hWnd`  
 A handle to the window.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 When a window is dynamically subclassed, windows messages will route through the `CWnd`'s message map and call message handlers in the `CWnd`'s class first. Messages that are passed to the base class will be passed to the default message handler in the window.  
  
 This member function attaches the Windows control to a `CWnd` object and replaces the window's **WndProc** and **AfxWndProc** functions. The function stores a pointer to the old **WndProc** in the `CWnd` object.  
  
> [!NOTE]
>  The window must not already be attached to an MFC object when this function is called.  
  
## Example  
 [!code[NVC_MFCWindowing#123](../vs140/codesnippet/CPP/cwnd--subclasswindow_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md)   
 [CWnd::SubclassDlgItem](../vs140/cwnd--subclassdlgitem.md)   
 [CWnd::Attach](../vs140/cwnd--attach.md)   
 [CWnd::PreSubclassWindow](../vs140/cwnd--presubclasswindow.md)   
 [CWnd::UnsubclassWindow](../vs140/cwnd--unsubclasswindow.md)