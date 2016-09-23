---
title: "CWindow::GetWindowProcessID"
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
  - ATL::CWindow::GetWindowProcessID
  - ATL.CWindow.GetWindowProcessID
  - GetWindowProcessID
  - CWindow::GetWindowProcessID
  - CWindow.GetWindowProcessID
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetWindowProcessID method
ms.assetid: b403eac0-ba9e-4031-8566-f2ba098a4c52
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::GetWindowProcessID
Retrieves the identifier of the process that created the window.  
  
## Syntax  
  
```  
  
DWORD GetWindowProcessID( ) throw();  
  
```  
  
## Remarks  
 See [GetWindowThreadProcessID](http://msdn.microsoft.com/library/windows/desktop/ms633522) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#15](../vs140/codesnippet/CPP/cwindow--getwindowprocessid_1.cpp)]
  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetWindowThreadID](../vs140/cwindow--getwindowthreadid.md)