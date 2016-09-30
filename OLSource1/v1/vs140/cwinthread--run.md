---
title: "CWinThread::Run"
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
  - "CWinThread.Run"
  - "CWinThread::Run"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Run method"
  - "CWinThread class, overridables"
ms.assetid: 1aa41001-7295-4159-a8f9-74d460acd1b1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::Run
Provides a default message loop for user-interface threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value that is returned by the thread. This value can be retrieved by calling [GetExitCodeThread](http://msdn.microsoft.com/library/windows/desktop/ms683190).  
  
## Remarks  
 **Run** acquires and dispatches Windows messages until the application receives a [WM_QUIT](http://msdn.microsoft.com/library/windows/desktop/ms632641) message. If the thread's message queue currently contains no messages, **Run** calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to perform idle-time processing. Incoming messages go to the [PreTranslateMessage](../vs140/cwinthread--pretranslatemessage.md) member function for special processing and then to the Windows function [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) for standard keyboard translation. Finally, the [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows function is called.  
  
 **Run** is rarely overridden, but you can override it to implement special behavior.  
  
 This member function is used only in user-interface threads.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::Run](../vs140/cwinapp--run.md)