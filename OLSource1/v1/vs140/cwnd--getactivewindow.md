---
title: "CWnd::GetActiveWindow"
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
  - "CWnd::GetActiveWindow"
  - "GetActiveWindow"
  - "CWnd.GetActiveWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveWindow method"
ms.assetid: 4117f01b-1cc2-497e-b66a-d4f9e22c9c60
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetActiveWindow
Retrieves a pointer to the active window.  
  
## Syntax  
  
```  
  
static CWnd* PASCAL GetActiveWindow( );  
```  
  
## Return Value  
 The active window or **NULL** if no window was active at the time of the call. The pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 The active window is either the window that has the current input focus or the window explicitly made active by the [SetActiveWindow](../vs140/cwnd--setactivewindow.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetActiveWindow](../vs140/cwnd--setactivewindow.md)   
 [GetActiveWindow](http://msdn.microsoft.com/library/windows/desktop/ms646292)