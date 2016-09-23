---
title: "CWnd::GetOwner"
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
  - CWnd.GetOwner
  - CWnd::GetOwner
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetOwner method
  - CWnd class, window-access functions
ms.assetid: fcad7014-01ba-4e40-a944-034a7cd6d1cb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::GetOwner
Retrieves a pointer to the owner of the window.  
  
## Syntax  
  
```  
  
CWnd* GetOwner( ) const;  
```  
  
## Return Value  
 A pointer to a `CWnd` object.  
  
## Remarks  
 If the window has no owner, then a pointer to the parent window object is returned by default. Note that the relationship between the owner and the owned differs from the parent-child aspect in several important aspects. For example, a window with a parent is confined to its parent window's client area. Owned windows can be drawn at any location on the desktop.  
  
 The ownership concept of this function is different from the ownership concept of [GetWindow](http://msdn.microsoft.com/library/windows/desktop/ms633515).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetParent](../vs140/cwnd--getparent.md)   
 [CWnd::SetOwner](../vs140/cwnd--setowner.md)