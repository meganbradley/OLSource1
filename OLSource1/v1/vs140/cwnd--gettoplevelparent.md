---
title: "CWnd::GetTopLevelParent"
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
  - GetTopLevelParent
  - CWnd::GetTopLevelParent
  - CWnd.GetTopLevelParent
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTopLevelParent method
ms.assetid: 3b5e5368-4614-4e6f-9bbd-8a0ae454265f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetTopLevelParent
Call this member function to retrieve the window's top-level parent.  
  
## Syntax  
  
```  
  
CWnd* GetTopLevelParent( ) const;  
  
```  
  
## Return Value  
 Identifies the top-level parent window of the window.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 `GetTopLevelParent` is similar to [GetTopLevelFrame](../vs140/cwnd--gettoplevelframe.md) and [GetTopLevelOwner](../vs140/cwnd--gettoplevelowner.md); however, it ignores the value set as the current owner window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetTopLevelOwner](../vs140/cwnd--gettoplevelowner.md)   
 [CWnd::GetTopLevelFrame](../vs140/cwnd--gettoplevelframe.md)   
 [CWnd::GetOwner](../vs140/cwnd--getowner.md)   
 [CWnd::SetOwner](../vs140/cwnd--setowner.md)