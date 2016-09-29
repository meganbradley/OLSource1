---
title: "CWnd::GetSafeHwnd"
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
  - "CWnd.GetSafeHwnd"
  - "CWnd::GetSafeHwnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSafeHwnd method"
ms.assetid: 0179bc13-81f7-4c96-97a9-cf15113407c6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetSafeHwnd
Returns `m_hWnd`, or **NULL** if the **this** pointer is **NULL**.  
  
## Syntax  
  
```  
  
HWND GetSafeHwnd( ) const;  
```  
  
## Return Value  
 Returns the window handle for a window. Returns **NULL** if the `CWnd` is not attached to a window or if it is used with a **NULL CWnd** pointer.  
  
## Example  
 See the example for [CWnd::SubclassWindow](../vs140/cwnd--subclasswindow.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)