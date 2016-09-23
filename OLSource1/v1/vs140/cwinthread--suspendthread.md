---
title: "CWinThread::SuspendThread"
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
  - CWinThread.SuspendThread
  - SuspendThread
  - CWinThread::SuspendThread
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinThread class, operations
  - SuspendThread method
ms.assetid: 57189c7e-fd71-42e5-bc4b-3de7cd373d28
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinThread::SuspendThread
Increments the current thread's suspend count.  
  
## Syntax  
  
```  
  
DWORD SuspendThread( );  
```  
  
## Return Value  
 The thread's previous suspend count if successful; `0xFFFFFFFF` otherwise.  
  
## Remarks  
 If any thread has a suspend count above zero, that thread does not execute. The thread can be resumed by calling the [ResumeThread](../vs140/cwinthread--resumethread.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinThread::ResumeThread](../vs140/cwinthread--resumethread.md)   
 [SuspendThread](http://msdn.microsoft.com/library/windows/desktop/ms686345)