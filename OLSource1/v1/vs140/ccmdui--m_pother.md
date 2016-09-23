---
title: "CCmdUI::m_pOther"
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
  - CCmdUI::m_pOther
  - m_pOther
  - CCmdUI.m_pOther
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_pOther
  - CCmdUI class, data members
ms.assetid: 7c79ced0-a4df-45b4-b63b-00ee738d91b8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCmdUI::m_pOther
Pointer (of type `CWnd`) to the window object, such as a tool or status bar, that sent the notification.  
  
## Syntax  
  
```  
  
CWnd* m_pOther;  
  
```  
  
## Remarks  
 **NULL** if the item is a menu or a non-`CWnd` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdUI Class](../vs140/ccmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd Class](../vs140/cwnd-class.md)