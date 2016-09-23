---
title: "CWindow::SetTimer"
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
  - CWindow::SetTimer
  - CWindow.SetTimer
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetTimer method
ms.assetid: 9af43e75-d680-4fb6-892b-8dbd90eb0f10
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::SetTimer
Creates a timer event.  
  
## Syntax  
  
```  
  
      UINT SetTimer(  
   UINT nIDEvent,  
   UINT nElapse,  
   void ( CALLBACK* lpfnTimer )(HWND, UINT, UINT, DWORD) = NULL   
) throw();  
```  
  
## Remarks  
 See [SetTimer](http://msdn.microsoft.com/library/windows/desktop/ms644906) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::KillTimer](../vs140/cwindow--killtimer.md)