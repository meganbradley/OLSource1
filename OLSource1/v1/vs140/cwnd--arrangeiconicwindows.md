---
title: "CWnd::ArrangeIconicWindows"
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
  - ArrangeIconicWindows
  - CWnd::ArrangeIconicWindows
  - CWnd.ArrangeIconicWindows
dev_langs: 
  - C++
helpviewer_keywords: 
  - ArrangeIconicWindows method
ms.assetid: 4090855b-2436-4cba-9a17-ef4dc7e02973
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::ArrangeIconicWindows
Arranges all the minimized (iconic) child windows.  
  
## Syntax  
  
```  
  
UINT ArrangeIconicWindows( );  
```  
  
## Return Value  
 The height of one row of icons if the function is successful; otherwise 0.  
  
## Remarks  
 This member function also arranges icons on the desktop window, which covers the entire screen. The [GetDesktopWindow](../vs140/cwnd--getdesktopwindow.md) member function retrieves a pointer to the desktop window object.  
  
 To arrange iconic MDI child windows in an MDI client window, call [CMDIFrameWnd::MDIIconArrange](../vs140/cmdiframewnd--mdiiconarrange.md).  
  
## Example  
 [!code[NVC_MFCWindowing#66](../vs140/codesnippet/CPP/cwnd--arrangeiconicwindows_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDesktopWindow](../vs140/cwnd--getdesktopwindow.md)   
 [CMDIFrameWnd::MDIIconArrange](../vs140/cmdiframewnd--mdiiconarrange.md)   
 [ArrangeIconicWindows](http://msdn.microsoft.com/library/windows/desktop/ms632671)