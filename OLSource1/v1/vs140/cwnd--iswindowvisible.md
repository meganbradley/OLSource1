---
title: "CWnd::IsWindowVisible"
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
  - CWnd::IsWindowVisible
  - CWnd.IsWindowVisible
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsWindowVisible method
ms.assetid: 5fdec4fd-ffcc-4c9f-b2c8-83c906b25385
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::IsWindowVisible
Determines the visibility state of the given window.  
  
## Syntax  
  
```  
  
BOOL IsWindowVisible( ) const;  
```  
  
## Return Value  
 Nonzero if `CWnd` is visible (has the [WS_VISIBLE](../vs140/window-styles.md) style bit set, and parent window is visible). Because the return value reflects the state of the **WS_VISIBLE** style bit, the return value may be nonzero even though `CWnd` is totally obscured by other windows.  
  
## Remarks  
 A window possesses a visibility state indicated by the **WS_VISIBLE** style bit. When this style bit is set with a call to the [ShowWindow](../vs140/cwnd--showwindow.md) member function, the window is displayed and subsequent drawing to the window is displayed as long as the window has the style bit set.  
  
 Any drawing to a window that has the **WS_VISIBLE** style will not be displayed if the window is covered by other windows or is clipped by its parent window.  
  
## Example  
 [!code[NVC_MFCWindowing#103](../vs140/codesnippet/CPP/cwnd--iswindowvisible_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::ShowWindow](../vs140/cwnd--showwindow.md)   
 [IsWindowVisible](http://msdn.microsoft.com/library/windows/desktop/ms633530)