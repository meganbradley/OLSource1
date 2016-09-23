---
title: "CWindow::GetWindowWord"
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
  - ATL::CWindow::GetWindowWord
  - ATL.CWindow.GetWindowWord
  - GetWindowWord
  - CWindow.GetWindowWord
  - CWindow::GetWindowWord
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetWindowWord method
ms.assetid: 6e92436a-49b7-4506-97f8-6fbf8874e94d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::GetWindowWord
Retrieves a 16-bit value at a specified offset into the extra window memory.  
  
## Syntax  
  
```  
  
      WORD GetWindowWord(  
   int nIndex   
) const throw();  
```  
  
## Remarks  
 See [GetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633584) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetWindowWord](../vs140/cwindow--setwindowword.md)   
 [CWindow::GetWindowLong](../vs140/cwindow--getwindowlong.md)