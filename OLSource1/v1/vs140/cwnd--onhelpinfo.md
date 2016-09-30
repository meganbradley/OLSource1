---
title: "CWnd::OnHelpInfo"
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
  - "CWnd.OnHelpInfo"
  - "OnHelpInfo"
  - "CWnd::OnHelpInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHelpInfo method"
ms.assetid: bf884ab0-0f48-4e31-a82c-8f52ea9619e0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnHelpInfo
Called by the framework when the user presses the F1 key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpHelpInfo*  
 Pointer to a [HELPINFO](http://msdn.microsoft.com/library/windows/desktop/bb773313) structure that contains information about the menu item, control, dialog box, or window for which help is requested.  
  
## Return Value  
 Returns TRUE if a window has the keyboard focus or if a menu is active within a window. If no window has the keyboard focus, returns FALSE.  
  
## Remarks  
 If a menu is active when F1 is pressed, **WM_HELP** is sent to the window associated with the menu; otherwise, **WM_HELP** is sent to the window that has the keyboard focus. If no window has the keyboard focus, **WM_HELP** is sent to the currently active window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnHelp](../vs140/cwinapp--onhelp.md)   
 [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md)