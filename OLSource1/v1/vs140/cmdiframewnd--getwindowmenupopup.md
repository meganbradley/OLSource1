---
title: "CMDIFrameWnd::GetWindowMenuPopup"
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
  - "CMDIFrameWnd::GetWindowMenuPopup"
  - "GetWindowMenuPopup"
  - "CMDIFrameWnd.GetWindowMenuPopup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowMenuPopup method"
  - "CMDIFrameWnd class, overridables"
ms.assetid: d65359cc-1d52-4467-9e02-27c15defad83
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWnd::GetWindowMenuPopup
Call this member function to obtain a handle to the current pop-up menu named "Window" (the pop-up menu with menu items for MDI window management).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hMenuBar*  
 The current menu bar.  
  
## Return Value  
 The Window pop-up menu if one exists; otherwise **NULL**.  
  
## Remarks  
 The default implementation looks for a pop-up menu containing standard Window menu commands such as **ID_WINDOW_NEW** and **ID_WINDOW_TILE_HORZ**.  
  
 Override this member function if you have a Window menu that does not use the standard menu command IDs.  
  
## Example  
 [!code[NVC_MFCWindowing#16](../vs140/codesnippet/CPP/cmdiframewnd--getwindowmenupopup_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDIGetActive](../vs140/cmdiframewnd--mdigetactive.md)