---
title: "CWinApp::ProcessWndProcException"
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
  - "CWinApp::ProcessWndProcException"
  - "ProcessWndProcException"
  - "CWinApp.ProcessWndProcException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ProcessWndProcException method"
  - "CWinApp class, overridables"
  - "processing, exceptions"
ms.assetid: 15ed56fe-deee-4a69-b0df-68a457ab4840
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::ProcessWndProcException
The framework calls this member function whenever the handler does not catch an exception thrown in one of your application's message or command handlers.  
  
## Syntax  
  
```  
  
      virtual LRESULT ProcessWndProcException(  
   CException* e,  
   const MSG* pMsg   
);  
```  
  
#### Parameters  
 *e*  
 A pointer to an uncaught exception.  
  
 `pMsg`  
 A [MSG](../vs140/msg-structure.md) structure that contains information about the windows message that caused the framework to throw an exception.  
  
## Return Value  
 The value that should be returned to Windows. Normally this is 0L for windows messages, 1L (**TRUE**) for command messages.  
  
## Remarks  
 Do not call this member function directly.  
  
 The default implementation of this member function creates a message box. If the uncaught exception originates with a menu, toolbar, or accelerator command failure, the message box displays a "Command failed" message; otherwise, it displays an "Internal application error" message.  
  
 Override this member function to provide global handling of your exceptions. Only call the base functionality if you wish the message box to be displayed.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::WindowProc](../vs140/cwnd--windowproc.md)   
 [CException Class](../vs140/cexception-class.md)