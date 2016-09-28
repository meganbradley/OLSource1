---
title: "COleControlSite::ShowWindow"
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
  - "COleControlSite.ShowWindow"
  - "COleControlSite::ShowWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowWindow method"
  - "COleControlSite class, overridables"
ms.assetid: 197d65af-a1db-4bec-9896-2f2be1c32968
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::ShowWindow
Sets the window's show state.  
  
## Syntax  
  
```  
  
      virtual BOOL ShowWindow(  
   int nCmdShow   
);  
```  
  
#### Parameters  
 `nCmdShow`  
 Specifies how the control site is to be shown. It must be one of the following values:  
  
-   **SW_HIDE** Hides this window and passes activation to another window.  
  
-   **SW_MINIMIZE** Minimizes the window and activates the top-level window in the system's list.  
  
-   **SW_RESTORE** Activates and displays the window. If the window is minimized or maximized, Windows restores it to its original size and position.  
  
-   **SW_SHOW** Activates the window and displays it in its current size and position.  
  
-   **SW_SHOWMAXIMIZED** Activates the window and displays it as a maximized window.  
  
-   **SW_SHOWMINIMIZED** Activates the window and displays it as an icon.  
  
-   **SW_SHOWMINNOACTIVE** Displays the window as an icon. The window that is currently active remains active.  
  
-   **SW_SHOWNA** Displays the window in its current state. The window that is currently active remains active.  
  
-   **SW_SHOWNOACTIVATE** Displays the window in its most recent size and position. The window that is currently active remains active.  
  
-   **SW_SHOWNORMAL** Activates and displays the window. If the window is minimized or maximized, Windows restores it to its original size and position.  
  
## Return Value  
 Nonzero if the window was previously visible; 0 if the window was previously hidden.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)