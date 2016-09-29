---
title: "CMDIFrameWndEx::EnableFullScreenMode"
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
  - "CMDIFrameWndEx::EnableFullScreenMode"
  - "EnableFullScreenMode"
  - "CMDIFrameWndEx.EnableFullScreenMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableFullScreenMode method"
ms.assetid: 7424d3da-32cc-4f6d-9bcf-df36b2512dc5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::EnableFullScreenMode
Enables full-screen mode for the frame window.  
  
## Syntax  
  
```  
void EnableFullScreenMode(  
   UINT uiFullScreenCmd  
);  
```  
  
#### Parameters  
 [in] `uiFullScreenCmd`  
 The ID of a command that enables or disables full-screen mode.  
  
## Remarks  
 In full-screen mode, all docking control bars, toolbars and menus are hidden and the active view is resized to occupy the full-screen.When you enable full-screen mode, you must specify an ID of the command that enables or disables it. You can call `EnableFullScreenMode` from the main frame's `OnCreate` function. When a frame window is being switched to full-screen mode, the framework creates a floating toolbar with one button that has the specified command ID.If you want to keep the main menu on the screen, call [CFrameWndEx::EnableFullScreenMainMenu](../vs140/cmdiframewndex--enablefullscreenmainmenu.md).  
  
## Requirements  
 **Header:** afxmdiframewndex.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)