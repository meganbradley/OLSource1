---
title: "CWnd::OnQueryEndSession"
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
  - CWnd.OnQueryEndSession
  - CWnd::OnQueryEndSession
  - OnQueryEndSession
  - WM_QUERYENDSESSION
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnQueryEndSession method
  - WM_QUERYENDSESSION
ms.assetid: b0256bc8-ef85-4647-a30d-1c3a1e3d6481
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnQueryEndSession
The framework calls this member function when the user chooses to end the Windows session or when an application calls the [ExitWindows](http://msdn.microsoft.com/library/windows/desktop/aa376867) Windows function.  
  
## Syntax  
  
```  
  
afx_msg BOOL OnQueryEndSession( );  
```  
  
## Return Value  
 Nonzero if an application can be conveniently shut down; otherwise 0.  
  
## Remarks  
 If any application returns 0, the Windows session is not ended. Windows stops calling `OnQueryEndSession` as soon as one application returns 0 and sends the [WM_ENDSESSION](../vs140/cwnd--onendsession.md) message with a parameter value of **FALSE** for any application that has already returned nonzero.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ExitWindows](http://msdn.microsoft.com/library/windows/desktop/aa376867)   
 [CWnd::OnEndSession](../vs140/cwnd--onendsession.md)   
 [WM_QUERYENDSESSION](http://msdn.microsoft.com/library/windows/desktop/aa376890)