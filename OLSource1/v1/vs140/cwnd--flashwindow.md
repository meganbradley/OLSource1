---
title: "CWnd::FlashWindow"
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
  - "CWnd.FlashWindow"
  - "FlashWindow"
  - "CWnd::FlashWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "alerts [C++], flash window"
  - "CWnd class, alert functions"
  - "FlashWindow method"
ms.assetid: 0da738a9-a458-44d0-9c9b-ac988663254c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::FlashWindow
Flashes the given window once.  
  
## Syntax  
  
```  
  
      BOOL FlashWindow(  
   BOOL bInvert   
);  
```  
  
#### Parameters  
 `bInvert`  
 Specifies whether the `CWnd` is to be flashed or returned to its original state. The `CWnd` is flashed from one state to the other if `bInvert` is **TRUE**. If `bInvert` is **FALSE**, the window is returned to its original state (either active or inactive).  
  
## Return Value  
 Nonzero if the window was active before the call to the `FlashWindow` member function; otherwise 0.  
  
## Remarks  
 For successive flashing, create a system timer and repeatedly call `FlashWindow`. Flashing the `CWnd` means changing the appearance of its title bar as if the `CWnd` were changing from inactive to active status, or vice versa. (An inactive title bar changes to an active title bar; an active title bar changes to an inactive title bar.)  
  
 Typically, a window is flashed to inform the user that it requires attention but that it does not currently have the input focus.  
  
 The `bInvert` parameter should be **FALSE** only when the window is getting the input focus and will no longer be flashing; it should be **TRUE** on successive calls while waiting to get the input focus.  
  
 This function always returns nonzero for minimized windows. If the window is minimized, `FlashWindow` will simply flash the window's icon; `bInvert` is ignored for minimized windows.  
  
## Example  
 [!code[NVC_MFCWindowing#95](../vs140/codesnippet/CPP/cwnd--flashwindow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [FlashWindow](http://msdn.microsoft.com/library/windows/desktop/ms679346)