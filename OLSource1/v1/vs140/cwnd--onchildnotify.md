---
title: "CWnd::OnChildNotify"
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
  - OnChildNotify
  - CWnd.OnChildNotify
  - CWnd::OnChildNotify
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd class, overridables
  - OnChildNotify method
ms.assetid: 1d311d06-3a9b-411d-a697-f6a0b628f4c2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnChildNotify
This member function is called by this window's parent window when it receives a notification message that applies to this window.  
  
## Syntax  
  
```  
  
      virtual BOOL OnChildNotify(   
   UINT message,   
   WPARAM wParam,   
   LPARAM lParam,   
   LRESULT* pResult    
);  
```  
  
#### Parameters  
 `message`  
 A Windows message number sent to a parent window.  
  
 `wParam`  
 The **wparam** associated with the message.  
  
 `lParam`  
 The **lparam** associated with the message.  
  
 `pLResult`  
 A pointer to a value to be returned from the parent's window procedure. This pointer will be **NULL** if no return value is expected.  
  
## Return Value  
 Nonzero if this window is responsible for handling the message sent to its parent; otherwise 0.  
  
## Remarks  
 Never call this member function directly.  
  
 The default implementation of this member function returns 0, which means that the parent should handle the message.  
  
 Override this member function to extend the manner in which a control responds to notification messages.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)