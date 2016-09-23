---
title: "Win32ThreadTraits::CreateThread"
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
  - Win32ThreadTraits::CreateThread
  - ATL.Win32ThreadTraits.CreateThread
  - Win32ThreadTraits.CreateThread
  - ATL::Win32ThreadTraits::CreateThread
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateThread method, overview
ms.assetid: 54b46a49-83e7-4499-b4a2-ffcc19fe62d4
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Win32ThreadTraits::CreateThread
Call this function to create a thread that should not use CRT functions.  
  
## Syntax  
  
```  
  
      static HANDLE CreateThread(  
   LPSECURITY_ATTRIBUTES lpsa,  
   DWORD dwStackSize,  
   LPTHREAD_START_ROUTINE pfnThreadProc,  
   void* pvParam,  
   DWORD dwCreationFlags,  
   DWORD* pdwThreadId   
) throw( );  
```  
  
#### Parameters  
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
  
## Return Value  
 Returns the handle to the newly created thread or NULL on failure. Call [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to get extended error information.  
  
## Remarks  
 See [CreateThread](http://msdn.microsoft.com/library/windows/desktop/ms682453) for further information on the parameters to this function.  
  
 This function calls `CreateThread` to create the thread.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Win32ThreadTraits Class](../vs140/win32threadtraits-class.md)