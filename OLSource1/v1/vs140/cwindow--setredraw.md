---
title: "CWindow::SetRedraw"
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
  - "ATL.CWindow.SetRedraw"
  - "ATL::CWindow::SetRedraw"
  - "CWindow::SetRedraw"
  - "CWindow.SetRedraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRedraw method"
ms.assetid: d9d54e1b-7edd-4c0f-ac98-36a9c74ece8d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetRedraw
Sets or clears the redraw flag by sending a [WM_SETREDRAW](http://msdn.microsoft.com/library/windows/desktop/dd145219) message to the window.  
  
## Syntax  
  
```  
  
      void SetRedraw(  
   BOOL bRedraw = TRUE   
) throw();  
```  
  
#### Parameters  
 `bRedraw`  
 [in] Specifies the state of the redraw flag. If **TRUE** (the default value), the redraw flag is set; if **FALSE**, the flag is cleared.  
  
## Remarks  
 Call `SetRedraw` to allow changes to be redrawn or to prevent changes from being redrawn.  
  
## Example  
 [!code[NVC_ATL_Windowing#33](../vs140/codesnippet/CPP/cwindow--setredraw_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)