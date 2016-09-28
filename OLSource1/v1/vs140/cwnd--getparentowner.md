---
title: "CWnd::GetParentOwner"
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
  - "CWnd::GetParentOwner"
  - "GetParentOwner"
  - "CWnd.GetParentOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParentOwner method"
  - "child windows, parent window"
  - "parent windows"
ms.assetid: 0b2e0834-6c82-4b12-b093-66ee08ee74f9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetParentOwner
Call this member function to get a pointer to a child window's parent window or owner window.  
  
## Syntax  
  
```  
  
CWnd* GetParentOwner( ) const;  
  
```  
  
## Return Value  
 A pointer to a `CWnd` object. If a `CWnd` object is not attached to the handle, a temporary `CWnd` object is created and attached. The pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 `GetParentOwner` returns a pointer to the most immediate parent or owner window that is not a child window (does not have the **WS_CHILD** style). The current owner window can be set with [SetOwner](../vs140/cwnd--setowner.md). By default, the parent of a window is its owner.  
  
 In contrast, the [GetParent](../vs140/cwnd--getparent.md) function returns a pointer to the immediate parent, whether it is a child window or not. If you have a child window within a child window `GetParent` and `GetParentOwner` return different results.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetParent](../vs140/cwnd--getparent.md)   
 [CWnd::GetOwner](../vs140/cwnd--getowner.md)   
 [CWnd::SetOwner](../vs140/cwnd--setowner.md)   
 [CWnd::SetParent](../vs140/cwnd--setparent.md)   
 [GetParent](http://msdn.microsoft.com/library/windows/desktop/ms633510)