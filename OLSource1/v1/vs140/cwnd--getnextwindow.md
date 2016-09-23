---
title: "CWnd::GetNextWindow"
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
  - GetNextWindow
  - CWnd::GetNextWindow
  - CWnd.GetNextWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetNextWindow method
ms.assetid: 2305b783-7ac4-4ea3-a476-d13f00f1afd1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetNextWindow
Searches for the next (or previous) window in the window manager's list.  
  
## Syntax  
  
```  
  
      CWnd* GetNextWindow(  
   UINT nFlag = GW_HWNDNEXT   
) const;  
```  
  
#### Parameters  
 `nFlag`  
 Specifies whether the function returns a pointer to the next window or the previous window. It can be either **GW_HWNDNEXT**, which returns the window that follows the `CWnd` object on the window manager's list, or **GW_HWNDPREV**, which returns the previous window on the window manager's list.  
  
## Return Value  
 Identifies the next (or the previous) window in the window manager's list if the member function is successful.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 The window manager's list contains entries for all top-level windows, their associated child windows, and the child windows of any child windows.  
  
 If `CWnd` is a top-level window, the function searches for the next (or previous) top-level window; if `CWnd` is a child window, the function searches for the next (or previous) child window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetNextWindow](http://msdn.microsoft.com/library/windows/desktop/ms633509)