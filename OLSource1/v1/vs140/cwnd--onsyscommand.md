---
title: "CWnd::OnSysCommand"
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
  - "WM_SYSCOMMAND"
  - "CWnd::OnSysCommand"
  - "OnSysCommand"
  - "CWnd.OnSysCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSysCommand method"
  - "WM_SYSCOMMAND"
ms.assetid: b5281236-5c1e-499d-9633-3bb3464a6ea1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSysCommand
The framework calls this member function when the user selects a command from the Control menu, or when the user selects the Maximize or the Minimize button.  
  
## Syntax  
  
```  
  
      afx_msg void OnSysCommand(  
   UINT nID,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `nID`  
 Specifies the type of system command requested. This parameter can be any one of the following values:  
  
-   **SC_CLOSE** Close the `CWnd` object.  
  
-   **SC_HOTKEY** Activate the `CWnd` object associated with the application-specified hot key. The low-order word of `lParam` identifies the `HWND` of the window to activate.  
  
-   **SC_HSCROLL** Scroll horizontally.  
  
-   **SC_KEYMENU** Retrieve a menu through a keystroke.  
  
-   **SC_MAXIMIZE** (or **SC_ZOOM**)   Maximize the `CWnd` object.  
  
-   **SC_MINIMIZE** (or **SC_ICON**)   Minimize the `CWnd` object.  
  
-   **SC_MOUSEMENU** Retrieve a menu through a mouse click.  
  
-   **SC_MOVE** Move the `CWnd` object.  
  
-   **SC_NEXTWINDOW** Move to the next window.  
  
-   **SC_PREVWINDOW** Move to the previous window.  
  
-   **SC_RESTORE** Restore window to normal position and size.  
  
-   **SC_SCREENSAVE** Executes the screen-saver application specified in the [boot] section of the SYSTEM.INI file.  
  
-   **SC_SIZE** Size the `CWnd` object.  
  
-   **SC_TASKLIST** Execute or activate the Windows Task Manager application.  
  
-   **SC_VSCROLL** Scroll vertically.  
  
 `lParam`  
 If a Control-menu command is chosen with the mouse, `lParam` contains the cursor coordinates. The low-order word contains the x coordinate, and the high-order word contains the y coordinate. Otherwise this parameter is not used.  
  
-   **SC_HOTKEY** Activate the window associated with the application-specified hot key. The low-order word of `lParam` identifies the window to activate.  
  
-   **SC_SCREENSAVE** Execute the screen-save application specified in the Desktop section of Control Panel.  
  
## Remarks  
 By default, `OnSysCommand` carries out the Control-menu request for the predefined actions specified in the preceding table.  
  
 In `WM_SYSCOMMAND` messages, the four low-order bits of the `nID` parameter are used internally by Windows. When an application tests the value of `nID`, it must combine the value 0xFFF0 with the `nID` value by using the bitwise-AND operator to obtain the correct result.  
  
 The menu items in a Control menu can be modified with the `GetSystemMenu`, `AppendMenu`, `InsertMenu`, and `ModifyMenu` member functions. Applications that modify the Control menu must process `WM_SYSCOMMAND` messages, and any `WM_SYSCOMMAND` messages not handled by the application must be passed on to `OnSysCommand`. Any command values added by an application must be processed by the application and cannot be passed to `OnSysCommand`.  
  
 An application can carry out any system command at any time by passing a `WM_SYSCOMMAND` message to `OnSysCommand`.  
  
 Accelerator (shortcut) keystrokes that are defined to select items from the Control menu are translated into `OnSysCommand` calls; all other accelerator keystrokes are translated into [WM_COMMAND](../vs140/cwnd--oncommand.md) messages.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_SYSCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646360)