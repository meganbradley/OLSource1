---
title: "CWindow::SetWindowWord"
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
  - "SetWindowWord"
  - "CWindow.SetWindowWord"
  - "ATL::CWindow::SetWindowWord"
  - "ATL.CWindow.SetWindowWord"
  - "CWindow::SetWindowWord"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowWord method"
ms.assetid: c53fd093-6800-419e-8a98-46968fc2486f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetWindowWord
Sets a 16-bit value at a specified offset into the extra window memory.  
  
## Syntax  
  
```  
  
      WORD SetWindowWord(  
   int nIndex,  
   WORD wNewWord   
) throw();  
```  
  
## Remarks  
 See [SetWindowLong](http://msdn.microsoft.com/library/windows/desktop/ms633591) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetWindowWord](../vs140/cwindow--getwindowword.md)   
 [CWindow::SetWindowLong](../vs140/cwindow--setwindowlong.md)