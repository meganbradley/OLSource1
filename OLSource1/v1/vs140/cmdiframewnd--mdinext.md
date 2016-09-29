---
title: "CMDIFrameWnd::MDINext"
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
  - "MDINext"
  - "CMDIFrameWnd::MDINext"
  - "CMDIFrameWnd.MDINext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MDINext method"
  - "CMDIFrameWnd class, operations"
ms.assetid: 2c6c18a3-3041-4915-9def-322163d6cb09
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWnd::MDINext
Activates the child window immediately behind the currently active child window and places the currently active child window behind all other child windows.  
  
## Syntax  
  
```  
  
void MDINext( );  
```  
  
## Remarks  
 If the currently active MDI child window is maximized, the member function restores the currently active child and maximizes the newly activated child.  
  
## Example  
 [!code[NVC_MFCWindowing#18](../vs140/codesnippet/CPP/cmdiframewnd--mdinext_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDIPrev](../vs140/cmdiframewnd--mdiprev.md)   
 [CMDIFrameWnd::MDIActivate](../vs140/cmdiframewnd--mdiactivate.md)   
 [CMDIFrameWnd::MDIGetActive](../vs140/cmdiframewnd--mdigetactive.md)   
 [WM_MDINEXT](http://msdn.microsoft.com/library/windows/desktop/ms644918)