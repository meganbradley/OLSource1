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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the controlling function for the worker thread. Cannot be **NULL**. This function must be declared as follows:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 *pThreadClass*  
 The [RUNTIME_CLASS](../vs140/runtime_class.md) of an object derived from [CWinThread](../vs140/cwinthread-class.md).  
  
 *pParam*  
 Parameter to be passed to the controlling function as shown in the parameter to the function declaration in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The desired priority of the thread. For a full list and description of the available priorities, see [SetThreadPriority](http://msdn.microsoft.com/library/windows/desktop/ms686277) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the size in bytes of the stack for the new thread. If 0, the stack size defaults to the same size stack as the creating thread.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies an additional flag that controls the creation of the thread. This flag can contain one of two values:  
  
-   **CREATE_SUSPENDED** Start the thread with a suspend count of one. Use **CREATE_SUSPENDED** if you want to initialize any member data of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, such as [m_bAutoDelete](../vs140/cwinthread--m_bautodelete.md) or any members of your derived class, before the thread starts running. Once your initialization is complete, use [CWinThread::ResumeThread](../vs140/cwinthread--resumethread.md) to start the thread running. The thread will not execute until <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is called.  
  
-   **0** Start the thread immediately after creation.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Points to a [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) structure that specifies the security attributes for the thread. If **NULL**, the same security attributes as the creating thread will be used. For more information on this structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Pointer to the newly created thread object, or **NULL** if a failure occurs.  
  
## Remarks  
 The first form of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> creates a worker thread. The second form creates a thread that may serve as a user-interface thread or as a worker thread.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> creates a new <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, calls its [CreateThread](../vs140/cwinthread--createthread.md) function to start executing the thread, and returns a pointer to the thread. Checks are made throughout the procedure to make sure all objects are deallocated properly should any part of the creation fail. To end the thread, call [AfxEndThread](../vs140/afxendthread.md) from within the thread, or return from the controlling function of the worker thread.  
  
 Multithreading must be enabled by the application; otherwise, this function will fail. For more information on enabling multithreading, refer to [/MD, /MT, /LD (Use Run-Time Library)](../vs140/-md---mt---ld--use-run-time-library-.md) under *Visual C++ Compiler Options*.  
  
 For more information on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, see the articles [Multithreading: Creating Worker Threads](../vs140/multithreading--creating-worker-threads.md) and [Multithreading: Creating User-Interface Threads](../vs140/multithreading--creating-user-interface-threads.md).  
  
## Example  
 See the example for [CSocket::Attach](../vs140/csocket--attach.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxGetThread](../vs140/afxgetthread.md)