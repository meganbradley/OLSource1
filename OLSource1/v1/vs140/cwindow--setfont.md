---
title: "CWindow::SetFont"
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
  - "ATL.CWindow.SetFont"
  - "CWindow.SetFont"
  - "ATL::CWindow::SetFont"
  - "CWindow::SetFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFont method"
ms.assetid: 998c351b-80bd-4d22-b5cd-80f72c0fc1f9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetFont
Changes the window's current font by sending a [WM_SETFONT](http://msdn.microsoft.com/library/windows/desktop/ms632642) message to the window.  
  
## Syntax  
  
```  
  
      void SetFont(  
   HFONT hFont,  
   BOOL bRedraw = TRUE   
) throw();  
```  
  
#### Parameters  
 `hFont`  
 [in] The handle to the new font.  
  
 `bRedraw`  
 [in] If **TRUE** (the default value), the window is redrawn. Otherwise, it is not.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetFont](../vs140/cwindow--getfont.md)