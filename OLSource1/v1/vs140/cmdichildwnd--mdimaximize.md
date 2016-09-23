---
title: "CMDIChildWnd::MDIMaximize"
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
  - CMDIChildWnd::MDIMaximize
  - MDIMaximize
  - CMDIChildWnd.MDIMaximize
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMDIChildWnd class, operations
  - MDIMaximize method
ms.assetid: 6aee4398-f959-473e-907f-96da6faac4dd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIChildWnd::MDIMaximize
Call this member function to maximize an MDI child window.  
  
## Syntax  
  
```  
  
void MDIMaximize( );  
```  
  
## Remarks  
 When a child window is maximized, Windows resizes it to make its client area fill the client area of the frame window. Windows places the child window's Control menu in the frame's menu bar so that the user can restore or close the child window and adds the title of the child window to the frame-window title.  
  
## Example  
 [!code[NVC_MFCWindowing#11](../vs140/codesnippet/CPP/cmdichildwnd--mdimaximize_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIChildWnd Class](../vs140/cmdichildwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_MDIMAXIMIZE](http://msdn.microsoft.com/library/windows/desktop/ms644917)   
 [CMDIChildWnd::MDIRestore](../vs140/cmdichildwnd--mdirestore.md)