---
title: "CWnd::GetDesktopWindow"
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
  - CWnd.GetDesktopWindow
  - CWnd::GetDesktopWindow
  - GetDesktopWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDesktopWindow method
ms.assetid: 796d6194-95c2-450a-997a-c510d900eba5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetDesktopWindow
Returns the Windows desktop window.  
  
## Syntax  
  
```  
  
static CWnd* PASCAL GetDesktopWindow( );  
```  
  
## Return Value  
 Identifies the Windows desktop window. This pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 The desktop window covers the entire screen and is the area on top of which all icons and other windows are painted.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetFocus](../vs140/cwnd--getfocus.md)   
 [GetDesktopWindow](http://msdn.microsoft.com/library/windows/desktop/ms633504)