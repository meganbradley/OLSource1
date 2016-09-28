---
title: "CWinThread::CreateThread"
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
  - "CWinThread::CreateThread"
  - "CWinThread.CreateThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinThread class, construction"
ms.assetid: a62f618d-d48b-4f77-bdc0-ee9f17306f9f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinThread::CreateThread
Creates a thread to execute within the address space of the calling process.  
  
## Syntax  
  
```  
  
      BOOL CreateThread(  
   DWORD dwCreateFlags = 0,  
   UINT nStackSize = 0,  
   LPSECURITY_ATTRIBUTES lpSecurityAttrs = NULL   
);  
```  
  
#### Parameters  
 `dwCreateFlags`  
 Specifies an additional flag that controls the creation of the thread. This flag can contain one of two values:  
  
-   **CREATE_SUSPENDED** Start the thread with a suspend count of one. Use **CREATE_SUSPENDED** if you want to initialize any member data of the `CWinThread` object, such as [m_bAutoDelete](../vs140/cwinthread--m_bautodelete.md) or any members of your derived class, before the thread starts running. Once your initialization is complete, use the [CWinThread::ResumeThread](../vs140/cwinthread--resumethread.md) to start the thread running. The thread will not execute until `CWinThread::ResumeThread` is called.  
  
-   **0** Start the thread immediately after creation.  
  
 `nStackSize`  
 Specifies the size in bytes of the stack for the new thread. If **0**, the stack size defaults to the same size as that of the process's primary thread.  
  
 `lpSecurityAttrs`  
 Points to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies the security attributes for the thread.  
  
## Return Value  
 Nonzero if the thread is created successfully; otherwise 0.  
  
## Remarks  
 Use `AfxBeginThread` to create a thread object and execute it in one step. Use `CreateThread` if you want to reuse the thread object between successive creation and termination of thread executions.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinThread Class](../vs140/cwinthread-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AfxBeginThread](../vs140/afxbeginthread.md)   
 [CWinThread::CWinThread](../vs140/cwinthread--cwinthread.md)   
 [CreateThread](http://msdn.microsoft.com/library/windows/desktop/ms682453)