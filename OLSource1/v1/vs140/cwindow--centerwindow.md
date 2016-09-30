---
title: "CWindow::CenterWindow"
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
  - "CWindow.CenterWindow"
  - "ATL::CWindow::CenterWindow"
  - "CWindow::CenterWindow"
  - "ATL.CWindow.CenterWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CenterWindow method"
ms.assetid: f7d3543a-032b-4bbc-8e15-1f739e5c594e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::CenterWindow
Centers the window against a given window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The handle to the window against which to center. If this parameter is **NULL** (the default value), the method will set <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the window's parent window if it is a child window. Otherwise, it will set <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the window's owner window.  
  
## Return Value  
 **TRUE** if the window is successfully centered; otherwise, **FALSE**.  
  
## Example  
 [!code[NVC_ATL_Windowing#4](../vs140/codesnippet/CPP/cwindow--centerwindow_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::MoveWindow](../vs140/cwindow--movewindow.md)   
 [CWindow::SetWindowPos](../vs140/cwindow--setwindowpos.md)