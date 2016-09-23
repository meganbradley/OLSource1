---
title: "CWindow::ResizeClient"
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
  - CWindow.ResizeClient
  - CWindow::ResizeClient
  - ResizeClient
dev_langs: 
  - C++
helpviewer_keywords: 
  - ResizeClient method
ms.assetid: a5ba0178-85d8-4013-be27-512f4b9ba367
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::ResizeClient
Resizes the window to the specified client area size.  
  
## Syntax  
  
```  
  
      BOOL ResizeClient(  
   int nWidth,  
   int nHeight,  
   BOOL bRedraw = FALSE   
) throw();  
```  
  
#### Parameters  
 `nWidth`  
 New width of the window in pixels.  
  
 `nHeight`  
 New height of the window in pixels.  
  
 `bRedraw`  
 A flag indicating whether to redraw changes. Default is **FALSE**, indicating the window does not redraw changes.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetWindowPos](../vs140/cwindow--setwindowpos.md)   
 [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545)