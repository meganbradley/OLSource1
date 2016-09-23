---
title: "CWnd::HideCaret"
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
  - CWnd.HideCaret
  - HideCaret
  - CWnd::HideCaret
dev_langs: 
  - C++
helpviewer_keywords: 
  - HideCaret method
ms.assetid: baf88432-59da-46d8-90fa-f20c715453d6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::HideCaret
Hides the caret by removing it from the display screen.  
  
## Syntax  
  
```  
  
void HideCaret( );  
```  
  
## Remarks  
 Although the caret is no longer visible, it can be displayed again by using the [ShowCaret](../vs140/cwnd--showcaret.md) member function. Hiding the caret does not destroy its current shape.  
  
 Hiding is cumulative. If `HideCaret` has been called five times in a row, the `ShowCaret` member function must be called five times before the caret will be shown.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ShowCaret](../vs140/cwnd--showcaret.md)   
 [HideCaret](http://msdn.microsoft.com/library/windows/desktop/ms648403)