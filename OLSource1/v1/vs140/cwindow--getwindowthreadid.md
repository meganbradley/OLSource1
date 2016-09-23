---
title: "CWindow::GetWindowThreadID"
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
  - ATL::CWindow::GetWindowThreadID
  - CWindow.GetWindowThreadID
  - GetWindowThreadID
  - CWindow::GetWindowThreadID
  - ATL.CWindow.GetWindowThreadID
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetWindowThreadID method
ms.assetid: 31d5aaca-786a-42aa-81a0-5325a0d21fdb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::GetWindowThreadID
Retrieves the identifier of the thread that created the specified window.  
  
## Syntax  
  
```  
  
DWORD GetWindowThreadID( ) throw();  
  
```  
  
## Remarks  
 See [GetWindowThreadProcessID](http://msdn.microsoft.com/library/windows/desktop/ms633522) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#16](../vs140/codesnippet/CPP/cwindow--getwindowthreadid_1.cpp)]
  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetWindowProcessID](../vs140/cwindow--getwindowprocessid.md)