---
title: "CWindow::GetHotKey"
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
  - "GetHotKey"
  - "ATL.CWindow.GetHotKey"
  - "CWindow.GetHotKey"
  - "ATL::CWindow::GetHotKey"
  - "CWindow::GetHotKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHotKey method"
ms.assetid: a20fb852-d71b-45c2-8511-955c87e9289a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetHotKey
Determines the hot key associated with the window by sending a **WM_GETHOTKEY** message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The virtual key code and modifiers for the hot key associated with the window. For a list of possible modifiers, see [WM_GETHOTKEY](http://msdn.microsoft.com/library/windows/desktop/ms646278) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For a list of of standard virtual key codes, see Winuser.h.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetHotKey](../vs140/cwindow--sethotkey.md)