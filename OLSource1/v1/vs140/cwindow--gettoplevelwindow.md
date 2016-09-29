---
title: "CWindow::GetTopLevelWindow"
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
  - "CWindow::GetTopLevelWindow"
  - "GetTopLevelWindow"
  - "CWindow.GetTopLevelWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTopLevelWindow method"
ms.assetid: 0e3398a8-d1ef-4996-9eb7-5fae7e0355e0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetTopLevelWindow
Retrieves the window's top-level parent or owner window.  
  
## Syntax  
  
```  
  
HWND GetTopLevelWindow( ) const throw();  
  
```  
  
## Return Value  
 The handle to the top-level owner window.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetTopLevelParent](../vs140/cwindow--gettoplevelparent.md)   
 [CWindow::GetWindow](../vs140/cwindow--getwindow.md)