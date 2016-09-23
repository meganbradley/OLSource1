---
title: "CWinThread::ExitInstance"
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
  - CWinThread::ExitInstance
  - CWinThread.ExitInstance
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinThread class, overridables
  - ExitInstance method
ms.assetid: e20c394d-b71d-40a7-9f85-b474bc17efc9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinThread::ExitInstance
Called by the framework from within a rarely overridden [Run](../vs140/cwinthread--run.md) member function to exit this instance of the thread, or if a call to [InitInstance](../vs140/cwinthread--initinstance.md) fails.  
  
## Syntax  
  
```  
  
virtual int ExitInstance( );  
```  
  
## Return Value  
 The thread's exit code; 0 indicates no errors, and values greater than 0 indicate an error. This value can be retrieved by calling [GetExitCodeThread](http://msdn.microsoft.com/library/windows/desktop/ms683190).  
  
## Remarks  
 Do not call this member function from anywhere but within the **Run** member function. This member function is used only in user-interface threads.  
  
 The default implementation of this function deletes the `CWinThread` object if [m_bAutoDelete](../vs140/cwinthread--m_bautodelete.md) is **TRUE**. Override this function if you wish to perform additional clean-up when your thread terminates. Your implementation of `ExitInstance` should call the base class's version after your code is executed.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::ExitInstance](../vs140/cwinapp--exitinstance.md)