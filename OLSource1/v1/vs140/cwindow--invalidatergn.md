---
title: "CWindow::InvalidateRgn"
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
  - ATL.CWindow.InvalidateRgn
  - CWindow::InvalidateRgn
  - ATL::CWindow::InvalidateRgn
  - CWindow.InvalidateRgn
dev_langs: 
  - C++
helpviewer_keywords: 
  - InvalidateRgn method
ms.assetid: bc62778a-84ab-442b-a8d3-f489d97f8739
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::InvalidateRgn
Invalidates the client area within the specified region.  
  
## Syntax  
  
```  
  
      void InvalidateRgn(  
   HRGN hRgn,  
   BOOL bErase = TRUE   
) throw();  
```  
  
## Remarks  
 See [InvalidateRgn](http://msdn.microsoft.com/library/windows/desktop/dd145003) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 Specifies a `void` return type, while the `InvalidateRgn` Win32 function always returns **TRUE**.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::Invalidate](../vs140/cwindow--invalidate.md)   
 [CWindow::InvalidateRect](../vs140/cwindow--invalidaterect.md)   
 [CWindow::ValidateRgn](../vs140/cwindow--validatergn.md)