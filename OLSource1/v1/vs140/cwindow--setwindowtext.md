---
title: "CWindow::SetWindowText"
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
  - ATL.CWindow.SetWindowText
  - CWindow.SetWindowText
  - ATL::CWindow::SetWindowText
  - CWindow::SetWindowText
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetWindowText method
ms.assetid: 99740ae8-9799-44e3-b640-c5b0e1f6071b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::SetWindowText
Changes the window's text.  
  
## Syntax  
  
```  
  
      BOOL SetWindowText(  
   LPCTSTR lpszString   
) throw();  
```  
  
## Remarks  
 See [SetWindowText](http://msdn.microsoft.com/library/windows/desktop/ms633546) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#34](../vs140/codesnippet/CPP/cwindow--setwindowtext_1.cpp)]
  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetWindowText](../vs140/cwindow--getwindowtext.md)