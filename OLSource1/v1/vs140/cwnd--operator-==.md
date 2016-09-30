---
title: "CWnd::operator =="
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
  - "CWnd::operator=="
  - "CWnd.operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, windows"
  - "CWnd class, operators"
  - "operator==, windows"
  - "== operator"
ms.assetid: f0c3c783-5812-4aad-a07b-b041ea33657d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::operator ==
Compares two `CWnd` objects to determine if they have the same [m_hWnd](../vs140/cwnd--m_hwnd.md).  
  
## Syntax  
  
```  
  
      BOOL operator==(  
   const CWnd& wnd   
) const;  
```  
  
#### Parameters  
 `wnd`  
 A reference to a `CWnd` object.  
  
## Return Value  
 Nonzero if equal; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::operator !=](../vs140/cwnd--operator-!=.md)