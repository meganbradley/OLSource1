---
title: "CWnd::EnableWindow"
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
  - "CWnd.EnableWindow"
  - "CWnd::EnableWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableWindow method"
ms.assetid: a0992a84-67dc-40fd-bc71-60db21fd697f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::EnableWindow
Enables or disables mouse and keyboard input.  
  
## Syntax  
  
```  
  
      BOOL EnableWindow(  
   BOOL bEnable = TRUE   
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether the given window is to be enabled or disabled. If this parameter is **TRUE**, the window will be enabled. If this parameter is **FALSE**, the window will be disabled.  
  
## Return Value  
 Indicates the state before the `EnableWindow` member function was called. The return value is nonzero if the window was previously disabled. The return value is 0 if the window was previously enabled or an error occurred.  
  
## Remarks  
 When input is disabled, input such as mouse clicks and keystrokes is ignored. When input is enabled, the window processes all input.  
  
 If the enabled state is changing, the [WM_ENABLE](../vs140/cwnd--onenable.md) message is sent before this function returns.  
  
 If disabled, all child windows are implicitly disabled, although they are not sent `WM_ENABLE` messages.  
  
 A window must be enabled before it can be activated. For example, if an application is displaying a modeless dialog box and has disabled its main window, the main window must be enabled before the dialog box is destroyed. Otherwise, another window will get the input focus and be activated. If a child window is disabled, it is ignored when Windows tries to determine which window should get mouse messages.  
  
 By default, a window is enabled when it is created. An application can specify the **WS_DISABLED** style in the [Create](../vs140/cwnd--create.md) or [CreateEx](../vs140/cwnd--createex.md) member function to create a window that is initially disabled. After a window has been created, an application can also use the `EnableWindow` member function to enable or disable the window.  
  
 An application can use this function to enable or disable a control in a dialog box. A disabled control cannot receive the input focus, nor can a user access it.  
  
## Example  
 [!code[NVC_MFCWindowing#93](../vs140/codesnippet/CPP/cwnd--enablewindow_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [EnableWindow](http://msdn.microsoft.com/library/windows/desktop/ms646291)   
 [CWnd::OnEnable](../vs140/cwnd--onenable.md)