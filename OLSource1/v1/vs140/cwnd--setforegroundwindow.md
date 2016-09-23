---
title: "CWnd::SetForegroundWindow"
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
  - SetForegroundWindow
  - CWnd.SetForegroundWindow
  - CWnd::SetForegroundWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - foreground window
  - top-level window
  - SetForegroundWindow method
  - windows [C++], on top
  - top frame window
  - top dialog
ms.assetid: b757011a-4508-4b69-a44a-91b240b837a7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::SetForegroundWindow
Puts the thread that created the window into the foreground and activates the window.  
  
## Syntax  
  
```  
  
BOOL SetForegroundWindow(  );  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 Keyboard input is directed to the window, and various visual cues are changed for the user. The foreground window is the window with which the user is currently working. The foreground window applies only to top-level windows (frame windows or dialogs boxes).  
  
## Example  
 See the example for [CWnd::FindWindow](../vs140/cwnd--findwindow.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetForegroundWindow](../vs140/cwnd--getforegroundwindow.md)