---
title: "CWindow::ScrollWindowEx"
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
  - "ScrollWindowEx"
  - "CWindow::ScrollWindowEx"
  - "CWindow.ScrollWindowEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScrollWindowEx method"
ms.assetid: e9f92cb5-a2bc-466d-a3c7-ba1f176fc0b8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::ScrollWindowEx
Scrolls the specified client area with additional features.  
  
## Syntax  
  
```  
  
      int ScrollWindowEx(  
   int dx,  
   int dy,  
   LPCRECT lpRectScroll,  
   LPCRECT lpRectClip,  
   HRGN hRgnUpdate,  
   LPRECT lpRectUpdate,  
   UINT flags   
) throw();  
```  
  
## Remarks  
 See [ScrollWindowEx](http://msdn.microsoft.com/library/windows/desktop/bb787593) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::ScrollWindow](../vs140/cwindow--scrollwindow.md)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)