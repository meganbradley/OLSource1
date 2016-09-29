---
title: "CWindow::ScrollWindow"
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
  - "ATL.CWindow.ScrollWindow"
  - "CWindow::ScrollWindow"
  - "CWindow.ScrollWindow"
  - "ATL::CWindow::ScrollWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ScrollWindow method"
ms.assetid: 45062fa3-4046-4318-a231-4b9271a05355
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::ScrollWindow
Scrolls the specified client area.  
  
## Syntax  
  
```  
  
      BOOL ScrollWindow(  
   int xAmount,  
   int yAmount,  
   LPCRECT lpRect = NULL,  
   LPCRECT lpClipRect = NULL   
) throw();  
```  
  
## Remarks  
 See [ScrollWindow](http://msdn.microsoft.com/library/windows/desktop/bb787591) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::ScrollWindowEx](../vs140/cwindow--scrollwindowex.md)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)