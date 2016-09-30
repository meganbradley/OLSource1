---
title: "CWnd::ShowWindow"
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
  - "CWnd::ShowWindow"
  - "CWnd.ShowWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowWindow method"
  - "windows [C++], showing"
ms.assetid: 2b2584c6-e6f6-46e1-ad6a-04ed49ab83e0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ShowWindow
Sets the visibility state of the window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies how the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is to be shown. It must be one of the following values:  
  
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
 Nonzero if the window was previously visible; 0 if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> was previously hidden.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be called only once per application for the main window with [CWinApp::m_nCmdShow](../vs140/cwinapp--m_ncmdshow.md). Subsequent calls to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must use one of the values listed above instead of the one specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CWnd::CalcWindowRect](../vs140/cwnd--calcwindowrect.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ShowWindow](http://msdn.microsoft.com/library/windows/desktop/ms633548)   
 [CWnd::OnShowWindow](../vs140/cwnd--onshowwindow.md)   
 [CWnd::ShowOwnedPopups](../vs140/cwnd--showownedpopups.md)