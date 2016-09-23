---
title: "CWnd::GetCapture"
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
  - CWnd.GetCapture
  - CWnd::GetCapture
  - GetCapture
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCapture method
ms.assetid: 0131de2e-8859-4339-a44c-f5ea54352311
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetCapture
Retrieves the window that has the mouse capture.  
  
## Syntax  
  
```  
  
static CWnd* PASCAL GetCapture( );  
```  
  
## Return Value  
 Identifies the window that has the mouse capture. It is **NULL** if no window has the mouse capture.  
  
 The return value may be temporary and should not be stored for later use.  
  
## Remarks  
 Only one window has the mouse capture at any given time. A window receives the mouse capture when the [SetCapture](../vs140/cwnd--setcapture.md) member function is called. This window receives mouse input whether or not the cursor is within its borders.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::SetCapture](../vs140/cwnd--setcapture.md)   
 [GetCapture](http://msdn.microsoft.com/library/windows/desktop/ms646257)