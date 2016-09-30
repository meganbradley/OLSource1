---
title: "CFrameWndEx::EnableFullScreenMode"
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
  - "CFrameWndEx::EnableFullScreenMode"
  - "CFrameWndEx.EnableFullScreenMode"
  - "EnableFullScreenMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableFullScreenMode method"
ms.assetid: 2b24a30e-acb4-48df-872d-6f836ec790a6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::EnableFullScreenMode
Enables the full-screen mode for the frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID of a command that enables and disables the full screen mode.  
  
## Remarks  
 In the full-screen mode, all docking control bars, toolbars and menu are hidden and the active view is resized to occupy the full-screen.  
  
 When you enable the full-screen mode, you must specify an ID of the command that enables or disables the full-screen mode. You can call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> from the main frame's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function. When a frame window is being switched to a full-screen mode, the framework creates a floating toolbar with one button that has the specified command ID.  
  
 If you want to keep the main menu on the screen, call [CFrameWndEx::EnableFullScreenMainMenu](../vs140/cframewndex--enablefullscreenmainmenu.md).  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)