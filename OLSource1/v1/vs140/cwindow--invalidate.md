---
title: "CWindow::Invalidate"
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
  - "CWindow.Invalidate"
  - "ATL::CWindow::Invalidate"
  - "ATL.CWindow.Invalidate"
  - "CWindow::Invalidate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Invalidate method"
ms.assetid: 0aa8c2ab-10ab-4673-8d00-6e75a111b53f
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::Invalidate
Invalidates the entire client area.  
  
## Syntax  
  
```  
  
      BOOL Invalidate(  
   BOOL bErase = TRUE   
) throw();  
```  
  
## Remarks  
 See [InvalidateRect](http://msdn.microsoft.com/library/windows/desktop/dd145002) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Passes **NULL** for the `RECT` parameter to the `InvalidateRect` Win32 function.  
  
## Example  
 [!code[NVC_ATL_Windowing#18](../vs140/codesnippet/CPP/cwindow--invalidate_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::InvalidateRect](../vs140/cwindow--invalidaterect.md)   
 [CWindow::InvalidateRgn](../vs140/cwindow--invalidatergn.md)   
 [CWindow::ValidateRect](../vs140/cwindow--validaterect.md)   
 [CWindow::ValidateRgn](../vs140/cwindow--validatergn.md)