---
title: "CMDIChildWnd::MDIDestroy"
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
  - "CMDIChildWnd::MDIDestroy"
  - "CMDIChildWnd.MDIDestroy"
  - "MDIDestroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMDIChildWnd class, operations"
  - "MDIDestroy method"
ms.assetid: 16d20d80-19ef-4cd1-8da5-1df9cf363ebd
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWnd::MDIDestroy
Call this member function to destroy an MDI child window.  
  
## Syntax  
  
```  
  
void MDIDestroy( );  
```  
  
## Remarks  
 The member function removes the title of the child window from the frame window and deactivates the child window.  
  
## Example  
 [!code[NVC_MFCWindowing#10](../vs140/codesnippet/CPP/cmdichildwnd--mdidestroy_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIChildWnd Class](../vs140/cmdichildwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_MDIDESTROY](http://msdn.microsoft.com/library/windows/desktop/ms644914)   
 [CMDIChildWnd::Create](../vs140/cmdichildwnd--create.md)