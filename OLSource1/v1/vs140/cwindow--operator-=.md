---
title: "CWindow::operator ="
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
  - CWindow.operator=
  - CWindow::operator=
  - ATL::CWindow::operator=
  - ATL.CWindow.operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - = operator, with specific ATL objects
  - operator=, windows
  - operator =, windows
ms.assetid: a7fbbc0b-ec90-4e0b-bac4-5540a7cbb2d4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::operator =
Assigns an `HWND` to the `CWindow` object by setting the [m_hWnd](../vs140/cwindow--m_hwnd.md) member to `hWnd`.  
  
## Syntax  
  
```  
  
      CWindow& operator =(  
   HWND hWnd   
) throw();  
```  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)