---
title: "CFrameWnd::GetMenuBarState"
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
  - "CFrameWnd.GetMenuBarState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenuBarState method"
ms.assetid: df3d9ec1-71fa-4ddb-bc51-c372b8ebf3bb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::GetMenuBarState
Retrieves the display state of the menu in the current MFC application.  
  
## Syntax  
  
```  
virtual DWORD GetMenuBarState();  
```  
  
## Return Value  
 The return value can have the following values:  
  
-   AFX_MBS_VISIBLE (0x01) – The menu is visible.  
  
-   AFX_MBS_HIDDEN (0x02) – The menu is hidden.  
  
## Remarks  
 If a runtime error occurs, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::SetMenuBarState](../vs140/cframewnd--setmenubarstate.md)