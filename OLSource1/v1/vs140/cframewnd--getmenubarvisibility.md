---
title: "CFrameWnd::GetMenuBarVisibility"
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
  - "CFrameWnd::GetMenuBarVisibility"
  - "GetMenuBarVisibility"
  - "CFrameWnd.GetMenuBarVisibility"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenuBarVisibility method"
ms.assetid: a7452d76-608c-4c11-8b0d-c5d87d032aa3
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::GetMenuBarVisibility
Indicates whether the default state of the menu in the current MFC application is hidden or visible.  
  
## Syntax  
  
```  
virtual DWORD CFrameWnd::GetMenuBarVisibility();  
```  
  
## Return Value  
 This method returns one of the following values:  
  
-   AFX_MBV_KEEPVISIBLE (0x01) - The menu is displayed at all times, and by default does not have the focus.  
  
-   AFX_MBV_DISPLAYONFOCUS (0x02) - The menu is hidden by default. If the menu is hidden, press the ALT key to display the menu and give it the focus. If the menu is displayed, press the ALT or ESC key to hide it.  
  
-   AFX_MBV_ DISPLAYONFOCUS (0x02) &#124; AFX_MBV_DISPLAYONF10 (0x04) (bitwise combination (OR)) - The menu is hidden by default. If the menu is hidden, press the F10 key to display the menu and give it the focus. If the menu is displayed, press the F10 key to toggle the focus on or off the menu. The menu is displayed until you press the ALT or ESC key to hide it.  
  
## Remarks  
 If a runtime error occurs, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::SetMenuBarVisibility](../vs140/cframewnd--setmenubarvisibility.md)