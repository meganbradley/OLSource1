---
title: "CWindow::GetExStyle"
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
  - "CWindow::GetExStyle"
  - "CWindow.GetExStyle"
  - "ATL.CWindow.GetExStyle"
  - "ATL::CWindow::GetExStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExStyle method"
ms.assetid: 9e9b2f27-55fb-4da9-9445-bdd4efff9888
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetExStyle
Retrieves the extended window styles of the window.  
  
## Syntax  
  
```  
  
DWORD GetExStyle( ) const throw();  
```  
  
## Return Value  
 The window's extended styles.  
  
## Remarks  
 To retrieve the regular window styles, call [GetStyle](../vs140/cwindow--getstyle.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#10](../vs140/codesnippet/CPP/cwindow--getexstyle_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::ModifyStyleEx](../vs140/cwindow--modifystyleex.md)