---
title: "CWindow::SetWindowPos"
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
  - CWindow.SetWindowPos
  - CWindow::SetWindowPos
  - ATL::CWindow::SetWindowPos
  - ATL.CWindow.SetWindowPos
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetWindowPos method
ms.assetid: bb344ced-f6b9-4f5a-91a6-9b874a16fe60
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::SetWindowPos
Sets the size, position, and Z order.  
  
## Syntax  
  
```  
  
      BOOL SetWindowPos(  
   HWND hWndInsertAfter,  
   int x,  
   int y,  
   int cx,  
   int cy,  
   UINT nFlags   
) throw();  
BOOL SetWindowPos(  
   HWND hWndInsertAfter,  
   LPCRECT lpRect,  
   UINT nFlags   
) throw();  
```  
  
## Remarks  
 See [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The second version of this method uses a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure to set the window's new position, width, and height.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::BringWindowToTop](../vs140/cwindow--bringwindowtotop.md)   
 [CWindow::MoveWindow](../vs140/cwindow--movewindow.md)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)