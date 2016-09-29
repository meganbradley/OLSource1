---
title: "AfxBeginThread"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxBeginThread"
  - "AFXWIN/AfxBeginThread"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxBeginThread function"
ms.assetid: e9e8684d-24f7-4599-8fdf-1f4f560a753b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxBeginThread
Call this function to create a new thread.  
  
## Syntax  
  
```  
  
      CWinThread* AfxBeginThread(  
   AFX_THREADPROC pfnThreadProc,  
   LPVOID pParam,  
   int nPriority = THREAD_PRIORITY_NORMAL,  
   UINT nStackSize = 0,  
   DWORD dwCreateFlags = 0,  
   LPSECURITY_ATTRIBUTES lpSecurityAttrs = NULL   
);  
CWinThread* AfxBeginThread(  
   CRuntimeClass* pThreadClass,  
   int nPriority = THREAD_PRIORITY_NORMAL,  
   UINT nStackSize = 0,  
   DWORD dwCreateFlags = 0,  
   LPSECURITY_ATTRIBUTES lpSecurityAttrs = NULL   
);  
```  
  
#### Parameters  
 `pfnThreadProc`  
 Points to the controlling function for the worker thread. Cannot be **NULL**. This function must be declared as follows:  
  
 `UINT __cdecl MyControllingFunction( LPVOID pParam );`  
  
 *pThreadClass*  
 The [RUNTIME_CLASS](../VS_csharp/runtime_class.md) of an object derived from [CWinThread](../VS_csharp/cwinthread-class.md).  
  
 *pParam*  
 Parameter to be passed to the controlling function as shown in the parameter to the function declaration in `pfnThreadProc`.  
  
 `nPriority`  
 The desired priority of the thread. For a full list and description of the available priorities, see [SetThreadPriority](http://msdn.microsoft.com/library/windows/desktop/ms686277) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
 `nStackSize`  
 Specifies the size in bytes of the stack for the new thread. If 0, the stack size defaults to the same size stack as the creating thread.  
  
 `dwCreateFlags`  
 Specifies an additional flag that controls the creation of the thread. This flag can contain one of two values:  
  
-   **CREATE_SUSPENDED** Start the thread with a suspend count of one. Use **CREATE_SUSPENDED** if you want to initialize any member data of the `CWinThread` object, such as [m_bAutoDelete](../Topic/CWinThread::m_bAutoDelete.md) or any members of your derived class, before the thread starts running. Once your initialization is complete, use [CWinThread::ResumeThread](../Topic/CWinThread::ResumeThread.md) to start the thread running. The thread will not execute until `CWinThread::ResumeThread` is called.  
  
-   **0** Start the thread immediately after creation.  
  
 `lpSecurityAttrs`  
 Points to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies the security attributes for the thread. If **NULL**, the same security attributes as the creating thread will be used. For more information on this structure, see the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Return Value  
 Pointer to the newly created thread object, or **NULL** if a failure occurs.  
  
## Remarks  
 The first form of `AfxBeginThread` creates a worker thread. The second form creates a thread that may serve as a user-interface thread or as a worker thread.  
  
 `AfxBeginThread` creates a new `CWinThread` object, calls its [CreateThread](../Topic/CWinThread::CreateThread.md) function to start executing the thread, and returns a pointer to the thread. Checks are made throughout the procedure to make sure all objects are deallocated properly should any part of the creation fail. To end the thread, call [AfxEndThread](../VS_csharp/afxendthread.md) from within the thread, or return from the controlling function of the worker thread.  
  
 Multithreading must be enabled by the application; otherwise, this function will fail. For more information on enabling multithreading, refer to [/MD, /MT, /LD (Use Run-Time Library)](../VS_csharp/-md---mt---ld--use-run-time-library-.md) under *Visual C++ Compiler Options*.  
  
 For more information on `AfxBeginThread`, see the articles [Multithreading: Creating Worker Threads](../VS_csharp/multithreading--creating-worker-threads.md) and [Multithreading: Creating User-Interface Threads](../VS_csharp/multithreading--creating-user-interface-threads.md).  
  
## Example  
 See the example for [CSocket::Attach](../Topic/CSocket::Attach.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [AfxGetThread](../VS_csharp/afxgetthread.md)