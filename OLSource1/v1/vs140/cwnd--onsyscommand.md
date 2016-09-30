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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSysCommand
The framework calls this member function when the user selects a command from the Control menu, or when the user selects the Maximize or the Minimize button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the type of system command requested. This parameter can be any one of the following values:  
  
-   **SC_CLOSE** Close the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
-   **SC_HOTKEY** Activate the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object associated with the application-specified hot key. The low-order word of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> identifies the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of the window to activate.  
  
-   **SC_HSCROLL** Scroll horizontally.  
  
-   **SC_KEYMENU** Retrieve a menu through a keystroke.  
  
-   **SC_MAXIMIZE** (or **SC_ZOOM**)   Maximize the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
-   **SC_MINIMIZE** (or **SC_ICON**)   Minimize the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
-   **SC_MOUSEMENU** Retrieve a menu through a mouse click.  
  
-   **SC_MOVE** Move the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
-   **SC_NEXTWINDOW** Move to the next window.  
  
-   **SC_PREVWINDOW** Move to the previous window.  
  
-   **SC_RESTORE** Restore window to normal position and size.  
  
-   **SC_SCREENSAVE** Executes the screen-saver application specified in the [boot] section of the SYSTEM.INI file.  
  
-   **SC_SIZE** Size the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
-   **SC_TASKLIST** Execute or activate the Windows Task Manager application.  
  
-   **SC_VSCROLL** Scroll vertically.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 If a Control-menu command is chosen with the mouse, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> contains the cursor coordinates. The low-order word contains the x coordinate, and the high-order word contains the y coordinate. Otherwise this parameter is not used.  
  
-   **SC_HOTKEY** Activate the window associated with the application-specified hot key. The low-order word of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> identifies the window to activate.  
  
-   **SC_SCREENSAVE** Execute the screen-save application specified in the Desktop section of Control Panel.  
  
## Remarks  
 By default, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> carries out the Control-menu request for the predefined actions specified in the preceding table.  
  
 In <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> messages, the four low-order bits of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter are used internally by Windows. When an application tests the value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, it must combine the value 0xFFF0 with the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value by using the bitwise-AND operator to obtain the correct result.  
  
 The menu items in a Control menu can be modified with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member functions. Applications that modify the Control menu must process <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> messages, and any <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> messages not handled by the application must be passed on to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Any command values added by an application must be processed by the application and cannot be passed to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 An application can carry out any system command at any time by passing a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> message to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 Accelerator (shortcut) keystrokes that are defined to select items from the Control menu are translated into <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> calls; all other accelerator keystrokes are translated into [WM_COMMAND](../vs140/cwnd--oncommand.md) messages.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_SYSCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646360)