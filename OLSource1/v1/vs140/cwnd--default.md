---
title: "CWnd::Default"
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
  - CWnd::Default
  - CWnd.Default
dev_langs: 
  - C++
helpviewer_keywords: 
  - Default method
  - window message functions
  - message functions
  - CWnd class, operations
ms.assetid: 6d1914c0-256b-467a-9ddc-1627e87290cf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::Default
Calls the default window procedure.  
  
## Syntax  
  
```  
  
LRESULT Default( );  
```  
  
## Return Value  
 Depends on the message sent.  
  
## Remarks  
 The default window procedure provides default processing for any window message that an application does not process. This member function ensures that every message is processed.  
  
## Example  
 [!code[NVC_MFCWindowing#85](../vs140/codesnippet/CPP/cwnd--default_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md)   
 [DefWindowProc](http://msdn.microsoft.com/library/windows/desktop/ms633572)