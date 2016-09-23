---
title: "CWindow::GetUpdateRect"
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
  - CWindow.GetUpdateRect
  - GetUpdateRect
  - CWindow::GetUpdateRect
  - ATL.CWindow.GetUpdateRect
  - ATL::CWindow::GetUpdateRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetUpdateRect method
ms.assetid: a5ccac33-d0b3-460c-9498-a58d0288a438
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::GetUpdateRect
Retrieves the coordinates of the smallest rectangle that completely encloses the update region.  
  
## Syntax  
  
```  
  
      BOOL GetUpdateRect(  
   LPRECT lpRect,  
   BOOL bErase = FALSE   
) throw();  
```  
  
## Remarks  
 See [GetUpdateRect](http://msdn.microsoft.com/library/windows/desktop/dd144943) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetUpdateRgn](../vs140/cwindow--getupdatergn.md)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)