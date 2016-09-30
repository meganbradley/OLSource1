---
title: "CMDIFrameWnd::MDIPrev"
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
  - "CMDIFrameWnd::MDIPrev"
  - "MDIPrev"
  - "CMDIFrameWnd.MDIPrev"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MDIPrev method"
ms.assetid: bda20b09-bc25-495e-89c2-79968213abd0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWnd::MDIPrev
Activates the previous child window and places the currently active child window immediately behind it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the currently active MDI child window is maximized, the member function restores the currently active child and maximizes the newly activated child.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDINext](../vs140/cmdiframewnd--mdinext.md)   
 [CMDIFrameWnd::MDIActivate](../vs140/cmdiframewnd--mdiactivate.md)   
 [CMDIFrameWnd::MDIGetActive](../vs140/cmdiframewnd--mdigetactive.md)   
 [WM_MDINEXT](http://msdn.microsoft.com/library/windows/desktop/ms644918)