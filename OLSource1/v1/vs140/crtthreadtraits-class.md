---
title: "CRTThreadTraits Class"
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
  - "ATL::CRTThreadTraits"
  - "ATL.CRTThreadTraits"
  - "CRTThreadTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRTThreadTraits class"
  - "threading [ATL], creation functions"
  - "threading [ATL], CRT threads"
ms.assetid: eb6e20b0-c2aa-4170-8e34-aaeeacc86343
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRTThreadTraits Class
This class provides the creation function for a CRT thread. Use this class if the thread will use CRT functions.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CRTThreadTraits  
  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRTThreadTraits::CreateThread](../vs140/crtthreadtraits--createthread.md)|(Static) Call this function to create a thread that can use CRT functions.|  
  
## Remarks  
 Thread traits are classes that provide a creation function for a particular type of thread. The creation function has the same signature and semantics as the Windows [CreateThread](http://msdn.microsoft.com/library/windows/desktop/ms682453) function.  
  
 Thread traits are used by the following classes:  
  
-   [CThreadPool](../vs140/cthreadpool-class.md)  
  
-   [CWorkerThread](../vs140/cworkerthread-class.md)  
  
 If the thread will not be using CRT functions, use [Win32ThreadTraits](../vs140/win32threadtraits-class.md) instead.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="crtthreadtraits__createthread"></a>  CRTThreadTraits::CreateThread  
 Call this function to create a thread that can use CRT functions.  
  
```  
  
static HANDLE CreateThread(  
      LPSECURITY_ATTRIBUTES  lpsa,  
      DWORD  dwStackSize,  
      LPTHREAD_START_ROUTINE  pfnThreadProc,  
      void*  pvParam,  
      DWORD  dwCreationFlags,  
      DWORD*  pdwThreadId  
   ) throw( );  
  
```  
  
### Parameters  
 `lpsa`  
 The security attributes for the new thread.  
  
 `dwStackSize`  
 The stack size for the new thread.  
  
 `pfnThreadProc`  
 The thread procedure of the new thread.  
  
 `pvParam`  
 The parameter to be passed to the thread procedure.  
  
 `dwCreationFlags`  
 The creation flags (0 or CREATE_SUSPENDED).  
  
 `pdwThreadId`  
 [out] Address of the DWORD variable that, on success, receives the thread ID of the newly created thread.  
  
### Return Value  
 Returns the handle to the newly created thread or NULL on failure. Call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to get extended error information.  
  
### Remarks  
 See [CreateThread](http://msdn.microsoft.com/library/windows/desktop/ms682453) for further information on the parameters to this function.  
  
 This function calls [_beginthreadex](../vs140/_beginthread--_beginthreadex.md) to create the thread.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)