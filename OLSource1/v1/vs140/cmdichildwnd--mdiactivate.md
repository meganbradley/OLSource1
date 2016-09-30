---
title: "CMDIChildWnd::MDIActivate"
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
  - "MDIActivate"
  - "CMDIChildWnd.MDIActivate"
  - "CMDIChildWnd::MDIActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMDIChildWnd class, operations"
  - "MDIActivate method"
ms.assetid: 763f1a7d-8c85-4774-9916-d803ba6f156d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWnd::MDIActivate
Call this member function to activate an MDI child window independently of the MDI frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When the frame becomes active, the child window that was last activated will be activated as well.  
  
## Example  
 See the example for [CMDIFrameWnd::GetWindowMenuPopup](../vs140/cmdiframewnd--getwindowmenupopup.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIChildWnd Class](../vs140/cmdichildwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDIGetActive](../vs140/cmdiframewnd--mdigetactive.md)   
 [CWnd::OnNcActivate](../vs140/cwnd--onncactivate.md)   
 [CMDIFrameWnd::MDINext](../vs140/cmdiframewnd--mdinext.md)   
 [WM_MDIACTIVATE](http://msdn.microsoft.com/library/windows/desktop/ms644911)