---
title: "CWnd::GetForegroundWindow"
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
  - "GetForegroundWindow"
  - "CWnd::GetForegroundWindow"
  - "CWnd.GetForegroundWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetForegroundWindow method"
ms.assetid: 86b91e20-d7e9-4b8a-9dfc-743966c08caf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetForegroundWindow
Returns a pointer to the foreground window (the window with which the user is currently working).  
  
## Syntax  
  
```  
  
static CWnd* PASCAL GetForegroundWindow( );  
```  
  
## Return Value  
 A pointer to the foreground window. This may be a temporary `CWnd` object.  
  
## Remarks  
 The foreground window applies only to top-level windows (frame windows or dialog boxes).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetForegroundWindow](../vs140/cwnd--setforegroundwindow.md)