---
title: "CWinThread::ProcessWndProcException"
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
  - "CWinThread.ProcessWndProcException"
  - "ProcessWndProcException"
  - "CWinThread::ProcessWndProcException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ProcessWndProcException method"
  - "CWinThread class, overridables"
ms.assetid: af8ab4de-24e1-4ea7-b7da-cfed98d726cd
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::ProcessWndProcException
The framework calls this member function whenever the handler does not catch an exception thrown in one of your thread's message or command handlers.  
  
## Syntax  
  
```  
  
      virtual LRESULT ProcessWndProcException(  
   CException *e,  
   const MSG *pMsg   
);  
```  
  
#### Parameters  
 *e*  
 Points to an unhandled exception.  
  
 `pMsg`  
 Points to a [MSG](../vs140/msg-structure.md) structure containing information about the windows message that caused the framework to throw an exception.  
  
## Return Value  
 –1 if a `WM_CREATE` exception is generated; otherwise 0.  
  
## Remarks  
 Do not call this member function directly.  
  
 The default implementation of this member function handles only exceptions generated from the following messages:  
  
|Command|Action|  
|-------------|------------|  
|`WM_CREATE`|Fail.|  
|`WM_PAINT`|Validate the affected window, thus preventing another `WM_PAINT` message from being generated.|  
  
 Override this member function to provide global handling of your exceptions. Call the base functionality only if you wish to display the default behavior.  
  
 This member function is used only in threads that have a message pump.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::ProcessWndProcException](../vs140/cwinapp--processwndprocexception.md)