---
title: "CWinApp::OnHelp"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnHelp
  - CWinApp.OnHelp
  - CWinApp::OnHelp
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinApp class, command handlers
  - OnHelp method
ms.assetid: b27ff76f-04e8-4593-ad69-134ab8194ed6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::OnHelp
Handles F1 Help within the application (using the current context).  
  
## Syntax  
  
```  
  
afx_msg void OnHelp( );  
```  
  
## Remarks  
 Usually you will also add an accelerator-key entry for the F1 key. Enabling the F1 key is only a convention, not a requirement.  
  
 You must add an `ON_COMMAND( ID_HELP, OnHelp )` statement to your `CWinApp` class message map to enable this member function. If enabled, called by the framework when the user presses the F1 key.  
  
 The default implementation of this message-handler function determines the Help context that corresponds to the current window, dialog box, or menu item and then calls WINHELP.EXE. If no context is currently available, the function uses the default context.  
  
 Override this member function to set the Help context to something other than the window, dialog box, menu item, or toolbar button that currently has the focus. Call `WinHelp` with the desired Help context ID.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::OnContextHelp](../vs140/cwinapp--oncontexthelp.md)   
 [CWinApp::OnHelpUsing](../vs140/cwinapp--onhelpusing.md)   
 [CWinApp::OnHelpIndex](../vs140/cwinapp--onhelpindex.md)   
 [CWinApp::WinHelp](../vs140/cwinapp--winhelp.md)